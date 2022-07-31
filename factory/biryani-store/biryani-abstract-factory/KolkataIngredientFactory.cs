namespace biryani_store;

public class KolkataIngredientFactory : BiryaniIngredientFactory
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
        return new BroilerChicken();
    }
    
    public Mutton CreateMutton()
    {
        return new Khasi();
    }

    public Additive[] CreateAdditives()
    {
        Additive[] additives = 
        {
            new YellowPotato(),
            new KashmiriZafran(),
            new Jaiphal(),
            new OdishaKewra()
        };
        return additives;
    }

}