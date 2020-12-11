using PizzaCalories.Models;
using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaInputs = Console.ReadLine().Split(' ');
                if (pizzaInputs[0] != "Pizza")
                    throw new Exception("Invalid command.");

                string pizzaName = pizzaInputs[1];
                var pizza = new Pizza(pizzaName);

                var doughInputs = Console.ReadLine().Split(' ');
                if (doughInputs[0] != "Dough")
                    throw new Exception("Invalid command.");

                string doughType = doughInputs[1],
                        doughTechnique = doughInputs[2];
                int doughWeight = int.Parse(doughInputs[3]);

                var dough = new Dough(doughType, doughTechnique, doughWeight);
                pizza.Dough = dough;

                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                        break;

                    var toppingInputs = line.Split(' ');
                    if (toppingInputs[0] != "Topping")
                        throw new Exception("Invalid command.");

                    string toppingType = toppingInputs[1];
                    int toppingWeight = int.Parse(toppingInputs[2]);

                    var topping = new Topping(toppingType, toppingWeight);
                    pizza.AddTopping(topping);
                }

                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
