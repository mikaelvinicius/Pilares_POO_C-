using System;

namespace Delegacao
{
    public class Funcionario
    {
        public virtual void Trabalhar(string tarefa)
        {
            Console.WriteLine("Funcionário Trabalhando");
        }
    }
    public class Estagiario
    {
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Estagiário trabalhando");
        }
    }
    public class Tester : Funcionario
    {
        public override void Trabalhar(string tarefa)
        {
            Console.WriteLine("Tester testando");
        }
    }
    public class Developer : Funcionario
    {
        public override void Trabalhar(string tarefa)
        {
            Console.WriteLine("Developer desenvolvendo");
        }
    }

    public class ArquitetoDeSoftware : Funcionario
    {
        public override void Trabalhar(string tarefa)
        {
            Console.WriteLine("Arquiteto arquitetando");
        }
    }
    //Delegacao
    public class Gerente
    {
        private Estagiario _estagiario;
        private Developer _developer;
        private ArquitetoDeSoftware _arquiteto;
        private Tester _tester;
        public Gerente()
        {
            _estagiario = new Estagiario();
            _developer = new Developer();
            _arquiteto = new ArquitetoDeSoftware();
            _tester = new Tester();

        }
        public void Trabalhar(string tarefa)
        {
            Console.WriteLine("Gerente recebeu a tarefa " + tarefa);
            _estagiario.Trabalhar(tarefa);
            _developer.Trabalhar(tarefa);
            _arquiteto.Trabalhar(tarefa);
            _tester.Trabalhar(tarefa);
        }
    }
}

