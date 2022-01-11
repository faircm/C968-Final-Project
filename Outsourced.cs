namespace C968Project
{
    public class Outsourced : Part
    {
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string source) : base(partID, name, price, inStock, min, max, source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = source;

        }

        public string CompanyName
        {
            get => default;
            set
            {
            }
        }
    }
}