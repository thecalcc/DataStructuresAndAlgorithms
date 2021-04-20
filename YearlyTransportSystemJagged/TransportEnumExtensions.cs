using System;
using System.Collections.Generic;
using System.Text;

namespace YearlyTransportSystemJagged
{
    public static class TransportEnumExtensions
    {
        public static char GetChar(this TransportEnum transportEnum)
        {
            switch (transportEnum)
            {
                case TransportEnum.CAR: return 'C';
                case TransportEnum.BUS: return 'U';
                case TransportEnum.SUBWAY: return 'S';
                case TransportEnum.BIKE: return 'B';
                case TransportEnum.WALK: return 'W';
                default: throw new Exception("Unknown transport!");
            }
        }

        public static ConsoleColor GetColor(this TransportEnum transport)
        {
            switch (transport)
            {
                case TransportEnum.CAR: return ConsoleColor.Red;
                case TransportEnum.BUS: return ConsoleColor.Blue;
                case TransportEnum.SUBWAY: return ConsoleColor.DarkGreen;
                case TransportEnum.BIKE: return ConsoleColor.DarkMagenta;
                case TransportEnum.WALK: return ConsoleColor.DarkYellow;
                default: throw new Exception("Unknown transport");
            }
        }
    }
}
