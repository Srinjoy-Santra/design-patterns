// See https://aka.ms/new-console-template for more information

using Singleton;

void callBoiler()
{
    for (int i = 0; i < 10; i++)
    {
        var boiler = ChocolateBoiler.Instance;
        Console.WriteLine(boiler.GetHashCode());
    }
}
Thread t = new Thread(callBoiler);
t.Start();
for (int i = 0; i < 10; i++)
{
    var boiler = ChocolateBoiler.Instance;
    boiler.Boil();
    boiler.Drain();
    boiler.Fill();
    Console.WriteLine("main" + boiler.GetHashCode());
}

