using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSetAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> usedCupons = new HashSet<int>();
            do
            {
                Console.WriteLine("Enter the cupon number:" );
                string cuponString = Console.ReadLine();

                if (int.TryParse(cuponString, out int cupon))
                {
                    if (usedCupons.Contains(cupon))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("It has been already used!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        usedCupons.Add(cupon);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Thank you!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else break;
            } while (true);
        }

        static void DictionaryExample()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>()
            {
                {"Key 1", "Value 1" },
                {"Key 2", "Value 2" }
            };

            dictionary["key"] = "value";
        } 

        static void HashTableExample()
        {
            Hashtable phoneBook = new Hashtable()
            {
                {"Marcin Jamro", "000-000-000"},
                {"John Smith", "111-111-111" }
            };

            phoneBook["Lily Smith"] = "333-333-333";

            try
            {
                phoneBook.Add("Mary Fox", "555-555-555");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The entry already exists");
            }
        }
    }
}
