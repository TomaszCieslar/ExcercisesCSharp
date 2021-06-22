using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.Linq
{
    class LINQEntityFrameworkNET
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CarDb>());
            InsertData();
            QueryData();
            Console.ReadLine();
        }

        private static void InsertData()
        {
            var cars = ProcessFile("fuel.csv");
            var db = new CarDb();

            if (!db.Cars.Any())
            {
                foreach (var car in cars)
                {
                    db.Cars.Add(car);
                }
                db.SaveChanges();
            }
        }

        private static object ProcessCars(string v)
        {
            throw new NotImplementedException();
        }

        private static void QueryData()
        {

        }



        private static List<Car> ProcessFile(string path)
        {
            return
                 File.ReadAllLines(path)
                  .Skip(1)
                  .Where(line => line.Length > 1)
                  .Select(Car.ParseFromCSV).ToList();

        }

        private static List<Manufacturer> ProcessManufacturers(string path)
        {
            var query =
                File.ReadAllLines(path)
                    .Where(l => l.Length > 1)
                    .Select(l =>
                    {
                        var columns = l.Split(',');
                        return new Manufacturer
                        {
                            Name = columns[0],
                            Headquarters = columns[1],
                            Year = int.Parse(columns[2])
                        };
                    });
            return query.ToList();
        }
    }
    public class Manufacturer3
    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public int Year { get; set; }

    }
    public class CarDb : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
    public class Car4
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Displacement { get; set; }
        public int Cylinders { get; set; }
        public int City { get; set; }
        public int Highway { get; set; }
        public int Combined { get; set; }

        internal static Car ParseFromCSV(string line)
        {
            var columns = line.Split(',');
            return new Car
            {
                Year = int.Parse(columns[0]),
                Manufacturer = columns[1],
                Name = columns[2],
                Displacement = double.Parse(columns[3], CultureInfo.InvariantCulture),
                Cylinders = int.Parse(columns[4]),
                City = int.Parse(columns[5]),
                Highway = int.Parse(columns[6]),
                Combined = int.Parse(columns[7])
            };
        }
    }
}
