using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public Rei(Tabuleiro tab, Cor preto)
        {
            this.tab = tab;
        }

        public override string ToString() 
        {
            return "R";
        }
    }
}
