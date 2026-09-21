namespace SimpleFactoryToAbstract
{
    internal class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Sauce and Clam Pizza";
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
