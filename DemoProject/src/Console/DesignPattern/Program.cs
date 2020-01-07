using System;
using DesignPattern.Decorator;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Decorator Pattern:");
            Console.WriteLine("==================");

            IComponent component = new Component();
            Display("1. Basic component: ", component);
            Display("2. Decorator A: ", new DecoratorA(component));
            Display("2. Decorator B: ", new DecoratorB(component));
            Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(component)));

            DecoratorB b = new DecoratorB(new Component());
            Display("5. A-B-decorated : ", new DecoratorA(b));
            Console.WriteLine("\t\t\t" +b.addState + b.AddBehavior());


        }

        static void Display(string s, IComponent c)
        {
            Console.WriteLine(s + c.Operation());

        }
    }
}
