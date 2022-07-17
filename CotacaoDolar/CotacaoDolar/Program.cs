using System;
using System.Globalization;

namespace CotacaoDolar {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?  ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("aaaa");
            Console.WriteLine($"Valor a ser pago em reais = {ConversorDeMoeda.Valor(valor, cotacao).ToString("F2", CultureInfo.InvariantCulture)} ");

        }
    }
}
