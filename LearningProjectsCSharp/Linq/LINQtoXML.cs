using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LearningProjectsCSharp.Linq
{
    class LINQtoXML
    {
        static void Main(string[] args)
        {
            CreateXml();
            QueryXml();


            Console.ReadLine();
        }

        private static void QueryXml()
        {
            var document = XDocument.Load("fuel.xml");
            var query = document.Element("Cars").Elements("Car")
                                .Where(e => e.Attribute("Manufacturer").Value == "BMW")
                                .Select(c => c.Attribute("Name").Value);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }

        private static void CreateXml()
        {
            var records = ProcessFile("fuel.csv");

            var document = new XDocument();
            var cars = new XElement("Cars");


            foreach (var record in records)
            {

                var car = new XElement("Car",
                            new XAttribute("Name", record.Name),
                            new XAttribute("Combined", record.Combined),
                            new XAttribute("Manufacturer", record.Manufacturer)
                            );




                cars.Add(car);

            }

            document.Add(cars);
            document.Save("fuel.xml");
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

    public class Manufacturer2

    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public int Year { get; set; }

    }

    public class Car3
    {
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
