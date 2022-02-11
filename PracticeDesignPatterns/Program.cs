using PracticeDesignPatterns.sample2;
using System;

namespace PracticeDesignPatterns {
    class Program {
        static void Main(string[] args) {

            sample2();
        }

        static void sample1() {
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();
            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();
            // Wait for user input
            Console.ReadKey();
        }

        static void sample2() {
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
            // Wait for user input
            Console.ReadKey();
        }
    }
}
