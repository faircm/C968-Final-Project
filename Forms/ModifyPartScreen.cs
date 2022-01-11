using System;
using System.Windows.Forms;

namespace C968Project
{
    public partial class ModifyPartScreen : Form
    {
        public ModifyPartScreen(Outsourced oldPart)
        {
            InitializeComponent();
            OutsourcedRadio.Checked = true;
            PartIDText.Text = oldPart.PartID.ToString();
            PartNameText.Text = oldPart.Name;
            PartStockText.Text = oldPart.InStock.ToString();
            PartPriceText.Text = oldPart.Price.ToString();
            PartMinText.Text = oldPart.Min.ToString();
            PartMaxText.Text = oldPart.Max.ToString();
            PartSourceText.Text = oldPart.Source;
            SourceIDLabel.Text = "Company Name:";
        }

        public ModifyPartScreen(Inhouse oldPart)
        {
            InitializeComponent();
            InHouseRadio.Checked = true;
            PartIDText.Text = oldPart.PartID.ToString();
            PartNameText.Text = oldPart.Name;
            PartStockText.Text = oldPart.InStock.ToString();
            PartPriceText.Text = oldPart.Price.ToString();
            PartMinText.Text = oldPart.Min.ToString();
            PartMaxText.Text = oldPart.Max.ToString();
            PartSourceText.Text = oldPart.Source.ToString();

        }

        private void CancelAddPartClick_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SavePartClick_Click(object sender, EventArgs e)
        {
            int inStock, max, min;
            int partId = Convert.ToInt32(PartIDText.Text);
            decimal price;
            string name = PartNameText.Text;

            try
            {
                inStock = Convert.ToInt32(PartStockText.Text);
                price = Convert.ToDecimal(PartPriceText.Text);
                max = Convert.ToInt32(PartMaxText.Text);
                min = Convert.ToInt32(PartMinText.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure your Inventory, Price, Min and Max inputs do not contain invalid values (i.e., letters, symbols other than '.')", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            inStock = Convert.ToInt32(PartStockText.Text);
            price = Convert.ToDecimal(PartPriceText.Text);
            max = Convert.ToInt32(PartMaxText.Text);
            min = Convert.ToInt32(PartMinText.Text);

            if (min > max)
            {
                MessageBox.Show("The minimum stock value must be lower than the maximum stock value.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (min > inStock || max < inStock)
            {
                MessageBox.Show("The currenty number of items in stock must be between the minimum and maximum stock values.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (InHouseRadio.Checked)
            {
                int machineID;
                try
                {
                    machineID = Convert.ToInt32(PartSourceText.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Machine IDs must only contain numeric values", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                machineID = Convert.ToInt32(PartSourceText.Text);
                Inhouse newInhousePart = new Inhouse(partId, name, price, inStock, min, max, machineID.ToString());
                Inventory.updatePart(partId, newInhousePart);
            }
            else if (OutsourcedRadio.Checked)
            {
                Outsourced newOutsourcedPart = new Outsourced(partId, name, price, inStock, min, max, PartSourceText.Text);
                Inventory.updatePart(partId, newOutsourcedPart);
            }
            this.Hide();
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceIDLabel.Text = "Company Name";
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            SourceIDLabel.Text = "Machine ID";
        }
    }
}
