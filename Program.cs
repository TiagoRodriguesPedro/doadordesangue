using System;

namespace doadordesangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
             Console.Write("Por favor digite sua idade---");

             idade = Convert.ToInt32(Console.ReadLine());

             if (idade > 18 && idade < 67)
             {
                  Console.WriteLine(" voce pode doador de sangue");
             }
             

             else
             {
                 Console.WriteLine("voce nao pode doar sangue");
             }




        }
    }
}
