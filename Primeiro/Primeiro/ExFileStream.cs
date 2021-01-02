using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    public class ExFileStream
    {
        public void FileStreamMethod()
        {
            // FileStrem....  Stream compatilhamento de dados
            string path = @"C:\Users\User\Documents\GitHub\Primeiro\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
