namespace TestPizzaGUI
{
    partial class Form1
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
            this.smallRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.largeRadio = new System.Windows.Forms.RadioButton();
            this.radioLabel = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.toppingsBox = new System.Windows.Forms.GroupBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.sausageCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.jalapenoCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.mushroomCheckBox = new System.Windows.Forms.CheckBox();
            this.oliveCheckBox = new System.Windows.Forms.CheckBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sizeBox.SuspendLayout();
            this.toppingsBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallRadio
            // 
            this.smallRadio.AutoSize = true;
            this.smallRadio.Location = new System.Drawing.Point(6, 20);
            this.smallRadio.Name = "smallRadio";
            this.smallRadio.Size = new System.Drawing.Size(97, 17);
            this.smallRadio.TabIndex = 0;
            this.smallRadio.TabStop = true;
            this.smallRadio.Text = "Small 8\"- $8.99";
            this.smallRadio.UseVisualStyleBackColor = true;
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Location = new System.Drawing.Point(6, 44);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(121, 17);
            this.mediumRadio.TabIndex = 1;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium 10\"- $10.99";
            this.mediumRadio.UseVisualStyleBackColor = true;
            // 
            // largeRadio
            // 
            this.largeRadio.AutoSize = true;
            this.largeRadio.Location = new System.Drawing.Point(6, 68);
            this.largeRadio.Name = "largeRadio";
            this.largeRadio.Size = new System.Drawing.Size(111, 17);
            this.largeRadio.TabIndex = 2;
            this.largeRadio.TabStop = true;
            this.largeRadio.Text = "Large 12\"- $11.99";
            this.largeRadio.UseVisualStyleBackColor = true;
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLabel.Location = new System.Drawing.Point(23, 52);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(129, 25);
            this.radioLabel.TabIndex = 3;
            this.radioLabel.Text = "Select a size:";
            // 
            // sizeBox
            // 
            this.sizeBox.Controls.Add(this.smallRadio);
            this.sizeBox.Controls.Add(this.largeRadio);
            this.sizeBox.Controls.Add(this.mediumRadio);
            this.sizeBox.Location = new System.Drawing.Point(171, 12);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(133, 100);
            this.sizeBox.TabIndex = 4;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Size";
            // 
            // toppingsBox
            // 
            this.toppingsBox.Controls.Add(this.oliveCheckBox);
            this.toppingsBox.Controls.Add(this.mushroomCheckBox);
            this.toppingsBox.Controls.Add(this.onionCheckBox);
            this.toppingsBox.Controls.Add(this.jalapenoCheckBox);
            this.toppingsBox.Controls.Add(this.pineappleCheckBox);
            this.toppingsBox.Controls.Add(this.sausageCheckBox);
            this.toppingsBox.Controls.Add(this.cheeseCheckBox);
            this.toppingsBox.Controls.Add(this.pepperoniCheckBox);
            this.toppingsBox.Location = new System.Drawing.Point(12, 124);
            this.toppingsBox.Name = "toppingsBox";
            this.toppingsBox.Size = new System.Drawing.Size(292, 114);
            this.toppingsBox.TabIndex = 5;
            this.toppingsBox.TabStop = false;
            this.toppingsBox.Text = "Toppings (up to 2 free, $50 for each additional)";
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(29, 19);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 0;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            // 
            // cheeseCheckBox
            // 
            this.cheeseCheckBox.AutoSize = true;
            this.cheeseCheckBox.Location = new System.Drawing.Point(29, 43);
            this.cheeseCheckBox.Name = "cheeseCheckBox";
            this.cheeseCheckBox.Size = new System.Drawing.Size(89, 17);
            this.cheeseCheckBox.TabIndex = 1;
            this.cheeseCheckBox.Text = "Extra Cheese";
            this.cheeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // sausageCheckBox
            // 
            this.sausageCheckBox.AutoSize = true;
            this.sausageCheckBox.Location = new System.Drawing.Point(29, 67);
            this.sausageCheckBox.Name = "sausageCheckBox";
            this.sausageCheckBox.Size = new System.Drawing.Size(68, 17);
            this.sausageCheckBox.TabIndex = 2;
            this.sausageCheckBox.Text = "Sausage";
            this.sausageCheckBox.UseVisualStyleBackColor = true;
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(29, 90);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.pineappleCheckBox.TabIndex = 3;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            // 
            // jalapenoCheckBox
            // 
            this.jalapenoCheckBox.AutoSize = true;
            this.jalapenoCheckBox.Location = new System.Drawing.Point(165, 19);
            this.jalapenoCheckBox.Name = "jalapenoCheckBox";
            this.jalapenoCheckBox.Size = new System.Drawing.Size(69, 17);
            this.jalapenoCheckBox.TabIndex = 4;
            this.jalapenoCheckBox.Text = "Jalapeno";
            this.jalapenoCheckBox.UseVisualStyleBackColor = true;
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(165, 43);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(54, 17);
            this.onionCheckBox.TabIndex = 5;
            this.onionCheckBox.Text = "Onion";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            // 
            // mushroomCheckBox
            // 
            this.mushroomCheckBox.AutoSize = true;
            this.mushroomCheckBox.Location = new System.Drawing.Point(165, 67);
            this.mushroomCheckBox.Name = "mushroomCheckBox";
            this.mushroomCheckBox.Size = new System.Drawing.Size(75, 17);
            this.mushroomCheckBox.TabIndex = 6;
            this.mushroomCheckBox.Text = "Mushroom";
            this.mushroomCheckBox.UseVisualStyleBackColor = true;
            // 
            // oliveCheckBox
            // 
            this.oliveCheckBox.AutoSize = true;
            this.oliveCheckBox.Location = new System.Drawing.Point(165, 91);
            this.oliveCheckBox.Name = "oliveCheckBox";
            this.oliveCheckBox.Size = new System.Drawing.Size(50, 17);
            this.oliveCheckBox.TabIndex = 7;
            this.oliveCheckBox.Text = "Olive";
            this.oliveCheckBox.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(55, 246);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 6;
            this.totalButton.Text = "Get Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(192, 251);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(34, 13);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "$0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderTextBox);
            this.groupBox1.Location = new System.Drawing.Point(323, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 251);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(195, 277);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add to Order --->";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(7, 19);
            this.orderTextBox.Multiline = true;
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(187, 226);
            this.orderTextBox.TabIndex = 0;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(405, 277);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(64, 13);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total: $0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 312);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.toppingsBox);
            this.Controls.Add(this.radioLabel);
            this.Controls.Add(this.sizeBox);
            this.Name = "Form1";
            this.Text = "PizzaTest";
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.toppingsBox.ResumeLayout(false);
            this.toppingsBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton smallRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton largeRadio;
        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.GroupBox toppingsBox;
        private System.Windows.Forms.CheckBox oliveCheckBox;
        private System.Windows.Forms.CheckBox mushroomCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox jalapenoCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
        private System.Windows.Forms.CheckBox sausageCheckBox;
        private System.Windows.Forms.CheckBox cheeseCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label totalLabel;
    }
}

