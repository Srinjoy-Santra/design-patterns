namespace biryani_store;

public class LucknowBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        switch (type)
        {
            case BiryaniTypes.VEGETARIAN:
                return new LucknowStyleVegetarianBiryani();
            case BiryaniTypes.CHICKEN:
                return new LucknowStyleChickenBiryani();
            case BiryaniTypes.MUTTON:
                return new LucknowStyleMuttonBiryani();
            default:
                return null;
        }
    }
    
}

public class LucknowStyleMuttonBiryani : Biryani
{
    public LucknowStyleMuttonBiryani()
    {
        Name = "Lucknow Style Mutton Biryani";
        Rice = "Basmati";
        Item = "Mutton";
        Ingredients.Add("Saffron");
        Ingredients.Add("Star Anise");
        Ingredients.Add("Cinnamon");
    }
}

public class LucknowStyleChickenBiryani : Biryani
{
    public LucknowStyleChickenBiryani()
    {
        Name = "Lucknow Style Chicken Biryani";
        Rice = "Basmati";
        Item = "Chicken";
        Ingredients.Add("Saffron");
        Ingredients.Add("Star Anise");
        Ingredients.Add("Cinnamon");
    }
}

public class LucknowStyleVegetarianBiryani : Biryani
{
    public LucknowStyleVegetarianBiryani()
    {
        Name = "Lucknow Style Mutton Biryani";
        Rice = "Basmati";
        Item = "-";
        Ingredients.Add("Saffron");
        Ingredients.Add("Star Anise");
        Ingredients.Add("Cinnamon");
    }
}