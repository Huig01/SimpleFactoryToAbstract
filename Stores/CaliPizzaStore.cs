namespace SimpleFactoryToAbstract
{
    internal class CaliPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CaliforniaCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new CaliforniaVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new CaliforniaClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new CaliforniaPepperoniPizza();
            }

            return pizza;
        }
    }
}