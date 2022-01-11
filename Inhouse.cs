using System;

namespace C968Project
{
    public class Inhouse : Part
    {
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, string source) : base(partID, name, price, inStock, min, max, source)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = Convert.ToInt32(source);
        }

        public int MachineID
        {
            get => default;
            set
            {
            }
        }

    }
}