using System;
using System.Globalization;


namespace Secao3_Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa:");
            int bedRoom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto, sua casa:");
            double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura. Separado por espaço!");
            string[] vet = Console.ReadLine().Split(' ');

            string lastName = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine("Nome completo: " + fullName);
            Console.WriteLine("Qtde de quartos na casa: " + bedRoom);
            Console.WriteLine("Preço: " + price);
            Console.WriteLine("Último nome é " + lastName + ", sua idade " + age + " e sua altura é " + height.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------");

        }
    }
}
