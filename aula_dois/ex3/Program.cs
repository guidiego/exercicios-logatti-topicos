using System;
using System.Collections.Generic;

using utils;
/**
O custo de um carro novo ao consumidor é a soma do custo de fábrica coma porcentagem
do distribuidor e dos impostos (aplicados ao custo de fábrica). Supondo que o percentual do
distribuidor seja de 28% e os impostos de 45%, escrever um algoritmo para ler o custo de
fábrica de um carro, calcular e escrever o custo final ao consumidor. */
namespace ex3
{
    class Program
    {
        public static String factoryPrice = "factoryPrice";
        public static double distPercent = 0.28;
        public static double tax = 0.45;

        public static void Main(string[] args)
        {
            Form form = new Form();
            form.add("Qual o custo de fabrica?", Program.factoryPrice);

            Dictionary<String, String> data = form.ask();
            var price = Convert.ToDouble(data[Program.factoryPrice]);

            var distPercentVal = Program.getVal(price, Program.distPercent);
            var taxVal = Program.getVal(price, Program.tax);
            var totalPrice = (double) price + distPercentVal + taxVal;

            Console.WriteLine(
                "O valor do total do carro é R$ {0}",
                totalPrice.ToString("F")
            );
        }

        public static double getVal(double price, double percent) {
            return price * percent;
        }
    }
}
