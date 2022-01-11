namespace C968Project
{
    partial class AddPartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPartScreen));
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.partIDText = new System.Windows.Forms.TextBox();
            this.partNameText = new System.Windows.Forms.TextBox();
            this.partInventoryText = new System.Windows.Forms.TextBox();
            this.partPriceText = new System.Windows.Forms.TextBox();
            this.partMaxText = new System.Windows.Forms.TextBox();
            this.partMinText = new System.Windows.Forms.TextBox();
            this.partSourceText = new System.Windows.Forms.TextBox();
            this.IDPartLabel = new System.Windows.Forms.Label();
            this.NamePartLabel = new System.Windows.Forms.Label();
            this.InvPartLabel = new System.Windows.Forms.Label();
            this.PricePartLabel = new System.Windows.Forms.Label();
            this.MaxPartLabel = new System.Windows.Forms.Label();
            this.MinPartLabel = new System.Windows.Forms.Label();
            this.SourceIDLabel = new System.Windows.Forms.Label();
            this.SavePartClick = new System.Windows.Forms.Button();
            this.CancelAddPartClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Enabled = false;
            this.AddPartLabel.Location = new System.Drawing.Point(13, 10);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(48, 13);
            this.AddPartLabel.TabIndex = 0;
            this.AddPartLabel.Text = "Add Part";
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(109, 9);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 1;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(193, 9);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 2;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // partIDText
            // 
            this.partIDText.Location = new System.Drawing.Point(109, 69);
            this.partIDText.Name = "partIDText";
            this.partIDText.ReadOnly = true;
            this.partIDText.Size = new System.Drawing.Size(164, 20);
            this.partIDText.TabIndex = 3;
            // 
            // partNameText
            // 
            this.partNameText.Location = new System.Drawing.Point(109, 105);
            this.partNameText.Name = "partNameText";
            this.partNameText.Size = new System.Drawing.Size(164, 20);
            this.partNameText.TabIndex = 4;
            // 
            // partInventoryText
            // 
            this.partInventoryText.Location = new System.Drawing.Point(109, 143);
            this.partInventoryText.Name = "partInventoryText";
            this.partInventoryText.Size = new System.Drawing.Size(164, 20);
            this.partInventoryText.TabIndex = 5;
            // 
            // partPriceText
            // 
            this.partPriceText.Location = new System.Drawing.Point(109, 179);
            this.partPriceText.Name = "partPriceText";
            this.partPriceText.Size = new System.Drawing.Size(164, 20);
            this.partPriceText.TabIndex = 6;
            // 
            // partMaxText
            // 
            this.partMaxText.Location = new System.Drawing.Point(109, 215);
            this.partMaxText.Name = "partMaxText";
            this.partMaxText.Size = new System.Drawing.Size(53, 20);
            this.partMaxText.TabIndex = 7;
            // 
            // partMinText
            // 
            this.partMinText.Location = new System.Drawing.Point(220, 215);
            this.partMinText.Name = "partMinText";
            this.partMinText.Size = new System.Drawing.Size(53, 20);
            this.partMinText.TabIndex = 8;
            // 
            // partSourceText
            // 
            this.partSourceText.Location = new System.Drawing.Point(109, 251);
            this.partSourceText.Name = "partSourceText";
            this.partSourceText.Size = new System.Drawing.Size(164, 20);
            this.partSourceText.TabIndex = 9;
            // 
            // IDPartLabel
            // 
            this.IDPartLabel.AutoSize = true;
            this.IDPartLabel.Location = new System.Drawing.Point(77, 72);
            this.IDPartLabel.Name = "IDPartLabel";
            this.IDPartLabel.Size = new System.Drawing.Size(18, 13);
            this.IDPartLabel.TabIndex = 10;
            this.IDPartLabel.Text = "ID";
            // 
            // NamePartLabel
            // 
            this.NamePartLabel.AutoSize = true;
            this.NamePartLabel.Location = new System.Drawing.Point(60, 108);
            this.NamePartLabel.Name = "NamePartLabel";
            this.NamePartLabel.Size = new System.Drawing.Size(35, 13);
            this.NamePartLabel.TabIndex = 11;
            this.NamePartLabel.Text = "Name";
            // 
            // InvPartLabel
            // 
            this.InvPartLabel.AutoSize = true;
            this.InvPartLabel.Location = new System.Drawing.Point(44, 146);
            this.InvPartLabel.Name = "InvPartLabel";
            this.InvPartLabel.Size = new System.Drawing.Size(51, 13);
            this.InvPartLabel.TabIndex = 12;
            this.InvPartLabel.Text = "Inventory";
            // 
            // PricePartLabel
            // 
            this.PricePartLabel.AutoSize = true;
            this.PricePartLabel.Location = new System.Drawing.Point(38, 182);
            this.PricePartLabel.Name = "PricePartLabel";
            this.PricePartLabel.Size = new System.Drawing.Size(57, 13);
            this.PricePartLabel.TabIndex = 13;
            this.PricePartLabel.Text = "Price/Cost";
            // 
            // MaxPartLabel
            // 
            this.MaxPartLabel.AutoSize = true;
            this.MaxPartLabel.Location = new System.Drawing.Point(68, 218);
            this.MaxPartLabel.Name = "MaxPartLabel";
            this.MaxPartLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxPartLabel.TabIndex = 14;
            this.MaxPartLabel.Text = "Max";
            // 
            // MinPartLabel
            // 
            this.MinPartLabel.AutoSize = true;
            this.MinPartLabel.Location = new System.Drawing.Point(181, 218);
            this.MinPartLabel.Name = "MinPartLabel";
            this.MinPartLabel.Size = new System.Drawing.Size(24, 13);
            this.MinPartLabel.TabIndex = 15;
            this.MinPartLabel.Text = "Min";
            // 
            // SourceIDLabel
            // 
            this.SourceIDLabel.AutoSize = true;
            this.SourceIDLabel.Location = new System.Drawing.Point(23, 254);
            this.SourceIDLabel.Name = "SourceIDLabel";
            this.SourceIDLabel.Size = new System.Drawing.Size(62, 13);
            this.SourceIDLabel.TabIndex = 16;
            this.SourceIDLabel.Text = "Machine ID";
            // 
            // SavePartClick
            // 
            this.SavePartClick.BackColor = System.Drawing.Color.White;
            this.SavePartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavePartClick.Location = new System.Drawing.Point(157, 300);
            this.SavePartClick.Name = "SavePartClick";
            this.SavePartClick.Size = new System.Drawing.Size(55, 23);
            this.SavePartClick.TabIndex = 17;
            this.SavePartClick.Text = "Save";
            this.SavePartClick.UseVisualStyleBackColor = false;
            this.SavePartClick.Click += new System.EventHandler(this.SavePartClick_Click);
            // 
            // CancelAddPartClick
            // 
            this.CancelAddPartClick.BackColor = System.Drawing.Color.White;
            this.CancelAddPartClick.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelAddPartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAddPartClick.Location = new System.Drawing.Point(218, 300);
            this.CancelAddPartClick.Name = "CancelAddPartClick";
            this.CancelAddPartClick.Size = new System.Drawing.Size(55, 23);
            this.CancelAddPartClick.TabIndex = 18;
            this.CancelAddPartClick.Text = "Cancel";
            this.CancelAddPartClick.UseVisualStyleBackColor = false;
            this.CancelAddPartClick.Click += new System.EventHandler(this.CancelAddPartClick_Click);
            // 
            // AddPartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.CancelButton = this.CancelAddPartClick;
            this.ClientSize = new System.Drawing.Size(306, 337);
            this.Controls.Add(this.CancelAddPartClick);
            this.Controls.Add(this.SavePartClick);
            this.Controls.Add(this.SourceIDLabel);
            this.Controls.Add(this.MinPartLabel);
            this.Controls.Add(this.MaxPartLabel);
            this.Controls.Add(this.PricePartLabel);
            this.Controls.Add(this.InvPartLabel);
            this.Controls.Add(this.NamePartLabel);
            this.Controls.Add(this.IDPartLabel);
            this.Controls.Add(this.partSourceText);
            this.Controls.Add(this.partMinText);
            this.Controls.Add(this.partMaxText);
            this.Controls.Add(this.partPriceText);
            this.Controls.Add(this.partInventoryText);
            this.Controls.Add(this.partNameText);
            this.Controls.Add(this.partIDText);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Controls.Add(this.AddPartLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddPartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.TextBox partIDText;
        private System.Windows.Forms.TextBox partNameText;
        private System.Windows.Forms.TextBox partInventoryText;
        private System.Windows.Forms.TextBox partPriceText;
        private System.Windows.Forms.TextBox partMaxText;
        private System.Windows.Forms.TextBox partMinText;
        private System.Windows.Forms.TextBox partSourceText;
        private System.Windows.Forms.Label IDPartLabel;
        private System.Windows.Forms.Label NamePartLabel;
        private System.Windows.Forms.Label InvPartLabel;
        private System.Windows.Forms.Label PricePartLabel;
        private System.Windows.Forms.Label MaxPartLabel;
        private System.Windows.Forms.Label MinPartLabel;
        private System.Windows.Forms.Label SourceIDLabel;
        private System.Windows.Forms.Button SavePartClick;
        private System.Windows.Forms.Button CancelAddPartClick;
    }
}