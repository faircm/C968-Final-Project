using System.ComponentModel;

namespace C968Project
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static void InitializeInventory()
        {
            //Initialize method avoids complications caused by using Inventory constructor
            AllParts.Add(new Inhouse(1, "headphone drivers", 5.99m, 50, 20, 400, "1"));
            AllParts.Add(new Inhouse(2, "headphone frame", 3.99m, 50, 20, 400, "2"));
            AllParts.Add(new Outsourced(3, "headphone i/o wire", 2.99m, 50, 20, 400, "wires, inc."));
            AllParts.Add(new Outsourced(4, "ear pads", 2.99m, 50, 20, 400, "soft thingz"));
            AllParts.Add(new Inhouse(5, "chair frame", 10.99m, 20, 30, 300, "2"));
            AllParts.Add(new Inhouse(6, "chair wheels", 5.99m, 50, 20, 400, "3"));
            AllParts.Add(new Outsourced(7, "chair cushion", 14.99m, 50, 20, 300, "soft thingz"));

            Products.Add(new Product(1, "headphones", 24.99m, 100, 10, 200));
            Products.Add(new Product(2, "desk chair", 59.99m, 75, 8, 150));
            Products.Add(new Product(3, "monitor stand", 14.99m, 120, 10, 220));
            Products.Add(new Product(4, "mousepad", 4.99m, 150, 20, 300));
        }

        public static void addProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        public static bool removeProduct(int productID)
        {
            Product removeProduct = lookupProduct(productID);
            return Products.Remove(removeProduct);
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    return product;
                }
            }
            return null;
        }

        public static void updateProduct(int productID, Product newProduct)
        {
            Product oldProduct = lookupProduct(productID);
            oldProduct.AssociatedParts = newProduct.AssociatedParts;
            oldProduct.Name = newProduct.Name;
            oldProduct.Price = newProduct.Price;
            oldProduct.InStock = newProduct.InStock;
            oldProduct.Min = newProduct.Min;
            oldProduct.Max = newProduct.Max;
        }

        public static void addPart(Part newPart)
        {
            AllParts.Add(newPart);
        }

        public static bool deletePart(Part deletePart)
        {
            return AllParts.Remove(deletePart);
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }

        public static void updatePart(int partID, Part newPart)
        {
            Part oldPart = lookupPart(partID);
            AllParts.Remove(oldPart);
            AllParts.Add(newPart);
        }
    }
}