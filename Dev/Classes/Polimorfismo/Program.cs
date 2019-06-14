using System;

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
