using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _019_static_instance
{

    internal class Program
    {
        static void Main(string[] args)
        {
            date xmas = new date();

            xmas.year = 2023;
            xmas.month = 12;
            xmas.day = 25;

            Console.WriteLine("xmas : {0}/{1}/{2}는 {3}일째 는 날입니다.", xmas.year, xmas.month, xmas.day, xmas.DayOfYear());
            if (date.IsLeapYear(2023) == true)
                Console.WriteLine("2023년은 윤년입니다.");
            else
                Console.WriteLine("2023년은 평년입니다.");
        }
    }
}
