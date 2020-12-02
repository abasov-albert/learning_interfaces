namespace ConsoleApp1.Fauna
{
    public class Bear : Animal
    {
        public override string talk()
        {
            return "roar very loud";
        }

        public override string food()
        {
            return "honey";
        }

        public override string run()
        {
            return "run very veeeery fast if hungry";
        }
    }
}