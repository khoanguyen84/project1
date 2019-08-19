using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Example1.Example5.Models;

namespace Example1.Example5
{
    public class News : INews
    {
        protected int id;
        protected string title;
        protected string publishDate;
        protected string author;
        protected string content;
        protected double averageRate;

        public int[] RateList = new int[3];
        public NewsItem[] ArrayList = new NewsItem[100];

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        public double AverageRate { get => averageRate;}
        public void Display()
        {
            foreach(var newsItem in ArrayList)
            {
                if(newsItem != null)
                {
                    Console.WriteLine("Id {0} Title {1} PublishDate {2} Author {3} Content {4} AverageRate {5}",
                                newsItem.Id, newsItem.Title,
                                newsItem.PublishDate, newsItem.Author,
                                newsItem.Content, newsItem.AverageRate);
                }
            }
        }

        public void Calculate()
        {
            var total = 0.0;
            for(int i = 0; i < RateList.Length; i++)
            {
                total += RateList[i];
            }
            averageRate =  (double)(total / RateList.Length);
        }

        public void InsertNews(int index)
        {
            Calculate();
            var newsItem = new NewsItem()
            {
                Id = id,
                Author = author,
                Content = content,
                PublishDate = publishDate,
                Title = title,
                AverageRate = averageRate
            };
            ArrayList[index] = newsItem;
        }
    }
}
