using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    class FileInstaller
    {
        public void OnFileUnpacked(object source, FileEventArgs e)
        {
            Console.WriteLine("An event raised by: " + source);
            Console.WriteLine($"FilerInstaller: installing {e.FileName}...");
        }
    }
}
