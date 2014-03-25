using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileIndexer.App.WinForms
{
    public partial class AppForm : Form
    {

        private FileIndexEngine _fileIndexEngine;

        public AppForm()
        {
            InitializeComponent();
        }



        private void btnScan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                this.barStatusLabel.Image = global::FileIndexer.App.WinForms.Properties.Resources.settings1_16x16;
                this.btnScan.Enabled = false;
                this.btnSave.Enabled = false;
                this.btnReset.Enabled = false;
                this._fileIndexEngine = new FileIndexEngine(folderBrowserDialog.SelectedPath);
                this._fileIndexEngine.FileIndexUpdate += new FileIndexEngine.FileIndexEvent(_fileIndexEngine_FileIndexUpdate);
                this._fileIndexEngine.FileIndexCompleted += new FileIndexEngine.FileIndexEvent(_fileIndexEngine_FileIndexCompleted);
                this._fileIndexEngine.Start();

                //fileInfoList = this.Scan(folderBrowserDialog.SelectedPath, fileInfoList);
                //this.lstFileInfoList.Items.AddRange(fileInfoList.ToArray());
            }
        }

        private void _fileIndexEngine_FileIndexUpdate(int numberFilesTotal, int numberFilesScanned)
        {
            this.BeginInvoke(new FileIndexEngine.FileIndexEvent(this.FileIndexUpdate), new object[] { numberFilesTotal, numberFilesScanned });
        }

        private void _fileIndexEngine_FileIndexCompleted(int numberFilesTotal, int numberFilesScanned)
        {
            this.BeginInvoke(new FileIndexEngine.FileIndexEvent(this.FileIndexCompleted), new object[] { numberFilesTotal, numberFilesScanned });
        }

        private void FileIndexUpdate(int numberFilesTotal, int numberFilesScanned)
        {
            this.barStatusLabel.Text = "Processing: " + numberFilesScanned + " Files Indexed";
        }

        private void FileIndexCompleted(int numberFilesTotal, int numberFilesScanned)
        {
            this.barStatusLabel.Text = "Processing Completed: " + numberFilesScanned + " Files Indexed";

            List<FileInfo> fileInfoList = this._fileIndexEngine.FileInfoList;
            this.lstFileInfoList.Items.AddRange(fileInfoList.ToArray());
            this.btnScan.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnReset.Enabled = true;

            this.txtHtmlOutput.Text = this._fileIndexEngine.HtmlOutput;
        }

        #region Scan
        private List<FileInfo> Scan(string sourceDirectory, List<FileInfo> fileInfoList)
        {
            DirectoryInfo source = new DirectoryInfo(sourceDirectory);

            //Determine whether the source directory exists.
            if (!source.Exists)
            {
                return fileInfoList;
            }

            //Copy files.
            FileInfo[] sourceFiles = source.GetFiles();
            for (int i = 0; i < sourceFiles.Length; ++i)
            {
                //sourceFiles[i].FullName;
                //sourceFiles[i].Name;
            }
            fileInfoList.AddRange(sourceFiles);

            //Copy directories.
            DirectoryInfo[] sourceDirectories = source.GetDirectories();
            for (int i = 0; i < sourceDirectories.Length; ++i)
            {
                fileInfoList = Scan(sourceDirectories[i].FullName, fileInfoList);
            }
            return fileInfoList;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HTML files (*.html)|*.html|HTM files (*.htm)|*.htm|All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = this._fileIndexEngine.Path;
            if (DialogResult.OK == saveFileDialog.ShowDialog(this))
            {
                using (StreamWriter streamWriter = File.CreateText(saveFileDialog.FileName))
                {
                    streamWriter.Write(this._fileIndexEngine.HtmlOutput);
                    streamWriter.Close();
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.lstFileInfoList.Items.Clear();
            this.txtHtmlOutput.Clear();
            this.barStatusLabel.Text = "";
            this.barStatusLabel.Image = null;
            this.btnSave.Enabled = false;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            //
            // TODO: Stop Engine
            //
            Application.Exit();
        }

        private void mnuFileAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + " v" + Application.ProductVersion);
        }

    }
}
