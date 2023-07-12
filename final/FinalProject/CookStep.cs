using System;
using System.Collections.Generic;

namespace Final
{
    public class CookStep
    {
        private string _instruction;

        public void AddInstruction(string newInstruction)
        {
            //set up the instruction
            _instruction = newInstruction;
        }

        public string GetStep()
        {
            //returns the instruction
            return _instruction;
        }
    }
}