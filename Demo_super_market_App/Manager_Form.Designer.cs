namespace Demo_super_market_App
{
    partial class Manager_Form
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
            this.Product_button1 = new System.Windows.Forms.Button();
            this.Category_button2 = new System.Windows.Forms.Button();
            this.Taxcategory_button3 = new System.Windows.Forms.Button();
            this.Customer_button4 = new System.Windows.Forms.Button();
            this.Operator_button5 = new System.Windows.Forms.Button();
            this.Amount_button6 = new System.Windows.Forms.Button();
            this.Bill_button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_button1
            // 
            this.Product_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_button1.Location = new System.Drawing.Point(251, 169);
            this.Product_button1.Name = "Product_button1";
            this.Product_button1.Size = new System.Drawing.Size(162, 42);
            this.Product_button1.TabIndex = 0;
            this.Product_button1.Text = "Product";
            this.Product_button1.UseVisualStyleBackColor = true;
            this.Product_button1.Click += new System.EventHandler(this.Product_button1_Click);
            // 
            // Category_button2
            // 
            this.Category_button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category_button2.Location = new System.Drawing.Point(514, 169);
            this.Category_button2.Name = "Category_button2";
            this.Category_button2.Size = new System.Drawing.Size(162, 42);
            this.Category_button2.TabIndex = 1;
            this.Category_button2.Text = "Category";
            this.Category_button2.UseVisualStyleBackColor = true;
            this.Category_button2.Click += new System.EventHandler(this.Category_button2_Click);
            // 
            // Taxcategory_button3
            // 
            this.Taxcategory_button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taxcategory_button3.Location = new System.Drawing.Point(780, 169);
            this.Taxcategory_button3.Name = "Taxcategory_button3";
            this.Taxcategory_button3.Size = new System.Drawing.Size(162, 42);
            this.Taxcategory_button3.TabIndex = 2;
            this.Taxcategory_button3.Text = "Taxcategory";
            this.Taxcategory_button3.UseVisualStyleBackColor = true;
            this.Taxcategory_button3.Click += new System.EventHandler(this.Taxcategory_button3_Click);
            // 
            // Customer_button4
            // 
            this.Customer_button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_button4.Location = new System.Drawing.Point(251, 264);
            this.Customer_button4.Name = "Customer_button4";
            this.Customer_button4.Size = new System.Drawing.Size(162, 41);
            this.Customer_button4.TabIndex = 3;
            this.Customer_button4.Text = "Customer";
            this.Customer_button4.UseVisualStyleBackColor = true;
            this.Customer_button4.Click += new System.EventHandler(this.Customer_button4_Click);
            // 
            // Operator_button5
            // 
            this.Operator_button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operator_button5.Location = new System.Drawing.Point(780, 264);
            this.Operator_button5.Name = "Operator_button5";
            this.Operator_button5.Size = new System.Drawing.Size(162, 41);
            this.Operator_button5.TabIndex = 4;
            this.Operator_button5.Text = "Operator";
            this.Operator_button5.UseVisualStyleBackColor = true;
            this.Operator_button5.Click += new System.EventHandler(this.Operator_button5_Click);
            // 
            // Amount_button6
            // 
            this.Amount_button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_button6.Location = new System.Drawing.Point(514, 264);
            this.Amount_button6.Name = "Amount_button6";
            this.Amount_button6.Size = new System.Drawing.Size(162, 41);
            this.Amount_button6.TabIndex = 5;
            this.Amount_button6.Text = "Amount";
            this.Amount_button6.UseVisualStyleBackColor = true;
            this.Amount_button6.Click += new System.EventHandler(this.Amount_button6_Click);
            // 
            // Bill_button7
            // 
            this.Bill_button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_button7.Location = new System.Drawing.Point(251, 361);
            this.Bill_button7.Name = "Bill_button7";
            this.Bill_button7.Size = new System.Drawing.Size(162, 41);
            this.Bill_button7.TabIndex = 6;
            this.Bill_button7.Text = "Bill";
            this.Bill_button7.UseVisualStyleBackColor = true;
            this.Bill_button7.Click += new System.EventHandler(this.Bill_button7_Click);
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 723);
            this.Controls.Add(this.Bill_button7);
            this.Controls.Add(this.Amount_button6);
            this.Controls.Add(this.Operator_button5);
            this.Controls.Add(this.Customer_button4);
            this.Controls.Add(this.Taxcategory_button3);
            this.Controls.Add(this.Category_button2);
            this.Controls.Add(this.Product_button1);
            this.Name = "Manager_Form";
            this.Text = "Manager_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Product_button1;
        private System.Windows.Forms.Button Category_button2;
        private System.Windows.Forms.Button Taxcategory_button3;
        private System.Windows.Forms.Button Customer_button4;
        private System.Windows.Forms.Button Operator_button5;
        private System.Windows.Forms.Button Amount_button6;
        private System.Windows.Forms.Button Bill_button7;
    }
}