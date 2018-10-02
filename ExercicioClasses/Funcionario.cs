using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto, desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentaSalario(double porcentagem)
        {
            salarioBruto = salarioBruto + (salarioBruto*porcentagem/100);

        }

        public override string ToString()
        {
            return nome
                + ", R$"
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
