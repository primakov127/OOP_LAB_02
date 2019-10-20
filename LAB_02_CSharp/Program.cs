using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_02_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любой символ: ");
            char ch = Console.ReadKey().KeyChar;
            Console.Clear();

            Console.Write("\nВведите строку: ");
            string str = Console.ReadLine();
            Console.Clear();

            Console.Write("\nВведите целое число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("\nВведите дробное число: ");
            double dbl = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("\nВведите (true or false): ");
            bool bl = Convert.ToBoolean(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("1) char ch = {0};\n2) string str = {1};\n3) int num = {2};\n4) double dbl = {3};\n5) bool bl = {4};\n", ch, str, num, dbl, bl);


            //  Task 1  Boxing Unboxing

            int a = 4;
            string b = "stroka";
            double c = 12.2;
            Object d = a;
            a = (int)d;
            d = b;
            b = (string)d;
            d = c;
            c = (double)d;

            //  Task 2  Явное и неявное преобразование

            string str1 = "12,4";
            string str2 = "45";
            int groupNum = 21;
            short temp1 = (short)groupNum;
            double temp2 = groupNum;
            temp2 = Convert.ToDouble(str1);
            Console.WriteLine(temp2);

            //  Task 3  Вывод строки в консоль

            string myName = "Max";
            string strToConsole = string.Format("My name is {0}", myName);
            Console.WriteLine(strToConsole);
            Console.WriteLine($"My name is {myName}");

            //  Task 4  Использование открытых методов класса Object

            str1 = str.ToString();
            groupNum.GetHashCode();
            temp1.GetType();
            int num1 = 12;
            int num2 = 12;
            bool Eq = num1.Equals(num2);
            Console.WriteLine($"Task 4 Eq: {Eq}");

            //  Task 5  Демонтсрация работы методов: Comppare, Contains, Substring, Insert, Replace

            String.Compare(str1, str2);
            str1.Contains(str2);
            str1.Substring(1);              //  Извлечение строки с индекса
            str1.Insert(2, str2);
            str1.Replace('1', '2');

            //  Task 6

            string str3 = null;
            string str4 = "";
            Console.WriteLine(String.IsNullOrEmpty(str3));
            Console.WriteLine(String.IsNullOrEmpty(str4));

            //  Task 7

            var number = 12;
            //number = "";

            //  Task 8

            int? z1 = 5;

            Nullable<int> z2 = 5;
            int? z3 = null;

            //  Task 9

            TaskM(12);

            //  Task 10

            var tur = (12, "store", 12.2);
            var (e1, e2, e3) = tur;
            (int r1, string r2, double r3) = tur;
            (int t1, string t2, var t3) = tur;
            (_, _, var y3) = tur;

            //  Task 11

            TaskY();

            //  Task..

            using (Example ex = new Example(4))
            {
                Console.WriteLine(ex.GetState());
            }
                
        }

        static int TaskM(int a)
        {
            bool Test(Tuple<int, int> tuple)
            {
                return true;
            }

            

            var t = Tuple.Create(a, 35);
            if (Test(t) == true)
                Console.WriteLine("Turple true!!");

            return 1;
        }

        static void TaskY()
        {
            int l = 10;

            void Che()
            {
                checked
                {
                    int a = 2147483647 + l;
                }
                
            }

            void unChe()
            {
                unchecked
                {
                    int a = 2147483647 + l;
                }
            }

            unChe();
        }

        class Example : IDisposable
        {
            private readonly int _state;

            public Example(int state)
            {
                _state = state;
            }

            public int GetState() => _state;

            public void Dispose()
            {

            }
        }


    }
}
