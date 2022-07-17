using System;
using System.Globalization;

namespace LerFuncionario {
    internal class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            SalarioBruto = (SalarioBruto * porcentagem/100) + SalarioBruto;
            Console.WriteLine($"Dados atualizados: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}