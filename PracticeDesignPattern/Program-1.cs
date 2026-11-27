class FactoryDesignPattern
{
    interface ICar
    {
        void GetDetail();
    }
    interface IBike
    {
        void GetDetail();
    }

    class GeneralCar: ICar
    {
        public void GetDetail()
        {
            Console.WriteLine("This is general Car");
        }
    }

    class SportsCar : ICar
    {
        public void GetDetail()
        {
            Console.WriteLine("This is sports ca");
        }
    }

    interface IvehicleFactory
    {
        ICar CreateCar();
    }

    class GeneralVehicleFactory : IvehicleFactory
    {
        public ICar CreateCar()
        {
            return new GeneralCar();
        }
    }
    class SportsVehicleFactory: IvehicleFactory
    {
        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }

    public static void Main(string[] args)
    {
        string vehicleType = "sports";
        

       IvehicleFactory vehicleFactory = new GeneralVehicleFactory();
       ICar regularCar = vehicleFactory.CreateCar();
        regularCar.GetDetail();

        ICar sportsCar = vehicleFactory.CreateCar();
        sportsCar.GetDetail();

        Console.ReadLine();
    }
}
    
//{
//}
class Program
{
    
}
        

        //Singleton.DerivedSingleton fromDerived = new Singleton.DerivedSingleton();
        //fromDerived.PrintDetail("This is derive");

    






