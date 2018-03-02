using System;
using System.Collections.Generic;

using utils;
/*
Tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule e
mostre seu peso ideal, utilizando as seguintes fórmulas:
- para sexo masculino: peso ideal = (72.7 * altura) - 58
- para sexo feminino: peso ideal = (62.1 * altura) - 44.7 */
namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.add("Nome", "name");
            form.add("Peso", "height");
            form.add("Sexo (M/F)", "sex");

            Person p = new Person(form.ask());
            Console.WriteLine(
                "Nome: {0}\nPeso Ideal: {1}",
                p.name, p.calcIdealWeight()
            );
        }
    }
}
