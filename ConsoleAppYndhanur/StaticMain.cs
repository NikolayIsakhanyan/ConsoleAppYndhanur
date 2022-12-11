using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYndhanur
{
    public class StaticMain
    {
        public int a =5;
        public static int b = 8;
        static void MyStat(int n)
        {
            Console.WriteLine(n);
        }
        public int MyStat2(int g)
        {
            return g + 5;
        }
    }
}
