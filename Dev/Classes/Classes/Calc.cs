using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //SINGLE RESPONSABILITY PROGRAM - SRP
    //CLASSE CONCRETA
    public class Calc
    {
        public int Somar(int x, int y)
        {
            int r = x + y; //business
            return r;
        }

    }
}
