using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Mouse", "Fare");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(" " + dictionary["Book"]);
            Console.WriteLine();
            //C# is case sensitive
            //Console.WriteLine(dictionary["book"]); //never work, throws an error

            foreach (var item in dictionary)
            {
                Console.Write(" KEY ");
                Console.WriteLine(" VALUE");
                Console.Write(" " + item.Key);
                Console.WriteLine(" " + item.Value);
                Console.WriteLine();
            }

            Console.WriteLine(" " + dictionary.ContainsKey("Glass"));//Is there content(returns true or false)
            Console.WriteLine(" " + dictionary.ContainsValue("Bardak"));//Is there content(returns true or false)


            Console.ReadLine();
        }
    }
}
