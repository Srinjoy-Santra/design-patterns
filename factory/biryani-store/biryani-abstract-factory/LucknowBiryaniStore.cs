namespace biryani_store;

public class LucknowBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        var ingredientFactory = new LucknowIngredientFactory();
        return type switch
        {
            BiryaniTypes.VEGETARIAN => new LucknowStyleVegetarianBiryani(ingredientFactory),
            BiryaniTypes.CHICKEN => new LucknowStyleChickenBiryani(ingredientFactory),
            BiryaniTypes.MUTTON => new LucknowStyleMuttonBiryani(ingredientFactory),
            _ => null
        };
    }

    public class LucknowStyleMuttonBiryani : Biryani
    {
        private readonly BiryaniIngredientFactory _ingredientFactory;

        public LucknowStyleMuttonBiryani(BiryaniIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name="Lucknow Style Mutton Biryani";
        }

        public override void Prepare()
        {
            _rice = _ingredientFactory.CreateRice();
            _mutton = _ingredientFactory.CreateMutton();
            _additives = _ingredientFactory.CreateAdditives();
            ToString(_mutton.toString());
        }
    }

    public class LucknowStyleChickenBiryani : Biryani
    {
        private readonly BiryaniIngredientFactory _ingredientFactory;

        public LucknowStyleChickenBiryani(BiryaniIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name="Lucknow Style Chicken Biryani";
        }

        public override void Prepare()
        {
            _rice = _ingredientFactory.CreateRice();
            _chicken = _ingredientFactory.CreateChicken();
            _additives = _ingredientFactory.CreateAdditives();
            ToString(_chicken.toString());
        }
    }

    public class LucknowStyleVegetarianBiryani : Biryani
    {
        private readonly BiryaniIngredientFactory _ingredientFactory;

        public LucknowStyleVegetarianBiryani(BiryaniIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
            Name="Lucknow Style Vegetable Biryani";
        }

        public override void Prepare()
        {
            _rice = _ingredientFactory.CreateRice();
            _vegetable = _ingredientFactory.CreateVegetable();
            _additives = _ingredientFactory.CreateAdditives();
            ToString(_vegetable.toString());
        }
    }
}