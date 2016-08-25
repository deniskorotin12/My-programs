using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, S;
            Console.WriteLine("Введите сторону а : ");
            a = Convert.ToInt32(Console.ReadLine());           
            
            S = a * a;
            Console.WriteLine("Площадь равна: "+S);
            Console.ReadKey();
        }
    }
}
