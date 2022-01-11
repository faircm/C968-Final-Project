using System;
using System.Windows.Forms;

namespace C968Project
{
    public partial class MainScreen : Form
    {
        AddPartScreen addPartScreen = new AddPartScreen();
        AddProductScreen addProductScreen = new AddProductScreen();
        Inventory inventory = new Inventory();

        public MainScreen()
        {
            InitializeComponent();
            Inventory.InitializeInventory();

            AllPartsList.DataSource = Inventory.AllParts;
            AllProductsList.DataSource = Inventory.Products;
        }

        private void AddPartClick_Click(object sender, EventArgs e)
        {
            addPartScreen.Show();
        }

        private void ExitMainScreenClick_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ModifyPartClick_Click(object sender, EventArgs e)
        {
            if (AllPartsList.CurrentRow.DataBoundItem.GetType() == typeof(C968Project.Inhouse))
            {
                Inhouse newInhousePart = (Inhouse)AllPartsList.CurrentRow.DataBoundItem;
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen(newInhousePart);
                modifyPartScreen.Show();
            }
            else
            {
                Outsourced newOutsourcedPart = (Outsourced)AllPartsList.CurrentRow.DataBoundItem;
                ModifyPartScreen modifyPartScreen = new ModifyPartScreen(newOutsourcedPart);
                modifyPartScreen.Show();
            }
        }

        private void AddProductClick_Click(object sender, EventArgs e)
        {
            addProductScreen.Show();
        }

        private void ModifyProductClick_Click(object sender, EventArgs e)
        {
            ModifyProductScreen modifyProductScreen = new ModifyProductScreen((Product)AllProductsList.CurrentRow.DataBoundItem);
            modifyProductScreen.Show();
        }

        private void DeletePartClick_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Are you sure you want to delete? Deleted parts cannot be recovered.", "Delete Part", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (response == DialogResult.OK)
            {
                AllPartsList.Rows.Remove(AllPartsList.CurrentRow);
            }
        }

        private void DeleteProductClick_Click(object sender, EventArgs e)
        {
            Product deleteProduct = (Product)AllProductsList.CurrentRow.DataBoundItem;
            if (deleteProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Please remove all associated parts from Product before deleting.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult response = MessageBox.Show("Are you sure you want to delete? Deleted products cannot be recovered.", "Delete Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (response == DialogResult.OK)
                {
                    Inventory.removeProduct(deleteProduct.ProductID);
                }
            }
        }

        private void PartSearchText_Enter(object sender, EventArgs e)
        {
            PartSearchText.Clear();
        }

        private void PartSearch_Click(object sender, EventArgs e)
        {
            int searchedPartID;
            try
            {
                searchedPartID = Convert.ToInt32(PartSearchText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric characters into the search box.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            searchedPartID = Convert.ToInt32(PartSearchText.Text);

            foreach (DataGridViewRow row in AllPartsList.Rows)
            {
                Part currentRow = (Part)row.DataBoundItem;
                if (currentRow.PartID == searchedPartID)
                {
                    AllPartsList.ClearSelection();
                    row.Selected = true;
                }
            }
        }

        private void ProductSearchText_Enter(object sender, EventArgs e)
        {
            ProductSearchText.Clear();
        }

        private void ProductSearch_Click(object sender, EventArgs e)
        {
            int searchedProductID;
            try
            {
                searchedProductID = Convert.ToInt32(ProductSearchText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numeric characters into the search box.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            searchedProductID = Convert.ToInt32(ProductSearchText.Text);

            foreach (DataGridViewRow row in AllProductsList.Rows)
            {
                Product currentRow = (Product)row.DataBoundItem;
                if (currentRow.ProductID == searchedProductID)
                {
                    AllProductsList.ClearSelection();
                    row.Selected = true;
                }
            }
        }
    }
}