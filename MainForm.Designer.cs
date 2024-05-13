﻿using System.Windows.Forms;

namespace TikTok_Downloader
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            urlTextBox = new TextBox();
            downloadButton = new Button();
            outputTextBox = new TextBox();
            progressBar = new ProgressBar();
            cmbChoice = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            ChangeDownloadFolderToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            browseFileButton = new Button();
            withWatermarkCheckBox = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // urlTextBox
            // 
            urlTextBox.BackColor = SystemColors.Window;
            urlTextBox.Location = new Point(149, 73);
            urlTextBox.Name = "urlTextBox";
            urlTextBox.PlaceholderText = "Enter TikTok Video/Image Link";
            urlTextBox.Size = new Size(275, 23);
            urlTextBox.TabIndex = 0;
            urlTextBox.TextChanged += filePathTextBox_TextChanged;
            // 
            // downloadButton
            // 
            downloadButton.BackColor = SystemColors.Control;
            downloadButton.Location = new Point(434, 36);
            downloadButton.Name = "downloadButton";
            downloadButton.Size = new Size(88, 23);
            downloadButton.TabIndex = 1;
            downloadButton.Text = "Download";
            downloadButton.UseVisualStyleBackColor = false;
            downloadButton.Click += btnDownload_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.BackColor = SystemColors.WindowText;
            outputTextBox.Cursor = Cursors.IBeam;
            outputTextBox.ForeColor = Color.FromArgb(0, 192, 0);
            outputTextBox.Location = new Point(12, 185);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(510, 234);
            outputTextBox.TabIndex = 2;
            outputTextBox.TextChanged += outputTextBox_TextChanged;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 133);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(510, 22);
            progressBar.TabIndex = 3;
            progressBar.Click += progressBar_Click;
            // 
            // cmbChoice
            // 
            cmbChoice.FormattingEnabled = true;
            cmbChoice.Items.AddRange(new object[] { "Single Video/Image Download", "Mass Download by Username", "Mass Download from Text File Links" });
            cmbChoice.Location = new Point(149, 36);
            cmbChoice.Name = "cmbChoice";
            cmbChoice.Size = new Size(275, 23);
            cmbChoice.TabIndex = 4;
            cmbChoice.SelectedIndexChanged += cmbChoice_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(534, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ChangeDownloadFolderToolStripMenuItem, aboutToolStripMenuItem, settingsToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = SystemColors.MenuText;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(61, 20);
            fileToolStripMenuItem.Text = "Options";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // ChangeDownloadFolderToolStripMenuItem
            // 
            ChangeDownloadFolderToolStripMenuItem.BackColor = Color.Transparent;
            ChangeDownloadFolderToolStripMenuItem.Name = "ChangeDownloadFolderToolStripMenuItem";
            ChangeDownloadFolderToolStripMenuItem.Size = new Size(208, 22);
            ChangeDownloadFolderToolStripMenuItem.Text = "Change Download Folder";
            ChangeDownloadFolderToolStripMenuItem.Click += ChangeDownloadFolderToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.BackColor = Color.Transparent;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(208, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(208, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // browseFileButton
            // 
            browseFileButton.Location = new Point(434, 73);
            browseFileButton.Name = "browseFileButton";
            browseFileButton.Size = new Size(88, 23);
            browseFileButton.TabIndex = 7;
            browseFileButton.Text = "Browse";
            browseFileButton.UseVisualStyleBackColor = true;
            browseFileButton.Visible = false;
            browseFileButton.Click += browseFileButton_Click;
            // 
            // withWatermarkCheckBox
            // 
            withWatermarkCheckBox.AutoSize = true;
            withWatermarkCheckBox.BackColor = Color.Transparent;
            withWatermarkCheckBox.ForeColor = SystemColors.Control;
            withWatermarkCheckBox.ImageAlign = ContentAlignment.MiddleLeft;
            withWatermarkCheckBox.Location = new Point(12, 106);
            withWatermarkCheckBox.Name = "withWatermarkCheckBox";
            withWatermarkCheckBox.Size = new Size(154, 19);
            withWatermarkCheckBox.TabIndex = 8;
            withWatermarkCheckBox.Text = "Download Watermarked";
            withWatermarkCheckBox.TextAlign = ContentAlignment.TopLeft;
            withWatermarkCheckBox.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 9;
            label3.Text = "Download Single Links:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 10;
            label2.Text = "Latest Download Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 6;
            label1.Text = "Download Options:";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Teal;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Aquamarine;
            linkLabel1.Location = new Point(425, 106);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(97, 16);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Report Bug/Issue";
            linkLabel1.VisitedLinkColor = Color.Aquamarine;
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 431);
            Controls.Add(linkLabel1);
            Controls.Add(menuStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(withWatermarkCheckBox);
            Controls.Add(browseFileButton);
            Controls.Add(cmbChoice);
            Controls.Add(progressBar);
            Controls.Add(outputTextBox);
            Controls.Add(downloadButton);
            Controls.Add(urlTextBox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "TikTok Downloader";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox urlTextBox;
        private Button downloadButton;
        private TextBox outputTextBox;
        private ProgressBar progressBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem ChangeDownloadFolderToolStripMenuItem;
        private ComboBox cmbChoice;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button browseFileButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox withWatermarkCheckBox;
        private ToolStripMenuItem settingsToolStripMenuItem;

        private void cmbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbChoice.SelectedIndex)
            {
                case 0:
                    urlTextBox.PlaceholderText = "Enter TikTok Video/Image Link";
                    label3.Text = "Download Single Links:";
                    browseFileButton.Visible = false;
                    break;
                case 1:
                    urlTextBox.PlaceholderText = "Enter TikTok link/Username";
                    label3.Text = "Download by Username:";
                    browseFileButton.Visible = false;
                    break;
                case 2:
                    urlTextBox.PlaceholderText = "Enter/Select Path to Text File";
                    label3.Text = "Download from Text file:";
                    browseFileButton.Visible = true;
                    break;
                default:
                    urlTextBox.PlaceholderText = "Enter TikTok Video/Image Link";
                    label3.Text = "Download Single Links:";
                    browseFileButton.Visible = false;
                    break;
            }

            urlTextBox.Text = "";
        }

        private LinkLabel linkLabel1;
    }
}
