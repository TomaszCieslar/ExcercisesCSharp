using System;
using System.Collections.Generic;
using System.Text;

namespace LearningProjectsCSharp.OOP
{
    public class OOPPhotoAlbumTarea
    {
        public void Main()
        {
            PhotoAlbum album1 = new PhotoAlbum();
            Console.WriteLine(album1.GetNumberOfPages());

            PhotoAlbum album2 = new PhotoAlbum(24);
            Console.WriteLine(album2.GetNumberOfPages());

            BigPhotoAlbum album3 = new BigPhotoAlbum();
            Console.WriteLine(album3.GetNumberOfPages());

            Console.ReadLine();
        }
    }
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int number)
        {
            numberOfPages = number;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    class BigPhotoAlbum : PhotoAlbum
    {
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
    }
}
