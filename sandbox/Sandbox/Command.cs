using System;

namespace sandbox
{
    public class Command
    {
        public virtual void Execute()
        {
            Console.WriteLine("Executing");
        }
    }
}