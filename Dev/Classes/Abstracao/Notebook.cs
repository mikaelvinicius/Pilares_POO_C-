namespace Abstracao
{
    public class Notebook
    {
        private string _nome { get; }
        public string GetNome()
        {
            return _nome;
        }
        public Notebook(string nome)
        {
            _nome = nome;
        }
        public iPhone iPhone { get; set; }
        public Mouse Mouse { get; set; }
        public Teclado Teclado { get; set; }

    }
    public class iPhone
    {

    }
    public class Mouse
    {

    }
    public class Teclado
    {

    }
}

