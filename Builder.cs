using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Pizza
    {
        string dough;
        string sauce;
        string topping;
        public Pizza() { }
        public void SetDough(string d) { dough = d; }
        public void SetSauce(string s) { sauce = s; }
        public void SetTopping(string t) { topping = t; }
        public void Info()
        {
            Console.WriteLine("Dough: {0}\nSause: {1}\nTopping: {2}", dough, sauce, topping);
        }
    }
    abstract class PizzaBuilder
    {
        protected Pizza pizza;
        public PizzaBuilder() { }
        public Pizza GetPizza() { return pizza; }
        public void CreateNewPizza() { pizza = new Pizza(); }
        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildTopping();
    }
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough() { pizza.SetDough("cross"); }
        public override void BuildSauce() { pizza.SetSauce("mild"); }
        public override void BuildTopping()
        {
            pizza.SetTopping("ham+pineapple");
        }
    }
    class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("pan baked");
        }
        public override void BuildSauce() { pizza.SetSauce("hot"); }
        public override void BuildTopping()
        {
            pizza.SetTopping("pepparoni+salami");
        }
    }
    class MargaritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.SetDough("Margarita Dough");
        }
        public override void BuildSauce()
        {
            pizza.SetSauce("Tomato");
        }
        public override void BuildTopping()
        {
            pizza.SetTopping("Margarita Topping");
        }
    }
    class Waiter
    {
        private PizzaBuilder pizzaBuilder;
        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            pizzaBuilder = pb;
        }
        public Pizza GetPizza() { return pizzaBuilder.GetPizza(); }
        public void ConstructPizza()
        {
            pizzaBuilder.CreateNewPizza();
            pizzaBuilder.BuildDough();
            pizzaBuilder.BuildSauce();
            pizzaBuilder.BuildTopping();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();
            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            waiter.SetPizzaBuilder(margaritaPizzaBuilder);
            waiter.ConstructPizza();
            Pizza pizza = waiter.GetPizza();
            pizza.Info();
        }
    }
}
