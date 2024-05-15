using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    delegate void MyDelegate(int number);
    class Program
    {
        static void PrintNumber(int number)
        {
            Console.WriteLine($"Ваше число: {number}");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            MyDelegate delegateInstance = new MyDelegate(PrintNumber);

            Console.Write("Введіть число : ");
            int number = Convert.ToInt32(Console.ReadLine());

            delegateInstance(number); 

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
