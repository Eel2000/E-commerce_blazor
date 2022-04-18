using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class AppService
    {
        public readonly List<Article> Articles = new List<Article>
        {
            new Article("Banana","Food", 5,1),
            new Article("Phone","Electronic", 100,2),
            new Article("Compute (desktop)","Electronic", 300,3),
            new Article("Car","Cars for people", 2000,4)
        };

        public Basket GetBasket { get; set; }

        public List<int> Basket = new List<int>();

        public List<Article>? CompletedBasket = new List<Article>();

        public void Completed()
        {
            CompletedBasket?.Clear();
            foreach (var id in Basket)
            {
                var nameOfItem = Articles.Where(a => a.Id == id).Single();
                CompletedBasket?.Add(nameOfItem);
            }

            CreateMyBasket();
        }

        private void CreateMyBasket()
        {
            GetBasket = new Basket(CompletedBasket);
        }

        public void RemoveItem(Article article)
        {
            Basket.Remove(article.Id);
            Completed();
        }
    }

}
