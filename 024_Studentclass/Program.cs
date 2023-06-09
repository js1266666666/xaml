using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Studentclass
{
    internal class Program
    {
        public class Student
        {
            string name, major;
            int age;

            public Student(string n, int a, string m)
            {
                this.name = n;
                this.age = a;
                this.major = m;
            }

            public void DispalyInfo()
            {
                Console.WriteLine("이름: {0}, 나이: {1}, 전공: {2}",name,age,major);
            }
        }

        static void Main(string[] args)
        {
            Student s = new Student("홍길동", 20, "의료IT공학");
            s.DispalyInfo();
            
        }
    }
}
