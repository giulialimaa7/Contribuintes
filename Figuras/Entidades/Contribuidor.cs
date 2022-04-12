using Contribuintes.Entidades;

namespace Contribuintes.Entidades
{
    abstract class Contribuidor
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuidor (string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double Imposto();
        
    }
}
