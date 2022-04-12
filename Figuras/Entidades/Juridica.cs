using Contribuintes.Entidades;

namespace Contribuintes.Entidades
{
    class Juridica : Contribuidor 
    {
        public int NumeroFuncionario { get; set; }

        public Juridica (string nome, double rendaAnual, int numeroFuncionario) : base (nome, rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }
        public override double Imposto()
        {
            if (NumeroFuncionario < 10)
            {
                return RendaAnual * 0.14;
            }
            else
            {
                return RendaAnual * 0.16;
            }
        }
    }
}
