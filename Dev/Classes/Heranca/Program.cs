using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Cpf = "70000000000";
            p.Nome = "Fulano";
            p.Nascimento = new DateTime(1999, 6, 30, 23, 40, 5);
            Console.WriteLine("A idade da pessoa é {0}", p.Nascimento.ToString("d"));
            Console.WriteLine("A idade da pessoa é {0}", p.Nascimento.ToString("dd/MM/yyyy HH:mm"));
            Console.WriteLine("O nome da pessoa é {0}", p.Nome);
            //Console.WriteLine(p.Nascimento.ToString("d"));
            //Console.WriteLine(p.Nascimento.ToString("dd/MM/yyyy HH:mm"));


            Funcionario f = new Funcionario();
            f.Departamento = "Diretoria de Tecnologia";
            f.Nome = p.Nome;
            f.Trabalhar();
            Console.ReadKey();
        }
    }
}
