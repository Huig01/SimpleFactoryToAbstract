namespace SimpleFactoryToAbstract
{
    internal class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Extra thin cardboard";
            sauce = "nothing";
            toppings.Add("Grass");
        }

        internal override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
