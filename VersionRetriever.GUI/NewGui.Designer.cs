namespace VersionRetriever.GUI
{
    partial class NewGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGui));
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowseFilename = new System.Windows.Forms.Button();
            this.buttonReadVersions = new System.Windows.Forms.Button();
            this.groupBoxExtensions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxExtensions = new System.Windows.Forms.ListBox();
            this.buttonAddExtension = new System.Windows.Forms.Button();
            this.buttonDeleteExtension = new System.Windows.Forms.Button();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.groupBoxSource = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFileFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxReleaseNotes = new System.Windows.Forms.GroupBox();
            this.textBoxReleaseNotes = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.groupBoxExtensions.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBoxSource.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxReleaseNotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileName.Location = new System.Drawing.Point(5, 5);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(522, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // buttonBrowseFilename
            // 
            this.buttonBrowseFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseFilename.Location = new System.Drawing.Point(537, 5);
            this.buttonBrowseFilename.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBrowseFilename.Name = "buttonBrowseFilename";
            this.buttonBrowseFilename.Size = new System.Drawing.Size(70, 22);
            this.buttonBrowseFilename.TabIndex = 3;
            this.buttonBrowseFilename.Text = "Browse";
            this.buttonBrowseFilename.UseVisualStyleBackColor = true;
            this.buttonBrowseFilename.Click += new System.EventHandler(this.buttonBrowseFilename_Click);
            // 
            // buttonReadVersions
            // 
            this.buttonReadVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReadVersions.Location = new System.Drawing.Point(546, 412);
            this.buttonReadVersions.Margin = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.buttonReadVersions.Name = "buttonReadVersions";
            this.buttonReadVersions.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonReadVersions.Size = new System.Drawing.Size(70, 22);
            this.buttonReadVersions.TabIndex = 9;
            this.buttonReadVersions.Text = "Generate";
            this.buttonReadVersions.UseVisualStyleBackColor = true;
            this.buttonReadVersions.Click += new System.EventHandler(this.buttonReadVersions_Click);
            // 
            // groupBoxExtensions
            // 
            this.groupBoxExtensions.Controls.Add(this.tableLayoutPanel4);
            this.groupBoxExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExtensions.Location = new System.Drawing.Point(3, 117);
            this.groupBoxExtensions.Name = "groupBoxExtensions";
            this.groupBoxExtensions.Size = new System.Drawing.Size(164, 291);
            this.groupBoxExtensions.TabIndex = 2;
            this.groupBoxExtensions.TabStop = false;
            this.groupBoxExtensions.Text = "Extensions";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.listBoxExtensions, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonAddExtension, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.buttonDeleteExtension, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxExtension, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(158, 272);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // listBoxExtensions
            // 
            this.listBoxExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExtensions.FormattingEnabled = true;
            this.listBoxExtensions.Location = new System.Drawing.Point(25, 26);
            this.listBoxExtensions.Margin = new System.Windows.Forms.Padding(1, 2, 1, 0);
            this.listBoxExtensions.Name = "listBoxExtensions";
            this.listBoxExtensions.Size = new System.Drawing.Size(132, 246);
            this.listBoxExtensions.TabIndex = 7;
            this.listBoxExtensions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxExtensions_KeyUp);
            // 
            // buttonAddExtension
            // 
            this.buttonAddExtension.Location = new System.Drawing.Point(1, 1);
            this.buttonAddExtension.Margin = new System.Windows.Forms.Padding(1);
            this.buttonAddExtension.Name = "buttonAddExtension";
            this.buttonAddExtension.Size = new System.Drawing.Size(22, 22);
            this.buttonAddExtension.TabIndex = 5;
            this.buttonAddExtension.Text = "+";
            this.buttonAddExtension.UseVisualStyleBackColor = true;
            this.buttonAddExtension.Click += new System.EventHandler(this.buttonAddExtension_Click);
            // 
            // buttonDeleteExtension
            // 
            this.buttonDeleteExtension.Location = new System.Drawing.Point(1, 25);
            this.buttonDeleteExtension.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDeleteExtension.Name = "buttonDeleteExtension";
            this.buttonDeleteExtension.Size = new System.Drawing.Size(22, 22);
            this.buttonDeleteExtension.TabIndex = 6;
            this.buttonDeleteExtension.Text = "-";
            this.buttonDeleteExtension.UseVisualStyleBackColor = true;
            this.buttonDeleteExtension.Click += new System.EventHandler(this.buttonDeleteExtension_Click);
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExtension.Location = new System.Drawing.Point(25, 2);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(132, 20);
            this.textBoxExtension.TabIndex = 4;
            this.textBoxExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExtension_KeyPress);
            // 
            // groupBoxSource
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxSource, 3);
            this.groupBoxSource.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSource.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSource.Name = "groupBoxSource";
            this.groupBoxSource.Size = new System.Drawing.Size(618, 51);
            this.groupBoxSource.TabIndex = 1;
            this.groupBoxSource.TabStop = false;
            this.groupBoxSource.Text = "Source";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxFileFolder, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBrowse, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(612, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBoxFileFolder
            // 
            this.textBoxFileFolder.AllowDrop = true;
            this.textBoxFileFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileFolder.Location = new System.Drawing.Point(5, 5);
            this.textBoxFileFolder.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxFileFolder.Name = "textBoxFileFolder";
            this.textBoxFileFolder.ReadOnly = true;
            this.textBoxFileFolder.Size = new System.Drawing.Size(522, 20);
            this.textBoxFileFolder.TabIndex = 0;
            this.textBoxFileFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileFolder_DragDrop);
            this.textBoxFileFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileFolder_DragEnter);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Location = new System.Drawing.Point(537, 5);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(70, 22);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 51);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxFileName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonBrowseFilename, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(612, 32);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonReadVersions, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxExtensions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxReleaseNotes, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBoxReleaseNotes
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBoxReleaseNotes, 2);
            this.groupBoxReleaseNotes.Controls.Add(this.textBoxReleaseNotes);
            this.groupBoxReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReleaseNotes.Location = new System.Drawing.Point(173, 117);
            this.groupBoxReleaseNotes.Name = "groupBoxReleaseNotes";
            this.groupBoxReleaseNotes.Size = new System.Drawing.Size(448, 291);
            this.groupBoxReleaseNotes.TabIndex = 9;
            this.groupBoxReleaseNotes.TabStop = false;
            this.groupBoxReleaseNotes.Text = "Release notes";
            // 
            // textBoxReleaseNotes
            // 
            this.textBoxReleaseNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReleaseNotes.Location = new System.Drawing.Point(3, 16);
            this.textBoxReleaseNotes.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.textBoxReleaseNotes.Multiline = true;
            this.textBoxReleaseNotes.Name = "textBoxReleaseNotes";
            this.textBoxReleaseNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReleaseNotes.Size = new System.Drawing.Size(442, 272);
            this.textBoxReleaseNotes.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatus, 2);
            this.labelStatus.Location = new System.Drawing.Point(3, 416);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(532, 13);
            this.labelStatus.TabIndex = 10;
            // 
            // NewGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 380);
            this.Name = "NewGui";
            this.Text = "VersionRetriever";
            this.groupBoxExtensions.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBoxSource.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBoxReleaseNotes.ResumeLayout(false);
            this.groupBoxReleaseNotes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonBrowseFilename;
        private System.Windows.Forms.Button buttonReadVersions;
        private System.Windows.Forms.GroupBox groupBoxExtensions;
        private System.Windows.Forms.Button buttonAddExtension;
        private System.Windows.Forms.Button buttonDeleteExtension;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.TextBox textBoxFileFolder;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxExtensions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBoxReleaseNotes;
        private System.Windows.Forms.TextBox textBoxReleaseNotes;
        private System.Windows.Forms.Label labelStatus;
    }
}

