using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Gambler
    {
        int amount = 100;
        int bet = 0;
        public void StartBet()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            bet++;
            if (result == 0)
            {
                Console.WriteLine("Won the game");
                amount++;
            }
            else
            {
                Console.WriteLine("Won the game");
                amount--;
            }
            Console.WriteLine("Amount is : " + amount);
        }
    }
}
