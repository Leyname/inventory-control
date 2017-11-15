namespace InventoryControl
{
    partial class ReceiptOfProducts
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
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Provider = new System.Windows.Forms.ComboBox();
            this.button_AddProduct = new System.Windows.Forms.Button();
            this.button_AddProvider = new System.Windows.Forms.Button();
            this.button_GetAFew = new System.Windows.Forms.Button();
            this.button_GetOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(138, 15);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(180, 24);
            this.comboBox_Name.TabIndex = 0;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Quantity.Location = new System.Drawing.Point(138, 54);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(180, 23);
            this.textBox_Quantity.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поставщик";
            // 
            // comboBox_Provider
            // 
            this.comboBox_Provider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Provider.FormattingEnabled = true;
            this.comboBox_Provider.Location = new System.Drawing.Point(138, 95);
            this.comboBox_Provider.Name = "comboBox_Provider";
            this.comboBox_Provider.Size = new System.Drawing.Size(180, 24);
            this.comboBox_Provider.TabIndex = 7;
            // 
            // button_AddProduct
            // 
            this.button_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddProduct.Location = new System.Drawing.Point(344, 15);
            this.button_AddProduct.Name = "button_AddProduct";
            this.button_AddProduct.Size = new System.Drawing.Size(25, 23);
            this.button_AddProduct.TabIndex = 8;
            this.button_AddProduct.Text = "+";
            this.button_AddProduct.UseVisualStyleBackColor = true;
            this.button_AddProduct.Click += new System.EventHandler(this.button_AddProduct_Click);
            // 
            // button_AddProvider
            // 
            this.button_AddProvider.Location = new System.Drawing.Point(344, 94);
            this.button_AddProvider.Name = "button_AddProvider";
            this.button_AddProvider.Size = new System.Drawing.Size(25, 23);
            this.button_AddProvider.TabIndex = 9;
            this.button_AddProvider.Text = "+";
            this.button_AddProvider.UseVisualStyleBackColor = true;
            this.button_AddProvider.Click += new System.EventHandler(this.button_AddProvider_Click);
            // 
            // button_GetAFew
            // 
            this.button_GetAFew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GetAFew.Location = new System.Drawing.Point(62, 142);
            this.button_GetAFew.Name = "button_GetAFew";
            this.button_GetAFew.Size = new System.Drawing.Size(109, 47);
            this.button_GetAFew.TabIndex = 10;
            this.button_GetAFew.Text = "Получить несколько";
            this.button_GetAFew.UseVisualStyleBackColor = true;
            this.button_GetAFew.Click += new System.EventHandler(this.button_GetAFew_Click);
            // 
            // button_GetOne
            // 
            this.button_GetOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_GetOne.Location = new System.Drawing.Point(227, 142);
            this.button_GetOne.Name = "button_GetOne";
            this.button_GetOne.Size = new System.Drawing.Size(108, 47);
            this.button_GetOne.TabIndex = 11;
            this.button_GetOne.Text = "Получить один";
            this.button_GetOne.UseVisualStyleBackColor = true;
            this.button_GetOne.Click += new System.EventHandler(this.button_GetOne_Click);
            // 
            // ReceiptOfProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 206);
            this.Controls.Add(this.button_GetOne);
            this.Controls.Add(this.button_GetAFew);
            this.Controls.Add(this.button_AddProvider);
            this.Controls.Add(this.button_AddProduct);
            this.Controls.Add(this.comboBox_Provider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.comboBox_Name);
            this.Name = "ReceiptOfProducts";
            this.Text = "Получение товара";
            this.Load += new System.EventHandler(this.ReceiptOfProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Name;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Provider;
        private System.Windows.Forms.Button button_AddProduct;
        private System.Windows.Forms.Button button_AddProvider;
        private System.Windows.Forms.Button button_GetAFew;
        private System.Windows.Forms.Button button_GetOne;
    }
}