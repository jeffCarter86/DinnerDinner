﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinnerWinner
{
    class SweepstakesStackManager
    {
        Stack<Sweepstakes> stack;

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = stack.Pop();
            return sweepstakes;
        }
    }
}
