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
            this.addPartLabel.Location = new System.Drawing.Point(12, 38);
            this.addPartLabel.Name = "addPartLabel";
            this.addPartLabel.Size = new System.Drawing.Size(125, 32);
            this.addPartLabel.TabIndex = 0;
            this.addPartLabel.Text = "Add Part";
            // 
            // addPartGroupBoxRadioSet
            // 
            this.addPartGroupBoxRadioSet.Controls.Add(this.addPartOutsourcedRadio);
            this.addPartGroupBoxRadioSet.Controls.Add(this.addPartInHouseRadio);
            this.addPartGroupBoxRadioSet.Location = new System.Drawing.Point(168, 12);
            this.addPartGroupBoxRadioSet.Name = "addPartGroupBoxRadioSet";
            this.addPartGroupBoxRadioSet.Size = new System.Drawing.Size(426, 82);
            this.addPartGroupBoxRadioSet.TabIndex = 1;
            this.addPartGroupBoxRadioSet.TabStop = false;
            // 
            // addPartOutsourcedRadio
            // 
            this.addPartOutsourcedRadio.AutoSize = true;
            this.addPartOutsourcedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourcedRadio.Location = new System.Drawing.Point(242, 29);
            this.addPartOutsourcedRadio.Name = "addPartOutsourcedRadio";
            this.addPartOutsourcedRadio.Size = new System.Drawing.Size(135, 29);
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
            this.addPartInHouseRadio.Location = new System.Drawing.Point(66, 29);
            this.addPartInHouseRadio.Name = "addPartInHouseRadio";
            this.addPartInHouseRadio.Size = new System.Drawing.Size(113, 29);
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
            this.addPartIDLabel.Location = new System.Drawing.Point(229, 164);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(36, 29);
            this.addPartIDLabel.TabIndex = 2;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartsPriceCostLabel
            // 
            this.addPartsPriceCostLabel.AutoSize = true;
            this.addPartsPriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsPriceCostLabel.Location = new System.Drawing.Point(128, 393);
            this.addPartsPriceCostLabel.Name = "addPartsPriceCostLabel";
            this.addPartsPriceCostLabel.Size = new System.Drawing.Size(137, 29);
            this.addPartsPriceCostLabel.TabIndex = 3;
            this.addPartsPriceCostLabel.Text = "Price / Cost";
            // 
            // addPartsInventoryLabel
            // 
            this.addPartsInventoryLabel.AutoSize = true;
            this.addPartsInventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsInventoryLabel.Location = new System.Drawing.Point(156, 302);
            this.addPartsInventoryLabel.Name = "addPartsInventoryLabel";
            this.addPartsInventoryLabel.Size = new System.Drawing.Size(109, 29);
            this.addPartsInventoryLabel.TabIndex = 4;
            this.addPartsInventoryLabel.Text = "Inventory";
            // 
            // addPartsNameLabel
            // 
            this.addPartsNameLabel.AutoSize = true;
            this.addPartsNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsNameLabel.Location = new System.Drawing.Point(187, 229);
            this.addPartsNameLabel.Name = "addPartsNameLabel";
            this.addPartsNameLabel.Size = new System.Drawing.Size(78, 29);
            this.addPartsNameLabel.TabIndex = 5;
            this.addPartsNameLabel.Text = "Name";
            // 
            // addPartsMachineIdCompanyNameLabel
            // 
            this.addPartsMachineIdCompanyNameLabel.AutoSize = true;
            this.addPartsMachineIdCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMachineIdCompanyNameLabel.Location = new System.Drawing.Point(65, 569);
            this.addPartsMachineIdCompanyNameLabel.MinimumSize = new System.Drawing.Size(200, 30);
            this.addPartsMachineIdCompanyNameLabel.Name = "addPartsMachineIdCompanyNameLabel";
            this.addPartsMachineIdCompanyNameLabel.Size = new System.Drawing.Size(200, 30);
            this.addPartsMachineIdCompanyNameLabel.TabIndex = 6;
            this.addPartsMachineIdCompanyNameLabel.Text = "Machine ID";
            this.addPartsMachineIdCompanyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addPartsMinLabel
            // 
            this.addPartsMinLabel.AutoSize = true;
            this.addPartsMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMinLabel.Location = new System.Drawing.Point(405, 481);
            this.addPartsMinLabel.Name = "addPartsMinLabel";
            this.addPartsMinLabel.Size = new System.Drawing.Size(52, 29);
            this.addPartsMinLabel.TabIndex = 7;
            this.addPartsMinLabel.Text = "Min";
            // 
            // addPartsMaxLabel
            // 
            this.addPartsMaxLabel.AutoSize = true;
            this.addPartsMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsMaxLabel.Location = new System.Drawing.Point(208, 481);
            this.addPartsMaxLabel.Name = "addPartsMaxLabel";
            this.addPartsMaxLabel.Size = new System.Drawing.Size(57, 29);
            this.addPartsMaxLabel.TabIndex = 8;
            this.addPartsMaxLabel.Text = "Max";
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Enabled = false;
            this.addPartIDTextBox.Location = new System.Drawing.Point(297, 171);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(160, 22);
            this.addPartIDTextBox.TabIndex = 9;
            // 
            // addPartsPriceCostTextBox
            // 
            this.addPartsPriceCostTextBox.Location = new System.Drawing.Point(297, 400);
            this.addPartsPriceCostTextBox.Name = "addPartsPriceCostTextBox";
            this.addPartsPriceCostTextBox.Size = new System.Drawing.Size(160, 22);
            this.addPartsPriceCostTextBox.TabIndex = 10;
            this.addPartsPriceCostTextBox.TextChanged += new System.EventHandler(this.addPartsPriceCostTextBox_TextChanged);
            // 
            // addPartsMaxTextBox
            // 
            this.addPartsMaxTextBox.Location = new System.Drawing.Point(271, 488);
            this.addPartsMaxTextBox.Name = "addPartsMaxTextBox";
            this.addPartsMaxTextBox.Size = new System.Drawing.Size(128, 22);
            this.addPartsMaxTextBox.TabIndex = 11;
            this.addPartsMaxTextBox.TextChanged += new System.EventHandler(this.addPartsMaxTextBox_TextChanged);
            // 
            // addPartsMinTextBox
            // 
            this.addPartsMinTextBox.Location = new System.Drawing.Point(463, 488);
            this.addPartsMinTextBox.Name = "addPartsMinTextBox";
            this.addPartsMinTextBox.Size = new System.Drawing.Size(139, 22);
            this.addPartsMinTextBox.TabIndex = 12;
            this.addPartsMinTextBox.TextChanged += new System.EventHandler(this.addPartsMinTextBox_TextChanged);
            // 
            // addPartsInventoryTextBox
            // 
            this.addPartsInventoryTextBox.Location = new System.Drawing.Point(297, 309);
            this.addPartsInventoryTextBox.Name = "addPartsInventoryTextBox";
            this.addPartsInventoryTextBox.Size = new System.Drawing.Size(160, 22);
            this.addPartsInventoryTextBox.TabIndex = 13;
            this.addPartsInventoryTextBox.TextChanged += new System.EventHandler(this.addPartsInventoryTextBox_TextChanged);
            // 
            // addPartsNameTextBox
            // 
            this.addPartsNameTextBox.Location = new System.Drawing.Point(297, 236);
            this.addPartsNameTextBox.Name = "addPartsNameTextBox";
            this.addPartsNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.addPartsNameTextBox.TabIndex = 14;
            this.addPartsNameTextBox.TextChanged += new System.EventHandler(this.addPartsNameTextBox_TextChanged);
            // 
            // addPartsMachineIDCompNumTextBox
            // 
            this.addPartsMachineIDCompNumTextBox.Location = new System.Drawing.Point(271, 576);
            this.addPartsMachineIDCompNumTextBox.Name = "addPartsMachineIDCompNumTextBox";
            this.addPartsMachineIDCompNumTextBox.Size = new System.Drawing.Size(186, 22);
            this.addPartsMachineIDCompNumTextBox.TabIndex = 15;
            this.addPartsMachineIDCompNumTextBox.TextChanged += new System.EventHandler(this.addPartsMachineIDCompNumTextBox_TextChanged);
            // 
            // addPartsSaveButton
            // 
            this.addPartsSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsSaveButton.Location = new System.Drawing.Point(369, 643);
            this.addPartsSaveButton.Name = "addPartsSaveButton";
            this.addPartsSaveButton.Size = new System.Drawing.Size(88, 39);
            this.addPartsSaveButton.TabIndex = 16;
            this.addPartsSaveButton.Text = "Save";
            this.addPartsSaveButton.UseVisualStyleBackColor = true;
            this.addPartsSaveButton.Click += new System.EventHandler(this.addPartsSaveButton_Click);
            // 
            // addPartsCancelButton
            // 
            this.addPartsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.addPartsCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartsCancelButton.Location = new System.Drawing.Point(481, 643);
            this.addPartsCancelButton.Name = "addPartsCancelButton";
            this.addPartsCancelButton.Size = new System.Drawing.Size(121, 39);
            this.addPartsCancelButton.TabIndex = 17;
            this.addPartsCancelButton.Text = "Cancel";
            this.addPartsCancelButton.UseVisualStyleBackColor = true;
            this.addPartsCancelButton.Click += new System.EventHandler(this.addPartsCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AcceptButton = this.addPartsSaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.addPartsCancelButton;
            this.ClientSize = new System.Drawing.Size(742, 771);
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