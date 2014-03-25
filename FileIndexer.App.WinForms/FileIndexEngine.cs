using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace FileIndexer.App.WinForms
{

    internal class FileIndexEngine
    {

        #region Event Code

        public delegate void FileIndexEvent(int numberFilesTotal, int numberFilesScanned);
        public event FileIndexEvent FileIndexError;
        public event FileIndexEvent FileIndexUpdate;
        public event FileIndexEvent FileIndexCompleted;
        private void OnFileIndexError(int numberFilesTotal, int numberFilesScanned)
        {
            if (this.FileIndexError != null)
            {
                this.FileIndexError(numberFilesTotal, numberFilesScanned);
            }
        }
        private void OnFileIndexUpdate(int numberFilesTotal, int numberFilesScanned)
        {
            if (this.FileIndexUpdate != null)
            {
                this.FileIndexUpdate(numberFilesTotal, numberFilesScanned);
            }
        }
        private void OnFileIndexCompleted(int numberFilesTotal, int numberFilesScanned)
        {
            if (this.FileIndexCompleted != null)
            {
                this.FileIndexCompleted(numberFilesTotal, numberFilesScanned);
            }
        }

        #endregion Event Code

        private int _numberFilesTotal;
        private int _numberFilesScanned;
        private Thread _thread;

        private string _path;
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        private List<FileInfo> _fileInfoList;
        public List<FileInfo> FileInfoList
        {
            get { return this._fileInfoList; }
        }

        private StringBuilder _stringBuilder;
        public string HtmlOutput
        {
            get
            {
                return this._stringBuilder.ToString();
            }
        }

        public FileIndexEngine(string path)
        {
            this._path = path;
        }

        public void Start()
        {
            // Reset variables
            this._numberFilesTotal = 0;
            this._numberFilesScanned = 0;
            this._stringBuilder = new StringBuilder();
            this._fileInfoList = new List<FileInfo>();

            //Initialize Thread
            if (null == this._thread)
            {
                this._thread = new Thread(new ThreadStart(this.ThreadProcess));
            }

            this._thread.Start();
        }

        private void ThreadProcess()
        {
            this._stringBuilder.Append("<HTML>\r\n<HEAD><TITLE>Index of ");
            this._stringBuilder.Append(this._path);
            this._stringBuilder.Append("</TITLE></HEAD>\r\n<BODY>\r\n");

            this.Index(this._path);

            this._stringBuilder.Append("</BODY>\r\n</HTML>\r\n");

            this.OnFileIndexCompleted(this._numberFilesTotal, this._numberFilesScanned);
            this._thread.Abort();
        }

        private void Index(string sourceDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(sourceDirectory);

            //Determine whether the source directory exists.
            if (directoryInfo.Exists)
            {
                //Scan files
                FileInfo[] files = directoryInfo.GetFiles();
                foreach (FileInfo fileInfo in files)
                {
                    this._numberFilesTotal++;
                    this._numberFilesScanned++;
                    this._fileInfoList.Add(fileInfo);

                    string filePath = fileInfo.FullName.Replace(this._path, "");
                    filePath = filePath.Replace('\\', '/');
                    filePath = filePath.Remove(0, 1);

                    this._stringBuilder.Append("<a href=\"");
                    this._stringBuilder.Append(filePath);
                    this._stringBuilder.Append("\">");
                    this._stringBuilder.Append(filePath);
                    this._stringBuilder.Append("</a><br/>\r\n");

                    this.OnFileIndexUpdate(this._numberFilesTotal, this._numberFilesScanned);
                }

                //Scan all sub-directories
                DirectoryInfo[] directoryInfoList = directoryInfo.GetDirectories();
                for (int i = 0; i < directoryInfoList.Length; ++i)
                {
                    this.Index(directoryInfoList[i].FullName);
                }
            }
        }

    }

}