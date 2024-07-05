using System.Security.Cryptography.X509Certificates;

namespace OOPPractice
{
    class Car
    {
        public double FuelEconomy;
        public string type;

        public void ShowFuelEconomy()
        {
            Console.WriteLine("연비는 " + FuelEconomy + "입니다.");
        }

        public void ShowFuelEconomy(string type, double FuelEconomy)
        {
            Console.WriteLine(type + "의 연비는 " + FuelEconomy + "입니다.");
        }


        public virtual void ShowCar()
        {
            Console.WriteLine("차량입니다");
        }
    }

    class Bus : Car
    {
        public Bus()
        {
            FuelEconomy = 8.0;
        }
    }

    class Taxi : Car
    {
        public override void ShowCar()
        {
            Console.WriteLine("아반떼 차량입니다.");
        }
    }

    class Truck : Car
    {
        public override void ShowCar()
        {
            Console.WriteLine("볼보 트럭입니다.");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus();   
            bus.ShowFuelEconomy();

            Taxi taxi = new Taxi();
            taxi.ShowFuelEconomy("택시", 13.0);

            taxi.ShowCar();

            Truck truck = new Truck();
            truck.ShowCar();
            
        }
    }
}
