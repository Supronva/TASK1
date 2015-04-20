using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            LinearFuction f = new LinearFuction(3, 3);
            int x = 3;
            Console.WriteLine(" a = {0}\n b = {1}\n x = {2}\n y=ax+b = {3}",f.A,f.B,x,f.Fuction(x));
            Console.ReadKey();

        }
    }
}
