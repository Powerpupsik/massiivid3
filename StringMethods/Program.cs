using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÕIK NEED ON STRINGI MEETODID!
            //Trim(võtab tühikud ära, ei midagi muud)
            //IndexOf(sümboli asukoht)
            //Substring()
            //Split()

            /*string fullName = "Raima Levistu ";
            Console.WriteLine($"Full name length before trim:  {fullName.Length} ");

            fullName = fullName.Trim();
            Console.WriteLine($"Full name length after trim: {fullName.Length} ");

            Console.WriteLine($"{fullName[0]}");
            int indexOfSpace = fullName.IndexOf(' ');
            Console.WriteLine($"The position of the space is {indexOfSpace}");

            string firstName = fullName.Substring(0, indexOfSpace);
            string lastName = fullName.Substring(indexOfSpace + 1);
            Console.WriteLine($"Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");

            //SPLIT(saad lisada parameetrid, mille järgi otsida)
            string[] personalData = fullName.Split(' ');
            foreach (string value in personalData) 
            {
                Console.WriteLine($"Value from personalData: {value}");
            }*/


            //ÜLESANNE: sisesta oma täisnimi ja las arvuti ütleb eraldi, mis su ees ja perek. nimi on.

            Console.WriteLine("Enter your first and last name: ");
            string fullName = Console.ReadLine();
            GetArrayFromString(fullName);
            Console.ReadLine();
        }

        public static void GetArrayFromString(string stringToSplit)
        {
            string[] personalData = stringToSplit.Split(' '); //Split tagastab massiivi
            Console.WriteLine($"First name: {personalData[0]}");
            Console.WriteLine($"Last name: {personalData[1]}");

        }



    }
}
