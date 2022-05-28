using static biryani_store.BiryaniTypes;
namespace biryani_store;

public class HyderabadBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        switch (type)
        {
            case VEGETARIAN:
                return new HyderabadStyleVegetarianBiryani();
            case CHICKEN:
                return new HyderabadStyleChickenBiryani();
            case MUTTON:
                return new HyderabadStyleMuttonBiryani();
            default:
                return null;
        }
    }
}

public class HyderabadStyleMuttonBiryani : Biryani
{
    public HyderabadStyleMuttonBiryani()
    {
        Name = "Hyderabad Style Mutton Biryani";
        Rice = "Basmati";
        Item = "Mutton";
        Ingredients.Add("Onions");
        Ingredients.Add("Saffron");
        Ingredients.Add("Dry Fruits");
    }
}

public class HyderabadStyleChickenBiryani : Biryani
{
    public HyderabadStyleChickenBiryani()
    {
        Name = "Hyderabad Style Chicken Biryani";
        Rice = "Basmati";
        Item = "Chicken";
        Ingredients.Add("Onions");
        Ingredients.Add("Saffron");
        Ingredients.Add("Dry Fruits");
    }
}

public class HyderabadStyleVegetarianBiryani : Biryani
{
    public HyderabadStyleVegetarianBiryani()
    {
        Name = "Hyderabad Style Mutton Biryani";
        Rice = "Basmati";
        Item = "-";
        Ingredients.Add("Onions");
        Ingredients.Add("Saffron");
        Ingredients.Add("Dry Fruits");
    }
}