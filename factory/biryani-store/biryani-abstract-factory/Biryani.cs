using System.Collections;

namespace biryani_store;

public class Biryani
{
    public string Name;
    protected string Rice;
    protected string Item;
    protected List<string> Ingredients = new();

    public void Prepare()
    {
        Console.WriteLine($"Preparing {Name} \n Marinating the {Item}...\n Adding ingredients....");

        foreach(var ingredient in Ingredients)
        {
            Console.WriteLine(" -"+ingredient);
        }
        
        Console.WriteLine($" Adding {Rice} rice and water...");
    }

    protected internal void Simmer()
    {
        Console.WriteLine(" Simmer the pot for few hours");
    }

    protected internal void Churn()
    {
        Console.WriteLine($" Churn the {Rice} and {Item}");
    }

    protected internal void Serve()
    {
        Console.WriteLine(" Serve the dish");
    }

    protected void Box()
    {
        Console.WriteLine(" Place biryani in official store box");
    }
}

public enum BiryaniTypes
{
    VEGETARIAN,
    CHICKEN,
    MUTTON
}