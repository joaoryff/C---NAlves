using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    public class ExDirectory
    {

        public void DirectoryMethod()
        {
            // Directory
            string path = @"C:\Users\User\Documents\GitHub\Primeiro\myfolder";
            try
            {
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                //Directory.CreateDirectory(path + "\\newfolder");
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
