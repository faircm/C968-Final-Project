namespace C968Project
{
    partial class AddProductScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductScreen));
            this.AllPartsBox = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AssociatedPartsBox = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MinProductLabel = new System.Windows.Forms.Label();
            this.MaxProductLabel = new System.Windows.Forms.Label();
            this.PriceProductLabel = new System.Windows.Forms.Label();
            this.InvProductLabel = new System.Windows.Forms.Label();
            this.NameProductLabel = new System.Windows.Forms.Label();
            this.IDProductLabel = new System.Windows.Forms.Label();
            this.MinProductText = new System.Windows.Forms.TextBox();
            this.MaxProductText = new System.Windows.Forms.TextBox();
            this.PriceProductText = new System.Windows.Forms.TextBox();
            this.InvProductText = new System.Windows.Forms.TextBox();
            this.NameProductText = new System.Windows.Forms.TextBox();
            this.IDProductText = new System.Windows.Forms.TextBox();
            this.AllPartsSearchText = new System.Windows.Forms.TextBox();
            this.AllPartsSearchClick = new System.Windows.Forms.Button();
            this.AddPartClick = new System.Windows.Forms.Button();
            this.DeletePartClick = new System.Windows.Forms.Button();
            this.CancelButtonClick = new System.Windows.Forms.Button();
            this.SaveProductButtonClick = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPartsBox
            // 
            this.AllPartsBox.AllowUserToAddRows = false;
            this.AllPartsBox.AllowUserToDeleteRows = false;
            this.AllPartsBox.AllowUserToOrderColumns = true;
            this.AllPartsBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.AllPartsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsBox.Location = new System.Drawing.Point(232, 48);
            this.AllPartsBox.MultiSelect = false;
            this.AllPartsBox.Name = "AllPartsBox";
            this.AllPartsBox.RowHeadersVisible = false;
            this.AllPartsBox.Size = new System.Drawing.Size(599, 146);
            this.AllPartsBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // AssociatedPartsBox
            // 
            this.AssociatedPartsBox.AllowUserToAddRows = false;
            this.AssociatedPartsBox.AllowUserToDeleteRows = false;
            this.AssociatedPartsBox.AllowUserToOrderColumns = true;
            this.AssociatedPartsBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.AssociatedPartsBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsBox.Location = new System.Drawing.Point(232, 250);
            this.AssociatedPartsBox.MultiSelect = false;
            this.AssociatedPartsBox.Name = "AssociatedPartsBox";
            this.AssociatedPartsBox.RowHeadersVisible = false;
            this.AssociatedPartsBox.Size = new System.Drawing.Size(599, 146);
            this.AssociatedPartsBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Candidate Parts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parts Associated With This Product";
            // 
            // MinProductLabel
            // 
            this.MinProductLabel.AutoSize = true;
            this.MinProductLabel.Location = new System.Drawing.Point(129, 286);
            this.MinProductLabel.Name = "MinProductLabel";
            this.MinProductLabel.Size = new System.Drawing.Size(24, 13);
            this.MinProductLabel.TabIndex = 27;
            this.MinProductLabel.Text = "Min";
            // 
            // MaxProductLabel
            // 
            this.MaxProductLabel.AutoSize = true;
            this.MaxProductLabel.Location = new System.Drawing.Point(40, 286);
            this.MaxProductLabel.Name = "MaxProductLabel";
            this.MaxProductLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxProductLabel.TabIndex = 26;
            this.MaxProductLabel.Text = "Max";
            // 
            // PriceProductLabel
            // 
            this.PriceProductLabel.AutoSize = true;
            this.PriceProductLabel.Location = new System.Drawing.Point(10, 250);
            this.PriceProductLabel.Name = "PriceProductLabel";
            this.PriceProductLabel.Size = new System.Drawing.Size(57, 13);
            this.PriceProductLabel.TabIndex = 25;
            this.PriceProductLabel.Text = "Price/Cost";
            // 
            // InvProductLabel
            // 
            this.InvProductLabel.AutoSize = true;
            this.InvProductLabel.Location = new System.Drawing.Point(16, 214);
            this.InvProductLabel.Name = "InvProductLabel";
            this.InvProductLabel.Size = new System.Drawing.Size(51, 13);
            this.InvProductLabel.TabIndex = 24;
            this.InvProductLabel.Text = "Inventory";
            // 
            // NameProductLabel
            // 
            this.NameProductLabel.AutoSize = true;
            this.NameProductLabel.Location = new System.Drawing.Point(32, 176);
            this.NameProductLabel.Name = "NameProductLabel";
            this.NameProductLabel.Size = new System.Drawing.Size(35, 13);
            this.NameProductLabel.TabIndex = 23;
            this.NameProductLabel.Text = "Name";
            // 
            // IDProductLabel
            // 
            this.IDProductLabel.AutoSize = true;
            this.IDProductLabel.Location = new System.Drawing.Point(49, 140);
            this.IDProductLabel.Name = "IDProductLabel";
            this.IDProductLabel.Size = new System.Drawing.Size(18, 13);
            this.IDProductLabel.TabIndex = 22;
            this.IDProductLabel.Text = "ID";
            // 
            // MinProductText
            // 
            this.MinProductText.Location = new System.Drawing.Point(156, 283);
            this.MinProductText.Name = "MinProductText";
            this.MinProductText.Size = new System.Drawing.Size(45, 20);
            this.MinProductText.TabIndex = 21;
            // 
            // MaxProductText
            // 
            this.MaxProductText.Location = new System.Drawing.Point(81, 283);
            this.MaxProductText.Name = "MaxProductText";
            this.MaxProductText.Size = new System.Drawing.Size(45, 20);
            this.MaxProductText.TabIndex = 20;
            // 
            // PriceProductText
            // 
            this.PriceProductText.Location = new System.Drawing.Point(81, 247);
            this.PriceProductText.Name = "PriceProductText";
            this.PriceProductText.Size = new System.Drawing.Size(120, 20);
            this.PriceProductText.TabIndex = 19;
            // 
            // InvProductText
            // 
            this.InvProductText.Location = new System.Drawing.Point(81, 211);
            this.InvProductText.Name = "InvProductText";
            this.InvProductText.Size = new System.Drawing.Size(120, 20);
            this.InvProductText.TabIndex = 18;
            // 
            // NameProductText
            // 
            this.NameProductText.Location = new System.Drawing.Point(81, 173);
            this.NameProductText.Name = "NameProductText";
            this.NameProductText.Size = new System.Drawing.Size(120, 20);
            this.NameProductText.TabIndex = 17;
            // 
            // IDProductText
            // 
            this.IDProductText.Location = new System.Drawing.Point(81, 137);
            this.IDProductText.Name = "IDProductText";
            this.IDProductText.ReadOnly = true;
            this.IDProductText.Size = new System.Drawing.Size(120, 20);
            this.IDProductText.TabIndex = 16;
            // 
            // AllPartsSearchText
            // 
            this.AllPartsSearchText.Location = new System.Drawing.Point(731, 22);
            this.AllPartsSearchText.Name = "AllPartsSearchText";
            this.AllPartsSearchText.Size = new System.Drawing.Size(100, 20);
            this.AllPartsSearchText.TabIndex = 29;
            this.AllPartsSearchText.Text = " Enter Part ID";
            this.AllPartsSearchText.Enter += new System.EventHandler(this.AllPartsSearchText_Enter);
            // 
            // AllPartsSearchClick
            // 
            this.AllPartsSearchClick.BackColor = System.Drawing.Color.White;
            this.AllPartsSearchClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllPartsSearchClick.Location = new System.Drawing.Point(670, 21);
            this.AllPartsSearchClick.Name = "AllPartsSearchClick";
            this.AllPartsSearchClick.Size = new System.Drawing.Size(55, 23);
            this.AllPartsSearchClick.TabIndex = 28;
            this.AllPartsSearchClick.Text = "Search";
            this.AllPartsSearchClick.UseVisualStyleBackColor = false;
            this.AllPartsSearchClick.Click += new System.EventHandler(this.AllPartsSearchClick_Click);
            // 
            // AddPartClick
            // 
            this.AddPartClick.BackColor = System.Drawing.Color.White;
            this.AddPartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPartClick.Location = new System.Drawing.Point(776, 200);
            this.AddPartClick.Name = "AddPartClick";
            this.AddPartClick.Size = new System.Drawing.Size(55, 23);
            this.AddPartClick.TabIndex = 32;
            this.AddPartClick.Text = "Add";
            this.AddPartClick.UseVisualStyleBackColor = false;
            this.AddPartClick.Click += new System.EventHandler(this.AddPartClick_Click);
            // 
            // DeletePartClick
            // 
            this.DeletePartClick.BackColor = System.Drawing.Color.White;
            this.DeletePartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePartClick.Location = new System.Drawing.Point(776, 402);
            this.DeletePartClick.Name = "DeletePartClick";
            this.DeletePartClick.Size = new System.Drawing.Size(55, 23);
            this.DeletePartClick.TabIndex = 33;
            this.DeletePartClick.Text = "Delete";
            this.DeletePartClick.UseVisualStyleBackColor = false;
            this.DeletePartClick.Click += new System.EventHandler(this.DeletePartClick_Click);
            // 
            // CancelButtonClick
            // 
            this.CancelButtonClick.BackColor = System.Drawing.Color.White;
            this.CancelButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButtonClick.Location = new System.Drawing.Point(776, 442);
            this.CancelButtonClick.Name = "CancelButtonClick";
            this.CancelButtonClick.Size = new System.Drawing.Size(55, 23);
            this.CancelButtonClick.TabIndex = 34;
            this.CancelButtonClick.Text = "Cancel";
            this.CancelButtonClick.UseVisualStyleBackColor = false;
            this.CancelButtonClick.Click += new System.EventHandler(this.CancelButtonClick_Click);
            // 
            // SaveProductButtonClick
            // 
            this.SaveProductButtonClick.BackColor = System.Drawing.Color.White;
            this.SaveProductButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveProductButtonClick.Location = new System.Drawing.Point(715, 442);
            this.SaveProductButtonClick.Name = "SaveProductButtonClick";
            this.SaveProductButtonClick.Size = new System.Drawing.Size(55, 23);
            this.SaveProductButtonClick.TabIndex = 35;
            this.SaveProductButtonClick.Text = "Save";
            this.SaveProductButtonClick.UseVisualStyleBackColor = false;
            this.SaveProductButtonClick.Click += new System.EventHandler(this.SaveProductButtonClick_Click);
            // 
            // AddProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(844, 481);
            this.Controls.Add(this.SaveProductButtonClick);
            this.Controls.Add(this.CancelButtonClick);
            this.Controls.Add(this.DeletePartClick);
            this.Controls.Add(this.AddPartClick);
            this.Controls.Add(this.AllPartsSearchText);
            this.Controls.Add(this.AllPartsSearchClick);
            this.Controls.Add(this.MinProductLabel);
            this.Controls.Add(this.MaxProductLabel);
            this.Controls.Add(this.PriceProductLabel);
            this.Controls.Add(this.InvProductLabel);
            this.Controls.Add(this.NameProductLabel);
            this.Controls.Add(this.IDProductLabel);
            this.Controls.Add(this.MinProductText);
            this.Controls.Add(this.MaxProductText);
            this.Controls.Add(this.PriceProductText);
            this.Controls.Add(this.InvProductText);
            this.Controls.Add(this.NameProductText);
            this.Controls.Add(this.IDProductText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AssociatedPartsBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllPartsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPartsBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AssociatedPartsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MinProductLabel;
        private System.Windows.Forms.Label MaxProductLabel;
        private System.Windows.Forms.Label PriceProductLabel;
        private System.Windows.Forms.Label InvProductLabel;
        private System.Windows.Forms.Label NameProductLabel;
        private System.Windows.Forms.Label IDProductLabel;
        private System.Windows.Forms.TextBox MinProductText;
        private System.Windows.Forms.TextBox MaxProductText;
        private System.Windows.Forms.TextBox PriceProductText;
        private System.Windows.Forms.TextBox InvProductText;
        private System.Windows.Forms.TextBox NameProductText;
        private System.Windows.Forms.TextBox IDProductText;
        private System.Windows.Forms.TextBox AllPartsSearchText;
        private System.Windows.Forms.Button AllPartsSearchClick;
        private System.Windows.Forms.Button AddPartClick;
        private System.Windows.Forms.Button DeletePartClick;
        private System.Windows.Forms.Button CancelButtonClick;
        private System.Windows.Forms.Button SaveProductButtonClick;
    }
}