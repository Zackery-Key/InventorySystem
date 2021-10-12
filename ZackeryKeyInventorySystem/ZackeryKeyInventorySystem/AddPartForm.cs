using System;
using System.Windows.Forms;

namespace ZackeryKeyInventorySystem
{
    public partial class AddPartForm : Form
    {
        // Private Variable
        bool isInhouse;

        #region Private Methods

        /// <summary>
        /// Checks to see if the Radio button is set to Inhouse or Outsourced before saving the new object
        /// </summary>
        private void CheckRBSwitch()
        {
            // if txtSource has no text, or you're working with a InHouse object and the contents of MachineID/CompanyName Textbox is not a number, flag an error
            if (string.IsNullOrWhiteSpace(addPartsMachineIDCompNumTextBox.Text) || (isInhouse && !Int32.TryParse(addPartsMachineIDCompNumTextBox.Text, out int number)))
            {
                addPartsMachineIDCompNumTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                addPartsMachineIDCompNumTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartsSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        /// Checks to see if all the infomation is filled with the correct type of data before saving
        /// </summary>
        /// <returns></returns>
        private bool AllowSave()
        {
            // Checks to make sure there is now whitespace or null in the textbox
            return ((!string.IsNullOrWhiteSpace(addPartsNameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addPartsInventoryTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addPartsPriceCostTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addPartsMaxTextBox.Text) &&
                !string.IsNullOrWhiteSpace(addPartsMinTextBox.Text))

                &&

                // Checks to make sure the right type of info is recorded for the Radio textbox
                ((!isInhouse && !string.IsNullOrWhiteSpace(addPartsMachineIDCompNumTextBox.Text)) ||
                (isInhouse && Int32.TryParse(addPartsMachineIDCompNumTextBox.Text, out int number))));
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor for AddPartsForm
        /// </summary>
        public AddPartForm()
        {
            InitializeComponent();
            // Incriments the PartID number
            addPartIDTextBox.Text = Convert.ToString(Part.partCount);
        }

        private void AddPartsForm_Load(object sender, EventArgs e)
        {

        }


        #endregion

        #region Radio Buttons

        /// <summary>
        /// Controls what the happens when the In-House Radio Button does
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartInHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the name of the Company Name Label to Machine ID
            addPartsMachineIdCompanyNameLabel.Text = "Machine ID";
            isInhouse = true;
            CheckRBSwitch();
        }

        /// <summary>
        /// Controls what the happens when the Outsourced Radio Button does
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartOutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Changes the name of the Machine ID Lable to Company Name
            addPartsMachineIdCompanyNameLabel.Text = "Company Name";
            isInhouse = false;
            CheckRBSwitch();
        }


        #endregion

        #region Text Box

        /// <summary>
        ///  Validates Textbox for Part's Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartsNameTextBox.Text))
            {
                addPartsNameTextBox.BackColor = System.Drawing.Color.Salmon;
                addPartsSaveButton.Enabled = false;
            }
            else
            {
                addPartsNameTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartsSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        ///  Validates Textbox for Part's Inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartsInventoryTextBox.Text) || !(int.TryParse(addPartsInventoryTextBox.Text, out int n)))
            {
                addPartsInventoryTextBox.BackColor = System.Drawing.Color.Salmon;
                addPartsSaveButton.Enabled = false;
            }
            else
            {
                addPartsInventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartsSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        ///  Validates Textbox for Part's Price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsPriceCostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartsPriceCostTextBox.Text) || !(decimal.TryParse(addPartsPriceCostTextBox.Text, out decimal n)))
            {
                addPartsPriceCostTextBox.BackColor = System.Drawing.Color.Salmon;
                addPartsSaveButton.Enabled = false;
            }
            else
            {
                addPartsPriceCostTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartsSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        ///  Validates Textbox for Part's Max
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartsMaxTextBox.Text) || !(int.TryParse(addPartsMaxTextBox.Text, out int n)))
            {
                addPartsMaxTextBox.BackColor = System.Drawing.Color.Salmon;
                addPartsSaveButton.Enabled = false;
            }
            else
            {
                addPartsMaxTextBox.BackColor = System.Drawing.Color.White;
            }
            addPartsSaveButton.Enabled = AllowSave();
        }

        /// <summary>
        ///  Validates Textbox for Part's Min
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addPartsMinTextBox.Text) || !(int.TryParse(addPartsMinTextBox.Text, out int n)))
            {
                addPartsMinTextBox.BackColor = System.Drawing.Color.Salmon;
                addPartsSaveButton.Enabled = false;
            }
            else
            {
                addPartsMinTextBox.BackColor = System.Drawing.Color.White;
                addPartsSaveButton.Enabled = AllowSave();
            }
        }

        /// <summary>
        ///  Validates Textbox for Part's Radio Text Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsMachineIDCompNumTextBox_TextChanged(object sender, EventArgs e) { CheckRBSwitch(); }

        #endregion

        #region Save and Cancel Button



        /// <summary>
        /// Controls the process of saving changes when the save button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPartsSaveButton_Click(object sender, EventArgs e)
        {
            // Validates that the minimum does not exceed the maximum
            if (Convert.ToInt32(addPartsMaxTextBox.Text) > Convert.ToInt32(addPartsMinTextBox.Text))
            {
                if (Convert.ToInt32(addPartsInventoryTextBox.Text) >= Convert.ToInt32(addPartsMinTextBox.Text)
                    && Convert.ToInt32(addPartsInventoryTextBox.Text) <= Convert.ToInt32(addPartsMaxTextBox.Text))
                {
                    if (AllowSave())
                    {
                        // Creates new Inhouse part if the Inhouse radio is selected
                        if (addPartInHouseRadio.Checked)
                        {
                            // Creates new Inhouse object
                            Inhouse inhousePart = new Inhouse(
                                addPartsNameTextBox.Text,
                                Convert.ToInt32(addPartsInventoryTextBox.Text),
                                Convert.ToDecimal(addPartsPriceCostTextBox.Text),
                                Convert.ToInt32(addPartsMinTextBox.Text),
                                Convert.ToInt32(addPartsMaxTextBox.Text),
                                Convert.ToInt32(addPartsMachineIDCompNumTextBox.Text));

                            // Calls Inhouse Part Constructor
                            Inventory.AddPart(inhousePart);
                        }

                        // Creates new Outsourced part if the Outsource radio is selected
                        else if (addPartOutsourcedRadio.Checked)
                        {
                            // Creates new Outsourced object
                            Outsourced outsourcedPart = new Outsourced(
                                addPartsNameTextBox.Text,
                                Convert.ToInt32(addPartsInventoryTextBox.Text),
                                Convert.ToDecimal(addPartsPriceCostTextBox.Text),
                                Convert.ToInt32(addPartsMinTextBox.Text),
                                Convert.ToInt32(addPartsMaxTextBox.Text),
                                addPartsMachineIDCompNumTextBox.Text);

                            // Calls Outsourced Constructor
                            Inventory.AddPart(outsourcedPart);
                        }

                        // Creates new mainscreen object and closes AddPartForm Obj
                        MainScreenForm mainScreen = new MainScreenForm();
                        this.Hide();
                        mainScreen.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Machine ID can not contain a string.", "Error");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Inventory is outside of set Max and Min values.", "Error");
                    return;
                }
            }

            // Throws error if min is not lower than max
            else
            {
                MessageBox.Show("Your min value can not exceed the max value.", "Error");
            }

        }

        /// <summary>
        /// Closes the window, without saving any changes, when the cancel button is pressed
        /// </summary>
        /// 
        private void addPartsCancelButton_Click(object sender, EventArgs e)
        {
            // Closes window and opens main screen
            MainScreenForm mainScreen = new MainScreenForm();
            this.Hide();
            mainScreen.ShowDialog();
        }

        #endregion
    }
}



