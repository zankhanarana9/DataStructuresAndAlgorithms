﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public static class TerrainEnumExtensions
    {
        public static ConsoleColor GetColor(this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS: return ConsoleColor.Green;
                case TerrainEnum.SAND: return ConsoleColor.Yellow;
                case TerrainEnum.WATER: return ConsoleColor.Blue;
                default: return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar(this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.GRASS: return'\u201c';
                case TerrainEnum.SAND: return '\u25cb';
                case TerrainEnum.WATER: return '\u2248';
                default: return '\u25cf';
            }
        }
    }
}
