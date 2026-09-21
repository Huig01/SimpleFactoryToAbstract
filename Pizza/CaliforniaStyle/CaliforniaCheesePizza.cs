namespace SimpleFactoryToAbstract
{
    internal class CaliforniaCheesePizza : Pizza
    {
        public CaliforniaCheesePizza()
        {
            name = "California Style Cheese Pizza";
            dough = "Medium Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Parmesan Cheese");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into 6 slices");
        }
    }
}
