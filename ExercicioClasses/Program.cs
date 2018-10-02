using System;
using System.Globalization;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            x.nome = Console.ReadLine();
            x.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL = " + x.notaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (x.aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + x.quantoFaltaParaAprovacao().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            Console.ReadLine();


        }
    }
}
