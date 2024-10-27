using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();

            string[] tokensArticle = input.Split(',');

            string title = tokensArticle[0];
            string content = tokensArticle[1].Trim();
            string author = tokensArticle[2].Trim();

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokensCommand = Console.ReadLine().Split(':');

                string command = tokensCommand[0];
                string data = tokensCommand[1].Trim();

                if (command.StartsWith("Edit"))
                {
                    article.Edit(data);
                }
                else if (command.StartsWith("ChangeAuthor"))
                {
                    article.ChangeAuthor(data);
                }
                else // command starts with "Rename"
                {
                    article.Rename(data);
                }

            }

            Console.WriteLine(article.ToString());
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

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override String ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
