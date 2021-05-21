using System;

namespace Fight
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p2 = new Player();
            Player p1 = new Player();
            Random generator = new Random();
            

            while(true)
            {
                int generatedNumber = generator.Next(2);

                if (generatedNumber == 0)
                {
                    p2.Hp -= p1.GetAttackDamage();
                }
                else if(generatedNumber == 1)
                {
                    p1.Hp -= p2.GetAttackDamage();
                }
                // System.Console.WriteLine("p1: " + p1.Hp);
                // System.Console.WriteLine("p2: " + p2.Hp);
                // Console.ReadLine();

                if (p1.Hp <= 0)
                {
                    System.Console.WriteLine("p2 won!");
                    break;
                }
                if (p2.Hp <= 0)
                {
                    System.Console.WriteLine("p1 won!");
                    break;
                }
            }       
            Console.ReadLine();     
        }
    }
}
