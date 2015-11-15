//Harsh Patel
//Bowling Game Kata

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game
    {
        public void roll(int pins)
        {
            Rolls[currentRolls++] = pins;
        }
        public int score
        {
            get
            {
                var score = 0;
                var indexForRolls = 0;
                for (var frame = 0; frame < 10; frame++)
                {
                    if (Rolls[indexForRolls] == 10)
                    {
                        score += Rolls[indexForRolls] + Rolls[indexForRolls + 1] + Rolls[indexForRolls + 2]; // if the frame is strike than execute this code
                        indexForRolls++;
                    }
                    else if (Rolls[indexForRolls] + Rolls[indexForRolls + 1] == 10)
                    {
                        score += Rolls[indexForRolls] + Rolls[indexForRolls + 1] + Rolls[indexForRolls + 2]; // if the frame is spare than it executes this code
                        indexForRolls += 2;
                    }
                    else
                    {
                        score += Rolls[indexForRolls] + Rolls[indexForRolls + 1]; // otherwise it will execute this part of the code
                        indexForRolls += 2;
                    }
                }
                return score;
            }
        }

        private int[] Rolls = new int[21];
        private int currentRolls = 0;
    }
}
