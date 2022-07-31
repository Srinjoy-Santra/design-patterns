namespace biryani_store;

public class HyderabadIngredientFactory : BiryaniIngredientFactory
{
    public Rice CreateRice()
    {
        return new Basmati();
    }

    public Vegetable CreateVegetable()
    {
        return new MiscellaneousVegetable();
    }

    public Chicken CreateChicken()
    {
        return new GrassFedChicken();
    }

    public Mutton CreateMutton()
    {
        return new Katchi();
    }

    public Additive[] CreateAdditives()
    {
        Additive[] additives = 
        {
            new FriedOnion(),
            new KashmiriZafran(),
            new DryFruit()
        };
        return additives;
    }
}