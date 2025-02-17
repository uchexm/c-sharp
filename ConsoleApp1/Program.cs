using System.Formats.Asn1;

namespace Exercise {
  public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }

    public void Eat()
    {
        Console.WriteLine("Some generic animal food");
    }
}

public class Dog : Animal
{
    public void Eat()
    {
        Console.WriteLine("Kibble");
    }

    public override void MakeSound(){
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public void Eat()
    {
        Console.WriteLine("Tuna");
    }

    public override void MakeSound(){
        Console.WriteLine("Meow");
    }
}



}