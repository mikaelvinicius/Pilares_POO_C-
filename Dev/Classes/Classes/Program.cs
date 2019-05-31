using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 10;
            int y2 = 20;
            Calc c = new Calc();
            int r1 = c.Somar(x1, y2);

            Console.WriteLine("A soma de {0} com {1} é {2}", x1, y2, r1);
            Console.ReadKey();

            

            
        }
    }
}
