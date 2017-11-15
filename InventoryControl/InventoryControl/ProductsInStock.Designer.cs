namespace InventoryControl
{
    partial class ProductsInStock
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
            this.button_Menu = new System.Windows.Forms.Button();
            this.listBox_Stock = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_Menu
            // 
            this.button_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Menu.Location = new System.Drawing.Point(139, 198);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(126, 49);
            this.button_Menu.TabIndex = 2;
            this.button_Menu.Text = "Вернуться в меню";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // listBox_Stock
            // 
            this.listBox_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Stock.FormattingEnabled = true;
            this.listBox_Stock.ItemHeight = 16;
            this.listBox_Stock.Location = new System.Drawing.Point(12, 12);
            this.listBox_Stock.Name = "listBox_Stock";
            this.listBox_Stock.Size = new System.Drawing.Size(376, 164);
            this.listBox_Stock.TabIndex = 3;
            // 
            // ProductsInStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.listBox_Stock);
            this.Controls.Add(this.button_Menu);
            this.Name = "ProductsInStock";
            this.Text = "Продукты в наличии";
            this.Load += new System.EventHandler(this.ProductsInStock_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.ListBox listBox_Stock;
    }
}