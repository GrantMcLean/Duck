using Class_2.Interfaces;
namespace Class_2
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack() {
            System.Console.WriteLine("Quack");
        }
    }
}