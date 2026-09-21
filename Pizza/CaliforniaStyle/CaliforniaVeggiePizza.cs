namespace SimpleFactoryToAbstract
{
    internal class CaliforniaVeggiePizza : Pizza
    {
        public CaliforniaVeggiePizza()
        {
            name = "California Style Cheese Pizza";
            dough = "Medium Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Parmachane Cheese");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
