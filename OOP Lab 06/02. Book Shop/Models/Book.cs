using System;
using System.Text;

namespace BookShop.Models
{
    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public virtual string Author
        {
            get => author;
            protected set
            {
                string surname = value.Split(' ')[1];

                if (char.IsDigit(surname[0]))
                    throw new ArgumentException("Author not valid!");
                author = value;
            }
        }

        public virtual string Title
        {
            get => title;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Title not valid!");
                title = value;
            }
        }

        public virtual decimal Price
        {
            get => price;
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Price not valid!");
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();

            strBuilder
                .AppendLine($"Type: {GetType().Name}")
                .AppendLine($"Title: {Title}")
                .AppendLine($"Author: {Author}")
                .AppendLine($"Price: {Price:0.00}");

            return strBuilder.ToString().TrimEnd();
        }
    }
}
