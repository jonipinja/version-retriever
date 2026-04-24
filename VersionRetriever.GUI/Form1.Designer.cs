namespace VersionRetriever.GUI
{
    partial class Form1
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
            this.tableLayoutPanelContent = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFileFolder = new System.Windows.Forms.TextBox();
            this.labelFileFolder = new System.Windows.Forms.Label();
            this.labelExtensions = new System.Windows.Forms.Label();
            this.listBoxExtensions = new System.Windows.Forms.ListBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.flowLayoutPanelExtensionControls = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.buttonAddExtension = new System.Windows.Forms.Button();
            this.buttonDeleteExtension = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonBrowseFilename = new System.Windows.Forms.Button();
            this.buttonReadVersions = new System.Windows.Forms.Button();
            this.labelFilename = new System.Windows.Forms.Label();
            this.tableLayoutPanelContent.SuspendLayout();
            this.flowLayoutPanelExtensionControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContent
            // 
            this.tableLayoutPanelContent.ColumnCount = 3;
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanelContent.Controls.Add(this.textBoxFileFolder, 0, 1);
            this.tableLayoutPanelContent.Controls.Add(this.labelFileFolder, 0, 0);
            this.tableLayoutPanelContent.Controls.Add(this.labelExtensions, 0, 2);
            this.tableLayoutPanelContent.Controls.Add(this.listBoxExtensions, 0, 4);
            this.tableLayoutPanelContent.Controls.Add(this.buttonBrowse, 2, 1);
            this.tableLayoutPanelContent.Controls.Add(this.flowLayoutPanelExtensionControls, 0, 3);
            this.tableLayoutPanelContent.Controls.Add(this.textBoxFileName, 0, 6);
            this.tableLayoutPanelContent.Controls.Add(this.buttonBrowseFilename, 2, 6);
            this.tableLayoutPanelContent.Controls.Add(this.buttonReadVersions, 2, 7);
            this.tableLayoutPanelContent.Controls.Add(this.labelFilename, 0, 5);
            this.tableLayoutPanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContent.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContent.Name = "tableLayoutPanelContent";
            this.tableLayoutPanelContent.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanelContent.RowCount = 8;
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContent.Size = new System.Drawing.Size(427, 448);
            this.tableLayoutPanelContent.TabIndex = 0;
            // 
            // textBoxFileFolder
            // 
            this.textBoxFileFolder.AllowDrop = true;
            this.tableLayoutPanelContent.SetColumnSpan(this.textBoxFileFolder, 2);
            this.textBoxFileFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileFolder.Location = new System.Drawing.Point(13, 53);
            this.textBoxFileFolder.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.textBoxFileFolder.Name = "textBoxFileFolder";
            this.textBoxFileFolder.ReadOnly = true;
            this.textBoxFileFolder.Size = new System.Drawing.Size(298, 20);
            this.textBoxFileFolder.TabIndex = 2;
            this.textBoxFileFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileFolder_DragDrop);
            this.textBoxFileFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileFolder_DragEnter);
            // 
            // labelFileFolder
            // 
            this.labelFileFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileFolder.AutoSize = true;
            this.tableLayoutPanelContent.SetColumnSpan(this.labelFileFolder, 2);
            this.labelFileFolder.Location = new System.Drawing.Point(13, 20);
            this.labelFileFolder.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.labelFileFolder.Name = "labelFileFolder";
            this.labelFileFolder.Size = new System.Drawing.Size(298, 13);
            this.labelFileFolder.TabIndex = 1;
            this.labelFileFolder.Text = "File/folder:";
            // 
            // labelExtensions
            // 
            this.labelExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExtensions.AutoSize = true;
            this.tableLayoutPanelContent.SetColumnSpan(this.labelExtensions, 2);
            this.labelExtensions.Location = new System.Drawing.Point(13, 93);
            this.labelExtensions.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.labelExtensions.Name = "labelExtensions";
            this.labelExtensions.Size = new System.Drawing.Size(298, 13);
            this.labelExtensions.TabIndex = 4;
            this.labelExtensions.Text = "Extensions:";
            // 
            // listBoxExtensions
            // 
            this.listBoxExtensions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExtensions.FormattingEnabled = true;
            this.listBoxExtensions.Location = new System.Drawing.Point(13, 176);
            this.listBoxExtensions.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.listBoxExtensions.Name = "listBoxExtensions";
            this.listBoxExtensions.Size = new System.Drawing.Size(94, 130);
            this.listBoxExtensions.TabIndex = 8;
            this.listBoxExtensions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxExtensions_KeyUp);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(331, 53);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // flowLayoutPanelExtensionControls
            // 
            this.tableLayoutPanelContent.SetColumnSpan(this.flowLayoutPanelExtensionControls, 2);
            this.flowLayoutPanelExtensionControls.Controls.Add(this.textBoxExtension);
            this.flowLayoutPanelExtensionControls.Controls.Add(this.buttonAddExtension);
            this.flowLayoutPanelExtensionControls.Controls.Add(this.buttonDeleteExtension);
            this.flowLayoutPanelExtensionControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelExtensionControls.Location = new System.Drawing.Point(13, 126);
            this.flowLayoutPanelExtensionControls.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.flowLayoutPanelExtensionControls.Name = "flowLayoutPanelExtensionControls";
            this.flowLayoutPanelExtensionControls.Padding = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelExtensionControls.Size = new System.Drawing.Size(298, 30);
            this.flowLayoutPanelExtensionControls.TabIndex = 5;
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(1, 5);
            this.textBoxExtension.Margin = new System.Windows.Forms.Padding(0, 4, 3, 3);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtension.TabIndex = 5;
            this.textBoxExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExtension_KeyPress);
            // 
            // buttonAddExtension
            // 
            this.buttonAddExtension.Location = new System.Drawing.Point(107, 4);
            this.buttonAddExtension.Name = "buttonAddExtension";
            this.buttonAddExtension.Size = new System.Drawing.Size(75, 23);
            this.buttonAddExtension.TabIndex = 6;
            this.buttonAddExtension.Text = "Add";
            this.buttonAddExtension.UseVisualStyleBackColor = true;
            this.buttonAddExtension.Click += new System.EventHandler(this.buttonAddExtension_Click);
            // 
            // buttonDeleteExtension
            // 
            this.buttonDeleteExtension.Location = new System.Drawing.Point(188, 4);
            this.buttonDeleteExtension.Name = "buttonDeleteExtension";
            this.buttonDeleteExtension.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteExtension.TabIndex = 7;
            this.buttonDeleteExtension.Text = "Del";
            this.buttonDeleteExtension.UseVisualStyleBackColor = true;
            this.buttonDeleteExtension.Click += new System.EventHandler(this.buttonDeleteExtension_Click);
            // 
            // textBoxFileName
            // 
            this.tableLayoutPanelContent.SetColumnSpan(this.textBoxFileName, 2);
            this.textBoxFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFileName.Location = new System.Drawing.Point(13, 359);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(298, 20);
            this.textBoxFileName.TabIndex = 10;
            // 
            // buttonBrowseFilename
            // 
            this.buttonBrowseFilename.Location = new System.Drawing.Point(331, 359);
            this.buttonBrowseFilename.Margin = new System.Windows.Forms.Padding(10);
            this.buttonBrowseFilename.Name = "buttonBrowseFilename";
            this.buttonBrowseFilename.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowseFilename.TabIndex = 11;
            this.buttonBrowseFilename.Text = "Browse";
            this.buttonBrowseFilename.UseVisualStyleBackColor = true;
            this.buttonBrowseFilename.Click += new System.EventHandler(this.buttonBrowseFilename_Click);
            // 
            // buttonReadVersions
            // 
            this.buttonReadVersions.Location = new System.Drawing.Point(331, 399);
            this.buttonReadVersions.Margin = new System.Windows.Forms.Padding(10);
            this.buttonReadVersions.Name = "buttonReadVersions";
            this.buttonReadVersions.Size = new System.Drawing.Size(75, 23);
            this.buttonReadVersions.TabIndex = 12;
            this.buttonReadVersions.Text = "Generate";
            this.buttonReadVersions.UseVisualStyleBackColor = true;
            this.buttonReadVersions.Click += new System.EventHandler(this.buttonReadVersions_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFilename.AutoSize = true;
            this.tableLayoutPanelContent.SetColumnSpan(this.labelFilename, 2);
            this.labelFilename.Location = new System.Drawing.Point(13, 326);
            this.labelFilename.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(298, 13);
            this.labelFilename.TabIndex = 9;
            this.labelFilename.Text = "Save as:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 448);
            this.Controls.Add(this.tableLayoutPanelContent);
            this.Name = "Form1";
            this.Text = "VersionRetriever";
            this.tableLayoutPanelContent.ResumeLayout(false);
            this.tableLayoutPanelContent.PerformLayout();
            this.flowLayoutPanelExtensionControls.ResumeLayout(false);
            this.flowLayoutPanelExtensionControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContent;
        private System.Windows.Forms.TextBox textBoxFileFolder;
        private System.Windows.Forms.Label labelFileFolder;
        private System.Windows.Forms.Label labelExtensions;
        private System.Windows.Forms.ListBox listBoxExtensions;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelExtensionControls;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Button buttonAddExtension;
        private System.Windows.Forms.Button buttonDeleteExtension;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonBrowseFilename;
        private System.Windows.Forms.Button buttonReadVersions;
        private System.Windows.Forms.Label labelFilename;
    }
}

