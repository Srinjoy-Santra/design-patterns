namespace Bird;

public interface ITurkey
{
    public void Gobble();
    public void Fly();
}
public class WildTurkey : ITurkey
{
    public void Gobble()
    {
        Console.WriteLine("Gobble gobble");
    }

    public void Fly()
    {
        Console.WriteLine("I'm flying a short distance");
    }
}