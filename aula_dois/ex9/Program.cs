using System;
using System.Collections.Generic;

using utils;
/*
Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever:
- o maior preço lido
- a média aritmética dos preços dos produtos */
namespace ex9 {
    class Program {
        static void Main(string[] args) {
            Form form = new Form();
            for(var i = 0; i < 15; i++) {
                form.add("Insira o preço do produto " + (i + 1), i.ToString());
            }

            var list = ListHelper.ToIntList(form.ask());
            var media = ListHelper.Sum(list) / list.Count;
            var desc = ListHelper.Desc(list);

            Console.WriteLine(
                "A média é: {0}\nO maior preço é: {1}",
                media, desc[0]
            );
        }
    }
}
