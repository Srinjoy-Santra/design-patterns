using System.Collections;

namespace biryani_store;

public abstract class Biryani
{
    public string Name;
    protected Rice _rice;
    protected Vegetable _vegetable;
    protected Chicken _chicken;
    protected Mutton _mutton;
    protected Additive[] _additives;

    public abstract void Prepare();
    
    protected internal void Simmer()
    {
        Console.WriteLine(" Simmer the pot for few hours");
    }

    protected internal void Churn()
    {
        Console.WriteLine($" Churn the rice with the ingredients.");
    }

    protected internal void Serve()
    {
        Console.WriteLine(" Serve the dish");
    }

    protected void Box()
    {
        Console.WriteLine(" Place biryani in official store box");
    }

    protected void ToString(string item)
    {
        Console.WriteLine($"Preparing {Name} \n Marinating the {item}...\n Adding ingredients....");
        foreach(var additive in _additives)
        {
            Console.WriteLine(" *"+additive.toString());
        }
        Console.WriteLine($" Adding {_rice.toString()} and water to the {item}...");
    }
}

public enum BiryaniTypes
{
    VEGETARIAN,
    CHICKEN,
    MUTTON
}