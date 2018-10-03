using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Aula02
{
    class ContaBanco
    {
        public int numero;
        public string titular;
        public double saldo;

        public ContaBanco(int numero, string titular, double saldo)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
        }

        public ContaBanco(int numero, string titular)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = 0.0;
        }



        public override string ToString()
        {
            return "Conta "
                 + numero
                 + ", "
                 + "Titular: "
                 + titular
                 + ", "
                 + "Saldo: $ "
                 + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
