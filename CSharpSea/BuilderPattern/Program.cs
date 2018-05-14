using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.showItems();
            Console.WriteLine("Total Cost : " + vegMeal.getCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();
            Console.WriteLine("Non-Veg Meal");
            nonVegMeal.showItems();
            Console.WriteLine("Total Cost : " + nonVegMeal.getCost());

            Console.ReadKey();

        }
    }
}
