
using System.Numerics;

namespace Exercicio8
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;
        

        public double Media()
        {
            return (Nota1 + Nota2 + Nota3);
        }

        public double PontosParaAprovacao()
        {
            if (Media() >= 60)
            {
               return Media();
            }
            else
            {
                return 60 - Media();
            }
        }

    }
}
