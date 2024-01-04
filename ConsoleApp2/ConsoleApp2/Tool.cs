using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Tool
    {
        string name;
        char toolHead;

        public Tool(char toolHead, string name = "Nem megadott")
        {
            this.name = name;
            this.toolHead = toolHead;
        }

        public string GetName { get => name; }
        public char GetHead { get => toolHead; }
    }
}
