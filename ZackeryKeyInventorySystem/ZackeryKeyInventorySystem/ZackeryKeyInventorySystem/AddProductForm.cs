using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    public partial class AddProductForm : Form
    {
        // Private Variable for the selected part's index
        private static int idxSelectedPart;

        Product newProduct = new Product();

        /// <summary>
        /// Method to validate that all fields are filled with correct data
        /// </summary>
        /// <returns></returns>
        private bool AllowSave()
        {
            // Checks fields for any whitespace or null values
            return ((!string.IsNullOrWhiteSpace(addProductNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addProductInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addProductPriceTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addProductMinTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addProductMaxTextBox.Text))

                &&

                !newProduct.AssociatedParts.Count.Equals(0));
        }

        private void RefreshDataGrid()
        {
            addPartAssociatedGrid.DataSource = newProduct.AssociatedParts;
            addPartAssociatedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addPartAssociatedGrid.DefaultCellStyle.SelectionBackColor = addPartAssociatedGrid.DefaultCellStyle.BackColor;
            addPartAssociatedGrid.DefaultCellStyle.SelectionForeColor = addPartAssociatedGrid.DefaultCellStyle.ForeColor;
            addPartAssociatedGrid.DataSource = newProduct.AssociatedParts;
            addPartAssociatedGrid.Text = Convert.ToString(Product.productCount + 1);
        }

        #region Constructor

        /// <summary>
        /// Default Constructor for AddProductForm
        /// </summary>
        public AddProductForm()
        {
            InitializeComponent();

            // Initializes the index of the selected part to -1
            idxSelectedPart = -1;

            // Initializes the DataGridView and adds some styling for selection
            addPartCandidateGrid.DataSource = Inventory.AllParts;
            addPartCandidateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addPartCandidateGrid.DefaultCellStyle.SelectionBackColor = addPartCandidateGrid.DefaultCellStyle.BackColor;
            addPartCandidateGrid.DefaultCellStyle.SelectionForeColor = addPartCandidateGrid.DefaultCellStyle.ForeColor;
            addPartCandidateGrid.DataSource = Inventory.AllParts;
            addProductIDTextBox.Text = Convert.ToString(Product.productCount + 1);

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region TextBox

        /// <summary>
        /// Validates Textbox for Products's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null or Empty
            if (string.IsNullOrEmpty(addProductNameTextBox.Text))
            {
                addProductNameTextBox.BackColor = System.Drawing.Color.Salmon;
                addProductSaveButton.Enabled = false;
            }
            else
            {
                addProductNameTextBox.BackColor = Color.White;
            }
            addProductSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        /// Validates Textbox for Products's Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(addProductInventoryTextBox.Text) || !int.TryParse(addProductInventoryTextBox.Text, out int n))
            {
                addProductInventoryTextBox.BackColor = Color.Salmon;
                addProductSaveButton.Enabled = false;
            }
            else
            {
                addProductInventoryTextBox.BackColor = Color.White;
            }
            addProductSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        /// Validates Textbox for Products's Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(addProductPriceTextBox.Text) || !decimal.TryParse(addProductPriceTextBox.Text, out decimal n))
            {
                addProductPriceTextBox.BackColor = Color.Salmon;
                addProductSaveButton.Enabled = true;
            }
            else
            {
                addProductPriceTextBox.BackColor = Color.White;
            }
            addProductSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        /// Validates Textbox for Products's Max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(addProductMaxTextBox.Text) || !int.TryParse(addProductMaxTextBox.Text, out int n))
            {
                addProductMaxTextBox.BackColor = Color.Salmon;
                addProductSaveButton.Enabled = false;
            }
            else
            {
                addProductMaxTextBox.BackColor = Color.White;
            }
            addProductSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        /// Validates Textbox for Products's Min
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(addProductMinTextBox.Text) || !int.TryParse(addProductMinTextBox.Text, out int n))
            {
                addProductMinTextBox.BackColor = Color.Salmon;
                addProductSaveButton.Enabled = false;
            }
            else
            {
                addProductMinTextBox.BackColor = Color.White;
            }
            addProductSaveButton.Enabled = AllowSave();
        }

        private void addProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region DataGridView

        /// <summary>
        /// Paints the DataGridView for the add part CandidateGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartCandidateGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row by Index Value
            idxSelectedPart = e.RowIndex;

            // Sets the CurrentPartID with the row value
            Inventory.CurrentPartID = (int)addPartCandidateGrid.Rows[idxSelectedPart].Cells[0].Value;

            // Calls the LookupPart method to set set the CurrentPart based on PartID
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

            // Highlights the selected row yellow
            addPartCandidateGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        /// <summary>
        /// Paints the DataGridView for the add part AssociatedGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartAssociatedGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row by Index Value
            idxSelectedPart = e.RowIndex;

            // Sets the CurrentPartID with the row value
            Inventory.CurrentPartID = (int)addPartAssociatedGrid.Rows[idxSelectedPart].Cells[0].Value;

            // Calls the LookupPart method to set set the CurrentPart based on PartID
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

            // Highlights the selected row yellow
            addPartAssociatedGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        #endregion

        #region Button Handlers

        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                newProduct.AddAssociatedPart(Inventory.CurrentPart);
                RefreshDataGrid();
                AllowSave();               
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void addProductDeleteButton_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                newProduct.RemoveAssociatedPart(Inventory.CurrentPartID);
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }


        /// <summary>
        /// Saves the fields to a new object and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductSaveButton_Click(object sender, EventArgs e)
        {
            if (AllowSave())
            {
                // Validates that the minimum does not exceed the maximum
                if (Convert.ToInt32(addProductMinTextBox.Text) < Convert.ToInt32(addProductMaxTextBox.Text))
                {
                    // Creates and initializes new Product object
                    newProduct.Name = addProductNameTextBox.Text;
                    newProduct.InStock = Convert.ToInt32(addProductInventoryTextBox.Text);
                    newProduct.Price = Convert.ToDecimal(addProductPriceTextBox.Text);
                    newProduct.Max = Convert.ToInt32(addProductMaxTextBox.Text);
                    newProduct.Min = Convert.ToInt32(addProductMinTextBox.Text);

                    // Adds new product to DataGrid
                    Inventory.AddProduct(newProduct);
                    //newProduct.AssociatedParts.Add(Inventory.CurrentPart);

                    // Closes product form and opens new mainscreen
                    MainScreenForm mainScreen = new MainScreenForm();
                    this.Hide();
                    mainScreen.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Your min value is greater than the max value.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid entries. Please complete form before saving.", "Error");
            }
        }

        /// <summary>
        /// Cancels the product form and reopens mainscreen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductCancelButton_Click(object sender, EventArgs e)
        {
            // Closes window
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }

        private void addProductSearchButton_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
