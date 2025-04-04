namespace BookShop.Models.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string price { get; set; }   
        public bool Available {  get; set; }
    }
}
