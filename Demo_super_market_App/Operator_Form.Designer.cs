namespace Demo_super_market_App
{
    partial class Operator_Form
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
            this.New_bill_button = new System.Windows.Forms.Button();
            this.View_bill_button = new System.Windows.Forms.Button();
            this.Add_customer_button = new System.Windows.Forms.Button();
            this.performance_button = new System.Windows.Forms.Button();
            this.View_customer_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_bill_button
            // 
            this.New_bill_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_bill_button.Location = new System.Drawing.Point(543, 159);
            this.New_bill_button.Name = "New_bill_button";
            this.New_bill_button.Size = new System.Drawing.Size(199, 49);
            this.New_bill_button.TabIndex = 0;
            this.New_bill_button.Text = "New Bill";
            this.New_bill_button.UseVisualStyleBackColor = true;
            this.New_bill_button.Click += new System.EventHandler(this.New_bill_button_Click);
            // 
            // View_bill_button
            // 
            this.View_bill_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_bill_button.Location = new System.Drawing.Point(543, 245);
            this.View_bill_button.Name = "View_bill_button";
            this.View_bill_button.Size = new System.Drawing.Size(199, 48);
            this.View_bill_button.TabIndex = 1;
            this.View_bill_button.Text = "View Bill";
            this.View_bill_button.UseVisualStyleBackColor = true;
            this.View_bill_button.Click += new System.EventHandler(this.View_bill_button_Click);
            // 
            // Add_customer_button
            // 
            this.Add_customer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_customer_button.Location = new System.Drawing.Point(543, 328);
            this.Add_customer_button.Name = "Add_customer_button";
            this.Add_customer_button.Size = new System.Drawing.Size(199, 48);
            this.Add_customer_button.TabIndex = 2;
            this.Add_customer_button.Text = "Add Customer";
            this.Add_customer_button.UseVisualStyleBackColor = true;
            this.Add_customer_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // performance_button
            // 
            this.performance_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance_button.Location = new System.Drawing.Point(543, 496);
            this.performance_button.Name = "performance_button";
            this.performance_button.Size = new System.Drawing.Size(199, 48);
            this.performance_button.TabIndex = 3;
            this.performance_button.Text = "Performance";
            this.performance_button.UseVisualStyleBackColor = true;
            this.performance_button.Click += new System.EventHandler(this.performance_button_Click);
            // 
            // View_customer_button
            // 
            this.View_customer_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_customer_button.Location = new System.Drawing.Point(543, 416);
            this.View_customer_button.Name = "View_customer_button";
            this.View_customer_button.Size = new System.Drawing.Size(199, 42);
            this.View_customer_button.TabIndex = 4;
            this.View_customer_button.Text = "View Customer";
            this.View_customer_button.UseVisualStyleBackColor = true;
            this.View_customer_button.Click += new System.EventHandler(this.View_customer_button_Click);
            // 
            // Operator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 686);
            this.Controls.Add(this.View_customer_button);
            this.Controls.Add(this.performance_button);
            this.Controls.Add(this.Add_customer_button);
            this.Controls.Add(this.View_bill_button);
            this.Controls.Add(this.New_bill_button);
            this.Name = "Operator_Form";
            this.Text = "Operator_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_bill_button;
        private System.Windows.Forms.Button View_bill_button;
        private System.Windows.Forms.Button Add_customer_button;
        private System.Windows.Forms.Button performance_button;
        private System.Windows.Forms.Button View_customer_button;
    }
}