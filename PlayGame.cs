using System;
using System.Collections.Generic;

namespace cse210_02
{
    public class PlayGame
    {
        List<Card> card = new List<Card>();
        bool isPlaying = true;
        int winningbounus = 100;
        int losingloss = 75;
        int totalScore = 300;
        int currentCard;
        int nextCard;
        public PlayGame()
        {
            for(int i = 0; i < 1; i++)
            {
                Card card = new Card();
                
            }
        }
    }
}
