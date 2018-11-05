using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace San.LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count The Charecters in a given string ");
            Console.WriteLine("Please enter a string");
            string str = Console.ReadLine();
            char[] str1 = str.ToCharArray();
            int count = 0;
           
                for (char ch = 'a'; ch <= 'z'; ch++)
                {
                     for (int i = 0; i < str1.Length; i++)
                     {
                        if (str1[i]==ch)
                        {
                          count++;
                        }
                        Console.WriteLine(str1[i] + "--->" + count);
                       
                     }
                    if (count > 0)
                    {
                        count = 0;
                    }
            }
               
               
            Console.ReadLine();
        }
    }
}
