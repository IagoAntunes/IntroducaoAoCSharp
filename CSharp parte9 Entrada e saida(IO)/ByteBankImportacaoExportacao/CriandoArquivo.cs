﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Input , Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
         
                var contaComoString = "456,789234,4655.50,Gustavo Santos";
                var enconding = Encoding.UTF8;

                var bytes = enconding.GetBytes(contaComoString);
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }

        }
        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
                { 
                    escritor.Write("456,789234,4655.50,Gustavo Santos");
                }
            }
        }
        static void TestaEscrita() {
            var caminhoArquivo = "teste.txt";
            using(var fluxoDeArquivo = new FileStream(caminhoArquivo,FileMode.Create))
                using(var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000; i++)
                {
                    escritor.WriteLine("Linha"+i);
                    escritor.Flush();

                    Console.WriteLine($"Linha {i} escrita no arquivo");

                    Console.ReadLine();
                }
            }
        
        }
    }
}
