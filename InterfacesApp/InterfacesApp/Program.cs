namespace InterfacesApp
{
    // ------ POLYMORPHISM EXAMPLE -------
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    public class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    // ------ INTERFACE EXAMPLE -------
    //public interface IAnimal
    //{
    //    void MakeSound();
    //    void Eat(string food);
    //}


    //public class Dog : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine($"Dog ate {food}");
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Bark");
    //    }
    //}

    //public class Cat : IAnimal
    //{
    //    public void Eat(string food)
    //    {
    //        Console.WriteLine($"Cat ate {food}");
    //    }

    //    public void MakeSound()
    //    {
    //        Console.WriteLine("Meow");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------ POLYMOPRHISM EXAMPLE -------
            Animal mySomething = new Dog(); // It will make the sound of the Dog, not the object.
            mySomething.MakeSound();


            // ------ INTERFACE EXAMPLE -------
            //Dog dog = new Dog();
            //dog.MakeSound();
            //dog.Eat("Treat");

            //Cat cat = new Cat();
            //cat.MakeSound();
            //cat.Eat("Friskies");

            Console.ReadKey();
        }
    }
}
