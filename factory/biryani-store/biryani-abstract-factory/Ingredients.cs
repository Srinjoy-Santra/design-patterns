namespace biryani_store;

public interface Rice
{
    public string toString();
}

public interface Vegetable
{
    public string toString();
}

public interface Chicken
{
    public string toString();
}

public interface Mutton
{
    public string toString();
}

public interface Additive
{
    public string toString();
}

public class Basmati : Rice
{
    public string toString()
    {
        return "Basmati rice from WB";
    }
}
public class MiscellaneousVegetable : Vegetable
{
    public string toString()
    {
        return "Peas, carrots, cauliflower and French Beans";
    }
}

public class BroilerChicken : Chicken
{
    public string toString()
    {
        return "Broiler Chicken";
    }
}

public class GrassFedChicken : Chicken
{
    public string toString()
    {
        return "Grass-fed Chicken";
    }
}

public class CountryChicken : Chicken
{
    public string toString()
    {
        return "Grass-fed Chicken";
    }
}

public class Khasi : Mutton
{
    public string toString()
    {
        return "Tender mutton pieces";
    }
}

public class Katchi : Mutton
{
    public string toString()
    {
        return "Handi mutton";
    }
}

public class YellowPotato : Additive
{
    public string toString()
    {
        return "Medium-Large Yellow Potato";
    }
}

public class FriedOnion : Additive
{
    public string toString()
    {
        return "Caramelised Fried Onion";
    }
}

public class KashmiriZafran : Additive
{
    public string toString()
    {
        return "Saffron from Pampore";
    }
}

public class Jaiphal : Additive
{
    public string toString()
    {
        return "Jaiphal / Jaadhikai of TN";
    }
}

public class OdishaKewra : Additive
{
    public string toString()
    {
        return "Kewra from Ganjam of TN";
    }
}

public class ArunachalStarAnise : Additive
{
    public string toString()
    {
        return "Star Anise from Arunachal Pradesh";
    }
}

public class KeralaCinnamon : Additive
{
    public string toString()
    {
        return "Cinnamon from Kerala";
    }
}

public class DryFruit : Additive
{
    public string toString()
    {
        return "Dried grapes from Sangli, Maharashtra and Cashew from Goa";
    }
}
