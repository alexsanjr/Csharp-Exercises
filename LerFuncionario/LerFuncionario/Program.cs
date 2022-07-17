using System;
using System.Globalization;

namespace LerFuncionario {
    internal class Program {
        static void Main(string[] args) {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {f1.Nome}, $ {f1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f1.AumentarSalario(porcentagem);
        }
    }
}
