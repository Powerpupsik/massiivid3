using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            //shopinglist, kuva tulbana

            /*Console.WriteLine("Enter your list of supplies, separated by comma: ");
            string userList = Console.ReadLine();

            string[] shoppingList = userList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); //viimane eemaldab tühikud

            for(int i=0; i< shoppingList.Length; i++)
            {
                Console.WriteLine($"Item {i+1}: {shoppingList[i]}");
            }*/

            Console.WriteLine("Enter your first name, last name, birth year");
            string userData = Console.ReadLine();
            GetUserData(userData);
  
        }

        public static void GetUserData(string userData)
        {
            string[] userDataList=userData.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"First name: {userDataList[0]}");
            Console.WriteLine($"Last name: {userDataList[1]}");
            Console.WriteLine($"Age: {2019 - int.Parse(userDataList[2])}");
        }
        
    }
}
