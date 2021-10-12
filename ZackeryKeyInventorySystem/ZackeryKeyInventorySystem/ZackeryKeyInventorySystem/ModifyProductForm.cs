using System;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    public partial class ModifyProductForm : Form
    {
        /// <summary>
        /// Method to validate that all fields are filled with correct data
        /// </summary>
        /// <returns></returns>
        private bool AllowSave()
        {
            // Checks fields for any whitespace or null values
            return !string.IsNullOrWhiteSpace(modifyProductNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyProductInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyProductPriceTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyProductMinTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyProductMaxTextBox.Text);
        }
        public ModifyProductForm()
        {
            InitializeComponent();

            // Pre-fill textbox
            modifyProductIDTextBox.Text = Inventory.CurrentProduct.ProductID.ToString();
            modifyProductNameTextBox.Text = Inventory.CurrentProduct.Name;
            modifyProductInventoryTextBox.Text = Inventory.CurrentProduct.InStock.ToString();
            modifyProductPriceTextBox.Text = Inventory.CurrentProduct.Price.ToString();
            modifyProductMaxTextBox.Text = Inventory.CurrentProduct.Max.ToString();
            modifyProductMinTextBox.Text = Inventory.CurrentProduct.Min.ToString();

            // Paint the DataGridView for Candidate Parts
            modifyProductCandidateGrid.DataSource = Inventory.AllParts;
            modifyProductCandidateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductCandidateGrid.DefaultCellStyle.SelectionBackColor = modifyProductCandidateGrid.DefaultCellStyle.BackColor;
            modifyProductCandidateGrid.DefaultCellStyle.SelectionForeColor = modifyProductCandidateGrid.DefaultCellStyle.ForeColor;
            modifyProductCandidateGrid.DataSource = Inventory.AllParts;

            // Paint the DataGridView for Associated Parts
            modifyProductAssociatedGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            modifyProductAssociatedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductAssociatedGrid.DefaultCellStyle.SelectionBackColor = modifyProductAssociatedGrid.DefaultCellStyle.BackColor;
            modifyProductAssociatedGrid.DefaultCellStyle.SelectionForeColor = modifyProductAssociatedGrid.DefaultCellStyle.ForeColor;
            modifyProductAssociatedGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            modifyProductAssociatedGrid.Text = Convert.ToString(Inventory.CurrentProduct.ProductID);
        }

        private void ModifyProductForm_Load(object sender, System.EventArgs e)
        {

        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            // Closes window and opens main screen
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }
    }
}
