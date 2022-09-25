namespace Singleton;

public class ChocolateBoiler
{
    private bool _isEmpty;
    private bool _isBoiled;
    private static ChocolateBoiler _uniqueInstance;
    
    private ChocolateBoiler()
    {
        _isEmpty = true;
        _isBoiled = false;
    }

    public static ChocolateBoiler Instance
    {
        get
        {
            return _uniqueInstance ??= new ChocolateBoiler();
        }
    }

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