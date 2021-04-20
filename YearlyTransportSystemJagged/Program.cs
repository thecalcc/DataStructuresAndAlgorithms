using System;
using System.Globalization;
using System.Linq;

namespace YearlyTransportSystemJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int transportTypesCount = Enum.GetNames(typeof(TransportEnum)).Length;
            TransportEnum[][] transports = new TransportEnum[12][];

            for (int month = 1; month <= 12; month++)
            {
                int daysCount = DateTime.DaysInMonth(
                    DateTime.Now.Year, month);

                transports[month - 1] = new TransportEnum[daysCount];

                for (int day = 1; day < daysCount; day++)
                {
                    int randomType = rand.Next(transportTypesCount);
                    transports[month - 1][day - 1] = (TransportEnum)randomType;
                }
            }

            string[] monthNames = GetMonthNames();
            int monthNamesPart = monthNames.Max(n => n.Length) + 2;

            for (int months = 1; months <= transports.Length; months++)
            {
                Console.WriteLine($"{monthNames[months - 1]}".PadRight(monthNamesPart));

                for (int day = 1; day <= transports[months - 1].Length; day++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = transports[months - 1][day - 1].GetColor();
                    Console.Write(transports[months - 1][day - 1].GetChar());
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

        }

        private static string[] GetMonthNames()
        {
            string[] names = new string[12];

            for (int month = 1; month <= 12; month++)
            {
                DateTime fistDay = new DateTime(
                    DateTime.Now.Year, month, 1);

                string name = fistDay.ToString("MMMM",
                    CultureInfo.CreateSpecificCulture("en"));

                names[month - 1] = name;
            }

            return names;
        }
    }
}
