using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class AccessToRelationalDatabasesFullAccesToADatabase
    {
        public void Main()
        {
            int option;
            List<Book> ListOfBooks = new List<Book>();
            DataServices db = new DataServices();
            do
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Add New Book");
                Console.WriteLine("2 - Edit existing book");
                Console.WriteLine("3 - Remove existing book");
                Console.WriteLine("4 - Show all books");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("----------------------------------");
                Console.Write("Please choose option: ");
                option = Convert.ToInt32(Console.ReadLine());

                db.Connect();

                switch (option)
                {
                    case 1:
                        Book book = new Book();

                        Console.Write("Author:");
                        book.Author = Console.ReadLine();

                        Console.Write("Title:");
                        book.Title = Console.ReadLine();

                        Console.Write("Description:");
                        book.Description = Console.ReadLine();

                        ListOfBooks.Add(book);
                        db.AddNewBook(book);
                        break;
                    case 2:
                        db.EditExisitngBook();
                        break;
                    case 3:
                        db.RemoveExistingBook();
                        break;
                    case 4:
                        db.ShowAllBooks();
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            } while (option != 5);
        }
    }

    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }


    }

    internal class DataServices
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=test.db;Version=3;New=True;Compress=True;");
        SQLiteCommand command;

        public void Connect()
        {
            try
            {
                connection.Open();
                //string creation = "CREATE TABLE books (Title varchar(255), Author varchar(255), Description varchar(255))";
                //command = new SQLiteCommand(creation, connection);
                //command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error with connection: ", e);
            }
        }



        public void ShowAllBooks()
        {
            string showAllQuery = "SELECT * FROM books";
            command = new SQLiteCommand(showAllQuery, connection);
            SQLiteDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                Console.WriteLine(data[0]);
            }
        }

        public void RemoveExistingBook()
        {
            string removeExisitingQuery = "";
            command = new SQLiteCommand(removeExisitingQuery, connection);
            command.ExecuteNonQuery();
        }

        public void EditExisitngBook()
        {
            string editExistingQuery = "";
            command = new SQLiteCommand(editExistingQuery, connection);
            command.ExecuteNonQuery();
        }

        public void AddNewBook(Book book)
        {
            string addNewQuery = $"INSERT INTO books VALUES ('{book.Author}','{book.Title}','{book.Description}')";
            command = new SQLiteCommand(addNewQuery, connection);
            command.ExecuteNonQuery();
        }
    }
}
