
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
            this.labelMainDish = new System.Windows.Forms.Label();
            this.groupBoxPlaceOrder = new System.Windows.Forms.GroupBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddOrderItem = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.comboBoxSideDish = new System.Windows.Forms.ComboBox();
            this.labelSideDish = new System.Windows.Forms.Label();
            this.comboBoxMainDish = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxSelectOrder = new System.Windows.Forms.GroupBox();
            this.buttonPlaceOrder = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBoxPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxSelectOrder.SuspendLayout();
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
            // labelMainDish
            // 
            this.labelMainDish.AutoSize = true;
            this.labelMainDish.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMainDish.Location = new System.Drawing.Point(6, 19);
            this.labelMainDish.Name = "labelMainDish";
            this.labelMainDish.Size = new System.Drawing.Size(108, 30);
            this.labelMainDish.TabIndex = 1;
            this.labelMainDish.Text = "Main Dish";
            // 
            // groupBoxPlaceOrder
            // 
            this.groupBoxPlaceOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPlaceOrder.Controls.Add(this.textBox3);
            this.groupBoxPlaceOrder.Controls.Add(this.labelTotalPrice);
            this.groupBoxPlaceOrder.Controls.Add(this.buttonPlaceOrder);
            this.groupBoxPlaceOrder.Controls.Add(this.groupBoxSelectOrder);
            this.groupBoxPlaceOrder.Controls.Add(this.textBox2);
            this.groupBoxPlaceOrder.Controls.Add(this.labelEmail);
            this.groupBoxPlaceOrder.Controls.Add(this.labelComment);
            this.groupBoxPlaceOrder.Controls.Add(this.textBox1);
            this.groupBoxPlaceOrder.Location = new System.Drawing.Point(12, 59);
            this.groupBoxPlaceOrder.Name = "groupBoxPlaceOrder";
            this.groupBoxPlaceOrder.Size = new System.Drawing.Size(531, 379);
            this.groupBoxPlaceOrder.TabIndex = 2;
            this.groupBoxPlaceOrder.TabStop = false;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(120, 247);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 126);
            this.textBox1.TabIndex = 8;
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
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 125);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(121, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // comboBoxSideDish
            // 
            this.comboBoxSideDish.FormattingEnabled = true;
            this.comboBoxSideDish.Location = new System.Drawing.Point(120, 77);
            this.comboBoxSideDish.Name = "comboBoxSideDish";
            this.comboBoxSideDish.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSideDish.TabIndex = 4;
            // 
            // labelSideDish
            // 
            this.labelSideDish.AutoSize = true;
            this.labelSideDish.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSideDish.Location = new System.Drawing.Point(6, 70);
            this.labelSideDish.Name = "labelSideDish";
            this.labelSideDish.Size = new System.Drawing.Size(102, 30);
            this.labelSideDish.TabIndex = 3;
            this.labelSideDish.Text = "Side Dish";
            // 
            // comboBoxMainDish
            // 
            this.comboBoxMainDish.FormattingEnabled = true;
            this.comboBoxMainDish.Location = new System.Drawing.Point(120, 26);
            this.comboBoxMainDish.Name = "comboBoxMainDish";
            this.comboBoxMainDish.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMainDish.TabIndex = 2;
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(120, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 29);
            this.textBox2.TabIndex = 11;
            // 
            // groupBoxSelectOrder
            // 
            this.groupBoxSelectOrder.Controls.Add(this.labelMainDish);
            this.groupBoxSelectOrder.Controls.Add(this.comboBoxMainDish);
            this.groupBoxSelectOrder.Controls.Add(this.labelSideDish);
            this.groupBoxSelectOrder.Controls.Add(this.comboBoxSideDish);
            this.groupBoxSelectOrder.Controls.Add(this.labelQuantity);
            this.groupBoxSelectOrder.Controls.Add(this.buttonAddOrderItem);
            this.groupBoxSelectOrder.Controls.Add(this.numericUpDown1);
            this.groupBoxSelectOrder.Location = new System.Drawing.Point(6, 22);
            this.groupBoxSelectOrder.Name = "groupBoxSelectOrder";
            this.groupBoxSelectOrder.Size = new System.Drawing.Size(519, 159);
            this.groupBoxSelectOrder.TabIndex = 12;
            this.groupBoxSelectOrder.TabStop = false;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 300);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 15;
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
            this.groupBoxPlaceOrder.ResumeLayout(false);
            this.groupBoxPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxSelectOrder.ResumeLayout(false);
            this.groupBoxSelectOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPlaceOrder;
        private System.Windows.Forms.Label labelMainDish;
        private System.Windows.Forms.GroupBox groupBoxPlaceOrder;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ComboBox comboBoxSideDish;
        private System.Windows.Forms.Label labelSideDish;
        private System.Windows.Forms.ComboBox comboBoxMainDish;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddOrderItem;
        private System.Windows.Forms.Button buttonPlaceOrder;
        private System.Windows.Forms.GroupBox groupBoxSelectOrder;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelTotalPrice;
    }
}