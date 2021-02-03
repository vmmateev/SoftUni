using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_VehicleCatalogue
{
    class Program
    {
        public class Vehicle
        {
            public string TypeOfVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string typeVehicle, string modelVehicle, string color, double horsePower)
            {

                this.TypeOfVehicle = typeVehicle;
                this.Model = modelVehicle;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                if (TypeOfVehicle == "car")
                {
                    sb.AppendLine($"Type: Car");
                }
                else
                {
                    sb.AppendLine($"Type: Truck");
                }
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {HorsePower}");

                return sb.ToString().TrimEnd();
            }

        }
        static void Main(string[] args)
        {
            List<Vehicle> vehicleCatalog = new List<Vehicle>();
            string input = string.Empty;
            // Добавяме модели на коли и камиони
            while ((input = Console.ReadLine()) != "End")
            {
                string[] catalogArgs = input.Split();
                Vehicle currentVehicle = new Vehicle(catalogArgs[0], catalogArgs[1], catalogArgs[2], double.Parse(catalogArgs[3]));
                vehicleCatalog.Add(currentVehicle);
            }
            // вадим дадени модели от юсера

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicleCatalog.FirstOrDefault(x => x.Model == input).ToString());
            }

            var cars = vehicleCatalog.FindAll(x => x.TypeOfVehicle == "car");
            var carHpSum = cars.Sum(c => c.HorsePower);
            var carAverageHp = carHpSum / cars.Count;

            var trucks = vehicleCatalog.FindAll(x => x.TypeOfVehicle == "truck");
            var truckHpSum = trucks.Sum(t => t.HorsePower);
            var truckAverageHp = truckHpSum / trucks.Count;

            if (cars.Count == 0) // ako e >0 i da pechata rezultat garmi ako e taka minava 100 100
            {
                carAverageHp = 0;
            }
            if (trucks.Count == 0)
            {
                truckAverageHp = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAverageHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHp:f2}.");
        }
    }
}