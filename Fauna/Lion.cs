﻿namespace ConsoleApp1.Fauna
{
    public class Lion : Animal
    {
        public override string talk()
        {
            return "roar";
        }

        public override string food()
        {
            return "meat";
        }

        public override string run()
        {
            return "run fast";
        }
    }
}