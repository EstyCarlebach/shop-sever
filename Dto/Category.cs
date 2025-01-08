namespace Dto
{
    public class Category
    {
        public int CatId { get; set; }

        public string CatName { get; set; } = null!;

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
