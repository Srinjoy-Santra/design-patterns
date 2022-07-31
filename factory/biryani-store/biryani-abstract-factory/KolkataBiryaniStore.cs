using static biryani_store.BiryaniTypes;

namespace biryani_store;

public class KolkataBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        var ingredientFactory = new KolkataIngredientFactory();
        return type switch
        {
            VEGETARIAN => new KolkataStyleVegetarianBiryani(ingredientFactory),
            CHICKEN => new KolkataStyleChickenBiryani(ingredientFactory),
            MUTTON => new KolkataStyleMuttonBiryani(ingredientFactory),
            _ => null
        };
    }
}

public class KolkataStyleVegetarianBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public KolkataStyleVegetarianBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory; 
        Name="Kolkata Style Vegetable Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _vegetable = _ingredientFactory.CreateVegetable();
        _additives = _ingredientFactory.CreateAdditives();
        ToString(_vegetable.toString());
    }
}

public class KolkataStyleChickenBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public KolkataStyleChickenBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name="Kolkata Style Chicken Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _chicken = _ingredientFactory.CreateChicken();
        _additives = _ingredientFactory.CreateAdditives();
        ToString(_chicken.toString());
    }
}


public class KolkataStyleMuttonBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public KolkataStyleMuttonBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name="Kolkata Style Mutton Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _mutton = _ingredientFactory.CreateMutton();
        _additives = _ingredientFactory.CreateAdditives();
        ToString(_mutton.toString());
    }
}
