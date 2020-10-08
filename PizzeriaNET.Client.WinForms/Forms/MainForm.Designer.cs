
namespace PizzeriaNET.Client.WinForms
{
    partial class MainForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOrderHistory = new System.Windows.Forms.Button();
            this.buttonPlaceNewOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(376, 45);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "PizzeriaNET";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOrderHistory
            // 
            this.buttonOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrderHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrderHistory.Location = new System.Drawing.Point(13, 57);
            this.buttonOrderHistory.Name = "buttonOrderHistory";
            this.buttonOrderHistory.Size = new System.Drawing.Size(375, 35);
            this.buttonOrderHistory.TabIndex = 2;
            this.buttonOrderHistory.Text = "View Order History";
            this.buttonOrderHistory.UseVisualStyleBackColor = true;
            this.buttonOrderHistory.Click += new System.EventHandler(this.buttonOrderHistory_Click);
            // 
            // buttonPlaceNewOrder
            // 
            this.buttonPlaceNewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaceNewOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlaceNewOrder.Location = new System.Drawing.Point(13, 98);
            this.buttonPlaceNewOrder.Name = "buttonPlaceNewOrder";
            this.buttonPlaceNewOrder.Size = new System.Drawing.Size(375, 35);
            this.buttonPlaceNewOrder.TabIndex = 3;
            this.buttonPlaceNewOrder.Text = "Place New Order";
            this.buttonPlaceNewOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceNewOrder.Click += new System.EventHandler(this.buttonPlaceNewOrder_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 143);
            this.Controls.Add(this.buttonPlaceNewOrder);
            this.Controls.Add(this.buttonOrderHistory);
            this.Controls.Add(this.labelName);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzeriaNET Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOrderHistory;
        private System.Windows.Forms.Button buttonPlaceNewOrder;
    }
}