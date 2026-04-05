namespace TemperatureMonitorApp
{
    public delegate void TemperatureChangeHandler(string message);

    public class TemperatureMonitor
    {
        public event TemperatureChangeHandler OnTemperatureChange;
        private int _temparature;
        public int Temperature
        {
            get { return _temparature; }
            set
            {
                _temparature = value;
                if (_temparature > 30)
                {
                    RaiseTemperatureChangedEvent("Temperature is above threshold");
                }
            }
        }

        protected virtual void RaiseTemperatureChangedEvent(string message)
        {
            OnTemperatureChange?.Invoke(message);
        }

        public class TemperatureAlert
        {
            public void OnTemperatureChanged(string message)
            {
                Console.WriteLine($"Alert: {message}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                TemperatureMonitor monitor = new TemperatureMonitor();
                TemperatureAlert alert = new TemperatureAlert();
                monitor.OnTemperatureChange += alert.OnTemperatureChanged;

                monitor.Temperature = 20;
                Console.WriteLine("Please enter the temparature");
                monitor.Temperature = int.Parse(Console.ReadLine());

                Console.ReadKey();
            }
        }
    }
}
