using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    class FileUnpacker
    {
        // using C# default event handler and skipping the delegate
        public event EventHandler<FileEventArgs> FileUnpacked;


        public void OnFileUnpacked(string fileName)
        {
            if (FileUnpacked != null)
            {
                this.FileUnpacked(this, new FileEventArgs(fileName));
            }
        }

        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("An event raised by: " + source);
            Console.WriteLine($"FileUnpacker: Unpacking the {e.FileName} ...");
            this.OnFileUnpacked(e.FileName);
        }
    }
}
