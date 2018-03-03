using System;
using System.Collections.Generic;

using utils;

/*
Ler 3 valores (considere que não serão informados valores iguais)e escrever o maior deles.
 */
namespace ex7 {
    class Program {
        static void Main(string[] args) {
            Form form = new Form();
            form.add("Insira o numero 1", "1");
            form.add("Insira o numero 2", "2");
            form.add("Insira o numero 3", "3");

            List<int> data = ListHelper.ToIntList(form.ask());
            data.Sort((a, b) => -1* a.CompareTo(b));

            Console.WriteLine(
                "O maior valor da lista é {0}",
                data[0].ToString()
            );
        }
    }
}
