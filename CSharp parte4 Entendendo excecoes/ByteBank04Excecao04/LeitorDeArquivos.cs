﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankExcecao04
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: "+arquivo);
        }
        public string LerProximaLinha()
        {
            Console.WriteLine("LendoLinha...");
            
            throw new IOException();//Entrada ou saida

            return "Linha do arquivo";
        }

        public void Dispose()//Responsabilidade de lbierar os recursos
        {
            Console.WriteLine("Fechando arquivo");
        }
    }
}
