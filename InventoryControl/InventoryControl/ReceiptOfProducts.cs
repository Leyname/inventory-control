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
    public partial class ReceiptOfProducts : Form
    {
        public ReceiptOfProducts()
        {
            InitializeComponent();
        }


        private void ReceiptOfProducts_Load(object sender, EventArgs e)
        {
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            string sql_products = "SELECT name_product FROM products";
            MySqlCommand command_products = new MySqlCommand(sql_products, connectDB);
            MySqlDataReader reader_products = command_products.ExecuteReader();
            while (reader_products.Read())
            {
                comboBox_Name.Items.Add(reader_products[0].ToString());
            }
            reader_products.Close();

            string sql_providers = "SELECT name_provider FROM providers";
            MySqlCommand command_providers = new MySqlCommand(sql_providers, connectDB);
            MySqlDataReader reader_providers = command_providers.ExecuteReader();
            while (reader_providers.Read())
            {
                comboBox_Provider.Items.Add(reader_providers[0].ToString());
            }
            reader_providers.Close();
            connectDB.Close();
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct FormAddProduct = new AddProduct();
            FormAddProduct.ShowDialog();

            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            comboBox_Name.Items.Clear();
            string sql_products = "SELECT name_product FROM products";
            MySqlCommand command_products = new MySqlCommand(sql_products, connectDB);
            MySqlDataReader reader_products = command_products.ExecuteReader();
            while (reader_products.Read())
            {
                comboBox_Name.Items.Add(reader_products[0].ToString());
            }
            reader_products.Close();
            connectDB.Close();
        }

        private void button_AddProvider_Click(object sender, EventArgs e)
        {
            AddProvider FormAddProvider = new AddProvider();
            FormAddProvider.ShowDialog();

            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            comboBox_Provider.Items.Clear();
            string sql_providers = "SELECT name_provider FROM providers";
            MySqlCommand command_providers = new MySqlCommand(sql_providers, connectDB);
            MySqlDataReader reader_providers = command_providers.ExecuteReader();
            while (reader_providers.Read())
            {
                comboBox_Provider.Items.Add(reader_providers[0].ToString());
            }
            reader_providers.Close();
            connectDB.Close();
        }

        private void button_GetOne_Click(object sender, EventArgs e)
        {
            SendDataInDB();

            Close();
        }

        private void button_GetAFew_Click(object sender, EventArgs e)
        {
            SendDataInDB();

            textBox_Quantity.Text = "";
        }

        private void SendDataInDB()
        {
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();

            string sql_id_product = "SELECT id_product FROM products WHERE name_product = '" + comboBox_Name.Text + "';";
            MySqlCommand command_id_product = new MySqlCommand(sql_id_product, connectDB);
            string id_product = command_id_product.ExecuteScalar().ToString();

            string sql_id_provider = "SELECT id_provider FROM providers WHERE name_provider = '" + comboBox_Provider.Text + "';";
            MySqlCommand command_id_provider = new MySqlCommand(sql_id_provider, connectDB);
            string id_provider = command_id_provider.ExecuteScalar().ToString();

            string sql_receipt = "INSERT INTO receipt_of_products (id_product_receipt, date, id_provider, quantity_receipt) VALUES ('" + id_product + "', NOW(), '" + id_provider + "', '" + textBox_Quantity.Text + "'); ";
            MySqlCommand command_receipt = new MySqlCommand(sql_receipt, connectDB);
            command_receipt.ExecuteNonQuery();

            string sql_quantity = "SELECT quantity_in_stock FROM products WHERE name_product = '" + comboBox_Name.Text + "';";
            MySqlCommand command_quantity = new MySqlCommand(sql_quantity, connectDB);
            string quantity = command_quantity.ExecuteScalar().ToString();

            string sql_product_quantity = "UPDATE products SET quantity_in_stock = " + (Convert.ToInt32(quantity) + Convert.ToInt32(textBox_Quantity.Text)).ToString() + " WHERE id_product = " + id_product + "; ";
            MySqlCommand command_product_quantity = new MySqlCommand(sql_product_quantity, connectDB);
            command_product_quantity.ExecuteNonQuery();

            connectDB.Close();
        }
    }
}
