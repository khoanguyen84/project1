using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example2;


namespace Example1
{
    class AlbumTest
    {
        static void Main()
        {
            PhotoAlbum wedding = new PhotoAlbum();
            Console.WriteLine("Weeding pages: {0}", wedding.GetNumberOfPages());

            PhotoAlbum trip = new PhotoAlbum(24);
            Console.WriteLine("Trip pages: {0}", trip.GetNumberOfPages());

            BigPhotoAlbum family = new BigPhotoAlbum();
            Console.WriteLine("Family pages: {0}", family.GetNumberOfPages());
        }
    }
}
