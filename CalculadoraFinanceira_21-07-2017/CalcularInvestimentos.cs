using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class CalcularInvestimentos
    {
        public double ValorAplicado { get; set; }
        public double TaxaJuros { get; set; }
        public double Rendimento { get; set; }
        public double ValorTotalPoupanca { get; set; }
        public double ValorTotalFixa { get; set; }
        public int TempoInvestimento { get; set; }
        public double RendimentoFixa { get; set; }
        public double TaxaJurosFixa { get; set; }
        public double ImpostoDeRenda { get; set; }
        public double ValorIr { get; set; }
        public double ValorRendimentoFixa { get; set; }



        public void CalcularRendimentoPoupanca()
        {
            ValorTotalPoupanca = ValorAplicado;

            for (var i = 1; i <= TempoInvestimento; i++)
            {
                Rendimento = ValorTotalPoupanca * (TaxaJuros / 100);
                ValorTotalPoupanca += Rendimento;
            }

        }

        public void CalcularRendimentoFixa()
        {
            ValorTotalFixa = ValorAplicado;

            for (var i = 1; i <= TempoInvestimento; i++)
            {
                RendimentoFixa = ValorTotalFixa * (TaxaJurosFixa / 100);
                ValorTotalFixa += RendimentoFixa;
            }
            ValorRendimentoFixa = ValorTotalFixa - ValorAplicado;
        }

        public void CalcularImpostoDeRenda()
        {
            if (TempoInvestimento <= 12)
            {
                ImpostoDeRenda = ValorRendimentoFixa * 0.25;
            }

            else if (TempoInvestimento <= 24)
            {
                ImpostoDeRenda = ValorRendimentoFixa * 0.15;
            }

            else if (TempoInvestimento <= 36)
            {
                ImpostoDeRenda = ValorRendimentoFixa * 0.05;
            }

            else
            {
                ImpostoDeRenda = ValorRendimentoFixa * 0.01;
            }
        }

        public void CalcularValorTotalFixaComIr()
        {
            ValorIr = ValorAplicado + (ValorRendimentoFixa - ImpostoDeRenda);
        }

    }
}
