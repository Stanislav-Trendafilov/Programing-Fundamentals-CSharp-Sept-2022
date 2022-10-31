using System;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]input = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(": ")
                    .ToArray();
                string command = cmdArgs[0];
                if (command=="Edit")
                {
                    article.Content = cmdArgs[1];
                }
                else if (command == "ChangeAuthor")
                {
                    article.Author = cmdArgs[1];
                }
                else if (command == "Rename")
                {
                    article.Title = cmdArgs[1];
                }
            }
            Console.WriteLine(article.ToString());
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
