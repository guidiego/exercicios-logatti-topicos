using System;
using System.Collections.Generic;
using utils;

namespace ex1 {
    class Program {
        public static String yearProp = "years";
        public static String monthProp = "months";
        public static String daysProp = "days";

        static void Main(String[] args) {
            var questions = new Dictionary<String, String>();

            questions[Program.yearProp] = "Quantos anos você tem?";
            questions[Program.monthProp] = "Quantos meses a mais da sua idade?";
            questions[Program.daysProp] = "E dias?";

            Console.WriteLine(
                "Você tem {0} dias de vida!",
                Program.getAgeInDays(Form.ask(questions))
            );
        }

        static int getAgeInDays(Dictionary<String, String> data) {
            var years = Convert.ToInt32(data[Program.yearProp]);
            var months = Convert.ToInt32(data[Program.monthProp]);
            var days = Convert.ToInt32(data[Program.daysProp]);

            var actualDate = DateTime.Now;
            var agentDate = DateTime.Now
                            .AddYears(-years)
                            .AddMonths(-months)
                            .AddDays(-days);

            return actualDate.Subtract(agentDate).Days;
        }
    }
}