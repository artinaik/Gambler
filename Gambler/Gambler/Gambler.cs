using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler
{
    class Gambler
    {
        int amount = 100;
        int bet = 0;;
        public void StartBet()
        {
            while (amount > 0 && amount < 100)
            {
                bet++;
            }
        }
    }
}
