using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    internal class Program
    {
        delegate int MathOperation(int x, int y);

        static void Calculate(int a, int b, MathOperation operation)
        {
            int result = operation(a, b);

            Console.WriteLine($"Результат операції: {result}");
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Calculate(10, 3, (x, y) => x + y);

            Calculate(10, 3, (x, y) => x - y);

            Calculate(10, 3, (x, y) => x * y);

            Calculate(10, 3, (x, y) => x / y);

            Console.CursorVisible = false;
            Console.ReadKey();
        }
    }
}
