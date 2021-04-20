using System;
using System.Collections.Generic;
using System.Text;

namespace MiniGame
{
    /// <summary>
    /// Extension class of TerrainEnum type. Implements two extension methods.
    /// The extension methods have to be defined in a static class as a static method with the first parameter 
    /// indicating the type you want to add with the "this" keyword.
    /// </summary>
    public static class TerrainEnumExtensions
    {
        public static ConsoleColor GetColor(this TerrainEnum terrainEnum)
        {
            switch (terrainEnum)
            {
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.Blue;
                default: return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar(this TerrainEnum terrainEnum)
        {
            switch (terrainEnum)
            {
                case TerrainEnum.GRASS: return '\u201c';
                case TerrainEnum.SAND: return '\u25cb';
                case TerrainEnum.WATER: return '\u2248';
                default: return '\u25cf';
            }
        }
    }
}
