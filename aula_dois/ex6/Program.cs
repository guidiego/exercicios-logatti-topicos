using System;
using System.Collections.Generic;

using utils;
/*
 Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendose
que ele recebe uma comissão de 3% sobre o total das vendas até R$1.500,00 mais 5%
sobre o que ultrapassar este valor, calcular e escrever o seu salário total. */
namespace ex6 {
    class Program {
        static void Main(string[] args) {
            Form form = new Form();
            form.add("Insira seu Salario", "wage");
            form.add("Insira valor da Suas Vendas", "solds");

            Vendor v = new Vendor(form.ask());
            Console.WriteLine("O salario total do vendedor é R$ {0}", v.getTotalWage());
        }
    }
}
