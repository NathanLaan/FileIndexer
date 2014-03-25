namespace FileIndexer.App.WinForms
{
    partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.barStatusStrip = new System.Windows.Forms.StatusStrip();
            this.barStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsc = new System.Windows.Forms.ToolStripContainer();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.lstFileInfoList = new System.Windows.Forms.ListBox();
            this.tabHtml = new System.Windows.Forms.TabPage();
            this.txtHtmlOutput = new System.Windows.Forms.TextBox();
            this.barToolBar = new System.Windows.Forms.ToolStrip();
            this.btnScan = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnIndent = new System.Windows.Forms.ToolStripButton();
            this.mnu.SuspendLayout();
            this.barStatusStrip.SuspendLayout();
            this.tsc.ContentPanel.SuspendLayout();
            this.tsc.TopToolStripPanel.SuspendLayout();
            this.tsc.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabHtml.SuspendLayout();
            this.barToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu
            // 
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.mnu.Location = new System.Drawing.Point(0, 0);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(632, 24);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Size = new System.Drawing.Size(132, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(40, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuFileAbout
            // 
            this.mnuFileAbout.Name = "mnuFileAbout";
            this.mnuFileAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.mnuFileAbout.Size = new System.Drawing.Size(193, 22);
            this.mnuFileAbout.Text = "&About";
            this.mnuFileAbout.Click += new System.EventHandler(this.mnuFileAbout_Click);
            // 
            // barStatusStrip
            // 
            this.barStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barStatusLabel});
            this.barStatusStrip.Location = new System.Drawing.Point(0, 424);
            this.barStatusStrip.Name = "barStatusStrip";
            this.barStatusStrip.Size = new System.Drawing.Size(632, 22);
            this.barStatusStrip.TabIndex = 1;
            this.barStatusStrip.Text = "statusStrip1";
            // 
            // barStatusLabel
            // 
            this.barStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.barStatusLabel.Name = "barStatusLabel";
            this.barStatusLabel.Size = new System.Drawing.Size(617, 17);
            this.barStatusLabel.Spring = true;
            this.barStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsc
            // 
            // 
            // tsc.ContentPanel
            // 
            this.tsc.ContentPanel.Controls.Add(this.tab);
            this.tsc.ContentPanel.Size = new System.Drawing.Size(632, 375);
            this.tsc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsc.Location = new System.Drawing.Point(0, 24);
            this.tsc.Name = "tsc";
            this.tsc.Size = new System.Drawing.Size(632, 400);
            this.tsc.TabIndex = 2;
            this.tsc.Text = "toolStripContainer1";
            // 
            // tsc.TopToolStripPanel
            // 
            this.tsc.TopToolStripPanel.Controls.Add(this.barToolBar);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabList);
            this.tab.Controls.Add(this.tabHtml);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(632, 375);
            this.tab.TabIndex = 0;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.lstFileInfoList);
            this.tabList.Location = new System.Drawing.Point(4, 22);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(624, 349);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "File List";
            this.tabList.UseVisualStyleBackColor = true;
            // 
            // lstFileInfoList
            // 
            this.lstFileInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFileInfoList.FormattingEnabled = true;
            this.lstFileInfoList.HorizontalScrollbar = true;
            this.lstFileInfoList.IntegralHeight = false;
            this.lstFileInfoList.Location = new System.Drawing.Point(3, 3);
            this.lstFileInfoList.Name = "lstFileInfoList";
            this.lstFileInfoList.ScrollAlwaysVisible = true;
            this.lstFileInfoList.Size = new System.Drawing.Size(618, 343);
            this.lstFileInfoList.TabIndex = 1;
            // 
            // tabHtml
            // 
            this.tabHtml.Controls.Add(this.txtHtmlOutput);
            this.tabHtml.Location = new System.Drawing.Point(4, 22);
            this.tabHtml.Name = "tabHtml";
            this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
            this.tabHtml.Size = new System.Drawing.Size(624, 349);
            this.tabHtml.TabIndex = 1;
            this.tabHtml.Text = "HTML Output";
            this.tabHtml.UseVisualStyleBackColor = true;
            // 
            // txtHtmlOutput
            // 
            this.txtHtmlOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHtmlOutput.Location = new System.Drawing.Point(3, 3);
            this.txtHtmlOutput.Multiline = true;
            this.txtHtmlOutput.Name = "txtHtmlOutput";
            this.txtHtmlOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHtmlOutput.Size = new System.Drawing.Size(618, 343);
            this.txtHtmlOutput.TabIndex = 0;
            // 
            // barToolBar
            // 
            this.barToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.barToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnScan,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnReset,
            this.btnIndent});
            this.barToolBar.Location = new System.Drawing.Point(3, 0);
            this.barToolBar.Name = "barToolBar";
            this.barToolBar.Size = new System.Drawing.Size(333, 25);
            this.barToolBar.TabIndex = 0;
            // 
            // btnScan
            // 
            this.btnScan.Image = global::FileIndexer.App.WinForms.Properties.Resources.play_16x16;
            this.btnScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(67, 22);
            this.btnScan.Text = "Index...";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::FileIndexer.App.WinForms.Properties.Resources.save_16x16;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 22);
            this.btnSave.Text = "Save...";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::FileIndexer.App.WinForms.Properties.Resources.refresh_16x16;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 22);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnIndent
            // 
            this.btnIndent.Checked = true;
            this.btnIndent.CheckOnClick = true;
            this.btnIndent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnIndent.Image = global::FileIndexer.App.WinForms.Properties.Resources.indent_16x16;
            this.btnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIndent.Name = "btnIndent";
            this.btnIndent.Size = new System.Drawing.Size(101, 22);
            this.btnIndent.Text = "###TEMP###";
            this.btnIndent.Click += new System.EventHandler(this.btnIndent_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 446);
            this.Controls.Add(this.tsc);
            this.Controls.Add(this.barStatusStrip);
            this.Controls.Add(this.mnu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnu;
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Indexer";
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.barStatusStrip.ResumeLayout(false);
            this.barStatusStrip.PerformLayout();
            this.tsc.ContentPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.ResumeLayout(false);
            this.tsc.TopToolStripPanel.PerformLayout();
            this.tsc.ResumeLayout(false);
            this.tsc.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabHtml.ResumeLayout(false);
            this.tabHtml.PerformLayout();
            this.barToolBar.ResumeLayout(false);
            this.barToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileAbout;
        private System.Windows.Forms.StatusStrip barStatusStrip;
        private System.Windows.Forms.ToolStripContainer tsc;
        private System.Windows.Forms.ToolStrip barToolBar;
        private System.Windows.Forms.ToolStripButton btnScan;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.ListBox lstFileInfoList;
        private System.Windows.Forms.TabPage tabHtml;
        private System.Windows.Forms.TextBox txtHtmlOutput;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.ToolStripStatusLabel barStatusLabel;
        private System.Windows.Forms.ToolStripButton btnIndent;
    }

}