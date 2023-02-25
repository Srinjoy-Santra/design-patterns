namespace Bird;

public class TurkeyAdapter : IDuck
{
    private ITurkey _turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        _turkey = turkey;
    }


    public void Quack()
    {
        _turkey.Gobble();
    }

    public void Fly()
    {
        // Since turkey flights are shorter than duck
        for(int i=0;i<3;i++)
            _turkey.Fly(); 
    }
}