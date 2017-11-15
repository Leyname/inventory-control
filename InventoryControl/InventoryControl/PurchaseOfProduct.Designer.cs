namespace InventoryControl
{
    partial class PurchaseOfProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.comboBox_Customer = new System.Windows.Forms.ComboBox();
            this.button_AddCustomer = new System.Windows.Forms.Button();
            this.button_SendAFew = new System.Windows.Forms.Button();
            this.button_SendOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Покупатель";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Quantity.Location = new System.Drawing.Point(138, 54);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(179, 23);
            this.textBox_Quantity.TabIndex = 3;
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(138, 15);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(179, 24);
            this.comboBox_Name.TabIndex = 4;
            // 
            // comboBox_Customer
            // 
            this.comboBox_Customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Customer.FormattingEnabled = true;
            this.comboBox_Customer.Location = new System.Drawing.Point(138, 95);
            this.comboBox_Customer.Name = "comboBox_Customer";
            this.comboBox_Customer.Size = new System.Drawing.Size(179, 24);
            this.comboBox_Customer.TabIndex = 5;
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.Location = new System.Drawing.Point(344, 94);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(25, 23);
            this.button_AddCustomer.TabIndex = 7;
            this.button_AddCustomer.Text = "+";
            this.button_AddCustomer.UseVisualStyleBackColor = true;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // button_SendAFew
            // 
            this.button_SendAFew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SendAFew.Location = new System.Drawing.Point(61, 143);
            this.button_SendAFew.Name = "button_SendAFew";
            this.button_SendAFew.Size = new System.Drawing.Size(108, 50);
            this.button_SendAFew.TabIndex = 8;
            this.button_SendAFew.Text = "Отправить несколько";
            this.button_SendAFew.UseVisualStyleBackColor = true;
            this.button_SendAFew.Click += new System.EventHandler(this.button_SendAFew_Click);
            // 
            // button_SendOne
            // 
            this.button_SendOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_SendOne.Location = new System.Drawing.Point(222, 143);
            this.button_SendOne.Name = "button_SendOne";
            this.button_SendOne.Size = new System.Drawing.Size(105, 50);
            this.button_SendOne.TabIndex = 9;
            this.button_SendOne.Text = "Отправить один";
            this.button_SendOne.UseVisualStyleBackColor = true;
            this.button_SendOne.Click += new System.EventHandler(this.button_SendOne_Click);
            // 
            // PurchaseOfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 207);
            this.Controls.Add(this.button_SendOne);
            this.Controls.Add(this.button_SendAFew);
            this.Controls.Add(this.button_AddCustomer);
            this.Controls.Add(this.comboBox_Customer);
            this.Controls.Add(this.comboBox_Name);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseOfProduct";
            this.Text = "Отправление товаров";
            this.Load += new System.EventHandler(this.PurchaseOfProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.ComboBox comboBox_Customer;
        private System.Windows.Forms.Button button_AddCustomer;
        private System.Windows.Forms.Button button_SendAFew;
        private System.Windows.Forms.Button button_SendOne;
    }
}