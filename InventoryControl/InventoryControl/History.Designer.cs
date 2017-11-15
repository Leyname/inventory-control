namespace InventoryControl
{
    partial class History
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
            this.tabControl_History = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox_Receipt = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox_Purchase = new System.Windows.Forms.ListBox();
            this.tabControl_History.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Menu
            // 
            this.button_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Menu.Location = new System.Drawing.Point(139, 198);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(126, 49);
            this.button_Menu.TabIndex = 1;
            this.button_Menu.Text = "Вернуться в меню";
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // tabControl_History
            // 
            this.tabControl_History.Controls.Add(this.tabPage1);
            this.tabControl_History.Controls.Add(this.tabPage2);
            this.tabControl_History.Location = new System.Drawing.Point(4, 12);
            this.tabControl_History.Name = "tabControl_History";
            this.tabControl_History.SelectedIndex = 0;
            this.tabControl_History.Size = new System.Drawing.Size(394, 168);
            this.tabControl_History.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox_Receipt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Получение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox_Receipt
            // 
            this.listBox_Receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Receipt.FormattingEnabled = true;
            this.listBox_Receipt.ItemHeight = 16;
            this.listBox_Receipt.Location = new System.Drawing.Point(-4, -1);
            this.listBox_Receipt.Name = "listBox_Receipt";
            this.listBox_Receipt.Size = new System.Drawing.Size(394, 148);
            this.listBox_Receipt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox_Purchase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отправка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox_Purchase
            // 
            this.listBox_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Purchase.FormattingEnabled = true;
            this.listBox_Purchase.ItemHeight = 16;
            this.listBox_Purchase.Location = new System.Drawing.Point(-4, -1);
            this.listBox_Purchase.Name = "listBox_Purchase";
            this.listBox_Purchase.Size = new System.Drawing.Size(394, 148);
            this.listBox_Purchase.TabIndex = 1;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.tabControl_History);
            this.Controls.Add(this.button_Menu);
            this.Name = "History";
            this.Text = "История перемещения товаров";
            this.Load += new System.EventHandler(this.History_Load);
            this.tabControl_History.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Menu;
        private System.Windows.Forms.TabControl tabControl_History;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox_Receipt;
        private System.Windows.Forms.ListBox listBox_Purchase;
    }
}