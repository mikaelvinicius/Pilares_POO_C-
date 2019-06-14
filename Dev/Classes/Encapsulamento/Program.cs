using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Astra = new Carro("GM Astra GSI");
            Console.WriteLine(Astra.Nome + " Foi criado");
            Astra.Ligar();
            Astra.Abastecer();
            Astra.Mover();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
