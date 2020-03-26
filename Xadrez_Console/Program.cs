using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                tab.colocarPeca(new Torre(tab, Cor.Preta), new posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new posicao(1, 4));

                tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e){
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
