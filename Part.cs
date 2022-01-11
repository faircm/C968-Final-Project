namespace C968Project
{
    public abstract class Part
    {
        public Part(int partID, string name, decimal price, int inStock, int min, int max, string source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            Source = source;
        }

        public int PartID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int InStock { get; set; }

        public int Min { get; set; }

        public int Max { get; set; }

        public string Source { get; set; }
    }

}