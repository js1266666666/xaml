using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_constructer
{
    internal class date
    {
        private int year, month, day;

        public date()
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public date(int y, int m, int d)//여기가 int year, int month~ 이면 아래에 this.year = year 이런식으로 this를 꼭 붙여서 구분해야함
        {
            this.year = y;//this 생략가능(this.year -> 이 클래스의 year을 뜻 함)
            this.month = m;
            this.day = d;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
}
