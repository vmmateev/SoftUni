using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08_VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            var catalog = new Catalog(cars, trucks);
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split("/").ToArray();
                if (tokens[0] == "Car")
                {//Car/Audi/A3/110
                    var car = new Car(tokens[1], tokens[2], double.Parse(tokens[3]));
                    catalog.Cars.Add(car);
                }
                else
                {
                    var truck = new Truck(tokens[1], tokens[2], double.Parse(tokens[3]));
                    catalog.Trucks.Add(truck);
                }
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Catalog
    {
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

    }
}
public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Weight { get; set; }
    public Truck(string brand, string model, double weight)
    {
        this.Brand = brand;
        this.Model = model;
        this.Weight = weight;
    }
}
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double HorsePower { get; set; }
    public Car(string brand, string model, double horsePower)
    {
        this.Brand = brand;
        this.Model = model;
        this.HorsePower = horsePower;
    }
}

