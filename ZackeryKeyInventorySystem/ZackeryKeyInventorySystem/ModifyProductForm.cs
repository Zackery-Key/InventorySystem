using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ZackeryKeyInventorySystem
{
    public partial class ModifyProductForm : Form
    {
        // Private Variable for the selected part's index
        private static int idxSelectedPart;
        private BindingList<Part> tempParts = new BindingList<Part>();
        private BindingList<Part> TempParts { get { return tempParts; } set { tempParts = value; } }

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

        private void RefreshDataGrid()
        {
            modifyProductCandidateGrid.Refresh();
            modifyProductCandidateGrid.DataSource = Inventory.AllParts;
            modifyProductCandidateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductCandidateGrid.DefaultCellStyle.SelectionBackColor = modifyProductCandidateGrid.DefaultCellStyle.BackColor;
            modifyProductCandidateGrid.DefaultCellStyle.SelectionForeColor = modifyProductCandidateGrid.DefaultCellStyle.ForeColor;
            modifyProductCandidateGrid.DataSource = Inventory.AllParts;
            modifyProductCandidateGrid.ClearSelection();
            idxSelectedPart = -1;

            modifyProductAssociatedGrid.Refresh();
            modifyProductAssociatedGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            modifyProductAssociatedGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProductAssociatedGrid.DefaultCellStyle.SelectionBackColor = modifyProductAssociatedGrid.DefaultCellStyle.BackColor;
            modifyProductAssociatedGrid.DefaultCellStyle.SelectionForeColor = modifyProductAssociatedGrid.DefaultCellStyle.ForeColor;
            modifyProductAssociatedGrid.DataSource = Inventory.CurrentProduct.AssociatedParts;
            modifyProductAssociatedGrid.ClearSelection();
            idxSelectedPart = -1;

        }

        #region Constructor

        public ModifyProductForm()
        {
            InitializeComponent();

            foreach (Part x in Inventory.CurrentProduct.AssociatedParts)
            {
                TempParts.Add(x);
            }

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

        #endregion

        #region DataGridViews

        private void modifyProductCandidateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row by Index Value
            idxSelectedPart = e.RowIndex;

            // Sets the CurrentPartID with the row value
            Inventory.CurrentPartID = (int)modifyProductCandidateGrid.Rows[idxSelectedPart].Cells[0].Value;

            // Calls the LookupPart method to set set the CurrentPart based on PartID
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

            // Highlights the selected row yellow
            modifyProductCandidateGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }

        private void modifyProductAssociatedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Selects the row by Index Value
            idxSelectedPart = e.RowIndex;

            // Sets the CurrentPartID with the row value
            Inventory.CurrentPartID = (int)modifyProductAssociatedGrid.Rows[idxSelectedPart].Cells[0].Value;

            // Calls the LookupPart method to set set the CurrentPart based on PartID
            Inventory.CurrentPart = Inventory.LookupPart(Inventory.CurrentPartID);

            // Highlights the selected row yellow
            modifyProductAssociatedGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }


        #endregion

        #region Button Handlers

        private void modifyProductAddButton_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                if (Inventory.CurrentPart.InStock > 0)
                {
                    Inventory.CurrentPart.InStock--;
                    if (Inventory.CurrentPart is Inhouse)
                    {
                        Inhouse temp = new Inhouse(
                            Inventory.CurrentPart.Name,
                            1,
                            Inventory.CurrentPart.Price,
                            Inventory.CurrentPart.Min,
                            Inventory.CurrentPart.Max,
                            0);
                        temp.PartID = Inventory.CurrentPart.PartID;
                        Inventory.CurrentProduct.AddAssociatedPart(temp);
                        RefreshDataGrid();
                    }
                    else if (Inventory.CurrentPart is Outsourced)
                    {
                        Outsourced temp = new Outsourced(
                            Inventory.CurrentPart.Name,
                            1,
                            Inventory.CurrentPart.Price,
                            Inventory.CurrentPart.Min,
                            Inventory.CurrentPart.Max,
                            "null");
                        temp.PartID = Inventory.CurrentPart.PartID;
                        Inventory.CurrentProduct.AddAssociatedPart(temp);
                        RefreshDataGrid();
                    }
                }
                else
                {
                    MessageBox.Show("Currently out of stock");
                }
            }
            else
            {
                MessageBox.Show("Please select a part to add.");
            }
        }

        private void modifyProductDeleteButton_Click(object sender, EventArgs e)
        {
            if (idxSelectedPart >= 0)
            {
                // Displays a message box to confirm the users choice to delete the Part
                DialogResult exitRequestUserInput = MessageBox.Show("Are you sure you want to delete this Part.", "Delete Part", MessageBoxButtons.YesNo);

                // Switch expression to either delete the Part or cancel
                switch (exitRequestUserInput)
                {
                    // If user chooses yes will delete the Part
                    case DialogResult.Yes:

                        // Delete the Part
                        Inventory.CurrentProduct.RemoveAssociatedPart(Inventory.CurrentPartID);
                        RefreshDataGrid();
                        break;

                    // If user chooses no will cancel the exit request via a return statement
                    case DialogResult.No:
                        return;
                }
            }
            else
            {
                MessageBox.Show("Select a row");
            }
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            if (AllowSave())
            {
                if (Convert.ToInt32(modifyProductInventoryTextBox.Text) > Convert.ToInt32(modifyProductMinTextBox.Text)
                   && Convert.ToInt32(modifyProductInventoryTextBox.Text) < Convert.ToInt32(modifyProductMaxTextBox.Text)
                   )
                {
                    // Validates that the minimum does not exceed the maximum
                    if (Convert.ToInt32(modifyProductMinTextBox.Text) < Convert.ToInt32(modifyProductMaxTextBox.Text))
                    {
                        // Creates and initializes new Product object
                        Inventory.CurrentProduct.Name = modifyProductNameTextBox.Text;
                        Inventory.CurrentProduct.InStock = Convert.ToInt32(modifyProductInventoryTextBox.Text);
                        Inventory.CurrentProduct.Price = Convert.ToDecimal(modifyProductPriceTextBox.Text);
                        Inventory.CurrentProduct.Max = Convert.ToInt32(modifyProductMaxTextBox.Text);
                        Inventory.CurrentProduct.Min = Convert.ToInt32(modifyProductMinTextBox.Text);

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
                    MessageBox.Show("Inventory is outside of set Max and Min values.", "Error");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid entries. Please complete form before saving.", "Error");
            }
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProduct.AssociatedParts.Clear();

            foreach (Part x in TempParts)
            {
                Inventory.CurrentProduct.AssociatedParts.Add(x);
            }

            // Closes window and opens main screen
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }

        private void modifyProductSearchButton_Click(object sender, EventArgs e)
        {
            modifyProductCandidateGrid.ClearSelection();
            modifyProductCandidateGrid.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            bool found = false;
            if (modifyProductSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].PartID.ToString().Equals(modifyProductSearchTextBox.Text) ||
                       Inventory.AllParts[i].Name.ToUpper().Contains(modifyProductSearchTextBox.Text.ToUpper()) ||
                       Inventory.AllParts[i].InStock.ToString().Equals((modifyProductSearchTextBox.Text)) ||
                       Inventory.AllParts[i].Price.ToString().Equals((modifyProductSearchTextBox.Text)) ||
                       Inventory.AllParts[i].Max.ToString().Equals((modifyProductSearchTextBox.Text)) ||
                       Inventory.AllParts[i].Min.ToString().Equals(modifyProductSearchTextBox.Text))
                    {
                        modifyProductCandidateGrid.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found.");
            }
        }

        #endregion

        #region Text Box

        private void modifyProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null or Empty
            if (string.IsNullOrEmpty(modifyProductNameTextBox.Text))
            {
                modifyProductNameTextBox.BackColor = Color.Salmon;
                modifyProductSaveButton.Enabled = false;
            }
            else
            {
                modifyProductNameTextBox.BackColor = Color.White;
            }
            modifyProductSaveButton.Enabled = AllowSave();
        }

        private void modifyProductInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyProductInventoryTextBox.Text) || !int.TryParse(modifyProductInventoryTextBox.Text, out int n))
            {
                modifyProductInventoryTextBox.BackColor = Color.Salmon;
                modifyProductSaveButton.Enabled = false;
            }
            else
            {
                modifyProductInventoryTextBox.BackColor = Color.White;
            }
            modifyProductSaveButton.Enabled = AllowSave();
        }

        private void modifyProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(modifyProductPriceTextBox.Text) || !decimal.TryParse(modifyProductPriceTextBox.Text, out decimal n))
            {
                modifyProductPriceTextBox.BackColor = Color.Salmon;
                modifyProductSaveButton.Enabled = true;
            }
            else
            {
                modifyProductPriceTextBox.BackColor = Color.White;
            }
            modifyProductSaveButton.Enabled = AllowSave();
        }

        private void modifyProductMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(modifyProductMaxTextBox.Text) || !int.TryParse(modifyProductMaxTextBox.Text, out int n))
            {
                modifyProductMaxTextBox.BackColor = Color.Salmon;
                modifyProductSaveButton.Enabled = false;
            }
            else
            {
                modifyProductMaxTextBox.BackColor = Color.White;
            }
            modifyProductSaveButton.Enabled = AllowSave();
        }

        private void modifyProductMinTextBox_TextChanged(object sender, EventArgs e)
        {
            // Disables save button if Null, Empty, or string
            if (string.IsNullOrWhiteSpace(modifyProductMinTextBox.Text) || !int.TryParse(modifyProductMinTextBox.Text, out int n))
            {
                modifyProductMinTextBox.BackColor = Color.Salmon;
                modifyProductSaveButton.Enabled = false;
            }
            else
            {
                modifyProductMinTextBox.BackColor = Color.White;
            }
            modifyProductSaveButton.Enabled = AllowSave();
        }

        #endregion
    }
}
