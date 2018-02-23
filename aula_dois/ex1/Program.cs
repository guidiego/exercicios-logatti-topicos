using System;

namespace ex1 {
    class Program {
        static void Main(String[] args) {
            System.Console.WriteLine("Quantos anos você tem?");
            var years = Program.readInt();

            System.Console.WriteLine("Quantos meses a mais da sua idade?");
            var months = Program.readInt();

            System.Console.WriteLine("E dias?");
            var days = Program.readInt();

            System.Console.WriteLine(
                "Você tem {0} dias de vida!",
                Program.getAgeInDays(years, months, days)
            );
        }

        static int readInt() {
            return System.Convert.ToInt32(System.Console.ReadLine());
        }

        static int getAgeInDays(int years, int months, int days) {
            var actualDate = System.DateTime.Now;
            var agentDate = System.DateTime.Now
                            .AddDays(-days)
                            .AddYears(-years)
                            .AddMonths(-months);

            return actualDate.Subtract(agentDate).Days;
        }
    }
}