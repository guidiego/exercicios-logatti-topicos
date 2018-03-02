using System;
using System.Collections.Generic;

using utils;
/*
Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por
mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das
vendas por ele efetuadas. Escrever um algoritmo que leia o número de carros por ele
vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro  */
namespace ex4 {
    class Program {
        public static String totalCars = "totalCars";
        public static String totalValue = "totalValue";
        public static String comissionValue = "comissionValue";
        public static String wage = "wage";

        static void Main(string[] args) {
            Form form = new Form();
            form.add("Numero de Carros Vendidos", Program.totalCars);
            form.add("Valor total da Venda", Program.totalValue);
            form.add("Comissão por Venda", Program.comissionValue);
            form.add("Salario", Program.wage);

            var data = form.ask();
            var total = Convert.ToDouble(data[Program.wage]) +
                (Convert.ToDouble(data[Program.totalValue]) * 0.05) +
                (Convert.ToInt32(data[Program.totalCars]) *
                Convert.ToDouble(data[Program.comissionValue]));

            Console.WriteLine(
                "O valor total de seu salario é R$ {0}",
                total.ToString("F")
            );
        }
    }
}
