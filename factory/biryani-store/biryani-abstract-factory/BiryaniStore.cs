namespace biryani_store;

public abstract class BiryaniStore
{
    protected abstract Biryani? CreateBiryani(BiryaniTypes type);

    public Biryani? OrderBiryani(BiryaniTypes type)
    {
        var biryani = CreateBiryani(type);

        biryani?.Prepare();
        biryani?.Simmer();
        biryani?.Churn();
        biryani?.Serve();

        return biryani;
    }

    
}