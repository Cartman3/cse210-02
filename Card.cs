using System;

namespace cse210_02
{
    public class Card
    {
        public int cardValue;
        public void getNewCard()
        {
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,13);
        }
    }
}
