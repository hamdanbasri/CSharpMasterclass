namespace TemperatureMonitorApp
{
    // Using the generic delegate EventHandler<TEventArgs>

    //public delegate void TemperatureChangeHandler(string message);

    public class TemperatureChangedEventArgs : EventArgs
    {
        // Property holding the temperature
        public int Temperature { get; }

        // Constructor
        public TemperatureChangedEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
    public class TemperatureMonitor
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        //public event TemperatureChangeHandler OnTemperatureChange;
        private int _temparature;
        public int Temperature
        {
            get { return _temparature; }
            set
            {
                if (_temparature != value)
                {
                    _temparature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
                //_temparature = value;
                //if (_temparature > 30)
                //{
                //    RaiseTemperatureChangedEvent("Temperature is above threshold");
                //}
            }
        }

        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
        {
            TemperatureChanged?.Invoke(this, e);
        }

        //protected virtual void RaiseTemperatureChangedEvent(TemperatureChangedEventArgs e)
        //{
        //    OnTemperatureChange?.Invoke(e);
        //}

        //protected virtual void RaiseTemperatureChangedEvent(string message)
        //{
        //    OnTemperatureChange?.Invoke(message);
        //}

        // Subscriber
        public class TemperatureAlert
        {
            public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
            {
                Console.WriteLine($"Alert: temperature is {e.Temperature}, sender is {sender}");
            }
            //public void OnTemperatureChanged(string message)
            //{
            //    Console.WriteLine($"Alert: {message}");
            //}
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                TemperatureMonitor monitor = new TemperatureMonitor();
                TemperatureAlert alert = new TemperatureAlert();

                monitor.TemperatureChanged += alert.OnTemperatureChanged;
                //monitor.OnTemperatureChange += alert.OnTemperatureChanged;

                monitor.Temperature = 20;
                Console.WriteLine("Please enter the temperature");
                monitor.Temperature = int.Parse(Console.ReadLine());

                Console.ReadKey();
            }
        }
    }
}
