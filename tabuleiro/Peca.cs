
using xadrez_console.tabuleiro;

namespace tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantidadeMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.tab = tab;
            this.quantidadeMovimentos = 0;
        }
    }
}
