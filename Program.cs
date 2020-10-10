using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            string valorDig, parcelasDig, rendaDig;
            decimal valor, renda;
            int parcelas;
            decimal valorparcela, valorMaximo;
            bool creditoAprovado;
            bool valorValido, rendaMensalValido, parcelasValido;


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("=+= Analise de credito =+=");
            Console.WriteLine();
            Console.ResetColor();

            Console.Write("Qual o valor que voçe precisa?....: ");
            valorDig = Console.ReadLine();

            Console.Write("Em quantas parcelas voçe pagaria?..: ");
            parcelasDig = Console.ReadLine();

            Console.Write("Qual sua renda mensal?.............: ");
            rendaDig = Console.ReadLine();

            valorValido = Decimal.TryParse(valorDig, out valor);
            parcelasValido = Int32.TryParse(parcelasDig, out parcelas);
            rendaMensalValido = decimal.TryParse(rendaDig, out renda);

            if (!valorValido || !parcelasValido || !rendaMensalValido)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Voce digitou algo errado");
                Console.ResetColor();
            }
            else
            {
            Console.WriteLine();

            valorparcela = valor / parcelas;
            valorMaximo = renda * 0.3m;

            Console.WriteLine($"Valor da parcela.....: {valorparcela:C}");
            Console.WriteLine($"Parcela maxima.......: {valorMaximo:C}");

            Console.WriteLine();

            creditoAprovado = valorparcela <= valorMaximo;

            if (creditoAprovado)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Parabéns seu credito foi aprovado!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Desculpe seu credito não foi aprovado. :(");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Obrigado pela preferencia!");
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
            }
        }
    }
}
