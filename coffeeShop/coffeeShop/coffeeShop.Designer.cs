namespace coffeeShop
{
    partial class CoffeeShop
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
            this.customerName = new System.Windows.Forms.Label();
            this.contactNo = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.customerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(18, 57);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 0;
            this.customerName.Text = "Customer Name";
            this.customerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // contactNo
            // 
            this.contactNo.AutoSize = true;
            this.contactNo.Location = new System.Drawing.Point(18, 90);
            this.contactNo.Name = "contactNo";
            this.contactNo.Size = new System.Drawing.Size(61, 13);
            this.contactNo.TabIndex = 1;
            this.contactNo.Text = "Contact No";
            // 
            // customerAddress
            // 
            this.customerAddress.AutoSize = true;
            this.customerAddress.Location = new System.Drawing.Point(18, 125);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(45, 13);
            this.customerAddress.TabIndex = 2;
            this.customerAddress.Text = "Address";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(18, 200);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(33, 13);
            this.order.TabIndex = 3;
            this.order.Text = "Order";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(18, 239);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(46, 13);
            this.quantity.TabIndex = 4;
            this.quantity.Text = "Quantity";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(216, 293);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 30);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black - 120",
            "Cold -100",
            "Hot -90",
            "Regular -80"});
            this.orderComboBox.Location = new System.Drawing.Point(170, 192);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderComboBox.TabIndex = 7;
            this.orderComboBox.SelectedIndexChanged += new System.EventHandler(this.orderComboBox_SelectedIndexChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(170, 231);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(121, 20);
            this.quantityTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(170, 125);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(170, 90);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(121, 20);
            this.contactTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(170, 57);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(430, 66);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(250, 332);
            this.richTextBox.TabIndex = 12;
            this.richTextBox.Text = "";
            // 
            // customerInfoGroupBox
            // 
            this.customerInfoGroupBox.Controls.Add(this.label8);
            this.customerInfoGroupBox.Controls.Add(this.label7);
            this.customerInfoGroupBox.Controls.Add(this.addButton);
            this.customerInfoGroupBox.Controls.Add(this.addressTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerName);
            this.customerInfoGroupBox.Controls.Add(this.nameTextBox);
            this.customerInfoGroupBox.Controls.Add(this.contactNo);
            this.customerInfoGroupBox.Controls.Add(this.contactTextBox);
            this.customerInfoGroupBox.Controls.Add(this.customerAddress);
            this.customerInfoGroupBox.Controls.Add(this.order);
            this.customerInfoGroupBox.Controls.Add(this.quantityTextBox);
            this.customerInfoGroupBox.Controls.Add(this.quantity);
            this.customerInfoGroupBox.Controls.Add(this.orderComboBox);
            this.customerInfoGroupBox.Controls.Add(this.saveButton);
            this.customerInfoGroupBox.Location = new System.Drawing.Point(54, 47);
            this.customerInfoGroupBox.Name = "customerInfoGroupBox";
            this.customerInfoGroupBox.Size = new System.Drawing.Size(345, 351);
            this.customerInfoGroupBox.TabIndex = 13;
            this.customerInfoGroupBox.TabStop = false;
            this.customerInfoGroupBox.Text = "Customer Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(297, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(297, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // addButton
            // 
            this.addButton.AccessibleName = "addButton";
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(114, 293);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 30);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 439);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerInfoGroupBox);
            this.Controls.Add(this.richTextBox);
            this.Name = "CoffeeShop";
            this.Text = "Coffee Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.customerInfoGroupBox.ResumeLayout(false);
            this.customerInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label contactNo;
        private System.Windows.Forms.Label customerAddress;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.GroupBox customerInfoGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

