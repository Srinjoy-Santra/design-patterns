namespace Singleton;

public class ChocolateBoiler
{
    private bool _isEmpty;
    private bool _isBoiled;
    private static readonly ChocolateBoiler _uniqueInstance = new();
    
    // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
    static ChocolateBoiler()
    {
    }
    
    private ChocolateBoiler()
    {
        _isEmpty = true;
        _isBoiled = false;
    }

    public static ChocolateBoiler Instance => _uniqueInstance;

    public void Fill()
    {
        if (_isEmpty)
        {
            _isEmpty = false;
            _isBoiled = false;
        }
    }
    
    public void Boil()
    {
        if (!_isEmpty && !_isBoiled)
        {
            _isBoiled = true;
        }
    }

    public void Drain()
    {
        if (!_isEmpty && _isBoiled)
        {
            _isEmpty = true;
        }
    }
}