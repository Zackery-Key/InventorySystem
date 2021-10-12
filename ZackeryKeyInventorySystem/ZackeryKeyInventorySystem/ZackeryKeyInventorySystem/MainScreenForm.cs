using System;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    public partial class MainScreenForm : Form
    {
        private static int idxSelectedPart;
        private static int idxSelectedProduct;

        #region Constructor (Main Screen Form)

        /// <summary>
        /// Default Constructor for Main Screen Form
        /// </summary>
        public MainScreenForm()
        {
            InitializeComponent();
            // DataGridView for Parts initializer
            idxSelectedPart = -1;
            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.DefaultCellStyle.SelectionBackColor = dataGridViewParts.DefaultCellStyle.BackColor;
            dataGridViewParts.DefaultCellStyle.SelectionForeColor = dataGridViewParts.DefaultCellStyle.ForeColor;
            dataGridViewParts.DataSource = Inventory.AllParts;

            // DataGridView for Products initializer
            idxSelectedProduct = -1;
            dataGridViewProducts.DataSource = Inventory.Products;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = dataGridViewProducts.DefaultCellStyle.BackColor;
            dataGridViewProducts.DefaultCellStyle.SelectionForeColor = dataGridViewProducts.DefaultCellStyle.ForeColor;
            dataGridViewProducts.DataSource = Inventory.Products;
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Main Form Parts Event Handlers

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row when a cell is clicked
            idxSelectedPart = e.RowIndex;
            Inventory.CurrentPartID = (int)dataGridViewParts.Rows[idxSelectedPart].Cells[0].Value;
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

            // Shows selected row as yellow
            dataGridViewParts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void searchPartsButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Creates a new instance of a Add Parts form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPartForm AddPartScreen = new AddPartForm();
            AddPartScreen.Show();
        }


        /// <summary>
        /// Creates a new instance of a Modify Parts form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            // Validates that something is selected first
            if (idxSelectedPart >= 0)
            {
                this.Hide();
                ModifyPartForm ModifyPartScreen = new ModifyPartForm();
                ModifyPartScreen.Show();
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void deletePartsButton_Click(object sender, EventArgs e)
        {
            {
                // Validates that something is selected first
                if (idxSelectedPart >= 0)
                {
                    Inventory.DeletePart(Inventory.CurrentPart);
                }
                else
                {
                    MessageBox.Show("Please select a part to modify.");
                }
            }
        }

        #endregion

        #region Main Form Products Event Handlers

        private void searchProductsButton_Click(object sender, EventArgs e)
        {

        }

        private void searchProductsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row when a cell is clicked
            idxSelectedProduct = e.RowIndex;
            Inventory.CurrentProductID = (int)dataGridViewProducts.Rows[idxSelectedProduct].Cells[0].Value;
            Inventory.CurrentProduct = Inventory.LookupProduct(Inventory.CurrentProductID);

            // Selected row displays as yellow
            dataGridViewProducts.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        /// <summary>
        /// Creates new instance of AddProductForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm AddProductScreen = new AddProductForm();
            AddProductScreen.Show();
        }

        /// <summary>
        /// Creates a new instance of ModifyPartsForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            // Validates that a row is selected
            if (idxSelectedProduct >= 0)
            {
                this.Hide();
                ModifyProductForm ModifyProductScreen = new ModifyProductForm();
                ModifyProductScreen.Show();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            {
                // Validates that something is selected first
                if (idxSelectedProduct >= 0)
                {
                    Inventory.RemoveProduct(Inventory.CurrentProductID);
                }
                else
                {
                    MessageBox.Show("Please select a part to modify.");
                }
            }
        }


        #endregion

        #region Exit Application Event Handler

        /// <summary>
        /// Exits the application upon user button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Displays a message box to confirm the users choice to exit the application
            DialogResult exitRequestUserInput = MessageBox.Show("Do you want to exit the IMS application.", "Exit Application", MessageBoxButtons.YesNo);

            // Switch expression to either shutdown application or cancel
            switch (exitRequestUserInput)
            {
                // If user chooses yes will shut down application
                case DialogResult.Yes:

                    // Shuts down the entire application and releases any resources in use
                    System.Windows.Forms.Application.Exit();
                    break;

                // If user chooses no will cancel the exit request via a return statement
                case DialogResult.No:
                    return;
            }
        }

        #endregion

    }
}
