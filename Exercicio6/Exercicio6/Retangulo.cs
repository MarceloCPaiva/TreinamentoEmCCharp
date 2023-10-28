using System.Globalization;

namespace Exercicio6
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcArea()
        {
            return Largura * Altura;
        }

        public double CalcPerimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double CalcDiagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
