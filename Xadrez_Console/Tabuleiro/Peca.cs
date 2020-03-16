using System;

namespace tabuleiro
{
    class Peca
    {
        public posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantMovimentos = 0;

        }

       
    }
}
