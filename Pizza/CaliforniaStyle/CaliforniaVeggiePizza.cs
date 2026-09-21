namespace SimpleFactoryToAbstract
{
    internal class CaliforniaVeggiePizza : Pizza
    {
        public CaliforniaVeggiePizza()
        {
            name = "California Style Veggie Pizza";
            dough = "Double thin cardboard";
            sauce = "nothing";
            toppings.Add("Grass");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
