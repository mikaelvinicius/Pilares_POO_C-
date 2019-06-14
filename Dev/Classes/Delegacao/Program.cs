using System;

namespace Delegacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente chefe = new Gerente();
            chefe.Trabalhar("Sistema atendimento ao usuário");
            Console.ReadLine();
        }
    }
}
