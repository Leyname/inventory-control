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
    public partial class ProductsInStock : Form
    {
        public ProductsInStock()
        {
            InitializeComponent();
        }

        private void ProductsInStock_Load(object sender, EventArgs e)
        {
            listBox_Stock.Items.Add("Продукт       Количество      Цена");
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            string sql_products = "SELECT name_product, quantity_in_stock, price FROM products";
            MySqlCommand command_products = new MySqlCommand(sql_products, connectDB);
            MySqlDataReader reader_products = command_products.ExecuteReader();
            while (reader_products.Read())
            {
                listBox_Stock.Items.Add(reader_products[0].ToString() + "      " + reader_products[1].ToString() + "      " + reader_products[2].ToString() + ";");
            }
            reader_products.Close();

            connectDB.Close();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
