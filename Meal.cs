using System;
namespace Assignment_19_Generics
{
    public interface IMealPlan
    {
        string Name { get; }
        string Description { get; }
        void PrepareMeal();
    }

    public class VegetarianMeal : IMealPlan
    {
        public string Name
        {
            get { return "Vegetarian Meal"; }
        }

        public string Description
        {
            get { return "A meal consisting of plant-based foods, no animal products."; }
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing Vegetarian Meal, Rice and Grilled Vegetables.");
        }
    }

    public class VeganMeal : IMealPlan
    {
        public string Name
        {
            get { return "Vegan Meal"; }
        }

        public string Description
        {
            get { return "A meal free from all animal products."; }
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing Vegan Meal: Tofu Stir-fry with Vegetables.");
        }
    }

    public class KetoMeal : IMealPlan
    {
        public string Name
        {
            get { return "Keto Meal"; }
        }

        public string Description
        {
            get { return "A high-fat, low-carb meal plan."; }
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing Keto Meal Grilled Salmon with Avocado.");
        }
    }

    public class HighProteinMeal : IMealPlan
    {
        public string Name
        {
            get { return "High Protein Meal"; }
        }

        public string Description
        {
            get { return "A meal with a focus on protein-rich foods."; }
        }

        public void PrepareMeal()
        {
            Console.WriteLine("Preparing High Protein Meal: Chicken Breast with Protien Powder.");
        }
    }

    public class Meal<T> where T : IMealPlan, new()
    {
        public T GenerateMealPlan()
        {
            T meal = new T(); //creating a new instance of T (different types)
            Console.WriteLine("Generating " + meal.Name + " " + meal.Description);
            meal.PrepareMeal();
            return meal;
        }
    }

    public class MealPlanGenerator
    {
        public void ValidateAndGenerateMealPlan<T>(string mealType) where T : IMealPlan, new()
        {
            if (mealType == typeof(T).Name)
            {
                Console.WriteLine("Valid meal type: " + mealType);
                Meal<T> meal = new Meal<T>();
                meal.GenerateMealPlan();
            }
            else
            {
                Console.WriteLine("Invalid meal type.");
            }
        }
    }

    class Program4
    {
        static void Main()
        {
            MealPlanGenerator generator = new MealPlanGenerator();

            //choosing a meal plan
            string userChoice = "VegetarianMeal"; //this could come from user input

            //validate and generate the meal plan
            generator.ValidateAndGenerateMealPlan<VegetarianMeal>(userChoice);
            generator.ValidateAndGenerateMealPlan<VeganMeal>(userChoice);
        }
    }
}
