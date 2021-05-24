using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class AccessToRelationalDatabasesDatabaseCreation
    {
        public void Main()
        {

            SQLiteConnection connection;
            SQLiteCommand command;

            try
            {

                connection = new SQLiteConnection("Data Source=test.db;Version=3;New=True;Compress=True;");
                connection.Open();

                //    if (!File.Exists("test.db"))
                //  {
                string creation = "create table books ("
            + " title varchar(50), autor varchar(50), genre varchar(50), summary varchar(50))";
                command = new SQLiteCommand(creation, connection);
                command.ExecuteNonQuery();
                //}

                string line;
                string title = "",
                       autor = "",
                       genre = "",
                       summary = "";
                do
                {
                    Console.Write("Title: ");
                    line = Console.ReadLine();
                    if (line != null)
                        title = line;

                    Console.Write("Autor: ");
                    line = Console.ReadLine();
                    if (line != null)
                        autor = line;

                    Console.Write("Genre: ");
                    line = Console.ReadLine();
                    if (line != null)
                        genre = line;

                    Console.Write("Summary: ");
                    line = Console.ReadLine();
                    if (line != null)
                        summary = line;

                    string insercion = "insert into books values ('" + title +
                        "', '" + autor + "','" + genre + "', '" + summary + "')";

                    command = new SQLiteCommand(insercion, connection);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Insert OK!");
                }
                while (line != null);
                connection.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Error" + e.Message);
            }

            Console.ReadLine();

        }
    }
}
