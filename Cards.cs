using System;

namespace cse210_02
{
    public class Cards
    {
        public int cardValue;
        public void getNewCard()
        {
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,13);
        }
    }
}
