
using System.Globalization;

namespace HerancaExDois.Entities
{
    public class Gerente : Colaborador
    {
        public double Bonificacao { get; private set; }

        public Gerente(string nome, string cpf, double bonificacao) : base(nome, cpf)
        {
            Bonificacao = bonificacao;
        }

        public void SetBonificação(double bonificacao)
        {
            Bonificacao = bonificacao;
        }

        public override double CalcularSalario()
        {
            double total = SalarioMinimo * 6 + Bonificacao;
            return total;
        }

        public override string? ToString()
        {
            return "Nome " + Nome + ", CPF " + Cpf + ", valor da Bonificação "  + Bonificacao.ToString("F2");
        }
    }
}
