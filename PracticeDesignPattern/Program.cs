interface ITravelStarategy
{
    public void SetTravelStrategy();
    
}

class BusTravelStrategy : ITravelStarategy
{
    public void SetTravelStrategy()
    {
        Console.WriteLine("Traveller will travel to airport by bus");
    }
}
class CabTravelStrategy : ITravelStarategy
{
    public void SetTravelStrategy()
    {
        Console.WriteLine("Traveller will travel to airport by cab");
    }
}

class TravelContext
{
    ITravelStarategy _strategy;
    public void SetTravelStrategy(ITravelStarategy strategy)
    {
        _strategy = strategy;
    }

    public void GoToAirpoer()
    {
        _strategy.SetTravelStrategy();
    }
}

class Program
{
    public static void Main(string[] args)
    {
        TravelContext ctx = new TravelContext();
        string travelStarategy = "bus";

        if(travelStarategy == "bus")
        {
            ctx.SetTravelStrategy(new BusTravelStrategy());
        }
        else if(travelStarategy == "cab")
        {
            ctx.SetTravelStrategy(new CabTravelStrategy());
        }

        ctx.GoToAirpoer();
        Console.ReadLine();
    }
}