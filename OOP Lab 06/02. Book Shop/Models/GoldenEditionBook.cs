namespace BookShop.Models
{
    public class GoldenEditionBook : Book
    {
        public override decimal Price => base.Price * 1.3M;

        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }
    }
}
