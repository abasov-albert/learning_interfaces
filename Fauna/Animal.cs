using ConsoleApp1.AnimalBehavior;

namespace ConsoleApp1.Fauna
{
    public abstract class Animal : ITalkable, IEat, IMovable
    {
        public abstract string talk();

        public abstract string food();

        public abstract string run();
    }
}