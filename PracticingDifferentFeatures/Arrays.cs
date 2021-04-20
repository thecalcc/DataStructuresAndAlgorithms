using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace PracticingDifferentFeatures
{
    class Arrays
    {
        static string[] GenNames()
        {
            string[] names = new string[4];

            names[0] = "Jon";
            names[1] = "Skeet";
            names[2] = "Skeet";
            names[3] = "Skeet";

            return names;
        }

        static ArrayList GenerateNames()
        {
            ArrayList names = new ArrayList();

            names.Add("Peter");
            names.Add("Peter");
            names.Add("Peter");
            names.Add("Peter");

            return names;
        }

        static StringCollection GenerateStrNames()
        {
            StringCollection names = new StringCollection();

            names.Add("Gamma");
            names.Add("Gamma");
            names.Add("Gamma");

            return names;
        }

        /// <summary>
        /// Solves a lot of problems.
        /// 1. No need to know the size of the collection beforehand, unlike arrays.
        /// 2. The API uses T everywhere it needs to refer to the element type, that way you know that List<string> will contain only string references.
        /// 3. Usable with any element type without worries about generating code and managing the result, unlike with StringCollection and similar types.
        /// </summary>
        /// <returns></returns>

        static List<string> GenListNames()
        {
            List<string> names = new List<string>();

            names.Add("Kiril");
            names.Add("Kiril");
            names.Add("Kiril");
            names.Add("Kiril");

            return names;
        }

        static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintNames(ArrayList names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintNames(StringCollection names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void PrintNames(List<string> names)
        {
            names.ForEach(x => Console.WriteLine(x));
        }


    }
}
