namespace SimpleFactoryToAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza.Name);

            PizzaStore calpizzaStore = new CaliPizzaStore();
            pizza = calpizzaStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered " + pizza.Name);
        }
    }
}