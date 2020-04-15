using System;

namespace EventPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDownloader downloader = new FileDownloader();
            FileUnpacker unpacker = new FileUnpacker();
            FileInstaller installer = new FileInstaller();
            downloader.FileDownloadedEvent += unpacker.OnFileDownloaded;
            unpacker.FileUnpackedEvent += installer.OnFileUnpacked;

            downloader.DownloadFile("SomeFile");
        }
    }
}
