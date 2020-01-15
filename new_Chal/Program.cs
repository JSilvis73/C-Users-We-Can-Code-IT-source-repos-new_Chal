using System;

namespace new_Chal
{
    class Program
    {
        static void Main(string[] args)
        {
            int diners = 4;
            int cost = 10;
            int bill = (diners * cost);
            if (bill >= 50)
            {
                Console.WriteLine("You get a 10% discount!");
            }
            else 
            {
                Console.WriteLine("You get a 5% discount!"); 
            }
            
        }
    }
}
