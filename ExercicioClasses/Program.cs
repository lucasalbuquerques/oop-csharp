using System;
using System.Globalization;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco x;
            

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string titular = (Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n)? ");
            string ch = (Console.ReadLine());
            if(ch == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double DepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new ContaBanco(numero, titular, DepositoInicial);
            }
            else
            {
                x = new ContaBanco(numero, titular);
            }

            Console.WriteLine(x);
            Console.ReadLine();
          

        }
    }
}
