using System;
using System.Globalization;

namespace ExercicioBanco {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string conta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char validador = char.Parse(Console.ReadLine());


            ContaBancaria c1;
            if (validador == 's' || validador == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new ContaBancaria(numero, conta, saldo);

            }
            else {
                c1 = new ContaBancaria(numero, conta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(c1);
            Console.WriteLine();
            
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);
        }
    }
}
