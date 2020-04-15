using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    class FileUnpacker
    {
        // (Modern way) using C# default event handler and skipping the delegate
        public event EventHandler<FileEventArgs> FileUnpackedEvent;

        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("An event raised by: " + source);
            Console.WriteLine($"FileUnpacker: Unpacking the {e.FileName} ...");

            // (Modern way) raising event, Note that it is a one liner
            // and does not need a virtual method that first checked
            // all that is done by using "?.Invoke" syntax
            FileUnpackedEvent?.Invoke(this, new FileEventArgs(e.FileName));
        }
    }
}
