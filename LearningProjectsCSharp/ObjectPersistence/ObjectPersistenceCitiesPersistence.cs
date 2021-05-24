using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LearningProjectsCSharp.ObjectPersistence
{
    public class ObjectPersistenceCitiesPersistence
    {
        public void Main()
        {
            ArrayList cities = new ArrayList();

            int currentCityNumber;
            string option;
            string textToSearch;
            bool found;
            string textToModify;
            bool finished = false;
            City currentCity;
            // string line;
            // City newCity;

            City[] city = new City[2000];


            if (File.Exists("data.dat"))
            {

                Serializador s = new Serializador("data.dat");
                city = (City[])s.Cargar();
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("Cities database");
                Console.WriteLine();
                Console.WriteLine("1.- Add a new city");
                Console.WriteLine("2.- View all cities");
                Console.WriteLine("3.- Modify a record");
                Console.WriteLine("4.- Insert a new record");
                Console.WriteLine("5.- Delete a record");
                Console.WriteLine("6.- Search in the records");
                Console.WriteLine("7.- Correct the capitalization of the names");
                Console.WriteLine("0.- Exit");
                Console.WriteLine();
                Console.Write("Choose an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    //0.-Exit
                    case "0":
                        finished = true;
                        break;


                    //1 .- Add a new city (at the end of the existing data)
                    case "1":
                        Console.WriteLine("Entering data for city number {0}", cities.Count + 1);
                        Console.Write("Enter the city name: ");
                        City newcity = new City();
                        newcity.Name = Console.ReadLine();
                        Console.Write("Enter the inhabitants numbers: ");
                        newcity.Inhabitants = Convert.ToUInt32(Console.ReadLine());
                        cities.Add(newcity);
                        Console.WriteLine("The data was entered correctly");
                        break;


                    //2 .- View all cities (name and inhabitants)
                    case "2":
                        for (int i = 0; i < cities.Count; i++)
                        {
                            currentCity = (City)cities[i];
                            Console.WriteLine("{0}: {1}, {2} inhabitants",
                                i + 1, currentCity.Name, currentCity.Inhabitants);
                        }
                        Console.WriteLine();
                        break;


                    //3 .- Modify a record (rename and / or change number of inhabitants)
                    case "3":
                        Console.Write("Enter the city number: ");
                        currentCityNumber = Convert.ToInt32(Console.ReadLine());
                        currentCity = (City)cities[currentCityNumber - 1];
                        Console.WriteLine("Enter a new data for a city number: {0}",
                            currentCityNumber);
                        Console.Write("City name (was {0}; hit ENTER to leave as is): ",
                            currentCity.Name);
                        textToModify = Console.ReadLine();
                        if (textToModify != "")
                            currentCity.Name = textToModify;
                        Console.Write("Inhabitants (was {0}; hit ENTER to leave as is): ",
                            currentCity.Inhabitants);
                        textToModify = Console.ReadLine();
                        if (textToModify != "")
                            currentCity.Inhabitants = Convert.ToUInt32(textToModify);
                        cities[currentCityNumber - 1] = currentCity;
                        Console.WriteLine();
                        break;


                    //4 .- Insert a new record (in a specified position,
                    //moving the following ones to the right).
                    case "4":
                        Console.Write("Enter the number of the city to modify: ");
                        currentCityNumber = Convert.ToInt32(Console.ReadLine());
                        currentCity = (City)cities[currentCityNumber - 1];
                        Console.WriteLine("Insert a new data at {0} position: ",
                            currentCityNumber);
                        Console.Write("City name: ");
                        currentCity.Name = Console.ReadLine();
                        Console.Write("Inhabitants: ");
                        currentCity.Inhabitants = Convert.ToUInt32(Console.ReadLine());
                        cities.Insert(currentCityNumber - 1, currentCity);
                        break;


                    //5 .- Delete a record (moving the following 
                    //  ones to the left so that no empty spaces are left)
                    case "5":
                        Console.Write("Enter the city number for delete: ");
                        currentCityNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Deleting the number {0}", currentCityNumber);
                        cities.RemoveAt(currentCityNumber - 1);
                        break;


                    //6 .- Search in the records (display the ones which contain 
                    //a certain text in their name, whether in upper or lower case, 
                    //using partial search)
                    case "6":
                        Console.Write("Enter the text to search: ");
                        textToSearch = Console.ReadLine();
                        found = false;
                        for (int i = 0; i < cities.Count; i++)
                        {
                            currentCity = (City)cities[i];
                            if (currentCity.Name.ToUpper().
                                    IndexOf(textToSearch.ToUpper()) >= 0)
                            {
                                Console.WriteLine("{0} found in {1}",
                                    textToSearch, currentCity.Name);
                                found = true;
                            }
                        }
                        if (!found)
                            Console.WriteLine("Not found.");
                        break;


                    // 7 .- Correct the capitalization of the names
                    //(turn into uppercase the first letter and the ones after 
                    //a space, and make the rest lowercase).
                    case "7":
                        for (int i = 0; i < cities.Count; i++)
                        {
                            currentCity = (City)cities[i];
                            // First, the whole name to lower case
                            string lowerCaseName = currentCity.Name.ToLower();
                            // then, first letter to uppercase
                            string correctedName = lowerCaseName.Substring(0, 1).ToUpper()
                                + lowerCaseName.Substring(1);
                            // and then the letters after a space
                            for (int j = 1; j < correctedName.Length - 2; j++)
                            {
                                if (correctedName[j] == ' ')
                                    correctedName = correctedName.Substring(0, j) + " " +
                                        correctedName.Substring(j + 1, 1).ToUpper() +
                                        correctedName.Substring(j + 2);
                            }

                            currentCity.Name = correctedName;
                        }
                        break;


                    default:
                        Console.WriteLine("Wrong option ");
                        break;

                }

            } while (!finished);

            var outputFile = File.CreateText("data.dat");

            for (int i = 0; i < cities.Count; i++)
            {
                currentCity = (City)cities[i];
                outputFile.WriteLine(currentCity.Name);
                outputFile.WriteLine(currentCity.Inhabitants);
            }

            outputFile.Close();

        }
    }

    [Serializable]
    internal class City
    {
        private string name;
        private uint inhabitants;


        //CONSTRUCTORS
        public City()
        {

        }

        public City(string name, uint inhabitants)
        {

            this.name = name;
            this.inhabitants = inhabitants;
        }

        //GETTERS && SETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public uint Inhabitants
        {
            get { return inhabitants; }
            set { inhabitants = value; }
        }

    }
    internal class Serializador
    {
        string nombre;

        public Serializador(string nombreFich)
        {
            nombre = nombreFich;
        }

        public void Guardar(City objeto)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nombre,
            FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, objeto);
            stream.Close();
        }

        public City[] Cargar()
        {
            City objeto;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(nombre,
            FileMode.Open, FileAccess.Read, FileShare.Read);
            objeto = (City)formatter.Deserialize(stream);
            stream.Close();
            return objeto;
        }

    }
}
