using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Primeiro
{
    public class ExUsingFecharStream
    {
        public void UsingFecharStreamMethod()
        {
            // Using para fechar
            string path = @"C:\Users\User\Documents\GitHub\Primeiro\file1.txt";
            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //using (StreamReader sr = new StreamReader(fs))
                using (StreamReader sr = File.OpenText(path))
                {

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                //}

            }
            catch (IOException e)
            {

                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            //} 
        }
    }
}
