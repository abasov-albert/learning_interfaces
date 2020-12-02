namespace ConsoleApp1.Fauna
{
    public class Seal : Animal
    {
        public override string talk()
        {
            return "ah-ah-ah";
        }

        public override string food()
        {
            return "fish";
        }

        public override string run()
        {
            return "crawl";
        }
    }
}