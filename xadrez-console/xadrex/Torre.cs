using xadrez_console.tabuleiro;

namespace xadrez_console.xadrex
{
        public class Torre : Peca
        {
            public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            
            }

            public override string ToString()
            {
                return "T";
            }
        }
}