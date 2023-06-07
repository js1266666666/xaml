using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_constructer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            date Birthday = new date(2023, 11, 22);
            date christmas = new date(2023, 12, 25);
            date firstday = new date();

            Birthday.PrintDate();
            christmas.PrintDate();
            firstday.PrintDate();
        }
    }
}
