using System;
using System.Collections.Generic;

using utils;
/*
 Ler o salário fixo e o valor das vendas efetuadas pelo vendedor de uma empresa. Sabendose
que ele recebe uma comissão de 3% sobre o total das vendas até R$1.500,00 mais 5%
sobre o que ultrapassar este valor, calcular e escrever o seu salário total. */
namespace ex6 {
    class Vendor {
        private double staticWage;
        private double soldsVal;

        public static double soldLimit = 1500;

        public Vendor(Dictionary<String, String> data) {
            this.staticWage = Convert.ToDouble(data["wage"]);
            this.soldsVal = Convert.ToDouble(data["solds"]);
        }

        public double getTotalWage() {
            double percent = this.soldsVal.CompareTo(soldLimit) >= 0 ? 0.05 : 0.03;
            return this.staticWage + (this.soldsVal * percent);
        }
    }
}
