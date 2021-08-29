namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageURL { get; set; }

        public string SubstringName()
        {
            if (Name.Length < 24) return Name;
            return $"{ Name.Substring(0, 21) } ...";
        }

        public string SubstringDescription()
        {
            if (Description.Length < 355) return Description;
            return $"{ Description.Substring(0, 352) } ...";
        }
    }
}
