using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example2
{
    public class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        public PhotoAlbum(int numPages)
        {
            numberOfPages = numPages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
