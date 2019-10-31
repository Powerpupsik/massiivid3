using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mitu korda mingit sõna  esineb.
            string[] names = new string[5]; //õige on ka {"koer", "kass", "lehm", "lammas", "koer"}
            //2 variant: 
            names[0] = "koer";
            names[1] = "lehm";
            names[2] = "kass";
            names[3] = "koer";
            names[4] = "lammas";

            string searchNames = "koer";
            int counter = 0;
            CountNames(names, searchNames);

           /*foreach(string name in names)
            {
                if (name == searchNames)
                {
                    counter++;
                }
            }



            Console.WriteLine($"There are {counter} {searchNames} in the array");
            Console.ReadLine();*/
        }

        public static void CountNames(string[] searchArray, string searchWord) // see on funktsioon siin...
        {
            int counter = 0;
            foreach(string word in searchArray)
            {
                if (word == searchWord)
                {
                    counter++; //pole sama counter mis ülemine!!!
                }
            }
            Console.WriteLine($"There are {counter} {searchWord} in the array");
            Console.ReadLine();

        }
    
    }    
}
