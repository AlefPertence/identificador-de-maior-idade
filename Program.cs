using System;

namespace Verificador
{
    class Program
    {
        public static void Main(String[] args)
        {
            int idade = 0;

            Console.Write("digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 17 && idade > 0)
            {
                Console.WriteLine("Você é menor de idade.");
            }

            else if (idade >= 18 && idade <= 49)
            {
                Console.WriteLine("voce é adulto");
                    
            }
            
            else if (idade >= 50)
            {
                Console.WriteLine("Você é idosos");
            }


            else
            {
                Console.WriteLine("Idade irregular!");
            }
        }    

    }
}