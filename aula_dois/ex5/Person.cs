using System;
using System.Collections.Generic;

/*
Tendo como dados de entrada o nome, a altura e o sexo (M ou F) de uma pessoa, calcule e
mostre seu peso ideal, utilizando as seguintes fórmulas:
- para sexo masculino: peso ideal = (72.7 * altura) - 58
- para sexo feminino: peso ideal = (62.1 * altura) - 44.7 */
namespace ex5
{
    class Person {
        public String name;
        private double height;
        private String sex;

        public Person(Dictionary<String, String> data) {
            this.name = data["name"];
            this.height = Convert.ToDouble(data["height"]);
            this.sex = data["sex"];
        }

        public double calcIdealWeight() {
            if (this.sex.ToUpper() == "M") {
                return (72.7 * this.height) - 58;
            }

            return (62.1 * this.height) - 44.7;
        }
    }
}
