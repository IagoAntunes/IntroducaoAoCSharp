﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia03
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente03[] _itens;
        private int _proximaPosicao;
        public int Tamanho {
            get 
            {
                return _proximaPosicao;
            }
        }
        public ListaDeContaCorrente(int capacidadeInicial=5)
        {
            _itens = new ContaCorrente03[capacidadeInicial];
            _proximaPosicao = 0;
        }
        public void Adicionar(ContaCorrente03 item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posicao {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionaVarios(params ContaCorrente03[] itens)
        {
            foreach(ContaCorrente03 conta in itens){
                Adicionar(conta);
            }
        }

        public void Remover(ContaCorrente03 item)
        {
            int indiceItem = 0;
            for(int i=0;i< _proximaPosicao; i++)
            {
                ContaCorrente03 itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proximaPosicao-1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;

        }

        public ContaCorrente03 GetContaCorrenteNoIndice(int indice)
        {
            if(indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario) { 
                return ;
            }

            int novoTamanho = _itens.Length * 2;
            if(novoTamanho< tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista");
            ContaCorrente03[] novoArray = new ContaCorrente03[novoTamanho];

            for(int indice = 0;indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }

        public ContaCorrente03 this[int indice]
        {
            get
            {
                return GetContaCorrenteNoIndice(indice);
            }
        }
    }
}
