using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    public class ExFileInfo
    {
        public void FileInfoMethod()
        {

            // FileInfo and File
            string sourcePath = @"C:\Users\User\Documents\GitHub\Primeiro\file1.txt";
            string targetPath = @"C:\Users\User\Documents\GitHub\Primeiro\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
