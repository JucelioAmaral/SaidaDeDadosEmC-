using System;
using System.Globalization;

namespace Secao3_Exerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;
            //Console.Write => escreve na mesma linha
            //Console.WriteLine => pula de linha.
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é {1} ", produto1, preco1.ToString("F2"));
            Console.Write($"{produto2}, cujo o preço é $ ");
            Console.WriteLine($"{preco2.ToString("F2")}");
            Console.WriteLine();
            Console.Write("Registro: " + idade + " anos de idade");
            Console.WriteLine($", código {codigo} e genero {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com 8 casas decimais é: " + medida);
            Console.WriteLine("Arredondando (três casas decimais):" + medida.ToString("F3"));
            Console.WriteLine("Separador deciaml invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
