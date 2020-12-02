using ConsoleApp1.AnimalBehavior;

namespace ConsoleApp1.Fauna
{
    public class Animal : ITalkable, IEat, IMovable
    {
        public string talk()
        {
            throw new System.NotImplementedException();
        }

        public string food()
        {
            throw new System.NotImplementedException();
        }

        public string run()
        {
            throw new System.NotImplementedException();
        }
    }
}