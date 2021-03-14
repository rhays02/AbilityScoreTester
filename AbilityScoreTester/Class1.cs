﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbilityScoreTester
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14;
        public double DivideBy = 1.75;
        public int AddAmount = 2;
        public int Minimum = 3;
        public int Score;

        public void CalculateAbilityScore()
        {
            // Divide the roll result by the DivideBy field
            double divided = RollResult / DivideBy;

            //add AddAmount to the result of the division
            int added = AddAmount += (int)divided;

            // If the result is too small, use Minimum
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }


        }
    }
}
