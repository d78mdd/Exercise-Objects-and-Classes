using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> Phrases = new List<string>();
            List<string> Events = new List<string>();
            List<string> Authors = new List<string>();
            List<string> Cities = new List<string>();

            Phrases.Add("Excellent product.");
            Phrases.Add("Such a great product.");
            Phrases.Add("I always use that product.");
            Phrases.Add("Best product of its category.");
            Phrases.Add("Exceptional product.");
            Phrases.Add("I can't live without this product.");

            Events.Add("Now I feel good.");
            Events.Add("I have succeeded with this product.");
            Events.Add("Makes miracles. I am happy of the results!");
            Events.Add("I cannot believe but now I feel awesome.");
            Events.Add("Try it yourself, I am very satisfied.");
            Events.Add("I feel great!");

            Authors.Add("Diana");
            Authors.Add("Petya");
            Authors.Add("Stella");
            Authors.Add("Elena");
            Authors.Add("Katya");
            Authors.Add("Iva");
            Authors.Add("Annie");
            Authors.Add("Eva");

            Cities.Add("Burgas");
            Cities.Add("Sofia");
            Cities.Add("Plovdiv");
            Cities.Add("Varna");
            Cities.Add("Ruse");

            string phrase;
            string messageEvent;
            string author;
            string city;

            Random rnd = new Random();
            int index;

            for (int i = 0; i < n; i++)
            {
                index = rnd.Next(Phrases.Count());
                phrase = Phrases.ElementAt(index);

                index = rnd.Next(Events.Count());
                messageEvent = Events.ElementAt(index);

                index = rnd.Next(Authors.Count());
                author = Authors.ElementAt(index);

                index = rnd.Next(Cities.Count());
                city = Cities.ElementAt(index);

                Console.WriteLine($"{phrase} {messageEvent} {author} - {city}.");
            }
  
        }
    }
}
