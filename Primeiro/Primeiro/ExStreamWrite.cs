using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    public class ExStreamWrite
    {
        public void StremWriteMethod()
        {

            string sourcePath = @"C:\Users\User\Documents\GitHub\Primeiro\file1.txt";
            string targetPath = @"C:\Users\User\Documents\GitHub\Primeiro\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {

                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
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
