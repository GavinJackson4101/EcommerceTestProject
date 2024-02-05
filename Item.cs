namespace Test1.Models
{
    public class Item
    {
        //public List<Item>? Items { get; set; }
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Picture { get; set; }

        public List<string>? Sizes { get; set; }
        public List<string>? Colors { get; set; }

        public decimal Price { get; set; }

        public int? Discount { get; set;}

        public int? Qty { get; set; }

    }
}
