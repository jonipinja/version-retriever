using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VersionRetriever;

namespace VersionRetriever.GUI
{
    public partial class NewGui : Form
    {
        public NewGui()
        {
            InitializeComponent();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(textBoxFileFolder, "Browse for the file (zip) or folder or drag-and-drop one on top of this text box.");

            textBoxExtension.SetPlaceholder("File extension...");
        }

        private void textBoxFileFolder_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void textBoxFileFolder_DragDrop(object sender, DragEventArgs e)
        {
            string[] data = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (data == null)
            {
                textBoxFileFolder.Text = "Invalid drop data.";
            }
            else if (data.Length == 1) // Accept only one dropped file/folder.
            {
                SetFileFolder(data[0]);
            }
            else
            {
                textBoxFileFolder.Text = "Way too many (or too few) files/folders dropped.";
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SetFileFolder(dlg.SelectedPath);
                }
            }
        }

        private void buttonAddExtension_Click(object sender, EventArgs e)
        {
            AddExtension(textBoxExtension.Text);
        }

        private void buttonDeleteExtension_Click(object sender, EventArgs e)
        {
            DeleteSelectedExtension();
        }

        private void buttonBrowseFilename_Click(object sender, EventArgs e)
        {
            string path = textBoxFileName.Text;
            if (!string.IsNullOrWhiteSpace(path))
            {
                path = Path.GetDirectoryName(path);
            }
            else
            {
                path = string.Empty;
            }

            using (SaveFileDialog dlg = new SaveFileDialog() { InitialDirectory = path })
            {
                dlg.Filter = "md files (*.md)|*.md";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SetOutputFilepath(dlg.FileName);
                }
            }
        }

        private async void buttonReadVersions_Click(object sender, EventArgs e)
        {
            // Check if output file already exists and warn if it does.
            if (File.Exists(textBoxFileName.Text))
            {
                if (MessageBox.Show("Selected output file already exists. Are you sure you want to overwrite it?", "Output file already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                {
                    return;
                }
            }

            string path = textBoxFileFolder.Text;

            if (string.IsNullOrWhiteSpace(path))
            {
                return;
            }

            if (listBoxExtensions.Items.Count == 0)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxFileName.Text))
            {
                MessageBox.Show("Output filename cannot be empty.", "Empty output filename.");
                return;
            }

            //tableLayoutPanel1.Enabled = false;
            buttonReadVersions.Enabled = false;
            //Cursor = Cursors.WaitCursor;
            labelStatus.Text = "Generating version info...";

            string errMsg = await ReadFileVersions();
            if (!string.IsNullOrWhiteSpace(errMsg))
            {
                MessageBox.Show(errMsg, "Errors while reading/writing file versions.");
            }

            //Cursor = Cursors.Default;
            labelStatus.Text = string.Empty;
            buttonReadVersions.Enabled = true;
            //tableLayoutPanel1.Enabled = true;
        }

        private async Task<string> ReadFileVersions()
        {
            string msg = string.Empty;
            await Task.Run(() =>
            {
                string releaseNotes = string.Empty;
                if (!string.IsNullOrWhiteSpace(textBoxReleaseNotes.Text))
                {
                    releaseNotes = textBoxReleaseNotes.Text;
                }

                string path = textBoxFileFolder.Text;

                // Read file versions.
                IEnumerable<string> exts = listBoxExtensions.Items.OfType<string>();
                VersionRetriever retriever = new VersionRetriever(path, exts);
                if (!retriever.ReadFileVersions())
                {
                    //MessageBox.Show(retriever.ErrorMessage, "Could not read file versions.");

                    msg = $"Could not read file versions.{Environment.NewLine}{retriever.ErrorMessage}";
                }

                // Write file versions.
                VersionWriter writer = new VersionWriter(textBoxFileName.Text);
                if (!writer.WriteVersions(retriever, releaseNotes))
                {
                    //MessageBox.Show("Could not write file versions.");

                    msg = $"Could not write file versions.{Environment.NewLine}{writer.ErrorMessage}";
                }
            });

            return msg;
        }

        private void textBoxExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handle Return and Enter.
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                AddExtension(textBoxExtension.Text);
            }
        }

        private void AddExtension(string extension)
        {
            if (!string.IsNullOrWhiteSpace(extension))
            {
                if (extension.StartsWith("."))
                {
                    listBoxExtensions.Items.Add(extension);
                }
                else
                {
                    listBoxExtensions.Items.Add($".{extension}");
                }

                textBoxExtension.ResetText();
                textBoxExtension.Focus();
            }
        }

        private void DeleteSelectedExtension()
        {
            if (listBoxExtensions.SelectedIndex >= 0)
            {
                listBoxExtensions.Items.RemoveAt(listBoxExtensions.SelectedIndex);
            }
        }

        private void listBoxExtensions_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSelectedExtension();
            }
        }

        /// <summary>
        /// Set the given path to file/folder textbox. Sets output filename/-path also.
        /// </summary>
        /// <param name="path">File/Folder path.</param>
        private void SetFileFolder(string path)
        {
            textBoxFileFolder.ResetText();
            textBoxFileFolder.AppendText(path);

            string outputPath = string.Empty;
            string extension = Path.GetExtension(path);
            if (!string.IsNullOrWhiteSpace(extension) && extension.ToLowerInvariant() == ".zip")
            {
                outputPath = $"{path.Substring(0, path.Length - 4)}.md";
            }
            else if (string.IsNullOrWhiteSpace(extension)) // Assume folder
            {
                outputPath = $"{path}.md";
            }

            // If found some output filepath, set it.
            if (!string.IsNullOrWhiteSpace(outputPath))
            {
                SetOutputFilepath(outputPath);
            }
        }

        private void SetOutputFilepath(string filepath)
        {
            textBoxFileName.ResetText();
            textBoxFileName.AppendText(filepath);
        }
    }
}
