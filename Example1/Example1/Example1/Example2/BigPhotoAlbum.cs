using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example2
{
    public class BigPhotoAlbum
    {
        private int numberOfPages;
        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
