
namespace Builder
{
    partial class FormIssueReord
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.labelDiscoverer = new System.Windows.Forms.Label();
            this.labelDiscoveryDate = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(86, 505);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 40);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(238, 505);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(117, 40);
            this.buttonCreate.TabIndex = 25;
            this.buttonCreate.Text = "Create Issue";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(122, 197);
            this.comboBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(266, 21);
            this.comboBoxStatus.TabIndex = 21;
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(122, 132);
            this.comboBoxDiscoverer.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(266, 21);
            this.comboBoxDiscoverer.TabIndex = 17;
            // 
            // dateTimePickerDiscoveryDate
            // 
            this.dateTimePickerDiscoveryDate.CustomFormat = "hh:mm:ss tt dd MMM yyyy";
            this.dateTimePickerDiscoveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDiscoveryDate.Location = new System.Drawing.Point(122, 99);
            this.dateTimePickerDiscoveryDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDiscoveryDate.Name = "dateTimePickerDiscoveryDate";
            this.dateTimePickerDiscoveryDate.Size = new System.Drawing.Size(266, 20);
            this.dateTimePickerDiscoveryDate.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 254);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(350, 238);
            this.textBox1.TabIndex = 23;
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(122, 164);
            this.textBoxComponent.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(266, 20);
            this.textBoxComponent.TabIndex = 19;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(122, 67);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(266, 20);
            this.textBoxTitle.TabIndex = 13;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(122, 34);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(266, 20);
            this.textBoxId.TabIndex = 11;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(35, 229);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(87, 13);
            this.labelDescription.TabIndex = 22;
            this.labelDescription.Text = "Initial Description";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(35, 197);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 13);
            this.labelStatus.TabIndex = 20;
            this.labelStatus.Text = "Status:";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Location = new System.Drawing.Point(35, 164);
            this.labelComponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(64, 13);
            this.labelComponent.TabIndex = 18;
            this.labelComponent.Text = "Component:";
            // 
            // labelDiscoverer
            // 
            this.labelDiscoverer.AutoSize = true;
            this.labelDiscoverer.Location = new System.Drawing.Point(35, 132);
            this.labelDiscoverer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscoverer.Name = "labelDiscoverer";
            this.labelDiscoverer.Size = new System.Drawing.Size(61, 13);
            this.labelDiscoverer.TabIndex = 16;
            this.labelDiscoverer.Text = "Discoverer:";
            // 
            // labelDiscoveryDate
            // 
            this.labelDiscoveryDate.AutoSize = true;
            this.labelDiscoveryDate.Location = new System.Drawing.Point(35, 99);
            this.labelDiscoveryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiscoveryDate.Name = "labelDiscoveryDate";
            this.labelDiscoveryDate.Size = new System.Drawing.Size(83, 13);
            this.labelDiscoveryDate.TabIndex = 14;
            this.labelDiscoveryDate.Text = "Discovery Date:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(35, 67);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 13);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Title:";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(35, 34);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 13);
            this.labelId.TabIndex = 10;
            this.labelId.Text = "Id:";
            // 
            // FormIssueReord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 578);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.dateTimePickerDiscoveryDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.labelDiscoverer);
            this.Controls.Add(this.labelDiscoveryDate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelId);
            this.Name = "FormIssueReord";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormRecordIssue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDiscoveryDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.Label labelDiscoverer;
        private System.Windows.Forms.Label labelDiscoveryDate;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelId;
    }
}