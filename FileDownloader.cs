using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventPractice
{
    class FileDownloader
    {
        // This is to show how to create events from scratch using Delegates
        // In a modern way you do not need to do all of this. See FileUnpacker for the modern way.
        // step 1: define delegate that is used by event
        // C# provides a default delegate called EventHandler so you can skip this step if you want
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs e);
        // step 2: define event based of the delegate type
        public event FileDownloadedEventHandler FileDownloadedEvent;

        // step 3: define the event raiser as a virtual method
        // that checks if any listener is registered and raise it with correct data
        // Again this is an old way of raising events. Check FileUnpacker for modern way.
        protected virtual void OnFileDownloaded(string fileName)
        {
            if (FileDownloadedEvent != null)
            {
                FileDownloadedEvent(this, new FileEventArgs(fileName));
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
