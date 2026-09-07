namespace LunchOrder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxMainCourse = new GroupBox();
            rbSalad = new RadioButton();
            rbPizza = new RadioButton();
            rbHamburger = new RadioButton();
            groupBox2 = new GroupBox();
            txtOrderTotal = new TextBox();
            label3 = new Label();
            txtSalesTax = new TextBox();
            label2 = new Label();
            txtSubtotal = new TextBox();
            label1 = new Label();
            btnPlaceOrder = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            gbxMainCourse.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxMainCourse
            // 
            gbxMainCourse.Controls.Add(rbSalad);
            gbxMainCourse.Controls.Add(rbPizza);
            gbxMainCourse.Controls.Add(rbHamburger);
            gbxMainCourse.Location = new Point(49, 28);
            gbxMainCourse.Name = "gbxMainCourse";
            gbxMainCourse.Size = new Size(227, 163);
            gbxMainCourse.TabIndex = 0;
            gbxMainCourse.TabStop = false;
            gbxMainCourse.Text = "Main Course";
            // 
            // rbSalad
            // 
            rbSalad.AutoSize = true;
            rbSalad.Location = new Point(31, 121);
            rbSalad.Name = "rbSalad";
            rbSalad.Size = new Size(141, 29);
            rbSalad.TabIndex = 2;
            rbSalad.TabStop = true;
            rbSalad.Text = "Salad - $4.95";
            rbSalad.UseVisualStyleBackColor = true;
            rbSalad.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbPizza
            // 
            rbPizza.AutoSize = true;
            rbPizza.Location = new Point(31, 80);
            rbPizza.Name = "rbPizza";
            rbPizza.Size = new Size(137, 29);
            rbPizza.TabIndex = 1;
            rbPizza.TabStop = true;
            rbPizza.Text = "Pizza - $5.95";
            rbPizza.UseVisualStyleBackColor = true;
            rbPizza.CheckedChanged += radioButton_CheckedChanged;
            // 
            // rbHamburger
            // 
            rbHamburger.AutoSize = true;
            rbHamburger.Location = new Point(31, 40);
            rbHamburger.Name = "rbHamburger";
            rbHamburger.Size = new Size(184, 29);
            rbHamburger.TabIndex = 0;
            rbHamburger.TabStop = true;
            rbHamburger.Text = "Hamburger -$6.95";
            rbHamburger.UseVisualStyleBackColor = true;
            rbHamburger.CheckedChanged += radioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtOrderTotal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtSalesTax);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtSubtotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(49, 222);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 192);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(160, 127);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(150, 31);
            txtOrderTotal.TabIndex = 5;
            txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 132);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 4;
            label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(160, 83);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(150, 31);
            txtSalesTax.TabIndex = 3;
            txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(160, 38);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(150, 31);
            txtSubtotal.TabIndex = 1;
            txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 43);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(457, 238);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(111, 42);
            btnPlaceOrder.TabIndex = 2;
            btnPlaceOrder.Text = "Place &Order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(457, 370);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 42);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(352, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 178);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add-ons Items($ .75/each)";
            
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 143);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(131, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "French Fries";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 99);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(266, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Ketchup, mustard, and mayo";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 53);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(256, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "lettuce, tomato, and onions";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AcceptButton = btnPlaceOrder;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(712, 490);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnPlaceOrder);
            Controls.Add(groupBox2);
            Controls.Add(gbxMainCourse);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nady Fotie’s Lunch Order Application";
            gbxMainCourse.ResumeLayout(false);
            gbxMainCourse.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private RadioButton rbSalad;
        private RadioButton rbPizza;
        private RadioButton rbHamburger;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
