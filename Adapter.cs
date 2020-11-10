using System;

namespace Adapter
{
    interface ITransport
    {
        void Drive();
    }
    class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Авто їде");
        }
    }
    class Hourse
    {
        public void Move()
        {
            Console.WriteLine("Кiнь iде");
        }
    }
    class HourseAdapter : ITransport
    {
        private Hourse hourse;
        public HourseAdapter(Hourse _hourse)
        {
            hourse = _hourse;
        }
        public void Drive()
        {
            hourse.Move();
        }
    }
    class Driver
    {
        public void Go(ITransport transport)
        {
            transport.Drive();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();
            Hourse hourse = new Hourse();
            ITransport transport = new Car();
            driver.Go(transport);
            transport = new HourseAdapter(hourse);
            driver.Go(transport);
        }
    }
}
