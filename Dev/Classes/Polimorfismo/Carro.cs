using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Carro: Transporte
    {

        public override void Mover()
        {
            Console.WriteLine(Marca + " " + Modelo + " andando");
        }
    }
}
