using System;
using System.Globalization;

namespace FormadorRetangulo {
    internal class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Altura * Largura;

        }

        public double Perimetro() {
            return (2 * Altura) + (2 * Largura);

        }

        public double Diagonal() {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));

        }

        override public string ToString() {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}\r\nPERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\r\nDIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)} ";

        }
    }
}
