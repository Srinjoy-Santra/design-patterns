namespace biryani_store;

public class LucknowIngredientFactory : BiryaniIngredientFactory
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
        return new CountryChicken();
    }

    public Mutton CreateMutton()
    {
        return new Khasi();
    }

    public Additive[] CreateAdditives()
    {
        Additive[] additives = 
        {
            new ArunachalStarAnise(),
            new KashmiriZafran(),
            new KeralaCinnamon()
        };
        return additives;
    }
}