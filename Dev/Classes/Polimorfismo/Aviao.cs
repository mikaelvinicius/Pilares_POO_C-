using System;

namespace Polimorfismo
{
    public class Aviao : Transporte
    {
        public override void Mover()
        {
            Console.WriteLine(Modelo + " voando...");
        }
    }
}
