namespace BlazorApp1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }

        public Article(string name, string desc, decimal price, int id)
        {
            Name = name;
            Description = desc;
            Price = price;
            Id = id;
        }
    }
}
