using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics
{
    internal delegate void Process();

    internal class MenuItems
    {
        public Process process;
        public string message;
        public MenuItems(Process process, string message) {
            this.message = message;
            this.process = process;
        }
    };
}
