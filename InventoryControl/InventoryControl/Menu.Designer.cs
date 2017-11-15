namespace InventoryControl
{
    partial class Menu
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
            this.button_Receipt = new System.Windows.Forms.Button();
            this.button_Purchase = new System.Windows.Forms.Button();
            this.button_History = new System.Windows.Forms.Button();
            this.button_ProductsInStock = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Receipt
            // 
            this.button_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Receipt.Location = new System.Drawing.Point(46, 33);
            this.button_Receipt.Name = "button_Receipt";
            this.button_Receipt.Size = new System.Drawing.Size(245, 52);
            this.button_Receipt.TabIndex = 0;
            this.button_Receipt.Text = "Получение товара";
            this.button_Receipt.UseVisualStyleBackColor = true;
            this.button_Receipt.Click += new System.EventHandler(this.button_Receipt_Click);
            // 
            // button_Purchase
            // 
            this.button_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Purchase.Location = new System.Drawing.Point(46, 107);
            this.button_Purchase.Name = "button_Purchase";
            this.button_Purchase.Size = new System.Drawing.Size(245, 51);
            this.button_Purchase.TabIndex = 1;
            this.button_Purchase.Text = "Отправление товара";
            this.button_Purchase.UseVisualStyleBackColor = true;
            this.button_Purchase.Click += new System.EventHandler(this.button_Purchase_Click);
            // 
            // button_History
            // 
            this.button_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_History.Location = new System.Drawing.Point(46, 256);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(245, 51);
            this.button_History.TabIndex = 2;
            this.button_History.Text = "История перемещения товаров";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // button_Stock
            // 
            this.button_ProductsInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ProductsInStock.Location = new System.Drawing.Point(46, 181);
            this.button_ProductsInStock.Name = "button_Stock";
            this.button_ProductsInStock.Size = new System.Drawing.Size(245, 51);
            this.button_ProductsInStock.TabIndex = 3;
            this.button_ProductsInStock.Text = "Просмотр товаров в наличии";
            this.button_ProductsInStock.UseVisualStyleBackColor = true;
            this.button_ProductsInStock.Click += new System.EventHandler(this.button_ProductsInStock_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Exit.Location = new System.Drawing.Point(46, 336);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(245, 51);
            this.button_Exit.TabIndex = 4;
            this.button_Exit.Text = "Выход";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 423);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ProductsInStock);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.button_Purchase);
            this.Controls.Add(this.button_Receipt);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Receipt;
        private System.Windows.Forms.Button button_Purchase;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_ProductsInStock;
        private System.Windows.Forms.Button button_Exit;
    }
}

