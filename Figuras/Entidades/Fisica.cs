using Contribuintes.Entidades;

namespace Contribuintes.Entidades
{
    class Fisica : Contribuidor
    {
        public double GastoSaude { get; set; }

        public Fisica (string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }
        public override double Imposto()
        {
            if (RendaAnual < 20.000)
            {
                return RendaAnual * 0.15 - GastoSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastoSaude * 0.5;
            }
        }
    }
}
