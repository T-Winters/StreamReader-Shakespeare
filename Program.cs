using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_Classwork
{
    class Program
    {
        static void Main(string[] args)
            {
            //First Problem Read Line 1
                StreamReader sr = new StreamReader("shakespeare.txt");
                using (sr)
                {
                    int lineNumber = 0;

                    string linee = sr.ReadLine();

                    while (linee != null)
                    {
                        lineNumber++;
                        if (lineNumber == 1)
                        { Console.WriteLine(linee); }
                        linee = sr.ReadLine();

                    }


                    Console.WriteLine("Press the enter key to continue");
                    Console.ReadKey();
                    Console.Clear();

                }



            //Second Problem Read the entire file
                int counter = 0;
                string line;

                StreamReader file = new StreamReader("shakespeare.txt");
                while ((line = file.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    counter++;
                }

                file.Close();
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

            //Third Problem Read the entire text file and capitalize all lowercase vowels.

                StreamReader reader = new StreamReader("shakespeare.txt");
                using (reader)
                {
                    line = reader.ReadToEnd();
                    foreach (char v in line)
                    {
                        string vowel = v.ToString();
                        if (v == 'a' || v == 'e' || v == 'i' || v == 'o' || v == 'u')
                        {
                            vowel = v.ToString().ToUpper();
                        }
                        Console.Write(vowel);

                    }

                Console.ReadLine();
                }
            }
    }
}
