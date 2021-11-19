
namespace Builder
{
    partial class FormIssueDashboard
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
            this.IssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.IssuesByMonth = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIssuesByMonth = new System.Windows.Forms.Label();
            this.textBoxTotalIssues = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IssuesByDiscoverer
            // 
            this.IssuesByDiscoverer.FormattingEnabled = true;
            this.IssuesByDiscoverer.Location = new System.Drawing.Point(23, 296);
            this.IssuesByDiscoverer.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesByDiscoverer.Name = "IssuesByDiscoverer";
            this.IssuesByDiscoverer.ScrollAlwaysVisible = true;
            this.IssuesByDiscoverer.Size = new System.Drawing.Size(340, 121);
            this.IssuesByDiscoverer.Sorted = true;
            this.IssuesByDiscoverer.TabIndex = 12;
            // 
            // IssuesByMonth
            // 
            this.IssuesByMonth.FormattingEnabled = true;
            this.IssuesByMonth.Location = new System.Drawing.Point(23, 126);
            this.IssuesByMonth.Margin = new System.Windows.Forms.Padding(2);
            this.IssuesByMonth.Name = "IssuesByMonth";
            this.IssuesByMonth.ScrollAlwaysVisible = true;
            this.IssuesByMonth.Size = new System.Drawing.Size(340, 121);
            this.IssuesByMonth.Sorted = true;
            this.IssuesByMonth.TabIndex = 11;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(146, 434);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 45);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Issues by Discoverer";
            // 
            // labelIssuesByMonth
            // 
            this.labelIssuesByMonth.AutoSize = true;
            this.labelIssuesByMonth.Location = new System.Drawing.Point(141, 100);
            this.labelIssuesByMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIssuesByMonth.Name = "labelIssuesByMonth";
            this.labelIssuesByMonth.Size = new System.Drawing.Size(84, 13);
            this.labelIssuesByMonth.TabIndex = 8;
            this.labelIssuesByMonth.Text = "Issues by Month";
            // 
            // textBoxTotalIssues
            // 
            this.textBoxTotalIssues.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxTotalIssues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalIssues.Location = new System.Drawing.Point(202, 62);
            this.textBoxTotalIssues.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTotalIssues.Name = "textBoxTotalIssues";
            this.textBoxTotalIssues.ReadOnly = true;
            this.textBoxTotalIssues.Size = new System.Drawing.Size(75, 13);
            this.textBoxTotalIssues.TabIndex = 6;
            this.textBoxTotalIssues.TabStop = false;
            this.textBoxTotalIssues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(127, 38);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(119, 13);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total Number of Issues:";
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 517);
            this.Controls.Add(this.IssuesByDiscoverer);
            this.Controls.Add(this.IssuesByMonth);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIssuesByMonth);
            this.Controls.Add(this.textBoxTotalIssues);
            this.Controls.Add(this.labelTotal);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IssuesByDiscoverer;
        private System.Windows.Forms.ListBox IssuesByMonth;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIssuesByMonth;
        private System.Windows.Forms.TextBox textBoxTotalIssues;
        private System.Windows.Forms.Label labelTotal;
    }
}