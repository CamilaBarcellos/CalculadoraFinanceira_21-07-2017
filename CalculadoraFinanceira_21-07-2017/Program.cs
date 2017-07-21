using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularInvestimentos calcular = new CalcularInvestimentos();

            Console.WriteLine("Valor a ser aplicado:\n");
            calcular.ValorAplicado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPercentual do rendimento mensal na POUPANÇA:\n");
            calcular.TaxaJuros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nPercentual do rendimento mensal FIXO:");
            calcular.TaxaJurosFixa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTempo (em meses) da aplicacao:\n");
            calcular.TempoInvestimento = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n------------------------------------------------------------------------\n");


            calcular.CalcularRendimentoPoupanca();
            calcular.CalcularRendimentoFixa();
            calcular.CalcularImpostoDeRenda();
            calcular.CalcularValorTotalFixaComIr();



            Console.WriteLine("\nO valor investido na Poupança no final da aplicação será: R${0 :0.##}.\nNa modalidade de Renda Fixa será: R${1 :0.##}", calcular.ValorTotalPoupanca, calcular.ValorIr);

            if (calcular.ValorTotalPoupanca > calcular.ValorIr)
            {
                Console.WriteLine("\nÉ mais indicado fazer o investimento na Poupança, pois o rendimento será maior.");
            }
            else if (calcular.ValorTotalPoupanca < calcular.ValorIr)
            {
                Console.WriteLine("\nÉ mais indicado fazer o investimento na Renda Fixa, pois o rendimento será maior.");
            }
            else
            {
                Console.WriteLine("\nO valor do rendimento será o mesmo para as duas modalidades de aplicação.");
            }


            Console.ReadLine();

        }
    }
}
