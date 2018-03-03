using System;
using System;
using System.Collections.Generic;

using utils;

/*
Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e escrever se
formam ou não um triângulo. OBS: para formar um triângulo, o valor de cada lado deve ser
menor que a soma dos outros 2 lados. */
namespace ex8 {
    class Program {
        static void Main(string[] args) {
            Form form = new Form();
            form.add("Insira o Lado 1", "1");
            form.add("Insira o Lado 2", "2");
            form.add("Insira o Lado 3", "3");

            Triangle t = new Triangle(form.ask());
            Console.WriteLine(
                "É um triangulo? {0}",
                t.isOkey() ? "Sim" : "Não"
            );
        }
    }
}
