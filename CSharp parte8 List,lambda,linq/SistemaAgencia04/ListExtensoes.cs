﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAgencia04
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios(this List<int> listaDeInteiros,params int[] itens)
        {
            foreach(int item in itens)
            {

                listaDeInteiros.Add(item);
            }
        }
        public static void EscreverNaTela(this object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
