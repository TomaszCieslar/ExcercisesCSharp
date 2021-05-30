using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningProjectsCSharp.ArrayStructures
{
    class ArraysStructuresBooksDatabase
    {
        public struct Book
        {
            public string Title;
            public string Author;
        }

        public void Main()
        {
            Book[] ArrayOfBooks = new Book[1000];
            int Option;
            int NumberOfBooks = 0;
            do
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Add data for one book");
                Console.WriteLine("2 - Display all the entered books(just title and author, in the same line)");
                Console.WriteLine("3 - Search for the book(s) with a certain title");
                Console.WriteLine("4 - Delete a book at a known position(for example, book number 6)");
                Console.WriteLine("5 - Exit the program");
                Console.WriteLine("----------------------------");
                Console.Write("Choose Option: ");
                Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        Console.WriteLine("1 - Add data for one book");
                        Book item = new Book();

                        Console.Write("Please give name of book: ");
                        item.Title = Console.ReadLine();

                        Console.Write("Please give name of author: ");
                        item.Author = Console.ReadLine();

                        ArrayOfBooks[NumberOfBooks] = item;

                        NumberOfBooks++;


                        break;
                    case 2:
                        Console.WriteLine("2 - Display all the entered books(just title and author, in the same line)");
                        int index = 0;
                        foreach (var element in ArrayOfBooks)
                        {
                            if (element.Title != null && element.Author != null)
                            {
                                Console.WriteLine("id: {0} \t\t Author: {1} \t\t  Title: {2}", index, element.Author, element.Title);
                                index++;
                            }

                        }
                        break;
                    case 3:
                        string Title;
                        Console.WriteLine("3 - Search for the book(s) with a certain title");

                        Console.Write("Please enter title of a book: ");
                        Title = Console.ReadLine();

                        var booksTitle = ArrayOfBooks.Where(x => x.Title == Title).Select(x => x.Author);
                        foreach (var element in booksTitle)
                        {
                            Console.WriteLine(element);
                        }

                        break;
                    case 4:
                        Console.WriteLine("4 - Delete a book at a known position(for example, book number 6)");
                        int Index;
                        Console.Write("Please inter id you want to remove: ");
                        Index = Convert.ToInt32(Console.ReadLine());

                        ArrayOfBooks = ArrayOfBooks.Where((source, id) => id != Index).ToArray();

                        break;
                    case 5:
                        Console.WriteLine("5 - Exit the program");
                        break;
                    default:
                        Console.WriteLine("Option should be between 1 and 5");
                        break;
                }


            } while (Option != 5);


        }
    }
}
