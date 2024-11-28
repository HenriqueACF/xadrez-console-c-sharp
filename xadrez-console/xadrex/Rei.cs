using xadrez_console.tabuleiro;

namespace xadrez_console.xadrex
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
            
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return  p != null || p.cor != this.cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);
            
            //acima
            pos.definirValores(posicao.linha -1, posicao.coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //nordeste
            pos.definirValores(posicao.linha -1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //direita
            pos.definirValores(posicao.linha, posicao.linha);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //sudeste
            pos.definirValores(posicao.linha + 1, posicao.linha + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //abaixo
            pos.definirValores(posicao.linha +1, posicao.linha);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //sudoeste
            pos.definirValores(posicao.linha + 1, posicao.linha - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //esquerda
            pos.definirValores(posicao.linha, posicao.linha - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }
            
            //noroeste
            pos.definirValores(posicao.linha -1, posicao.linha - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
        
    }
}