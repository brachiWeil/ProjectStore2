namespace Store.Model
{
    public class Products
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MinSize { get; set; }
        public int MaxSize { get; set; }
       //כמות במלאי
        public int QtyInventory { get; set; }
    }
}
