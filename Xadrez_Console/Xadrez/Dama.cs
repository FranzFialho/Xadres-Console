﻿using System;
using tabuleiro;

namespace Xadrez
{
    class Dama : Peca
    {
            public Dama(Tabuleiro tab, Cor cor) : base(tab, cor)
            {
            }

            public override string ToString()
            {
                return "D";
            }

            private bool PodeMover(Posicao pos)
            {
                Peca p = Tab.Peca(pos);
                return p == null || p.Cor != Cor;
            }

            public override bool[,] MovimentosPossiveis()
            {
                bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

                Posicao pos = new Posicao(0, 0);

                //Esquerda
                pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha, pos.Coluna - 1);
                }

                //Direta
                pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha, pos.Coluna + 1);
                }

                //Acima
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha - 1, pos.Coluna);
                }

                //Abaixo
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha + 1, pos.Coluna);
                }

                //noroeste
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha - 1, pos.Coluna - 1);
                }

                //nordeste
                pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha - 1, pos.Coluna + 1);
                }

                //sudeste
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha + 1, pos.Coluna + 1);
                }

                //sudoeste
                pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                while (Tab.PosiçãoValida(pos) && PodeMover(pos))
                {
                    mat[pos.Linha, pos.Coluna] = true;
                    if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
                    {
                        break;
                    }
                    pos.DefinirValores(pos.Linha + 1, pos.Coluna - 1);
                }

                return mat;
            }
        }
}
