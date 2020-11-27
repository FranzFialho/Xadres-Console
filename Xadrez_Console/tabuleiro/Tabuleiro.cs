﻿using System;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        private Peca[,] pecas;

        public Tabuleiro(int linha, int colunas)
        {
            this.linhas = linha;
            this.colunas = colunas;

            pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos)
        {
            validarPosição(pos);
            return peca(pos) != null;
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição! ");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public bool posiçãoValida(Posicao pos)
        {
            if(pos.linha <0 || pos.linha >=linhas || pos.coluna<0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosição(Posicao pos)
        {
            if (!posiçãoValida(pos))
            {
                throw new TabuleiroException("Posição Invalida!");
            }
        }
    }
}
