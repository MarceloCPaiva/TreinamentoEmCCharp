using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {

        }

        public Torre(Tabuleiro tab, Cor preto)
        {
            this.tab = tab;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
