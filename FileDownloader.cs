using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventPractice
{
    class FileDownloader
    {
        // step 1: define delegate that is used by event
        // C# provides a default delegate called EventHandler so you can skip this step if you want
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs e);
        // step 2: define event based of the delegate type
        public event FileDownloadedEventHandler FileDownloaded;

        // step 3: define the event raiser as a virtual method
        // that checks if any listener is registered and raise it with correct data
        protected virtual void OnFileDownloaded(string fileName)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs(fileName));
            }
        }

        public void DownloadFile(string fileName)
        {
            Console.WriteLine("Downloading file " + fileName);
            Thread.Sleep(3000);

            // step 4: raise the event where you need it
            this.OnFileDownloaded(fileName);
        }
    }
}
