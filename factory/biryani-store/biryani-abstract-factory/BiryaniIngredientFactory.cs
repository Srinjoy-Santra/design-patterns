namespace biryani_store;

public interface BiryaniIngredientFactory
{
    public Rice CreateRice();

    public Vegetable CreateVegetable();

    public Chicken CreateChicken();

    public Mutton CreateMutton();

    public Additive[] CreateAdditives();
}