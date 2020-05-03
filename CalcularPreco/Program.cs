using System;
using System.Globalization;

namespace CalcularPreco
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int cod1, cod2, qtde1, qtde2;
                double vlr1, vlr2, resultado;

                Console.WriteLine("Digite o código, quantidade e valor unitário na sequência, separado por espaços. Exemplo: 1 15 10.00");
                string[] entrada = Console.ReadLine().Split(' ');
                cod1 = int.Parse(entrada[0]);
                qtde1 = int.Parse(entrada[1]);
                vlr1 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

                Console.WriteLine("Digite o código, quantidade e valor unitário na sequência, separado por espaços. Exemplo: 1 15 10.00");
                entrada = Console.ReadLine().Split(' ');
                cod2 = int.Parse(entrada[0]);
                qtde2 = int.Parse(entrada[1]);
                vlr2 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

                resultado = vlr1 * qtde1 + vlr2 * qtde2;

                Console.WriteLine($"VALOR A PAGAR: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
