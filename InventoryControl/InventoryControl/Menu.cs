using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryControl
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }


        private void button_Receipt_Click(object sender, EventArgs e)
        {
            ReceiptOfProducts FormReceipt = new ReceiptOfProducts();
            FormReceipt.ShowDialog();

        }

        private void button_Purchase_Click(object sender, EventArgs e)
        {
            PurchaseOfProduct FormPurchase = new PurchaseOfProduct();
            FormPurchase.ShowDialog();
        }

        private void button_ProductsInStock_Click(object sender, EventArgs e)
        {
            ProductsInStock FormProductsInStock = new ProductsInStock();
            FormProductsInStock.ShowDialog();
        }

        private void button_History_Click(object sender, EventArgs e)
        {
            History FormHistory = new History();
            FormHistory.ShowDialog();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
