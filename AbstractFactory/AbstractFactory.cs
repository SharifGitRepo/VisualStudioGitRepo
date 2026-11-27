using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AbstractFactory
    {
        public interface IBike
        {
            public void GetDetail();
        }
        public interface ICar
        {
            public void GetDetail();
        }

        class GeneralBike : IBike
        {
            public void GetDetail()
            {
                Console.WriteLine("This is bike");
            }
        }

        class GeneralCar : ICar
        {
            public void GetDetail()
            {
                Console.WriteLine("This is car");
            }
        }

        //interface IVehicleFactory
        //{
        //    public IBike CreateBike();
        //    public ICar CreateCar();
        //}

        //class VehicleFactory: IVehicleFactory
        //{
        //    public IBike CreateBike()
        //    {
        //        return new GeneralBike();
        //    }

        //    public ICar CreateCar()
        //    {
        //        return new GeneralCar();
        //    }
        //}

        public static void Main(string[] args)
        {
            //VehicleFactory vehicleFactory = new VehicleFactory();
            //IBike bike = vehicleFactory.CreateBike();
            //bike.GetDetail();

            //ICar car = vehicleFactory.CreateCar();
            //car.GetDetail();

            string vehicleType = "car";
            IBike bike = null;
            ICar car = null;
            if(vehicleType == "bike")
            {
                bike = new GeneralBike();
            }
            else if(vehicleType == "car")
            {
                car = new GeneralCar();
            }
        }
    }
}
