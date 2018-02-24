using System;
using utils;

namespace ex1 {
    class Program {
        static void Main(String[] args) {
            Console.WriteLine("Quantos anos você tem?");
            var years = ConsoleWrapper.ReadInt();

            Console.WriteLine("Quantos meses a mais da sua idade?");
            var months = ConsoleWrapper.ReadInt();

            Console.WriteLine("E dias?");
            var days = ConsoleWrapper.ReadInt();

            Console.WriteLine(
                "Você tem {0} dias de vida!",
                Program.getAgeInDays(years, months, days)
            );
        }

        static int getAgeInDays(int years, int months, int days) {
            var actualDate = DateTime.Now;
            var agentDate = DateTime.Now
                            .AddDays(-days)
                            .AddYears(-years)
                            .AddMonths(-months);

            return actualDate.Subtract(agentDate).Days;
        }
    }
}