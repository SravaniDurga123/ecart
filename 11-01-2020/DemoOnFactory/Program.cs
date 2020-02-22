using System;

namespace DemoOnFactory
{
    interface ifactory
    {
        public void manufacture(int cnt);

    }
    class Bike : ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing No: " + cnt);
        }
    }

    class car : ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("manufacturing No: " + cnt);
        }
    }
    abstract class  VehicleFactory
    {
          public abstract ifactory generateVehicles(string type);
        }

    class ConcreteVehicleFactory : VehicleFactory
    {
        public  override ifactory generateVehicles(string type)
        {
            if (type == "Bike") return new Bike();
            else return new car();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vf = new ConcreteVehicleFactory();
            ifactory myvehicle = vf.generateVehicles("Bike");
            myvehicle.manufacture(10);
            myvehicle = vf.generateVehicles("car");
            myvehicle.manufacture(10);
        }
    }
}
