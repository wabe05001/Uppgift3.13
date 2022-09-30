using System;

namespace Uppgift_3._13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("är du över 16 år gammal?svara i antal år");
            int ålder = int.Parse(Console.ReadLine());

            if(ålder >=19)
            {
                Console.WriteLine("du får delta i tävlingen");

            }

            if(ålder >=16)
            {
                Console.WriteLine("du får oxå vara med i tävlingen");

            }

            if(ålder <=16)
            {
                Console.WriteLine("du får tyvärr inte vara med i tävlingen");

            }




        }

    }


}