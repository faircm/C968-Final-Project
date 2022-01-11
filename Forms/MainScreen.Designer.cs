namespace C968Project
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.AllPartsList = new System.Windows.Forms.DataGridView();
            this.AllProductsList = new System.Windows.Forms.DataGridView();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.PartSearch = new System.Windows.Forms.Button();
            this.ProductSearchText = new System.Windows.Forms.TextBox();
            this.ProductSearch = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.AddPartClick = new System.Windows.Forms.Button();
            this.ModifyPartClick = new System.Windows.Forms.Button();
            this.DeletePartClick = new System.Windows.Forms.Button();
            this.DeleteProductClick = new System.Windows.Forms.Button();
            this.ModifyProductClick = new System.Windows.Forms.Button();
            this.AddProductClick = new System.Windows.Forms.Button();
            this.ExitMainScreenClick = new System.Windows.Forms.Button();
            this.PartSearchText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPartsList
            // 
            this.AllPartsList.AllowUserToAddRows = false;
            this.AllPartsList.AllowUserToDeleteRows = false;
            this.AllPartsList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AllPartsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.AllPartsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllPartsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllPartsList.Location = new System.Drawing.Point(12, 90);
            this.AllPartsList.MultiSelect = false;
            this.AllPartsList.Name = "AllPartsList";
            this.AllPartsList.ReadOnly = true;
            this.AllPartsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllPartsList.RowHeadersWidth = 20;
            this.AllPartsList.Size = new System.Drawing.Size(430, 150);
            this.AllPartsList.TabIndex = 0;
            // 
            // AllProductsList
            // 
            this.AllProductsList.AllowUserToAddRows = false;
            this.AllProductsList.AllowUserToDeleteRows = false;
            this.AllProductsList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AllProductsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.AllProductsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProductsList.Location = new System.Drawing.Point(462, 90);
            this.AllProductsList.MultiSelect = false;
            this.AllProductsList.Name = "AllProductsList";
            this.AllProductsList.ReadOnly = true;
            this.AllProductsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AllProductsList.RowHeadersWidth = 20;
            this.AllProductsList.Size = new System.Drawing.Size(430, 150);
            this.AllProductsList.TabIndex = 1;
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Enabled = false;
            this.PartsLabel.Location = new System.Drawing.Point(13, 64);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(31, 13);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "Parts";
            // 
            // PartSearch
            // 
            this.PartSearch.BackColor = System.Drawing.Color.White;
            this.PartSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartSearch.Location = new System.Drawing.Point(281, 54);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(55, 23);
            this.PartSearch.TabIndex = 4;
            this.PartSearch.Text = "Search";
            this.PartSearch.UseVisualStyleBackColor = false;
            this.PartSearch.Click += new System.EventHandler(this.PartSearch_Click);
            // 
            // ProductSearchText
            // 
            this.ProductSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductSearchText.BackColor = System.Drawing.Color.White;
            this.ProductSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductSearchText.ForeColor = System.Drawing.Color.Black;
            this.ProductSearchText.Location = new System.Drawing.Point(792, 56);
            this.ProductSearchText.Name = "ProductSearchText";
            this.ProductSearchText.Size = new System.Drawing.Size(100, 20);
            this.ProductSearchText.TabIndex = 7;
            this.ProductSearchText.Text = " Enter Product ID";
            this.ProductSearchText.Enter += new System.EventHandler(this.ProductSearchText_Enter);
            // 
            // ProductSearch
            // 
            this.ProductSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductSearch.BackColor = System.Drawing.Color.White;
            this.ProductSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductSearch.Location = new System.Drawing.Point(731, 55);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(55, 23);
            this.ProductSearch.TabIndex = 6;
            this.ProductSearch.Text = "Search";
            this.ProductSearch.UseVisualStyleBackColor = false;
            this.ProductSearch.Click += new System.EventHandler(this.ProductSearch_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Enabled = false;
            this.productsLabel.Location = new System.Drawing.Point(459, 64);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(49, 13);
            this.productsLabel.TabIndex = 8;
            this.productsLabel.Text = "Products";
            // 
            // AddPartClick
            // 
            this.AddPartClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPartClick.BackColor = System.Drawing.Color.White;
            this.AddPartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPartClick.Location = new System.Drawing.Point(265, 246);
            this.AddPartClick.Name = "AddPartClick";
            this.AddPartClick.Size = new System.Drawing.Size(55, 25);
            this.AddPartClick.TabIndex = 9;
            this.AddPartClick.Text = "Add";
            this.AddPartClick.UseVisualStyleBackColor = false;
            this.AddPartClick.Click += new System.EventHandler(this.AddPartClick_Click);
            // 
            // ModifyPartClick
            // 
            this.ModifyPartClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyPartClick.BackColor = System.Drawing.Color.White;
            this.ModifyPartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyPartClick.Location = new System.Drawing.Point(326, 246);
            this.ModifyPartClick.Name = "ModifyPartClick";
            this.ModifyPartClick.Size = new System.Drawing.Size(55, 25);
            this.ModifyPartClick.TabIndex = 10;
            this.ModifyPartClick.Text = "Modify";
            this.ModifyPartClick.UseVisualStyleBackColor = false;
            this.ModifyPartClick.Click += new System.EventHandler(this.ModifyPartClick_Click);
            // 
            // DeletePartClick
            // 
            this.DeletePartClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletePartClick.BackColor = System.Drawing.Color.White;
            this.DeletePartClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePartClick.Location = new System.Drawing.Point(387, 246);
            this.DeletePartClick.Name = "DeletePartClick";
            this.DeletePartClick.Size = new System.Drawing.Size(55, 25);
            this.DeletePartClick.TabIndex = 11;
            this.DeletePartClick.Text = "Delete";
            this.DeletePartClick.UseVisualStyleBackColor = false;
            this.DeletePartClick.Click += new System.EventHandler(this.DeletePartClick_Click);
            // 
            // DeleteProductClick
            // 
            this.DeleteProductClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductClick.BackColor = System.Drawing.Color.White;
            this.DeleteProductClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductClick.Location = new System.Drawing.Point(837, 246);
            this.DeleteProductClick.Name = "DeleteProductClick";
            this.DeleteProductClick.Size = new System.Drawing.Size(55, 25);
            this.DeleteProductClick.TabIndex = 14;
            this.DeleteProductClick.Text = "Delete";
            this.DeleteProductClick.UseVisualStyleBackColor = false;
            this.DeleteProductClick.Click += new System.EventHandler(this.DeleteProductClick_Click);
            // 
            // ModifyProductClick
            // 
            this.ModifyProductClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ModifyProductClick.BackColor = System.Drawing.Color.White;
            this.ModifyProductClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyProductClick.Location = new System.Drawing.Point(776, 246);
            this.ModifyProductClick.Name = "ModifyProductClick";
            this.ModifyProductClick.Size = new System.Drawing.Size(55, 25);
            this.ModifyProductClick.TabIndex = 13;
            this.ModifyProductClick.Text = "Modify";
            this.ModifyProductClick.UseVisualStyleBackColor = false;
            this.ModifyProductClick.Click += new System.EventHandler(this.ModifyProductClick_Click);
            // 
            // AddProductClick
            // 
            this.AddProductClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductClick.BackColor = System.Drawing.Color.White;
            this.AddProductClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductClick.Location = new System.Drawing.Point(715, 246);
            this.AddProductClick.Name = "AddProductClick";
            this.AddProductClick.Size = new System.Drawing.Size(55, 25);
            this.AddProductClick.TabIndex = 12;
            this.AddProductClick.Text = "Add";
            this.AddProductClick.UseVisualStyleBackColor = false;
            this.AddProductClick.Click += new System.EventHandler(this.AddProductClick_Click);
            // 
            // ExitMainScreenClick
            // 
            this.ExitMainScreenClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitMainScreenClick.BackColor = System.Drawing.Color.White;
            this.ExitMainScreenClick.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitMainScreenClick.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitMainScreenClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitMainScreenClick.Location = new System.Drawing.Point(837, 277);
            this.ExitMainScreenClick.Name = "ExitMainScreenClick";
            this.ExitMainScreenClick.Size = new System.Drawing.Size(55, 25);
            this.ExitMainScreenClick.TabIndex = 15;
            this.ExitMainScreenClick.Text = "Exit";
            this.ExitMainScreenClick.UseVisualStyleBackColor = false;
            this.ExitMainScreenClick.Click += new System.EventHandler(this.ExitMainScreenClick_Click);
            // 
            // PartSearchText
            // 
            this.PartSearchText.BackColor = System.Drawing.Color.White;
            this.PartSearchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartSearchText.ForeColor = System.Drawing.Color.Black;
            this.PartSearchText.Location = new System.Drawing.Point(342, 55);
            this.PartSearchText.Name = "PartSearchText";
            this.PartSearchText.Size = new System.Drawing.Size(100, 20);
            this.PartSearchText.TabIndex = 5;
            this.PartSearchText.Text = " Enter Part ID";
            this.PartSearchText.Enter += new System.EventHandler(this.PartSearchText_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(160)))));
            this.CancelButton = this.ExitMainScreenClick;
            this.ClientSize = new System.Drawing.Size(904, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitMainScreenClick);
            this.Controls.Add(this.DeleteProductClick);
            this.Controls.Add(this.ModifyProductClick);
            this.Controls.Add(this.AddProductClick);
            this.Controls.Add(this.DeletePartClick);
            this.Controls.Add(this.ModifyPartClick);
            this.Controls.Add(this.AddPartClick);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.ProductSearchText);
            this.Controls.Add(this.ProductSearch);
            this.Controls.Add(this.PartSearchText);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.AllProductsList);
            this.Controls.Add(this.AllPartsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllPartsList;
        private System.Windows.Forms.DataGridView AllProductsList;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Button PartSearch;
        private System.Windows.Forms.TextBox ProductSearchText;
        private System.Windows.Forms.Button ProductSearch;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button AddPartClick;
        private System.Windows.Forms.Button ModifyPartClick;
        private System.Windows.Forms.Button DeletePartClick;
        private System.Windows.Forms.Button DeleteProductClick;
        private System.Windows.Forms.Button ModifyProductClick;
        private System.Windows.Forms.Button AddProductClick;
        private System.Windows.Forms.Button ExitMainScreenClick;
        private System.Windows.Forms.TextBox PartSearchText;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

