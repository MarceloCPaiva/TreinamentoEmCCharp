

namespace Exercicio10
{
    internal class ConversorDeMoeda
    {
        public static double CotarDolar(double cotacaoDolar, double qtdDolar)
        {
            double calc = qtdDolar * cotacaoDolar;
            return calc + (calc * 0.06);
        }
    }
}
