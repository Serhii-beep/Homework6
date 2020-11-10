using System;
using System.Collections.Generic;
using System.Linq;

namespace Facade
{
    class Program
    {
        class Consumer
        {
            public void OrderGoods()
            {
                Console.WriteLine("Клiєнт замовляє товар");
            }
            public void Pay()
            {
                Console.WriteLine("Клiєнт платить за товар");
            }
        }

        class Manager
        {
            public void AcceptOrder()
            {
                Console.WriteLine("Менеджер пiдтверджує замовлення");
            }
            public void SendOrderToFactory()
            {
                Console.WriteLine("Менеджер надiслав замовлення на фабрику");
            }
            public void SendGoodsToClient()
            {
                Console.WriteLine("Менеджер вiдправляє товари замовнику");
            }
        }
        class Factory
        { 
            public void CreateGoods()
            {
                Console.WriteLine("Фабрика виробляє замовлення");
            }
            public void returnGoods()
            {
                Console.WriteLine("Фабрика вiдправляє товари менеджеру");
            }
        }

        class ShopFacade
        {
            Consumer consumer;
            Manager manager;
            Factory factory;
            public ShopFacade()
            {
                consumer = new Consumer();
                manager = new Manager();
                factory = new Factory();
            }
            public void ProcessOrder()
            {
                consumer.OrderGoods();
                manager.AcceptOrder();
                manager.SendOrderToFactory();
                factory.CreateGoods();
                factory.returnGoods();
                manager.SendGoodsToClient();
                consumer.Pay();
            }
        }

        static void Main(string[] args)
        {
            ShopFacade shop = new ShopFacade();
            shop.ProcessOrder();
        }
    }
}
