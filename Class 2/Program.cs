using System;

namespace Class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck myDuck = new Duck();
            // MallardDuck anneDuck = new MallardDuck();
            RubberDuck squeaky = new RubberDuck();

            // myDuck.Quack();

            // anneDuck.Quack();

            // squeaky.Quack();

            myDuck.quackBehavior.Quack();

            squeaky.quackBehavior.Quack();

            myDuck.quackBehavior = new SqueakBehavior();

            myDuck.quackBehavior.Quack();

            squeaky.quackBehavior = new QuackBehavior();

            squeaky.quackBehavior.Quack();

        }
    }
}
