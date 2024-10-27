using System;
using System.Collections.Generic;

namespace _3.Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string input = Console.ReadLine().Trim();

                string[] tokens = input.Split(',');

                string title = tokens[0];
                string content = tokens[1].Trim();
                string author = tokens[2].Trim();

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
            
        }
    }

    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override String ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
