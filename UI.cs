using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDiff
{
    class UI
    {
        public static string ReadLine(string text)
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        public static void line()
        {
            Console.WriteLine();
        }
    }
}
