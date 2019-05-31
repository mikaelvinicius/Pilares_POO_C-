using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Transporte c = new Carro();
            c.Marca = "GM";
            c.Modelo = "Astra";
            c.Mover();

            Transporte a = new Aviao();
            a.Modelo = "F22";
            a.Mover();
            Console.ReadLine();
        }
    }
}
