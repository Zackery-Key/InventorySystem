namespace ZackeryKeyInventorySystem
{
    partial class AddProductForm
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
            this.addProductsLabel = new System.Windows.Forms.Label();
            this.addPartCandidateGrid = new System.Windows.Forms.DataGridView();
            this.addPartAssociatedGrid = new System.Windows.Forms.DataGridView();
            this.addProductAddButton = new System.Windows.Forms.Button();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductCancelButton = new System.Windows.Forms.Button();
            this.addProductDeleteButton = new System.Windows.Forms.Button();
            this.addProductSearchButton = new System.Windows.Forms.Button();
            this.addProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addProductIDTextBox = new System.Windows.Forms.TextBox();
            this.addProductInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.addProductMaxTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinTextBox = new System.Windows.Forms.TextBox();
            this.addProductMinLabel = new System.Windows.Forms.Label();
            this.addProductMaxLabel = new System.Windows.Forms.Label();
            this.addProductPriceLabel = new System.Windows.Forms.Label();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductIDLabel = new System.Windows.Forms.Label();
            this.associatedWithDataGridLable = new System.Windows.Forms.Label();
            this.allCandidatePartsDataGridLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.addPartCandidateGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartAssociatedGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductsLabel
            // 
            this.addProductsLabel.AutoSize = true;
            this.addProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductsLabel.Location = new System.Drawing.Point(15, 11);
            this.addProductsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductsLabel.Name = "addProductsLabel";
            this.addProductsLabel.Size = new System.Drawing.Size(214, 38);
            this.addProductsLabel.TabIndex = 18;
            this.addProductsLabel.Text = "Add Products";
            // 
            // addPartCandidateGrid
            // 
            this.addPartCandidateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartCandidateGrid.Location = new System.Drawing.Point(785, 145);
            this.addPartCandidateGrid.Name = "addPartCandidateGrid";
            this.addPartCandidateGrid.RowHeadersWidth = 51;
            this.addPartCandidateGrid.RowTemplate.Height = 24;
            this.addPartCandidateGrid.Size = new System.Drawing.Size(942, 318);
            this.addPartCandidateGrid.TabIndex = 19;
            this.addPartCandidateGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addPartCandidateGrid_CellClick);
            // 
            // addPartAssociatedGrid
            // 
            this.addPartAssociatedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartAssociatedGrid.Location = new System.Drawing.Point(785, 557);
            this.addPartAssociatedGrid.Name = "addPartAssociatedGrid";
            this.addPartAssociatedGrid.RowHeadersWidth = 51;
            this.addPartAssociatedGrid.RowTemplate.Height = 24;
            this.addPartAssociatedGrid.Size = new System.Drawing.Size(942, 318);
            this.addPartAssociatedGrid.TabIndex = 20;
            this.addPartAssociatedGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addPartAssociatedGrid_CellClick);
            // 
            // addProductAddButton
            // 
            this.addProductAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductAddButton.Location = new System.Drawing.Point(1601, 469);
            this.addProductAddButton.Name = "addProductAddButton";
            this.addProductAddButton.Size = new System.Drawing.Size(126, 68);
            this.addProductAddButton.TabIndex = 21;
            this.addProductAddButton.Text = "Add";
            this.addProductAddButton.UseVisualStyleBackColor = true;
            this.addProductAddButton.Click += new System.EventHandler(this.addProductAddButton_Click);
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSaveButton.Location = new System.Drawing.Point(1469, 955);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(126, 68);
            this.addProductSaveButton.TabIndex = 22;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = true;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductCancelButton
            // 
            this.addProductCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductCancelButton.Location = new System.Drawing.Point(1601, 955);
            this.addProductCancelButton.Name = "addProductCancelButton";
            this.addProductCancelButton.Size = new System.Drawing.Size(126, 68);
            this.addProductCancelButton.TabIndex = 23;
            this.addProductCancelButton.Text = "Cancel";
            this.addProductCancelButton.UseVisualStyleBackColor = true;
            this.addProductCancelButton.Click += new System.EventHandler(this.addProductCancelButton_Click);
            // 
            // addProductDeleteButton
            // 
            this.addProductDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductDeleteButton.Location = new System.Drawing.Point(1601, 881);
            this.addProductDeleteButton.Name = "addProductDeleteButton";
            this.addProductDeleteButton.Size = new System.Drawing.Size(126, 68);
            this.addProductDeleteButton.TabIndex = 24;
            this.addProductDeleteButton.Text = "Delete";
            this.addProductDeleteButton.UseVisualStyleBackColor = true;
            this.addProductDeleteButton.Click += new System.EventHandler(this.addProductDeleteButton_Click);
            // 
            // addProductSearchButton
            // 
            this.addProductSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchButton.Location = new System.Drawing.Point(1182, 67);
            this.addProductSearchButton.Name = "addProductSearchButton";
            this.addProductSearchButton.Size = new System.Drawing.Size(132, 43);
            this.addProductSearchButton.TabIndex = 25;
            this.addProductSearchButton.Text = "Search";
            this.addProductSearchButton.UseVisualStyleBackColor = true;
            this.addProductSearchButton.Click += new System.EventHandler(this.addProductSearchButton_Click);
            // 
            // addProductSearchTextBox
            // 
            this.addProductSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchTextBox.Location = new System.Drawing.Point(1333, 74);
            this.addProductSearchTextBox.MinimumSize = new System.Drawing.Size(394, 30);
            this.addProductSearchTextBox.Name = "addProductSearchTextBox";
            this.addProductSearchTextBox.Size = new System.Drawing.Size(394, 31);
            this.addProductSearchTextBox.TabIndex = 27;
            this.addProductSearchTextBox.TextChanged += new System.EventHandler(this.addProductSearchTextBox_TextChanged);
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameTextBox.Location = new System.Drawing.Point(294, 428);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(244, 31);
            this.addProductNameTextBox.TabIndex = 28;
            this.addProductNameTextBox.TextChanged += new System.EventHandler(this.addProductNameTextBox_TextChanged);
            // 
            // addProductIDTextBox
            // 
            this.addProductIDTextBox.Enabled = false;
            this.addProductIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIDTextBox.Location = new System.Drawing.Point(294, 362);
            this.addProductIDTextBox.Name = "addProductIDTextBox";
            this.addProductIDTextBox.ReadOnly = true;
            this.addProductIDTextBox.Size = new System.Drawing.Size(244, 31);
            this.addProductIDTextBox.TabIndex = 29;
            // 
            // addProductInventoryTextBox
            // 
            this.addProductInventoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInventoryTextBox.Location = new System.Drawing.Point(294, 506);
            this.addProductInventoryTextBox.Name = "addProductInventoryTextBox";
            this.addProductInventoryTextBox.Size = new System.Drawing.Size(244, 31);
            this.addProductInventoryTextBox.TabIndex = 30;
            this.addProductInventoryTextBox.TextChanged += new System.EventHandler(this.addProductInventoryTextBox_TextChanged);
            // 
            // addProductPriceTextBox
            // 
            this.addProductPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceTextBox.Location = new System.Drawing.Point(294, 578);
            this.addProductPriceTextBox.Name = "addProductPriceTextBox";
            this.addProductPriceTextBox.Size = new System.Drawing.Size(244, 31);
            this.addProductPriceTextBox.TabIndex = 31;
            this.addProductPriceTextBox.TextChanged += new System.EventHandler(this.addProductPriceTextBox_TextChanged);
            // 
            // addProductMaxTextBox
            // 
            this.addProductMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxTextBox.Location = new System.Drawing.Point(206, 658);
            this.addProductMaxTextBox.Name = "addProductMaxTextBox";
            this.addProductMaxTextBox.Size = new System.Drawing.Size(134, 31);
            this.addProductMaxTextBox.TabIndex = 32;
            this.addProductMaxTextBox.TextChanged += new System.EventHandler(this.addProductMaxTextBox_TextChanged);
            // 
            // addProductMinTextBox
            // 
            this.addProductMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMinTextBox.Location = new System.Drawing.Point(478, 658);
            this.addProductMinTextBox.Name = "addProductMinTextBox";
            this.addProductMinTextBox.Size = new System.Drawing.Size(140, 31);
            this.addProductMinTextBox.TabIndex = 33;
            this.addProductMinTextBox.TextChanged += new System.EventHandler(this.addProductMinTextBox_TextChanged);
            // 
            // addProductMinLabel
            // 
            this.addProductMinLabel.AutoSize = true;
            this.addProductMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMinLabel.Location = new System.Drawing.Point(402, 652);
            this.addProductMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductMinLabel.Name = "addProductMinLabel";
            this.addProductMinLabel.Size = new System.Drawing.Size(69, 38);
            this.addProductMinLabel.TabIndex = 34;
            this.addProductMinLabel.Text = "Min";
            // 
            // addProductMaxLabel
            // 
            this.addProductMaxLabel.AutoSize = true;
            this.addProductMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductMaxLabel.Location = new System.Drawing.Point(122, 652);
            this.addProductMaxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductMaxLabel.Name = "addProductMaxLabel";
            this.addProductMaxLabel.Size = new System.Drawing.Size(79, 38);
            this.addProductMaxLabel.TabIndex = 35;
            this.addProductMaxLabel.Text = "Max";
            // 
            // addProductPriceLabel
            // 
            this.addProductPriceLabel.AutoSize = true;
            this.addProductPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductPriceLabel.Location = new System.Drawing.Point(132, 572);
            this.addProductPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductPriceLabel.Name = "addProductPriceLabel";
            this.addProductPriceLabel.Size = new System.Drawing.Size(92, 38);
            this.addProductPriceLabel.TabIndex = 36;
            this.addProductPriceLabel.Text = "Price";
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductInventoryLabel.Location = new System.Drawing.Point(75, 500);
            this.addProductInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(151, 38);
            this.addProductInventoryLabel.TabIndex = 37;
            this.addProductInventoryLabel.Text = "Inventory";
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductNameLabel.Location = new System.Drawing.Point(122, 422);
            this.addProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(104, 38);
            this.addProductNameLabel.TabIndex = 38;
            this.addProductNameLabel.Text = "Name";
            // 
            // addProductIDLabel
            // 
            this.addProductIDLabel.AutoSize = true;
            this.addProductIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductIDLabel.Location = new System.Drawing.Point(176, 355);
            this.addProductIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductIDLabel.Name = "addProductIDLabel";
            this.addProductIDLabel.Size = new System.Drawing.Size(49, 38);
            this.addProductIDLabel.TabIndex = 39;
            this.addProductIDLabel.Text = "ID";
            // 
            // associatedWithDataGridLable
            // 
            this.associatedWithDataGridLable.AutoSize = true;
            this.associatedWithDataGridLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associatedWithDataGridLable.Location = new System.Drawing.Point(778, 516);
            this.associatedWithDataGridLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.associatedWithDataGridLable.Name = "associatedWithDataGridLable";
            this.associatedWithDataGridLable.Size = new System.Drawing.Size(496, 38);
            this.associatedWithDataGridLable.TabIndex = 40;
            this.associatedWithDataGridLable.Text = "Parts Associated with the Poduct";
            // 
            // allCandidatePartsDataGridLable
            // 
            this.allCandidatePartsDataGridLable.AutoSize = true;
            this.allCandidatePartsDataGridLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCandidatePartsDataGridLable.Location = new System.Drawing.Point(778, 104);
            this.allCandidatePartsDataGridLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.allCandidatePartsDataGridLable.Name = "allCandidatePartsDataGridLable";
            this.allCandidatePartsDataGridLable.Size = new System.Drawing.Size(289, 38);
            this.allCandidatePartsDataGridLable.TabIndex = 41;
            this.allCandidatePartsDataGridLable.Text = "All candidate Parts";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1776, 1046);
            this.Controls.Add(this.allCandidatePartsDataGridLable);
            this.Controls.Add(this.associatedWithDataGridLable);
            this.Controls.Add(this.addProductIDLabel);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductPriceLabel);
            this.Controls.Add(this.addProductMaxLabel);
            this.Controls.Add(this.addProductMinLabel);
            this.Controls.Add(this.addProductMinTextBox);
            this.Controls.Add(this.addProductMaxTextBox);
            this.Controls.Add(this.addProductPriceTextBox);
            this.Controls.Add(this.addProductInventoryTextBox);
            this.Controls.Add(this.addProductIDTextBox);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductSearchTextBox);
            this.Controls.Add(this.addProductSearchButton);
            this.Controls.Add(this.addProductDeleteButton);
            this.Controls.Add(this.addProductCancelButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.addProductAddButton);
            this.Controls.Add(this.addPartAssociatedGrid);
            this.Controls.Add(this.addPartCandidateGrid);
            this.Controls.Add(this.addProductsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddProductForm";
            this.Text = "Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addPartCandidateGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartAssociatedGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductsLabel;
        private System.Windows.Forms.DataGridView addPartCandidateGrid;
        private System.Windows.Forms.DataGridView addPartAssociatedGrid;
        private System.Windows.Forms.Button addProductAddButton;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductCancelButton;
        private System.Windows.Forms.Button addProductDeleteButton;
        private System.Windows.Forms.Button addProductSearchButton;
        private System.Windows.Forms.TextBox addProductSearchTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.TextBox addProductIDTextBox;
        private System.Windows.Forms.TextBox addProductInventoryTextBox;
        private System.Windows.Forms.TextBox addProductPriceTextBox;
        private System.Windows.Forms.TextBox addProductMaxTextBox;
        private System.Windows.Forms.TextBox addProductMinTextBox;
        private System.Windows.Forms.Label addProductMinLabel;
        private System.Windows.Forms.Label addProductMaxLabel;
        private System.Windows.Forms.Label addProductPriceLabel;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.Label addProductIDLabel;
        private System.Windows.Forms.Label associatedWithDataGridLable;
        private System.Windows.Forms.Label allCandidatePartsDataGridLable;
    }
}