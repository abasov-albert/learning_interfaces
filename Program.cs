using System;
using ConsoleApp1.AnimalBehavior;
using ConsoleApp1.Fauna;

namespace ConsoleApp1
{
    class Program
    {
        public static void PrintAnimal(Animal animal)
        {
            Console.WriteLine($"{animal.GetType().Name} can {animal.run()} and like to eat " +
                              $"{animal.food()} and has very loud {animal.talk()}!");
        }

        static void Main(string[] args)
        {
            Animal lion = new Lion();
            PrintAnimal(lion);

            Console.WriteLine();

            Animal seal = new Seal();
            PrintAnimal(seal);

            Console.WriteLine();

            Animal bear = new Bear();
            PrintAnimal(bear);
        }
    }
}