using System;
using System.Collections.Generic;
using utils;

/** 
Escreva um algoritmo para ler o número total de eleitores de um município, o número de
votos brancos, nulos e válidos. Calcular e escrever o percentual que cada um representa em
relação ao total de eleitores.
 */
namespace ex2 {
    class Program {
        public static String totalEl = "totalEl";
        public static String blankVotes = "blankVotes";
        public static String nullVotes = "nullVotes";
        public static String okeyVotes = "okeyVotes";

        static void Main(string[] args) {
            Form form = new Form();
            form.add("Numero total de Eleitores", Program.totalEl);
            form.add("Numero de Votos Branco", Program.blankVotes);
            form.add("Numero de Votos Nulos", Program.nullVotes);
            form.add("Numero de Votos Válidos", Program.okeyVotes);

            Dictionary<String, String> data = form.ask();
            var total = Convert.ToInt32(data[Program.totalEl]);

            Console.WriteLine(
                "Votos Brancos: {0}",
                Program.percent(total, data[Program.blankVotes])
            );

            Console.WriteLine(
                "Votos Nulos: {0}",
                Program.percent(total, data[Program.nullVotes])
            );

            Console.WriteLine(
                "Votos Válidos: {0}",
                Program.percent(total, data[Program.okeyVotes])
            );
        }

        public static String percent(int total, String val) {
            return (total/Convert.ToDouble(val)).ToString("F") + "%";
        }
    }
}
