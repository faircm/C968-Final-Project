using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace C968Project
{
    public partial class AddProductScreen : Form
    {
        BindingList<Part> addedParts = new BindingList<Part>();

        public AddProductScreen()
        {
            InitializeComponent();
            AssociatedPartsBox.DataSource = addedParts;
            AllPartsBox.DataSource = Inventory.AllParts;
        }

        private void CancelButtonClick_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartClick_Click(object sender, EventArgs e)
        {
            addedParts.Add((Part)AllPartsBox.CurrentRow.DataBoundItem);
        }

        private void DeletePartClick_Click(object sender, EventArgs e)
        {
            addedParts.Remove((Part)AssociatedPartsBox.CurrentRow.DataBoundItem);
        }

        private void SaveProductButtonClick_Click(object sender, EventArgs e)
        {
            int productID = Inventory.Products.Count + 1;
            string productName = NameProductText.Text;
            int productInventory, productMin, productMax;
            decimal productPrice;

            try
            {
                productInventory = Convert.ToInt32(InvProductText.Text);
                productPrice = Convert.ToDecimal(PriceProductText.Text);
                productMin = Convert.ToInt32(MaxProductText.Text);
                productMax = Convert.ToInt32(MinProductText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure your Inventory, Price, Min and Max inputs do not contain invalid values (i.e., letters, symbols other than '.')", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            productInventory = Convert.ToInt32(InvProductText.Text);
            productPrice = Convert.ToDecimal(PriceProductText.Text);
            productMin = Convert.ToInt32(MinProductText.Text);
            productMax = Convert.ToInt32(MaxProductText.Text);

            if (productMin > productMax)
            {
                MessageBox.Show("The minimum stock value must be lower than the maximum stock value.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (productMin > productInventory || productMax < productInventory)
            {
                MessageBox.Show("The currenty number of items in stock must be between the minimum and maximum stock values.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Product newProduct = new Product(productID, productName, productPrice, productInventory, productMin, productMax);
            newProduct.AssociatedParts = addedParts;
            Inventory.addProduct(newProduct);
            this.Hide();
        }

        private void AllPartsSearchClick_Click(object sender, EventArgs e)
        {
            int searchedPartID;
            try
            {
                searchedPartID = Convert.ToInt32(AllPartsSearchText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric characters into the search box.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            searchedPartID = Convert.ToInt32(AllPartsSearchText.Text);

            foreach (DataGridViewRow row in AllPartsBox.Rows)
            {
                Part currentRow = (Part)row.DataBoundItem;
                if (currentRow.PartID == searchedPartID)
                {
                    AllPartsBox.ClearSelection();
                    row.Selected = true;
                }
            }
        }

        private void AllPartsSearchText_Enter(object sender, EventArgs e)
        {
            AllPartsSearchText.Clear();
        }
    }
}
