using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cpf; 
   

        public void Andar()
        {
            Console.WriteLine("A pessoa {0} está andando", Nome);
        }

        /*public void GetIdade()
        {
            Console.WriteLine("A idade da pessoa é {0}", (DateTime.Today.Date - Nascimento.Date));
        }*/
    }
}
