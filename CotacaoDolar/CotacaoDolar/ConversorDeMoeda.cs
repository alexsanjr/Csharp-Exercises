namespace CotacaoDolar {
    internal class ConversorDeMoeda {
        public static double IOF = 0.06;

        public static double Valor(double valor, double cotacao) {
            return valor * (IOF + 1) * cotacao;
        }
    }
}
