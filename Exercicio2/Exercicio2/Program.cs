using System;
using System.Globalization;

namespace Exercicio2 {
    internal class Program {
        static void Main(string[] args) {
            #region 01
            //int num1, num2, soma;

            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());
            //soma = num1 + num2;

            //Console.WriteLine($"Soma = {soma}");

            #endregion

            #region 02
            //double raio, area;
            //Console.WriteLine("Escreva o valor do raio: ");
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = Math.PI * Math.Pow(raio, 2);
            //Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            #endregion

            #region 03
            //int a, b, c, d, dif;

            // a = int.Parse(Console.ReadLine());
            // b = int.Parse(Console.ReadLine());
            // c = int.Parse(Console.ReadLine());
            //d = int.Parse(Console.ReadLine());

            //dif = a * b - c * d;
            //Console.WriteLine(dif);

            #endregion

            #region 04
            //int num, horas;
            //double valor, salario;

            //num = int.Parse(Console.ReadLine());
            //horas = int.Parse(Console.ReadLine());
            //valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = horas * valor;

            //Console.WriteLine($"NUMBER= {num}");
            //Console.WriteLine($"SALARY= U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

            #endregion

            #region 05
            //int item, num;
            //double valor, total1, total2, result;

            //string[] v = Console.ReadLine().Split(' ');

            //item = int.Parse(v[0]);
            //num = int.Parse(v[1]);
            //valor = double.Parse(v[2], CultureInfo.InvariantCulture);
            //total1 = valor * num;

            //string[] v2 = Console.ReadLine().Split(' ');

            //item = int.Parse(v2[0]);
            //num = int.Parse(v2[1]);
            //valor = double.Parse(v2[2], CultureInfo.InvariantCulture);
            //total2 = valor * num;
            //result = total1 + total2;

            //Console.WriteLine($"VALOR A PAGAR: {result:C}");

            #endregion

            #region 06
            double a, b, c, area;

            string[] val = Console.ReadLine().Split(' ');
            a = double.Parse(val[0], CultureInfo.InvariantCulture);
            b = double.Parse(val[1], CultureInfo.InvariantCulture);
            c = double.Parse(val[2], CultureInfo.InvariantCulture);

            area = a * c / 2.0;
            Console.WriteLine($"TRIÂNGULO= {area.ToString("F3", CultureInfo.InvariantCulture)}");

            area = Math.PI * Math.Pow(c, 2);
            Console.WriteLine($"CÍRCULO= {area.ToString("F3", CultureInfo.InvariantCulture)}");

            area = ( a + b) * c / 2;
            Console.WriteLine($"TRAPÉZIO= {area.ToString("F3", CultureInfo.InvariantCulture)}");

            area = Math.Pow(b, 2);
            Console.WriteLine($"QUADRADO= {area.ToString("F3", CultureInfo.InvariantCulture)}");

            area = a * b;
            Console.WriteLine($"RETÂNGULO= {area.ToString("F3", CultureInfo.InvariantCulture)}");
            #endregion
        }


    }
}
