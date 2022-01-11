using System;
using System.Windows.Forms;

namespace C968Project
{
    public partial class AddPartScreen : Form
    {

        public AddPartScreen()
        {
            InitializeComponent();
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceIDLabel.Text = "Machine ID";
            partIDText.Text = (Inventory.AllParts.Count + 1).ToString();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceIDLabel.Text = "Company Name";
            partIDText.Text = (Inventory.AllParts.Count + 1).ToString();
        }

        private void CancelAddPartClick_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SavePartClick_Click(object sender, EventArgs e)
        {
            int inStock, max, min;
            decimal price;
            string name = partNameText.Text;

            try
            {
                inStock = Convert.ToInt32(partInventoryText.Text);
                price = Convert.ToDecimal(partPriceText.Text);
                max = Convert.ToInt32(partMaxText.Text);
                min = Convert.ToInt32(partMinText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Ensure your Inventory, Price, Min and Max inputs do not contain invalid values (i.e., letters, symbols other than '.')", "INVALID ENTRY");
                return;
            }

            inStock = Convert.ToInt32(partInventoryText.Text);
            price = Convert.ToDecimal(partPriceText.Text);
            max = Convert.ToInt32(partMaxText.Text);
            min = Convert.ToInt32(partMinText.Text);

            if (min > max)
            {
                MessageBox.Show("The minimum stock value must be lower than the maximum stock value.", "INVALID MIN OR MAX STOCK");
                return;
            }
            else if (min > inStock || max < inStock)
            {
                MessageBox.Show("The currenty number of items in stock must be between the minimum and maximum stock values.", "INVALID MIN, MAX OR CURRENT STOCK");
                return;
            }

            if (InHouseRadio.Checked)
            {
                int machineID;
                try
                {
                    machineID = Convert.ToInt32(partSourceText.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Machine IDs must only contain numeric values", "INVALID MACHINE ID");
                    return;
                }

                machineID = Convert.ToInt32(partSourceText.Text);
                Inhouse newInhousePart = new Inhouse(Inventory.AllParts.Count + 1, name, price, inStock, min, max, machineID.ToString());
                Inventory.addPart(newInhousePart);
            }
            else if (OutsourcedRadio.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(Inventory.AllParts.Count + 1, name, price, inStock, min, max, partSourceText.Text);
                Inventory.addPart(newOutsourcedPart);
            }
            this.Hide();
        }
    }
}
