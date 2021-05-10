using System;

namespace Eleitor
{
    class Program
    {
        static void Main(string[] args)


        {
            int year = DateTime.Now.Year;
            Console.WriteLine("Em que ano você nasceu?");
            int datanascimento = int.Parse(Console.ReadLine());

            int idade = year - datanascimento;

            if (idade < 18)
            {
                Console.WriteLine("Você não poderá votar este ano, pois não tem a idade mínima necessária");
            }
            else
            {
                Console.WriteLine("Você pode votar");
            }


        }


    }
}
