using Class_2.Interfaces;
namespace Class_2
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack() {
            System.Console.WriteLine("Squeak");
        }
    }
}