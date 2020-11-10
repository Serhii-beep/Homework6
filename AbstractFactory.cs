using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class Car
    {
        public abstract void Info();
    }
    class Ford : Car
    {
        public override void Info()
        {
            Console.WriteLine("Ford");
        }
    }
    class Toyota : Car
    {
        public override void Info()
        {
            Console.WriteLine("Toyota");
        }
    }
    class Mercedes : Car
    {
        public override void Info()
        {
            Console.WriteLine("Mercedes");
        }
    }
    abstract class Body
    {
        public virtual void GetBodyInfo()
        {
        }
    }
    class FordBody : Body
    {
        public override void GetBodyInfo()
        {
            Console.WriteLine("Ford body");
        }
    }
    class ToyotaBody : Body
    {
        public override void GetBodyInfo()
        {
            Console.WriteLine("Toyota body");
        }
    }
    class MercedesBody : Body
    {
        public override void GetBodyInfo()
        {
            Console.WriteLine("Mercedes body");
        }
    }
    abstract class Engine
    {
        public virtual void GetPower()
        {
        }
    }
    class FordEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Ford Engine 4.4");
        }
    }
    class ToyotaEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Toyota Engine 3.2");
        }
    }
    class MercedesEngine : Engine
    {
        public override void GetPower()
        {
            Console.WriteLine("Mrcedes Engine 3.5");
        }
    }
    interface ICarFactory
    {
        Car CreateCar();
        Engine CreateEngine();
        Body CreateBody();
    }
    class FordFactory : ICarFactory
    {
        Car ICarFactory.CreateCar()
        {
            return new Ford();
        }
        Engine ICarFactory.CreateEngine()
        {
            return new FordEngine();
        }
        Body ICarFactory.CreateBody()
        {
            return new FordBody();
        }
    }
    class ToyotaFactory : ICarFactory
    {
        Car ICarFactory.CreateCar()
        {
            return new Toyota();
        }
        Engine ICarFactory.CreateEngine()
        {
            return new ToyotaEngine();
        }
        Body ICarFactory.CreateBody()
        {
            return new ToyotaBody();
        }
    }
    class MercedesFactory : ICarFactory
    {
        Car ICarFactory.CreateCar()
        {
            return new Mercedes();
        }
        Engine ICarFactory.CreateEngine()
        {
            return new MercedesEngine();
        }
        Body ICarFactory.CreateBody()
        {
            return new MercedesBody();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();
            Car myCar = carFactory.CreateCar();
            myCar.Info();
            Engine myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            Body myBody = carFactory.CreateBody();
            myBody.GetBodyInfo();
            carFactory = new FordFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();
            myBody = carFactory.CreateBody();
            myBody.GetBodyInfo();
            carFactory = new MercedesFactory();
            myCar = carFactory.CreateCar();
            myEngine = carFactory.CreateEngine();
            myBody = carFactory.CreateBody();
            myCar.Info();
            myEngine.GetPower();
            myBody.GetBodyInfo();
        }
    }

}
