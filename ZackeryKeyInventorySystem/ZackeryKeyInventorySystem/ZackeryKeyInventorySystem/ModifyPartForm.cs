using System;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    public partial class ModifyPartForm : Form
    {
        bool isInhouse;

        private bool AllowSave()
        {
            return ((!string.IsNullOrWhiteSpace(modifyPartsNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyPartsInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyPartsPriceCostTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyPartsMaxTextBox.Text) &&
                !string.IsNullOrWhiteSpace(modifyPartsMinTextBox.Text))

                &&

                (!string.IsNullOrWhiteSpace(modifyPartsMachineIDCompNumTextBox.Text) ||
                (isInhouse && Int32.TryParse(modifyPartsMachineIDCompNumTextBox.Text, out int number))));
        }

        private void CheckRBSwitch()
        {
            // if txtSource has no text, or you're working with a PartTime object and the contents of txtSource is not a number, flag an error
            int number;
            if (string.IsNullOrWhiteSpace(modifyPartsMachineIDCompNumTextBox.Text) || (isInhouse && !Int32.TryParse(modifyPartsMachineIDCompNumTextBox.Text, out number)))
            {
                modifyPartsMachineIDCompNumTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                modifyPartsMachineIDCompNumTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        #region Constructor for ModifyPartsForm

        /// <summary>
        /// Default constructor for ModifyPartsForm
        /// </summary>
        public ModifyPartForm()
        {
            InitializeComponent();
            modifyPartIDTextBox.Text = Inventory.CurrentPart.PartID.ToString();
            modifyPartsNameTextBox.Text = Inventory.CurrentPart.Name;
            modifyPartsInventoryTextBox.Text = Inventory.CurrentPart.InStock.ToString();
            modifyPartsPriceCostTextBox.Text = Inventory.CurrentPart.Price.ToString();
            modifyPartsMaxTextBox.Text = Inventory.CurrentPart.Max.ToString();
            modifyPartsMinTextBox.Text = Inventory.CurrentPart.Min.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPart;
                modifyPartsMachineIDCompNumTextBox.Text = e.MachineID.ToString();
                modifyPartInHouseRadio.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                modifyPartsMachineIDCompNumTextBox.Text = e.CompanyName.ToString();
                modifyPartInHouseRadio.Checked = false;
            }
        }

        private void ModifyPartForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Radio Buttons

        /// <summary>
        /// Changes the features of the GUI based on the In House radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the name of the Company Name Label to Machine ID
            modifyPartsMachineIdCompanyNameLabel.Text = "Machine ID";
            isInhouse = true;
            CheckRBSwitch();
        }

        /// <summary>
        /// Changes the features of the GUI based on the Outsourced radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the name of the Machine ID Lable to Company Name
            modifyPartsMachineIdCompanyNameLabel.Text = "Company Name";
            isInhouse = false;
            CheckRBSwitch();
        }

        #endregion

        #region Text Box

        private void modifyPartsNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartIDTextBox.Text))
            {
                modifyPartIDTextBox.BackColor = System.Drawing.Color.Salmon;
                modifyPartsSaveButton.Enabled = false;
            }
            else
            {
                modifyPartsNameTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        private void modifyPartsInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartsInventoryTextBox.Text) || !(int.TryParse(modifyPartsInventoryTextBox.Text, out int n)))
            {
                modifyPartsInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
                modifyPartsSaveButton.Enabled = false;
            }
            else
            {
                modifyPartsInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        private void modifyPartsPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartsPriceCostTextBox.Text) || !(decimal.TryParse(modifyPartsPriceCostTextBox.Text, out decimal n)))
            {
                modifyPartsPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
                modifyPartsSaveButton.Enabled = false;
            }
            else
            {
                modifyPartsPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        private void modifyPartsMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartsMaxTextBox.Text) || !(int.TryParse(modifyPartsMaxTextBox.Text, out int n)))
            {
                modifyPartsMaxTextBox.BackColor = System.Drawing.Color.Salmon;
                modifyPartsSaveButton.Enabled = false;
            }
            else
            {
                modifyPartsMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        private void modifyPartsMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modifyPartsMinTextBox.Text) || !(int.TryParse(modifyPartsMinTextBox.Text, out int n)))
            {
                modifyPartsMinTextBox.BackColor = System.Drawing.Color.Salmon;
                modifyPartsSaveButton.Enabled = false;
            }
            else
            {
                modifyPartsMinTextBox.BackColor = System.Drawing.Color.White;
            }
            modifyPartsSaveButton.Enabled = AllowSave();
        }

        private void modifyPartsMachineIDCompNumTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckRBSwitch();
        }

        #endregion

        #region Save and Cancel Buttons

        /// <summary>
        /// Saves the modified part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPartsSaveButton_Click(object sender, EventArgs e)
        {
            if (isInhouse)
            {
                Inhouse part = new Inhouse(modifyPartsNameTextBox.Text,
                    Convert.ToInt32(modifyPartsInventoryTextBox.Text),
                    Convert.ToDecimal(modifyPartsPriceCostTextBox.Text),
                    Convert.ToInt32(modifyPartsMaxTextBox.Text),
                    Convert.ToInt32(modifyPartsMinTextBox.Text),
                    Convert.ToInt32(modifyPartsMachineIDCompNumTextBox.Text));
                Inventory.UpdatePart(Inventory.CurrentPartIndex, part);
            }
            else
            {
                Outsourced part = new Outsourced(modifyPartsNameTextBox.Text,
                    Convert.ToInt32(modifyPartsInventoryTextBox.Text),
                    Convert.ToDecimal(modifyPartsPriceCostTextBox.Text),
                    Convert.ToInt32(modifyPartsMaxTextBox.Text),
                    Convert.ToInt32(modifyPartsMinTextBox.Text),
                    modifyPartsMachineIDCompNumTextBox.Text);
                Inventory.UpdatePart(Inventory.CurrentProductIndex, part);
            }

            // Closes window
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }

        /// <summary>
        /// Cancles the users selections and closes the Modify Parts window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifyPartsCancelButton_Click(object sender, EventArgs e)
        {
            // Closes window
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }

        #endregion
    }
}
