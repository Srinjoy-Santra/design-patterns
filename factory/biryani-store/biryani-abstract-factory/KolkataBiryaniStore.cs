using static biryani_store.BiryaniTypes;

namespace biryani_store;

public class KolkataBiryaniStore : BiryaniStore
{
    protected override Biryani? CreateBiryani(BiryaniTypes type)
    {
        switch (type)
        {
            case VEGETARIAN:
                return new KolkataStyleVegetarianBiryani();
            case CHICKEN:
                return new KolkataStyleChickenBiryani();
            case MUTTON:
                return new KolkataStyleMuttonBiryani();
            default:
                return null;
        }
    }
}

public class KolkataStyleMuttonBiryani : Biryani
{
    public KolkataStyleMuttonBiryani()
    {
        Name = "Kolkata Style Mutton Biryani";
        Rice = "Basmati";
        Item = "Mutton";
        Ingredients.Add("Potato");
        Ingredients.Add("Saffron");
        Ingredients.Add("Nutmeg");
        Ingredients.Add("Kewra");
    }
}

public class KolkataStyleChickenBiryani : Biryani
{
    public KolkataStyleChickenBiryani()
    {
        Name = "Kolkata Style Chicken Biryani";
        Rice = "Basmati";
        Item = "Chicken";
        Ingredients.Add("Potato");
        Ingredients.Add("Saffron");
        Ingredients.Add("Nutmeg");
        Ingredients.Add("Kewra");
    }
}

public class KolkataStyleVegetarianBiryani : Biryani
{
    public KolkataStyleVegetarianBiryani()
    {
        Name = "Kolkata Style Mutton Biryani";
        Rice = "Basmati";
        Item = "-";
        Ingredients.Add("Potato");
        Ingredients.Add("Saffron");
        Ingredients.Add("Nutmeg");
        Ingredients.Add("Kewra");
    }
}
