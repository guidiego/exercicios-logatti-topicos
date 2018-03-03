using System;
using System.Collections.Generic;

using utils;
/*
10. A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um
algoritmos para coletar dados sobre o salário e número de filhos de 4 habitantes e após as
leituras, escrever:
a) Média de salário da população
b) Média do número de filhos
c) Maior salário dos habitantes
d) Percentual de pessoas com salário menor que R$ 150,00 */
namespace ex10 {
    class Program {
        static void Main(string[] args) {
            int population = 2;
            List<Dictionary<String, String>> listData = new List<Dictionary<String, String>>();

            for (var i = 0; i < population; i++) {
                Form form = new Form();
                form.add("Quantidade de filhos", "soncount");
                form.add("Salario", "wage");

                listData.Add(form.ask());
            }

            var sons = ListHelper.GetIntListByProp(listData, "soncount");
            var wages = ListHelper.Desc(
                ListHelper.GetIntListByProp(listData, "wage")
            );

            var mediaSon = (ListHelper.Sum(sons) / population);
            var mediaWage = (ListHelper.Sum(wages) / population);

            Console.WriteLine(
                "A média de Salário é {0}\nA média de filhos é {1}\nO maior salário é {2}\nO % de quem ganha menos q 150 {3}%",
                mediaWage, mediaSon, wages[0], Program.CalcPercentLess150(wages, population)
            );
        }

        static String CalcPercentLess150(List<int> list, int total) {
            List<int> filtered = new List<int>();
            foreach(int item in list) {
                if (item > 150) {
                    filtered.Add(item);
                }
            }

            return ((filtered.Count * 100) / total);
        }
    }
}
