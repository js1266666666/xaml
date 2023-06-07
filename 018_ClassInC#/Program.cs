using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ClassInC_
{
    class Product//원래는 public말고 private 사용함 근데 여기선 편하게 할려고 public 사용
    {
        public string name;
        public int price;
    }
    class MyMath
    {
        public static double PI = 3.14;
    }

    class MyCalendar
    {
        public const int months = 12;
        public const int weeks = 52;
        public const int days = 365;

        public const double daysPerWeek = (double)days / (double)weeks;
        public const double daysPerMonths = (double)days / (double)months;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            Console.WriteLine("{0} : {1:C}", p.name, p.price);//class는 객체이름.필드
            Console.WriteLine("웑주율 : {0}", MyMath.PI);//static은 클래스이름.필드
            Console.WriteLine("한달은 평균 {0:F3}일", MyCalendar.daysPerMonths);//const도 클래스이름.필드로 사용 가능
        }
    }
}