using static biryani_store.BiryaniTypes;
namespace biryani_store;

public class HyderabadBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        var ingredientFactory = new HyderabadIngredientFactory();
        return type switch
        {
            VEGETARIAN => new HyderabadStyleVegetarianBiryani(ingredientFactory),
            CHICKEN => new HyderabadStyleChickenBiryani(ingredientFactory),
            MUTTON => new HyderabadStyleMuttonBiryani(ingredientFactory),
            _ => null
        };
    }
}

public class HyderabadStyleMuttonBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public HyderabadStyleMuttonBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name="Hyderabad Style Mutton Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _mutton = _ingredientFactory.CreateMutton();
        _additives = _ingredientFactory.CreateAdditives();
        
        ToString(_mutton.toString());
    }
}

public class HyderabadStyleChickenBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public HyderabadStyleChickenBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name="Hyderabad Style Chicken Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _chicken = _ingredientFactory.CreateChicken();
        _additives = _ingredientFactory.CreateAdditives();

        ToString(_chicken.toString());
    }
}
    
public class HyderabadStyleVegetarianBiryani : Biryani
{
    private BiryaniIngredientFactory _ingredientFactory;

    public HyderabadStyleVegetarianBiryani(BiryaniIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
        Name="Hyderabad Style Vegetable Biryani";
    }
    
    public override void Prepare()
    {
        _rice = _ingredientFactory.CreateRice();
        _vegetable = _ingredientFactory.CreateVegetable();
        _additives = _ingredientFactory.CreateAdditives();
        ToString(_vegetable.toString());
    }
}