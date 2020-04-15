using System;
using System.Collections.Generic;
using System.Text;

namespace EventPractice
{
    // this class just adds extra funtionality to EventArgs
    class FileEventArgs: EventArgs
    {
        // It is usually good practice to use private setter and only
        // allow setting of a property done through constructor.
        // This way you secure that different event handling codes wont change the referenced
        // event args by accident (Some time you might want to allow it though!)
        public string FileName { get; private set; }

        public FileEventArgs(string fileName)
        {
            this.FileName = fileName;
        }
    }
}
