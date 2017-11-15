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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            string sql_products = "INSERT INTO products (name_product, quantity_in_stock, price) VALUES ('" + textBox_Name.Text + "', 0, '" + textBox_Price.Text + "');";
            MySqlCommand command_products = new MySqlCommand(sql_products, connectDB);
            command_products.ExecuteNonQuery();
            connectDB.Close();
            Close();
        }
    }
}
