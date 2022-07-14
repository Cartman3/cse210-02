using System;
using System.Collections.Generic;

namespace cse210_02
{
    class program
    {
        // Starts game
        static int Main()
        {
            PlayGame playGame = new PlayGame();
            // Will be making a start game in PlayGame class
            playGame.StartGame();
            return 0;
        }
    }
}