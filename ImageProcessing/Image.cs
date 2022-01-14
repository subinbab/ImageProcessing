using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    internal class Image
    {
        public Image()
        {
            
            string[] lines = System.IO.File.ReadAllLines(@"C:\\Users\\HP\\Downloads\\test2.txt");
            List<string[]> vs = new List<string[]>();
            foreach (var i in lines)
            {
                //Console.WriteLine(i.Count());
                var str = i.Split(' ');
                /*Console.WriteLine(str.Max());*/
                vs.Add(str);
            }
                foreach (var str in vs)
            {
                foreach (var str2 in str)
                {
                    try
                    {
                        int value = Convert.ToInt32(str2);
                        if (value > 0 && value < 50)
                        {
                            Console.Write("@");
                        }
                        else if (value < 50 && value > 70)
                        {
                            Console.Write("#");
                        }
                        else if (value < 70 && value > 100)
                        {
                            Console.Write("8");
                        }
                        else if (value < 100 && value > 130)
                        {
                            Console.Write("&");
                        }
                        else if (value < 130 && value > 160)
                        {
                            Console.Write("o");
                        }
                        else if (value < 160 && value > 180)
                        {
                            Console.Write("0");
                        }
                        else if (value < 180 && value > 200)
                        {
                            Console.Write(":");
                        }
                        else if (value < 200 && value > 230)
                        {
                            Console.Write("*");
                        }
                        Console.Write(".");
                    }
                    catch (Exception x)
                    {
                        continue;
                    }
                    
                }
                Console.WriteLine();
                }
                //nsole.WriteLine();

            }

        
        
    }
}
