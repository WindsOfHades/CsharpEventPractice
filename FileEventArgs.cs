using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    // this class just adds extra funtionality to EventArgs
    class FileEventArgs: EventArgs
    {
        public string FileName { get; set; }

        public FileEventArgs(string fileName)
        {
            this.FileName = fileName;
        }
    }
}
