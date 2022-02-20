using Class_2.Interfaces;
namespace Class_2
{
    public class RubberDuck
    {
       public IQuackBehavior quackBehavior { get; set; }

       public RubberDuck() {
           quackBehavior = new SqueakBehavior();
       }
    }
}