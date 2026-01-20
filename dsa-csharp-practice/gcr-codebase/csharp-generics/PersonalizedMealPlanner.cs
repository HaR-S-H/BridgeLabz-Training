using System;

// Interface
interface IMealPlan
{
    string MealType { get; }
}

class VegetarianMeal : IMealPlan
{
    public string MealType => "Vegetarian";
}

class VeganMeal : IMealPlan
{
    public string MealType => "Vegan";
}

// Generic Meal
class Meal<T> where T : IMealPlan
{
    public void GenerateMeal(T plan)
    {
        Console.WriteLine($"Meal Plan Generated: {plan.MealType}");
    }
}

// Usage
class Program
{
    static void Main()
    {
        Meal<VeganMeal> meal = new Meal<VeganMeal>();
        meal.GenerateMeal(new VeganMeal());
    }
}
