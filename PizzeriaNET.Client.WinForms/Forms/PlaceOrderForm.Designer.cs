
namespace PizzeriaNET.Client.WinForms.Forms
{
    partial class PlaceOrderForm
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
            this.labelPlaceOrder = new System.Windows.Forms.Label();
            this.labelSelect = new System.Windows.Forms.Label();
            this.groupBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.groupBoxSelectOrder = new System.Windows.Forms.GroupBox();
            this.textBoxAdditionPrice = new System.Windows.Forms.TextBox();
            this.labelAddidtionPrice = new System.Windows.Forms.Label();
            this.textBoxMainPrice = new System.Windows.Forms.TextBox();
            this.labelMainPrice = new System.Windows.Forms.Label();
            this.comboBoxMainDish = new System.Windows.Forms.ComboBox();
            this.labelAddidion = new System.Windows.Forms.Label();
            this.comboBoxSideDish = new System.Windows.Forms.ComboBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.buttonAddOrderItem = new System.Windows.Forms.Button();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.checkBoxNotification = new System.Windows.Forms.CheckBox();
            this.groupBoxPlaceOrder.SuspendLayout();
            this.groupBoxSelectOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlaceOrder
            // 
            this.labelPlaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaceOrder.Location = new System.Drawing.Point(12, 9);
            this.labelPlaceOrder.Name = "labelPlaceOrder";
            this.labelPlaceOrder.Size = new System.Drawing.Size(531, 47);
            this.labelPlaceOrder.TabIndex = 0;
            this.labelPlaceOrder.Text = "Place Your Order";
            this.labelPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelect.Location = new System.Drawing.Point(6, 19);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(71, 30);
            this.labelSelect.TabIndex = 1;
            this.labelSelect.Text = "Select";
            // 
            // groupBoxPlaceOrder
            // 
            this.groupBoxPlaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlaceOrder.Controls.Add(this.checkBoxNotification);
            this.groupBoxPlaceOrder.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxPlaceOrder.Controls.Add(this.labelTotalPrice);
            this.groupBoxPlaceOrder.Controls.Add(this.buttonPlaceOrder);
            this.groupBoxPlaceOrder.Controls.Add(this.groupBoxSelectOrder);
            this.groupBoxPlaceOrder.Controls.Add(this.textBoxEmail);
            this.groupBoxPlaceOrder.Controls.Add(this.labelEmail);
            this.groupBoxPlaceOrder.Controls.Add(this.labelComment);
            this.groupBoxPlaceOrder.Controls.Add(this.textBoxComment);
            this.groupBoxPlaceOrder.Location = new System.Drawing.Point(12, 59);
            this.groupBoxPlaceOrder.Name = "groupBoxPlaceOrder";
            this.groupBoxPlaceOrder.Size = new System.Drawing.Size(531, 379);
            this.groupBoxPlaceOrder.TabIndex = 2;
            this.groupBoxPlaceOrder.TabStop = false;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(425, 300);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalPrice.TabIndex = 15;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.Location = new System.Drawing.Point(306, 296);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(117, 30);
            this.labelTotalPrice.TabIndex = 14;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // buttonPlaceOrder
            // 
            this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlaceOrder.Location = new System.Drawing.Point(306, 329);
            this.buttonPlaceOrder.Name = "buttonPlaceOrder";
            this.buttonPlaceOrder.Size = new System.Drawing.Size(219, 44);
            this.buttonPlaceOrder.TabIndex = 13;
            this.buttonPlaceOrder.Text = "Place Order";
            this.buttonPlaceOrder.UseVisualStyleBackColor = true;
            this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
            // 
            // groupBoxSelectOrder
            // 
            this.groupBoxSelectOrder.Controls.Add(this.textBoxAdditionPrice);
            this.groupBoxSelectOrder.Controls.Add(this.labelAddidtionPrice);
            this.groupBoxSelectOrder.Controls.Add(this.textBoxMainPrice);
            this.groupBoxSelectOrder.Controls.Add(this.labelSelect);
            this.groupBoxSelectOrder.Controls.Add(this.labelMainPrice);
            this.groupBoxSelectOrder.Controls.Add(this.comboBoxMainDish);
            this.groupBoxSelectOrder.Controls.Add(this.labelAddidion);
            this.groupBoxSelectOrder.Controls.Add(this.comboBoxSideDish);
            this.groupBoxSelectOrder.Controls.Add(this.labelQuantity);
            this.groupBoxSelectOrder.Controls.Add(this.buttonAddOrderItem);
            this.groupBoxSelectOrder.Controls.Add(this.numericUpDownQuantity);
            this.groupBoxSelectOrder.Location = new System.Drawing.Point(6, 22);
            this.groupBoxSelectOrder.Name = "groupBoxSelectOrder";
            this.groupBoxSelectOrder.Size = new System.Drawing.Size(519, 159);
            this.groupBoxSelectOrder.TabIndex = 12;
            this.groupBoxSelectOrder.TabStop = false;
            // 
            // textBoxAdditionPrice
            // 
            this.textBoxAdditionPrice.Location = new System.Drawing.Point(449, 71);
            this.textBoxAdditionPrice.Name = "textBoxAdditionPrice";
            this.textBoxAdditionPrice.ReadOnly = true;
            this.textBoxAdditionPrice.Size = new System.Drawing.Size(57, 23);
            this.textBoxAdditionPrice.TabIndex = 19;
            // 
            // labelAddidtionPrice
            // 
            this.labelAddidtionPrice.AutoSize = true;
            this.labelAddidtionPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddidtionPrice.Location = new System.Drawing.Point(378, 68);
            this.labelAddidtionPrice.Name = "labelAddidtionPrice";
            this.labelAddidtionPrice.Size = new System.Drawing.Size(65, 30);
            this.labelAddidtionPrice.TabIndex = 18;
            this.labelAddidtionPrice.Text = "Price:";
            // 
            // textBoxMainPrice
            // 
            this.textBoxMainPrice.Location = new System.Drawing.Point(449, 22);
            this.textBoxMainPrice.Name = "textBoxMainPrice";
            this.textBoxMainPrice.ReadOnly = true;
            this.textBoxMainPrice.Size = new System.Drawing.Size(57, 23);
            this.textBoxMainPrice.TabIndex = 17;
            // 
            // labelMainPrice
            // 
            this.labelMainPrice.AutoSize = true;
            this.labelMainPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainPrice.Location = new System.Drawing.Point(378, 19);
            this.labelMainPrice.Name = "labelMainPrice";
            this.labelMainPrice.Size = new System.Drawing.Size(65, 30);
            this.labelMainPrice.TabIndex = 16;
            this.labelMainPrice.Text = "Price:";
            // 
            // comboBoxMainDish
            // 
            this.comboBoxMainDish.FormattingEnabled = true;
            this.comboBoxMainDish.Location = new System.Drawing.Point(120, 26);
            this.comboBoxMainDish.Name = "comboBoxMainDish";
            this.comboBoxMainDish.Size = new System.Drawing.Size(174, 23);
            this.comboBoxMainDish.TabIndex = 2;
            this.comboBoxMainDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxMainDish_SelectedIndexChanged);
            // 
            // labelAddidion
            // 
            this.labelAddidion.AutoSize = true;
            this.labelAddidion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddidion.Location = new System.Drawing.Point(6, 70);
            this.labelAddidion.Name = "labelAddidion";
            this.labelAddidion.Size = new System.Drawing.Size(95, 30);
            this.labelAddidion.TabIndex = 3;
            this.labelAddidion.Text = "Addition";
            // 
            // comboBoxSideDish
            // 
            this.comboBoxSideDish.FormattingEnabled = true;
            this.comboBoxSideDish.Location = new System.Drawing.Point(120, 77);
            this.comboBoxSideDish.Name = "comboBoxSideDish";
            this.comboBoxSideDish.Size = new System.Drawing.Size(174, 23);
            this.comboBoxSideDish.TabIndex = 4;
            this.comboBoxSideDish.SelectedIndexChanged += new System.EventHandler(this.comboBoxSideDish_SelectedIndexChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.Location = new System.Drawing.Point(6, 119);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(95, 30);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            // 
            // buttonAddOrderItem
            // 
            this.buttonAddOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddOrderItem.Location = new System.Drawing.Point(358, 104);
            this.buttonAddOrderItem.Name = "buttonAddOrderItem";
            this.buttonAddOrderItem.Size = new System.Drawing.Size(148, 44);
            this.buttonAddOrderItem.TabIndex = 7;
            this.buttonAddOrderItem.Text = "Add";
            this.buttonAddOrderItem.UseVisualStyleBackColor = true;
            this.buttonAddOrderItem.Click += new System.EventHandler(this.buttonAddOrderItem_Click);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(120, 125);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(75, 23);
            this.numericUpDownQuantity.TabIndex = 6;
            this.numericUpDownQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(120, 187);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 29);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(6, 186);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(64, 30);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelComment.Location = new System.Drawing.Point(6, 240);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(109, 30);
            this.labelComment.TabIndex = 9;
            this.labelComment.Text = "Comment";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(120, 247);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(180, 126);
            this.textBoxComment.TabIndex = 8;
            // 
            // checkBoxNotification
            // 
            this.checkBoxNotification.AutoSize = true;
            this.checkBoxNotification.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxNotification.Location = new System.Drawing.Point(306, 185);
            this.checkBoxNotification.Name = "checkBoxNotification";
            this.checkBoxNotification.Size = new System.Drawing.Size(198, 34);
            this.checkBoxNotification.TabIndex = 17;
            this.checkBoxNotification.Text = "Send Notification";
            this.checkBoxNotification.UseVisualStyleBackColor = true;
            // 
            // PlaceOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.groupBoxPlaceOrder);
            this.Controls.Add(this.labelPlaceOrder);
            this.Name = "PlaceOrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PizzeriaNET";
            this.Load += new System.EventHandler(this.PlaceOrderForm_Load);
            this.groupBoxPlaceOrder.ResumeLayout(false);
            this.groupBoxPlaceOrder.PerformLayout();
            this.groupBoxSelectOrder.ResumeLayout(false);
            this.groupBoxSelectOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceOrder;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.GroupBox groupBoxPlaceOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ComboBox comboBoxSideDish;
        private System.Windows.Forms.Label labelAddidion;
        private System.Windows.Forms.ComboBox comboBoxMainDish;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonAddOrderItem;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.GroupBox groupBoxSelectOrder;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.TextBox textBoxMainPrice;
        private System.Windows.Forms.Label labelMainPrice;
        private System.Windows.Forms.TextBox textBoxAdditionPrice;
        private System.Windows.Forms.Label labelAddidtionPrice;
        private System.Windows.Forms.CheckBox checkBoxNotification;
    }
}