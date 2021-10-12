namespace ZackeryKeyInventorySystem
{
    partial class AddPartForm
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
            this.addPartLabel = new System.Windows.Forms.Label();
            this.addPartGroupBoxRadioSet = new System.Windows.Forms.GroupBox();
            this.addPartOutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.addPartInHouseRadio = new System.Windows.Forms.RadioButton();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartsPriceCostLabel = new System.Windows.Forms.Label();
            this.addPartsInventoryLabel = new System.Windows.Forms.Label();
            this.addPartsNameLabel = new System.Windows.Forms.Label();
            this.addPartsMachineIdCompanyNameLabel = new System.Windows.Forms.Label();
            this.addPartsMinLabel = new System.Windows.Forms.Label();
            this.addPartsMaxLabel = new System.Windows.Forms.Label();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartsPriceCostTextBox = new System.Windows.Forms.TextBox();
            this.addPartsMaxTextBox = new System.Windows.Forms.TextBox();
            this.addPartsMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartsInventoryTextBox = new System.Windows.Forms.TextBox();
            this.addPartsNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartsMachineIDCompNumTextBox = new System.Windows.Forms.TextBox();
            this.addPartsSaveButton = new System.Windows.Forms.Button();
            this.addPartsCancelButton = new System.Windows.Forms.Button();
            this.addPartGroupBoxRadioSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // addPartLabel
            // 
            this.addPartLabel.AutoSize = true;
            this.addPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartLabel.Location = new System.Drawing.Point(14, 48);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(144, 38);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartGroupBoxRadioSet
            // 
            this.addPartGroupBoxRadioSet.Controls.Add(this.addPartOutsourcedRadio);
            this.addPartGroupBoxRadioSet.Controls.Add(this.addPartInHouseRadio);
            this.addPartGroupBoxRadioSet.Location = new System.Drawing.Point(189, 15);
            this.addPartGroupBoxRadioSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartGroupBoxRadioSet.Name = "addPartGroupBoxRadioSet";
            this.addPartGroupBoxRadioSet.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartGroupBoxRadioSet.Size = new System.Drawing.Size(479, 102);
            this.addPartGroupBoxRadioSet.TabIndex = 1;
            this.addPartGroupBoxRadioSet.TabStop = false;
            // 
            // addPartOutsourcedRadio
            // 
            this.addPartOutsourcedRadio.AutoSize = true;
            this.addPartOutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourcedRadio.Location = new System.Drawing.Point(272, 36);
            this.addPartOutsourcedRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartOutsourcedRadio.Name = "addPartOutsourcedRadio";
            this.addPartOutsourcedRadio.Size = new System.Drawing.Size(163, 33);
            this.addPartOutsourcedRadio.TabIndex = 1;
            this.addPartOutsourcedRadio.TabStop = true;
            this.addPartOutsourcedRadio.Text = "Outsourced";
            this.addPartOutsourcedRadio.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadio.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadio_CheckedChanged);
            // 
            // addPartInHouseRadio
            // 
            this.addPartInHouseRadio.AutoSize = true;
            this.addPartInHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInHouseRadio.Location = new System.Drawing.Point(74, 36);
            this.addPartInHouseRadio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartInHouseRadio.Name = "addPartInHouseRadio";
            this.addPartInHouseRadio.Size = new System.Drawing.Size(135, 33);
            this.addPartInHouseRadio.TabIndex = 0;
            this.addPartInHouseRadio.TabStop = true;
            this.addPartInHouseRadio.Text = "In-House";
            this.addPartInHouseRadio.UseVisualStyleBackColor = true;
            this.addPartInHouseRadio.CheckedChanged += new System.EventHandler(this.addPartInHouseRadio_CheckedChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIDLabel.Location = new System.Drawing.Point(258, 205);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(42, 32);
            this.addPartIDLabel.TabIndex = 2;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartsPriceCostLabel
            // 
            this.addPartsPriceCostLabel.AutoSize = true;
            this.addPartsPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsPriceCostLabel.Location = new System.Drawing.Point(144, 491);
            this.addPartsPriceCostLabel.Name = "addPartsPriceCostLabel";
            this.addPartsPriceCostLabel.Size = new System.Drawing.Size(160, 32);
            this.addPartsPriceCostLabel.TabIndex = 3;
            this.addPartsPriceCostLabel.Text = "Price / Cost";
            // 
            // addPartsInventoryLabel
            // 
            this.addPartsInventoryLabel.AutoSize = true;
            this.addPartsInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsInventoryLabel.Location = new System.Drawing.Point(176, 378);
            this.addPartsInventoryLabel.Name = "addPartsInventoryLabel";
            this.addPartsInventoryLabel.Size = new System.Drawing.Size(131, 32);
            this.addPartsInventoryLabel.TabIndex = 4;
            this.addPartsInventoryLabel.Text = "Inventory";
            // 
            // addPartsNameLabel
            // 
            this.addPartsNameLabel.AutoSize = true;
            this.addPartsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsNameLabel.Location = new System.Drawing.Point(210, 286);
            this.addPartsNameLabel.Name = "addPartsNameLabel";
            this.addPartsNameLabel.Size = new System.Drawing.Size(90, 32);
            this.addPartsNameLabel.TabIndex = 5;
            this.addPartsNameLabel.Text = "Name";
            // 
            // addPartsMachineIdCompanyNameLabel
            // 
            this.addPartsMachineIdCompanyNameLabel.AutoSize = true;
            this.addPartsMachineIdCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMachineIdCompanyNameLabel.Location = new System.Drawing.Point(73, 711);
            this.addPartsMachineIdCompanyNameLabel.MinimumSize = new System.Drawing.Size(225, 38);
            this.addPartsMachineIdCompanyNameLabel.Name = "addPartsMachineIdCompanyNameLabel";
            this.addPartsMachineIdCompanyNameLabel.Size = new System.Drawing.Size(225, 38);
            this.addPartsMachineIdCompanyNameLabel.TabIndex = 6;
            this.addPartsMachineIdCompanyNameLabel.Text = "Machine ID";
            this.addPartsMachineIdCompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartsMinLabel
            // 
            this.addPartsMinLabel.AutoSize = true;
            this.addPartsMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMinLabel.Location = new System.Drawing.Point(456, 601);
            this.addPartsMinLabel.Name = "addPartsMinLabel";
            this.addPartsMinLabel.Size = new System.Drawing.Size(61, 32);
            this.addPartsMinLabel.TabIndex = 7;
            this.addPartsMinLabel.Text = "Min";
            // 
            // addPartsMaxLabel
            // 
            this.addPartsMaxLabel.AutoSize = true;
            this.addPartsMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMaxLabel.Location = new System.Drawing.Point(234, 601);
            this.addPartsMaxLabel.Name = "addPartsMaxLabel";
            this.addPartsMaxLabel.Size = new System.Drawing.Size(68, 32);
            this.addPartsMaxLabel.TabIndex = 8;
            this.addPartsMaxLabel.Text = "Max";
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Enabled = false;
            this.addPartIDTextBox.Location = new System.Drawing.Point(334, 214);
            this.addPartIDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(180, 26);
            this.addPartIDTextBox.TabIndex = 9;
            // 
            // addPartsPriceCostTextBox
            // 
            this.addPartsPriceCostTextBox.Location = new System.Drawing.Point(334, 500);
            this.addPartsPriceCostTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsPriceCostTextBox.Name = "addPartsPriceCostTextBox";
            this.addPartsPriceCostTextBox.Size = new System.Drawing.Size(180, 26);
            this.addPartsPriceCostTextBox.TabIndex = 10;
            this.addPartsPriceCostTextBox.TextChanged += new System.EventHandler(this.addPartsPriceCostTextBox_TextChanged);
            // 
            // addPartsMaxTextBox
            // 
            this.addPartsMaxTextBox.Location = new System.Drawing.Point(305, 610);
            this.addPartsMaxTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsMaxTextBox.Name = "addPartsMaxTextBox";
            this.addPartsMaxTextBox.Size = new System.Drawing.Size(144, 26);
            this.addPartsMaxTextBox.TabIndex = 11;
            this.addPartsMaxTextBox.TextChanged += new System.EventHandler(this.addPartsMaxTextBox_TextChanged);
            // 
            // addPartsMinTextBox
            // 
            this.addPartsMinTextBox.Location = new System.Drawing.Point(521, 610);
            this.addPartsMinTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsMinTextBox.Name = "addPartsMinTextBox";
            this.addPartsMinTextBox.Size = new System.Drawing.Size(156, 26);
            this.addPartsMinTextBox.TabIndex = 12;
            this.addPartsMinTextBox.TextChanged += new System.EventHandler(this.addPartsMinTextBox_TextChanged);
            // 
            // addPartsInventoryTextBox
            // 
            this.addPartsInventoryTextBox.Location = new System.Drawing.Point(334, 386);
            this.addPartsInventoryTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsInventoryTextBox.Name = "addPartsInventoryTextBox";
            this.addPartsInventoryTextBox.Size = new System.Drawing.Size(180, 26);
            this.addPartsInventoryTextBox.TabIndex = 13;
            this.addPartsInventoryTextBox.TextChanged += new System.EventHandler(this.addPartsInventoryTextBox_TextChanged);
            // 
            // addPartsNameTextBox
            // 
            this.addPartsNameTextBox.Location = new System.Drawing.Point(334, 295);
            this.addPartsNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsNameTextBox.Name = "addPartsNameTextBox";
            this.addPartsNameTextBox.Size = new System.Drawing.Size(180, 26);
            this.addPartsNameTextBox.TabIndex = 14;
            this.addPartsNameTextBox.TextChanged += new System.EventHandler(this.addPartsNameTextBox_TextChanged);
            // 
            // addPartsMachineIDCompNumTextBox
            // 
            this.addPartsMachineIDCompNumTextBox.Location = new System.Drawing.Point(305, 720);
            this.addPartsMachineIDCompNumTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsMachineIDCompNumTextBox.Name = "addPartsMachineIDCompNumTextBox";
            this.addPartsMachineIDCompNumTextBox.Size = new System.Drawing.Size(209, 26);
            this.addPartsMachineIDCompNumTextBox.TabIndex = 15;
            this.addPartsMachineIDCompNumTextBox.TextChanged += new System.EventHandler(this.addPartsMachineIDCompNumTextBox_TextChanged);
            // 
            // addPartsSaveButton
            // 
            this.addPartsSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsSaveButton.Location = new System.Drawing.Point(415, 804);
            this.addPartsSaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsSaveButton.Name = "addPartsSaveButton";
            this.addPartsSaveButton.Size = new System.Drawing.Size(99, 49);
            this.addPartsSaveButton.TabIndex = 16;
            this.addPartsSaveButton.Text = "Save";
            this.addPartsSaveButton.UseVisualStyleBackColor = true;
            this.addPartsSaveButton.Click += new System.EventHandler(this.addPartsSaveButton_Click);
            // 
            // addPartsCancelButton
            // 
            this.addPartsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addPartsCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsCancelButton.Location = new System.Drawing.Point(541, 804);
            this.addPartsCancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsCancelButton.Name = "addPartsCancelButton";
            this.addPartsCancelButton.Size = new System.Drawing.Size(136, 49);
            this.addPartsCancelButton.TabIndex = 17;
            this.addPartsCancelButton.Text = "Cancel";
            this.addPartsCancelButton.UseVisualStyleBackColor = true;
            this.addPartsCancelButton.Click += new System.EventHandler(this.addPartsCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AcceptButton = this.addPartsSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.addPartsCancelButton;
            this.ClientSize = new System.Drawing.Size(835, 964);
            this.Controls.Add(this.addPartsCancelButton);
            this.Controls.Add(this.addPartsSaveButton);
            this.Controls.Add(this.addPartsMachineIDCompNumTextBox);
            this.Controls.Add(this.addPartsNameTextBox);
            this.Controls.Add(this.addPartsInventoryTextBox);
            this.Controls.Add(this.addPartsMinTextBox);
            this.Controls.Add(this.addPartsMaxTextBox);
            this.Controls.Add(this.addPartsPriceCostTextBox);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.addPartsMaxLabel);
            this.Controls.Add(this.addPartsMinLabel);
            this.Controls.Add(this.addPartsMachineIdCompanyNameLabel);
            this.Controls.Add(this.addPartsNameLabel);
            this.Controls.Add(this.addPartsInventoryLabel);
            this.Controls.Add(this.addPartsPriceCostLabel);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartGroupBoxRadioSet);
            this.Controls.Add(this.addPartLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPartForm";
            this.Text = "Part";
            this.Load += new System.EventHandler(this.AddPartsForm_Load);
            this.addPartGroupBoxRadioSet.ResumeLayout(false);
            this.addPartGroupBoxRadioSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartLabel;
        private System.Windows.Forms.GroupBox addPartGroupBoxRadioSet;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadio;
        private System.Windows.Forms.RadioButton addPartInHouseRadio;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.Label addPartsPriceCostLabel;
        private System.Windows.Forms.Label addPartsInventoryLabel;
        private System.Windows.Forms.Label addPartsNameLabel;
        private System.Windows.Forms.Label addPartsMachineIdCompanyNameLabel;
        private System.Windows.Forms.Label addPartsMinLabel;
        private System.Windows.Forms.Label addPartsMaxLabel;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartsPriceCostTextBox;
        private System.Windows.Forms.TextBox addPartsMaxTextBox;
        private System.Windows.Forms.TextBox addPartsMinTextBox;
        private System.Windows.Forms.TextBox addPartsInventoryTextBox;
        private System.Windows.Forms.TextBox addPartsNameTextBox;
        private System.Windows.Forms.TextBox addPartsMachineIDCompNumTextBox;
        private System.Windows.Forms.Button addPartsSaveButton;
        private System.Windows.Forms.Button addPartsCancelButton;
    }
}