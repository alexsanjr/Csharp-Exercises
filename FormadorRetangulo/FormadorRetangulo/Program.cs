using System;
using System.Globalization;

namespace FormadorRetangulo {
    internal class Program {
        static void Main(string[] args) {
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");

            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(x);
        }
    }
}
