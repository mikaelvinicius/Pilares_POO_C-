using System;

namespace Encapsulamento
{
    public class Bateria
    {

    }
    public class SuperBateria : Bateria
    {

    }
    public class Motor
    {

    }
    public class Carro
    {
        //Encapsulando detalhes do carro
        //Composição de componentes
        private Motor _motor;
        private Bateria _bateria;

        //Propriedade...
        public string Nome { get; }

        //Construtor
        public Carro(string nome)
        {
            Console.WriteLine("Criando o objeto carro...");
            _motor = new Motor();
            _bateria = new SuperBateria();
            Nome = nome;
        }
        public int NumPneus()
        {
            return 4;
        }
        private void Ignicao()
        {
            Console.WriteLine("Foi dada a ignição do carro");
        }
        public void Abastecer()
        {
            Console.WriteLine("Abastecendo o carro...");
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando o carro...");
            Ignicao();
        }
        public void Mover()
        {
            Console.WriteLine("Movendo o carro..>");
        }
    }
}
