namespace BlazorApp1.Models
{
    public class Basket
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public List<Article> Items { get; set; } = new List<Article>();

        public Basket(List<Article> items)
        {
            Items = items;
        }
    }
}
