﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 123456);
            Funcionario funcionario = null;

            Console.WriteLine(conta.Numero);



            Console.ReadLine();
        }
    }
}
/*
 * Como criar biblioteca de classes
 * Como adicionar referencias de um projeto para outro
 * A diferença entre bibliotecas de classes e aplicativo de console
 * a extensao de arquivo .dll
 * como o .net busca as bibliotecas na execucao de um programa
 */