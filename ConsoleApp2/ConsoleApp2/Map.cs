using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Map
    {
        private int maxWidth, maxHeight, actX, actY;
        char mapType;
        char[,] wholeMap;

        public Map(int maxHeight, int maxWidth, char mapType = ' ', int actX=0, int actY = 0)
        {
            this.maxWidth = maxWidth;
            this.maxHeight = maxHeight;
            this.actX = actX;
            this.actY = actY;
            this.mapType = mapType;

            wholeMap = new char[maxWidth, maxHeight];

            for (int x = 0; x < maxWidth; x++)
            {
                for (int y = 0; y < maxHeight; y++)
                {
                    wholeMap[x, y] = mapType;
                }
            }
        }

        public int GetMaxWidth { get => maxWidth; set => maxWidth = value; }
        public int GetMaxHeight { get => maxHeight; set => maxHeight = value; }
        public int GetActX { get => actX; set => actX = value; }
        public int GetActY { get => actY; set => actY = value; }
        public char GetMapType { get => mapType; set => mapType = value; }
        public char[,] GetWholeMap { get => wholeMap; set => wholeMap = value; }
    }
}
