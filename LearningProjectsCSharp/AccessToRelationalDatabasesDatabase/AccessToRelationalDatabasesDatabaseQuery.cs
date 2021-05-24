using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class AccessToRelationalDatabasesDatabaseQuery
    {
        public void Main()
        {
            SQLiteConnection connection;
            SQLiteCommand command;

            try
            {
                connection = new SQLiteConnection("Data Source='test.db';Version=3;New=False;Compress=True;");
                connection.Open();

                string query = "SELECT * FROM books";
                command = new SQLiteCommand(query, connection);

                SQLiteDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0].ToString());
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine("Error in connection to db!!!");
            }

        }
    }
}
