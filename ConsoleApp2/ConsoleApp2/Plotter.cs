using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Plotter
    {
        private Map map;
        private List<Tool> toolNumber;
        private bool isHeadDown;
        private int actTool;

        internal Map GetMap { get => map; set => map = value; }
        internal List<Tool> GetTools { get => toolNumber; set => toolNumber = value; }
        public bool GetIsHeadDown { get => isHeadDown; set => isHeadDown = value; }
        public int GetActTool { get => actTool; set => actTool = value; }

        public Plotter(Map map, List<Tool> toolNumber, int actTool, bool isHeadDown= false)
        {
            this.map = map;
            this.toolNumber = toolNumber;
            this.isHeadDown = isHeadDown;
            this.actTool = actTool;
        }

        public void Menj(int newX, int newY)
        {
            //real.
            if (newX >this.GetMap.GetMaxWidth || newY > this.GetMap.GetMaxHeight || newX < 0 || newY < 0)
            {
                throw new Exception("Hibás adat!");
            }
            else
            {
                this.GetMap.GetActX = newX;
                this.GetMap.GetActY = newY;

            }
        }

        public void Fel() => isHeadDown = false;

        public void Le() => isHeadDown = true;

        public void Csere(int toolNum)
        {
            if (toolNum > toolNumber.Count || toolNum < 0)
            {
                throw new Exception("Hibás adat!");
            }
            else
            {
                actTool = toolNum;
            }
        }

        public void Map()
        {
            for (int row = 0; row < this.GetMap.GetMaxWidth; row++)
            {
                for (int item = 0;  item< this.GetMap.GetMaxHeight; item++)
                {
                    Console.Write(this.GetMap.GetWholeMap[row,item]);
                }
                Console.WriteLine();
            }
            /*
            foreach (var item in this.GetMap.GetWholeMap)
            {
                Console.Write(item);
            }
            */
        }

        //Draw function
        public void Draw(int newX, int newY)
        {
            int oldX = this.GetMap.GetActX;
            int oldY = this.GetMap.GetActY;
            

            Console.Clear();
            int xLength = Math.Abs(oldX - newX);
            int yLength = Math.Abs(oldY - newY);

            if (oldX<newX)
            {
                if (oldY<newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX + i, oldY + (i * yLength / xLength));
                        //Console.Write("*");
                        this.GetMap.GetWholeMap[oldX + i, Convert.ToInt32(oldY + (i * yLength / xLength))] = this.GetTools[this.GetActTool].GetHead;
                    }
                }
                else if(oldY>newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX + i, oldY - (i * yLength / xLength));
                        //Console.Write("*");
                        this.GetMap.GetWholeMap[oldX + i, Convert.ToInt32(oldY - (i * yLength / xLength))] = this.GetTools[this.GetActTool].GetHead;

                    }
                }
                else if(oldY==newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX + i, oldY - (i * yLength / xLength));
                        //Console.Write("*");
                        this.GetMap.GetWholeMap[oldX + i, oldY] = this.GetTools[this.GetActTool].GetHead;

                    }
                }
            }else if (oldX > newX)
            {
                if (oldY < newY)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX - i, oldY + (i * yLength / xLength));
                        //Console.Write("*");
                        this.GetMap.GetWholeMap[oldX - i, Convert.ToInt32(oldY + (i * yLength / xLength))] = this.GetTools[this.GetActTool].GetHead;
                    }
                }
                else if (oldY > newY)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX - i, oldY - (i * yLength / xLength));
                        //Console.Write("*");

                        this.GetMap.GetWholeMap[oldX - i, Convert.ToInt32(oldY - (i * yLength / xLength))] = this.GetTools[this.GetActTool].GetHead;
                    }
                }else if (oldY == newY)
                {
                    for (int i = 0; i < xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX + i, oldY - (i * yLength / xLength));
                        //Console.Write("*");
                        this.GetMap.GetWholeMap[oldX - i, oldY] = this.GetTools[this.GetActTool].GetHead;

                    }
                }
                else
                {
                    Console.WriteLine("nem");
                }
            }else if (oldX==newX)
            {
                if (oldY<newY)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX - i, oldY - (i * yLength / xLength));
                        //Console.Write("*");

                        this.GetMap.GetWholeMap[newX, oldY+i] = this.GetTools[this.GetActTool].GetHead;
                    }
                }else if (oldY>newX)
                {
                    for (int i = 1; i <= xLength; i++)
                    {
                        //Console.SetCursorPosition(oldX - i, oldY - (i * yLength / xLength));
                        //Console.Write("*");

                        this.GetMap.GetWholeMap[oldX, oldY - i] = this.GetTools[this.GetActTool].GetHead;
                    }
                }
            }
            this.GetMap.GetActX = newX;
            this.GetMap.GetActY = newY;



        }
    }
}
