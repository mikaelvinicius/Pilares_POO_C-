using System;

namespace Polimorfismo
{
    public class Carro : Transporte
    {

        public override void Mover()
        {
            Console.WriteLine(Marca + " " + Modelo + " andando");
        }
    }
}
