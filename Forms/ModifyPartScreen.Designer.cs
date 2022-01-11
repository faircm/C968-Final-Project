namespace C968Project
{
    partial class ModifyPartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyPartScreen));
            this.CancelAddPartClick = new System.Windows.Forms.Button();
            this.SavePartClick = new System.Windows.Forms.Button();
            this.SourceIDLabel = new System.Windows.Forms.Label();
            this.MinPartLabel = new System.Windows.Forms.Label();
            this.MaxPartLabel = new System.Windows.Forms.Label();
            this.PricePartLabel = new System.Windows.Forms.Label();
            this.InvPartLabel = new System.Windows.Forms.Label();
            this.NamePartLabel = new System.Windows.Forms.Label();
            this.IDPartLabel = new System.Windows.Forms.Label();
            this.PartSourceText = new System.Windows.Forms.TextBox();
            this.PartMinText = new System.Windows.Forms.TextBox();
            this.PartMaxText = new System.Windows.Forms.TextBox();
            this.PartPriceText = new System.Windows.Forms.TextBox();
            this.PartStockText = new System.Windows.Forms.TextBox();
            this.PartNameText = new System.Windows.Forms.TextBox();
            this.PartIDText = new System.Windows.Forms.TextBox();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.ModifyPartLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelAddPartClick
            // 
            this.CancelAddPartClick.BackColor = System.Drawing.Color.White;
            this.CancelAddPartClick.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddPartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddPartClick.Location = new System.Drawing.Point(217, 299);
            this.CancelAddPartClick.Name = "CancelAddPartClick";
            this.CancelAddPartClick.Size = new System.Drawing.Size(55, 23);
            this.CancelAddPartClick.TabIndex = 37;
            this.CancelAddPartClick.Text = "Cancel";
            this.CancelAddPartClick.UseVisualStyleBackColor = false;
            this.CancelAddPartClick.Click += new System.EventHandler(this.CancelAddPartClick_Click);
            // 
            // SavePartClick
            // 
            this.SavePartClick.BackColor = System.Drawing.Color.White;
            this.SavePartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePartClick.Location = new System.Drawing.Point(156, 299);
            this.SavePartClick.Name = "SavePartClick";
            this.SavePartClick.Size = new System.Drawing.Size(55, 23);
            this.SavePartClick.TabIndex = 36;
            this.SavePartClick.Text = "Save";
            this.SavePartClick.UseVisualStyleBackColor = false;
            this.SavePartClick.Click += new System.EventHandler(this.SavePartClick_Click);
            // 
            // SourceIDLabel
            // 
            this.SourceIDLabel.AutoSize = true;
            this.SourceIDLabel.Location = new System.Drawing.Point(22, 253);
            this.SourceIDLabel.Name = "SourceIDLabel";
            this.SourceIDLabel.Size = new System.Drawing.Size(62, 13);
            this.SourceIDLabel.TabIndex = 35;
            this.SourceIDLabel.Text = "Machine ID";
            // 
            // MinPartLabel
            // 
            this.MinPartLabel.AutoSize = true;
            this.MinPartLabel.Location = new System.Drawing.Point(180, 217);
            this.MinPartLabel.Name = "MinPartLabel";
            this.MinPartLabel.Size = new System.Drawing.Size(24, 13);
            this.MinPartLabel.TabIndex = 34;
            this.MinPartLabel.Text = "Min";
            // 
            // MaxPartLabel
            // 
            this.MaxPartLabel.AutoSize = true;
            this.MaxPartLabel.Location = new System.Drawing.Point(67, 217);
            this.MaxPartLabel.Name = "MaxPartLabel";
            this.MaxPartLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxPartLabel.TabIndex = 33;
            this.MaxPartLabel.Text = "Max";
            // 
            // PricePartLabel
            // 
            this.PricePartLabel.AutoSize = true;
            this.PricePartLabel.Location = new System.Drawing.Point(37, 181);
            this.PricePartLabel.Name = "PricePartLabel";
            this.PricePartLabel.Size = new System.Drawing.Size(57, 13);
            this.PricePartLabel.TabIndex = 32;
            this.PricePartLabel.Text = "Price/Cost";
            // 
            // InvPartLabel
            // 
            this.InvPartLabel.AutoSize = true;
            this.InvPartLabel.Location = new System.Drawing.Point(43, 145);
            this.InvPartLabel.Name = "InvPartLabel";
            this.InvPartLabel.Size = new System.Drawing.Size(51, 13);
            this.InvPartLabel.TabIndex = 31;
            this.InvPartLabel.Text = "Inventory";
            // 
            // NamePartLabel
            // 
            this.NamePartLabel.AutoSize = true;
            this.NamePartLabel.Location = new System.Drawing.Point(59, 107);
            this.NamePartLabel.Name = "NamePartLabel";
            this.NamePartLabel.Size = new System.Drawing.Size(35, 13);
            this.NamePartLabel.TabIndex = 30;
            this.NamePartLabel.Text = "Name";
            // 
            // IDPartLabel
            // 
            this.IDPartLabel.AutoSize = true;
            this.IDPartLabel.Location = new System.Drawing.Point(76, 71);
            this.IDPartLabel.Name = "IDPartLabel";
            this.IDPartLabel.Size = new System.Drawing.Size(18, 13);
            this.IDPartLabel.TabIndex = 29;
            this.IDPartLabel.Text = "ID";
            // 
            // PartSourceText
            // 
            this.PartSourceText.Location = new System.Drawing.Point(108, 250);
            this.PartSourceText.Name = "PartSourceText";
            this.PartSourceText.Size = new System.Drawing.Size(164, 20);
            this.PartSourceText.TabIndex = 28;
            // 
            // PartMinText
            // 
            this.PartMinText.Location = new System.Drawing.Point(219, 214);
            this.PartMinText.Name = "PartMinText";
            this.PartMinText.Size = new System.Drawing.Size(53, 20);
            this.PartMinText.TabIndex = 27;
            // 
            // PartMaxText
            // 
            this.PartMaxText.Location = new System.Drawing.Point(108, 214);
            this.PartMaxText.Name = "PartMaxText";
            this.PartMaxText.Size = new System.Drawing.Size(53, 20);
            this.PartMaxText.TabIndex = 26;
            // 
            // PartPriceText
            // 
            this.PartPriceText.Location = new System.Drawing.Point(108, 178);
            this.PartPriceText.Name = "PartPriceText";
            this.PartPriceText.Size = new System.Drawing.Size(164, 20);
            this.PartPriceText.TabIndex = 25;
            // 
            // PartStockText
            // 
            this.PartStockText.Location = new System.Drawing.Point(108, 142);
            this.PartStockText.Name = "PartStockText";
            this.PartStockText.Size = new System.Drawing.Size(164, 20);
            this.PartStockText.TabIndex = 24;
            // 
            // PartNameText
            // 
            this.PartNameText.Location = new System.Drawing.Point(108, 104);
            this.PartNameText.Name = "PartNameText";
            this.PartNameText.Size = new System.Drawing.Size(164, 20);
            this.PartNameText.TabIndex = 23;
            // 
            // PartIDText
            // 
            this.PartIDText.Location = new System.Drawing.Point(108, 68);
            this.PartIDText.Name = "PartIDText";
            this.PartIDText.ReadOnly = true;
            this.PartIDText.Size = new System.Drawing.Size(164, 20);
            this.PartIDText.TabIndex = 22;
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(192, 8);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 21;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(108, 8);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 20;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // ModifyPartLabel
            // 
            this.ModifyPartLabel.AutoSize = true;
            this.ModifyPartLabel.Enabled = false;
            this.ModifyPartLabel.Location = new System.Drawing.Point(12, 9);
            this.ModifyPartLabel.Name = "ModifyPartLabel";
            this.ModifyPartLabel.Size = new System.Drawing.Size(60, 13);
            this.ModifyPartLabel.TabIndex = 19;
            this.ModifyPartLabel.Text = "Modify Part";
            // 
            // ModifyPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(303, 333);
            this.Controls.Add(this.CancelAddPartClick);
            this.Controls.Add(this.SavePartClick);
            this.Controls.Add(this.SourceIDLabel);
            this.Controls.Add(this.MinPartLabel);
            this.Controls.Add(this.MaxPartLabel);
            this.Controls.Add(this.PricePartLabel);
            this.Controls.Add(this.InvPartLabel);
            this.Controls.Add(this.NamePartLabel);
            this.Controls.Add(this.IDPartLabel);
            this.Controls.Add(this.PartSourceText);
            this.Controls.Add(this.PartMinText);
            this.Controls.Add(this.PartMaxText);
            this.Controls.Add(this.PartPriceText);
            this.Controls.Add(this.PartStockText);
            this.Controls.Add(this.PartNameText);
            this.Controls.Add(this.PartIDText);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.ModifyPartLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyPartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelAddPartClick;
        private System.Windows.Forms.Button SavePartClick;
        private System.Windows.Forms.Label SourceIDLabel;
        private System.Windows.Forms.Label MinPartLabel;
        private System.Windows.Forms.Label MaxPartLabel;
        private System.Windows.Forms.Label PricePartLabel;
        private System.Windows.Forms.Label InvPartLabel;
        private System.Windows.Forms.Label NamePartLabel;
        private System.Windows.Forms.Label IDPartLabel;
        private System.Windows.Forms.TextBox PartSourceText;
        private System.Windows.Forms.TextBox PartMinText;
        private System.Windows.Forms.TextBox PartMaxText;
        private System.Windows.Forms.TextBox PartPriceText;
        private System.Windows.Forms.TextBox PartStockText;
        private System.Windows.Forms.TextBox PartNameText;
        private System.Windows.Forms.TextBox PartIDText;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.Label ModifyPartLabel;
    }
}