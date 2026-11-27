using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_2
{
    internal class AbstractFactory
    {
        public interface ICar
        {
            void GetDetails();
        }
        public interface IBike
        {
            void GetDetails();
        }
        class GeneralCar: ICar
        {
            public void GetDetails()
            {
                Console.WriteLine("This is a car");
            }
        }

        class GeneralBike : IBike
        {
            public void GetDetails()
            {
                Console.WriteLine("This is a bike");
            }
        }

        public interface IVehicleFactory
        {
            public IBike CreateBike();
            public ICar CreateCar();
        }

        class VehicleFactory : IVehicleFactory
        {
            public IBike CreateBike()
            {
                return new GeneralBike();
            }

            public ICar CreateCar()
            {
                return new GeneralCar();
            }
        }


        public static void Main(string[] args)
        {
            //IVehicle vehicle = null;
            //string vehicleType = "";
            //if (vehicleType == "car")
            //{
            //    vehicle  = new GeneralCar();
            //    vehicle.GetDetails();
            //}
            //else if(vehicleType == "bike")
            //{
            //    vehicle = new GeneralBike();
            //    vehicle.GetDetails();
            //}

            IVehicleFactory carFactory =  new VehicleFactory();
            ICar car = carFactory.CreateCar();
            car.GetDetails();

            Console.ReadLine();
        }
    }
}
