namespace SimpleFactoryToAbstract
{
    internal class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
