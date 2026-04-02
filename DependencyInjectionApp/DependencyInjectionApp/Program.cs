namespace DependencyInjectionApp
{
    //---------Interface Dependency Injection(DI)---------
    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }

    public class Hammer()
    {
        public void Use()
        {
            Console.WriteLine("Hammering nails");
        }
    }

    public class Saw()
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood");
        }
    }

    public class Builder : IToolUser
    {
        private Hammer _hammer;
        private Saw _saw;
        // ---------Setter Dependency Injection (DI)---------
        //public Hammer Hammer { get; set; }
        //public Saw Saw { get; set; }

        public void BuildHouse()
        {
            _hammer.Use();
            _saw.Use();
            // ---------Setter Dependency Injection (DI)---------
            //Hammer.Use();
            //Saw.Use();
            // ---------Constructor Dependency Injection (DI)---------
            //_hammer.Use();
            //_saw.Use();
            Console.WriteLine("House Built");
        }

        //---------Interface Dependency Injection(DI)---------
        public void SetHammer(Hammer hammer)
        {
            _hammer = hammer;
        }

        public void SetSaw(Saw saw)
        {
            _saw = saw;
        }
        // ---------Constructor Dependency Injection (DI)---------
        //private Hammer _hammer;
        //private Saw _saw;

        //public Builder(Hammer hammer, Saw saw)
        //{
        //    _hammer = hammer;
        //    _saw = saw;
        //}

        //public void BuildHouse()
        //{
        //    _hammer.Use();
        //    _saw.Use();
        //    Console.WriteLine("House Built");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------Constructor Dependency Injection(DI)---------
            //Hammer hammer = new Hammer();
            //Saw saw = new Saw();
            //Builder builder = new Builder(hammer, saw);

            //builder.BuildHouse();

            // ---------Setter Dependency Injection (DI)---------
            //Hammer hammer = new Hammer();
            //Saw saw = new Saw();
            //Builder builder = new Builder();
            //builder.Hammer = hammer; // Inject dependencies via Setters
            //builder.Saw = saw; // Inject dependencies via Setters

            //builder.BuildHouse();

            //---------Interface Dependency Injection(DI)---------
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.SetHammer(hammer);
            builder.SetSaw(saw);

            builder.BuildHouse();

            Console.ReadKey();
        }
    }
}
