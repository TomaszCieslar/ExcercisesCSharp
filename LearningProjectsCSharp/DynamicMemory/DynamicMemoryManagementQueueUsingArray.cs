using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.DynamicMemory
{
    public class DynamicMemoryManagementQueueUsingArray
    {
        public void Main()
        {
            //Implementing a queue using array

            QueueOfBooks q = new QueueOfBooks(2);
            q.Enqueue(new Book("title1"));
            q.Enqueue(new Book("title2"));

            q.CountNotNullElements();

            q.Dequeue();
            q.Dequeue();

            q.CountNotNullElements();
        }
    }
    internal class Book
    {
        private string title;

        public Book(string title)
        {
            this.title = title;
        }



    }
    internal class QueueOfBooks
    {
        private Book[] queueOfBooks;
        private int size;
        private int position;

        public QueueOfBooks(int size)
        {
            position = -1;
            this.size = size;

        }

        public void Enqueue(Book book)
        {
            position++;
            queueOfBooks[position] = book;
        }
        public void Dequeue()
        {
            Book tempBook = queueOfBooks[0];

            for (int i = 0; i < position; i++)
                queueOfBooks[i] = queueOfBooks[i + 1];

            queueOfBooks[position] = tempBook;

            position--;

        }

        public int CountNotNullElements()
        {
            int count = 0;
            foreach (var item in queueOfBooks)
            {
                if (string.IsNullOrEmpty(item.ToString()))
                {
                    count++;
                }
            }

            return count;
        }

    }
}
