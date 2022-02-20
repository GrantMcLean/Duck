using Class_2.Interfaces;
namespace Class_2
{
    public class Duck
    {
        public IQuackBehavior quackBehavior { get; set; }

        public Duck() {
            quackBehavior = new QuackBehavior();
        }
    }
}