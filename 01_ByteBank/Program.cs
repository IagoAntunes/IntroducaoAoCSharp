﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agência: "+contaDaGabriela.agencia);
            Console.WriteLine("Numero: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo: "+contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.ReadLine();
        }
    }
}
//Oque é uma classe
//Como criar uma classe
//Como criar um objeto ou instancia de uma classe
