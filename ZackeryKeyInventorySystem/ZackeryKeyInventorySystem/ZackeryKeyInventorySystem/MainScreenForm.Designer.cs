namespace ZackeryKeyInventorySystem
{
    partial class MainScreenForm
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
            this.titleLabelInvManSys = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.searchPartsButton = new System.Windows.Forms.Button();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.searchPartsTextBox = new System.Windows.Forms.TextBox();
            this.searchProductsTextBox = new System.Windows.Forms.TextBox();
            this.deletePartsButton = new System.Windows.Forms.Button();
            this.modifyPartsButton = new System.Windows.Forms.Button();
            this.addPartsButton = new System.Windows.Forms.Button();
            this.addProductsButton = new System.Windows.Forms.Button();
            this.modifyProductsButton = new System.Windows.Forms.Button();
            this.deleteProductsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabelInvManSys
            // 
            this.titleLabelInvManSys.AutoSize = true;
            this.titleLabelInvManSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabelInvManSys.Location = new System.Drawing.Point(13, 13);
            this.titleLabelInvManSys.Name = "titleLabelInvManSys";
            this.titleLabelInvManSys.Size = new System.Drawing.Size(302, 26);
            this.titleLabelInvManSys.TabIndex = 0;
            this.titleLabelInvManSys.Text = "Inventory Managment System";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(18, 148);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.RowHeadersWidth = 51;
            this.dataGridViewParts.Size = new System.Drawing.Size(501, 296);
            this.dataGridViewParts.TabIndex = 0;
            this.dataGridViewParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParts_CellContentClick);
            this.dataGridViewParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParts_CellContentClick);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(580, 148);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.Size = new System.Drawing.Size(501, 296);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(14, 115);
            this.partsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(63, 26);
            this.partsLabel.TabIndex = 3;
            this.partsLabel.Text = "Parts";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(576, 115);
            this.productsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(98, 26);
            this.productsLabel.TabIndex = 4;
            this.productsLabel.Text = "Products";
            // 
            // searchPartsButton
            // 
            this.searchPartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartsButton.Location = new System.Drawing.Point(240, 80);
            this.searchPartsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPartsButton.Name = "searchPartsButton";
            this.searchPartsButton.Size = new System.Drawing.Size(90, 32);
            this.searchPartsButton.TabIndex = 5;
            this.searchPartsButton.Text = "Search";
            this.searchPartsButton.UseVisualStyleBackColor = true;
            this.searchPartsButton.Click += new System.EventHandler(this.searchPartsButton_Click);
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsButton.Location = new System.Drawing.Point(803, 79);
            this.searchProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(90, 32);
            this.searchProductsButton.TabIndex = 6;
            this.searchProductsButton.Text = "Search";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            this.searchProductsButton.Click += new System.EventHandler(this.searchProductsButton_Click);
            // 
            // searchPartsTextBox
            // 
            this.searchPartsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPartsTextBox.Location = new System.Drawing.Point(334, 84);
            this.searchPartsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPartsTextBox.MinimumSize = new System.Drawing.Size(186, 35);
            this.searchPartsTextBox.Name = "searchPartsTextBox";
            this.searchPartsTextBox.Size = new System.Drawing.Size(186, 26);
            this.searchPartsTextBox.TabIndex = 7;
            // 
            // searchProductsTextBox
            // 
            this.searchProductsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductsTextBox.Location = new System.Drawing.Point(898, 80);
            this.searchProductsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchProductsTextBox.MinimumSize = new System.Drawing.Size(151, 35);
            this.searchProductsTextBox.Name = "searchProductsTextBox";
            this.searchProductsTextBox.Size = new System.Drawing.Size(185, 26);
            this.searchProductsTextBox.TabIndex = 8;
            this.searchProductsTextBox.TextChanged += new System.EventHandler(this.searchProductsTextBox_TextChanged);
            // 
            // deletePartsButton
            // 
            this.deletePartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePartsButton.Location = new System.Drawing.Point(429, 489);
            this.deletePartsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deletePartsButton.Name = "deletePartsButton";
            this.deletePartsButton.Size = new System.Drawing.Size(90, 32);
            this.deletePartsButton.TabIndex = 9;
            this.deletePartsButton.Text = "Delete";
            this.deletePartsButton.UseVisualStyleBackColor = true;
            this.deletePartsButton.Click += new System.EventHandler(this.deletePartsButton_Click);
            // 
            // modifyPartsButton
            // 
            this.modifyPartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyPartsButton.Location = new System.Drawing.Point(334, 489);
            this.modifyPartsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyPartsButton.Name = "modifyPartsButton";
            this.modifyPartsButton.Size = new System.Drawing.Size(90, 32);
            this.modifyPartsButton.TabIndex = 10;
            this.modifyPartsButton.Text = "Modify";
            this.modifyPartsButton.UseVisualStyleBackColor = true;
            this.modifyPartsButton.Click += new System.EventHandler(this.modifyPartsButton_Click);
            // 
            // addPartsButton
            // 
            this.addPartsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsButton.Location = new System.Drawing.Point(240, 489);
            this.addPartsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addPartsButton.Name = "addPartsButton";
            this.addPartsButton.Size = new System.Drawing.Size(90, 32);
            this.addPartsButton.TabIndex = 11;
            this.addPartsButton.Text = "Add";
            this.addPartsButton.UseVisualStyleBackColor = true;
            this.addPartsButton.Click += new System.EventHandler(this.addPartsButton_Click);
            // 
            // addProductsButton
            // 
            this.addProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsButton.Location = new System.Drawing.Point(802, 489);
            this.addProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addProductsButton.Name = "addProductsButton";
            this.addProductsButton.Size = new System.Drawing.Size(90, 32);
            this.addProductsButton.TabIndex = 14;
            this.addProductsButton.Text = "Add";
            this.addProductsButton.UseVisualStyleBackColor = true;
            this.addProductsButton.Click += new System.EventHandler(this.addProductsButton_Click);
            // 
            // modifyProductsButton
            // 
            this.modifyProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyProductsButton.Location = new System.Drawing.Point(897, 489);
            this.modifyProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifyProductsButton.Name = "modifyProductsButton";
            this.modifyProductsButton.Size = new System.Drawing.Size(90, 32);
            this.modifyProductsButton.TabIndex = 13;
            this.modifyProductsButton.Text = "Modify";
            this.modifyProductsButton.UseVisualStyleBackColor = true;
            this.modifyProductsButton.Click += new System.EventHandler(this.modifyProductsButton_Click);
            // 
            // deleteProductsButton
            // 
            this.deleteProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductsButton.Location = new System.Drawing.Point(992, 489);
            this.deleteProductsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteProductsButton.Name = "deleteProductsButton";
            this.deleteProductsButton.Size = new System.Drawing.Size(90, 32);
            this.deleteProductsButton.TabIndex = 12;
            this.deleteProductsButton.Text = "Delete";
            this.deleteProductsButton.UseVisualStyleBackColor = true;
            this.deleteProductsButton.Click += new System.EventHandler(this.deleteProductsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(992, 544);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 32);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1108, 609);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addProductsButton);
            this.Controls.Add(this.modifyProductsButton);
            this.Controls.Add(this.deleteProductsButton);
            this.Controls.Add(this.addPartsButton);
            this.Controls.Add(this.modifyPartsButton);
            this.Controls.Add(this.deletePartsButton);
            this.Controls.Add(this.searchProductsTextBox);
            this.Controls.Add(this.searchPartsTextBox);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.searchPartsButton);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.dataGridViewParts);
            this.Controls.Add(this.titleLabelInvManSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainScreenForm";
            this.Text = "IMS Main Screen";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabelInvManSys;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button searchPartsButton;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.TextBox searchPartsTextBox;
        private System.Windows.Forms.TextBox searchProductsTextBox;
        private System.Windows.Forms.Button deletePartsButton;
        private System.Windows.Forms.Button modifyPartsButton;
        private System.Windows.Forms.Button addPartsButton;
        private System.Windows.Forms.Button addProductsButton;
        private System.Windows.Forms.Button modifyProductsButton;
        private System.Windows.Forms.Button deleteProductsButton;
        private System.Windows.Forms.Button exitButton;
    }
}

