﻿using System;
using tabuleiro;
using xadrez;


namespace xadrez
{
    class Program { 
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(7, 5));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(4, 1));

                Tela.imprimirTabuleiro(tab);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            //PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            //Console.WriteLine(pos);

            //Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }

}



