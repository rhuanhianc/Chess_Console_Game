using System;

namespace tabuleiro
{
    class Peca
    {
        public posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca (posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = Cor;
            this.tab = tab;
            this.quantMovimentos = 0;

        }

    }
}
