﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                        .Split(", ")
                        .ToArray();
                Article article = new Article(input[0], input[1], input[2]);
                articles.Add(article);
            }
            for (int i = 0; i < articles.Count; i++)
            {
                Console.WriteLine(articles[i].ToString());
            }
            
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{ this.Title} - { this.Content}: {this.Author}";
        }
    }
}
