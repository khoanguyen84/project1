using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example5.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public double AverageRate { get; set; }
    }
}
