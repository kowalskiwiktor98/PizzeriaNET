
namespace PizzeriaNET.Client.WinForms.Forms
{
    partial class OrderHistoryForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelOrderHistory = new System.Windows.Forms.Label();
            this.buttonCheckHistory = new System.Windows.Forms.Button();
            this.comboBoxOrders = new System.Windows.Forms.ComboBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxOrderDetails = new System.Windows.Forms.ListBox();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(13, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Your Email";
            this.textBox1.Size = new System.Drawing.Size(285, 29);
            this.textBox1.TabIndex = 0;
            // 
            // labelOrderHistory
            // 
            this.labelOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderHistory.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderHistory.Location = new System.Drawing.Point(13, 13);
            this.labelOrderHistory.Name = "labelOrderHistory";
            this.labelOrderHistory.Size = new System.Drawing.Size(366, 47);
            this.labelOrderHistory.TabIndex = 1;
            this.labelOrderHistory.Text = "Order History";
            this.labelOrderHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCheckHistory
            // 
            this.buttonCheckHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckHistory.AutoSize = true;
            this.buttonCheckHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckHistory.Location = new System.Drawing.Point(304, 87);
            this.buttonCheckHistory.Name = "buttonCheckHistory";
            this.buttonCheckHistory.Size = new System.Drawing.Size(75, 31);
            this.buttonCheckHistory.TabIndex = 2;
            this.buttonCheckHistory.Text = "Check";
            this.buttonCheckHistory.UseVisualStyleBackColor = true;
            this.buttonCheckHistory.Click += new System.EventHandler(this.buttonCheckHistory_Click);
            // 
            // comboBoxOrders
            // 
            this.comboBoxOrders.FormattingEnabled = true;
            this.comboBoxOrders.Location = new System.Drawing.Point(13, 169);
            this.comboBoxOrders.Name = "comboBoxOrders";
            this.comboBoxOrders.Size = new System.Drawing.Size(366, 23);
            this.comboBoxOrders.TabIndex = 3;
            this.comboBoxOrders.Text = "Your orders";
            this.comboBoxOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrders_SelectionChanged);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(13, 125);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(366, 23);
            this.progressBar.TabIndex = 4;
            // 
            // listBoxOrderDetails
            // 
            this.listBoxOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOrderDetails.FormattingEnabled = true;
            this.listBoxOrderDetails.ItemHeight = 15;
            this.listBoxOrderDetails.Items.AddRange(new object[] {
            "Select order"});
            this.listBoxOrderDetails.Location = new System.Drawing.Point(13, 249);
            this.listBoxOrderDetails.Name = "listBoxOrderDetails";
            this.listBoxOrderDetails.Size = new System.Drawing.Size(366, 184);
            this.listBoxOrderDetails.TabIndex = 5;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOrderDetails.Location = new System.Drawing.Point(13, 210);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(366, 23);
            this.labelOrderDetails.TabIndex = 6;
            this.labelOrderDetails.Text = "Order Details";
            this.labelOrderDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 450);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.listBoxOrderDetails);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.comboBoxOrders);
            this.Controls.Add(this.buttonCheckHistory);
            this.Controls.Add(this.labelOrderHistory);
            this.Controls.Add(this.textBox1);
            this.Name = "OrderHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderHistoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelOrderHistory;
        private System.Windows.Forms.Button buttonCheckHistory;
        private System.Windows.Forms.ComboBox comboBoxOrders;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxOrderDetails;
        private System.Windows.Forms.Label labelOrderDetails;
    }
}