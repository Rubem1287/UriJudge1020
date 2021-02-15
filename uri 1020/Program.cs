using System;

namespace uri_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor,anos, meses,dias,resto;


            Console.WriteLine();
            Console.Write("digite um valor para ser convertido em anos, meses e dias : ");
            valor = int.Parse(Console.ReadLine());

            anos = valor / 365;
            Console.WriteLine();
            Console.Write(anos+" ano(s)");
            resto = valor % 365;

            meses = resto / 30;
            Console.WriteLine();
            Console.Write(meses + " mes(es)");
            dias = resto % 30;

            Console.WriteLine();
            Console.Write(dias + " dia(s)");

        }
    }
}
