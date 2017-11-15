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
    public partial class PurchaseOfProduct : Form
    {
        public PurchaseOfProduct()
        {
            InitializeComponent();
            
        }

        private void PurchaseOfProduct_Load(object sender, EventArgs e)
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

            string sql_customers = "SELECT name_customer FROM customers";
            MySqlCommand command_customers = new MySqlCommand(sql_customers, connectDB);
            MySqlDataReader reader_customers = command_customers.ExecuteReader();
            while (reader_customers.Read())
            {
                comboBox_Customer.Items.Add(reader_customers[0].ToString());
            }
            reader_customers.Close();
            connectDB.Close();
        }


        private void button_AddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer FormAddCustomer = new AddCustomer();
            FormAddCustomer.Show();

            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            comboBox_Customer.Items.Clear();
            string sql_customers = "SELECT name_customer FROM customers";
            MySqlCommand command_customers = new MySqlCommand(sql_customers, connectDB);
            MySqlDataReader reader_customers = command_customers.ExecuteReader();
            while (reader_customers.Read())
            {
                comboBox_Customer.Items.Add(reader_customers[0].ToString());
            }
            reader_customers.Close();
            connectDB.Close();
        }

        private void button_SendOne_Click(object sender, EventArgs e)
        {
            SendDataInDB();

            Close();
        }

        private void button_SendAFew_Click(object sender, EventArgs e)
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

            string sql_id_customer = "SELECT id_customer FROM customers WHERE name_customer = '" + comboBox_Customer.Text + "';";
            MySqlCommand command_id_customer = new MySqlCommand(sql_id_customer, connectDB);
            string id_customer = command_id_customer.ExecuteScalar().ToString();

            string sql_purchase = "INSERT INTO purchase_of_products (id_product_purchase, date, id_customer, quantity_purchase) VALUES ('" + id_product + "', NOW(), '" + id_customer + "', '" + textBox_Quantity.Text + "'); ";
            MySqlCommand command_purchase = new MySqlCommand(sql_purchase, connectDB);
            command_purchase.ExecuteNonQuery();

            string sql_quantity = "SELECT quantity_in_stock FROM products WHERE name_product = '" + comboBox_Name.Text + "';";
            MySqlCommand command_quantity = new MySqlCommand(sql_quantity, connectDB);
            string quantity = command_quantity.ExecuteScalar().ToString();

            string sql_product_quantity = "UPDATE products SET quantity_in_stock = " + (Convert.ToInt32(quantity) - Convert.ToInt32(textBox_Quantity.Text)).ToString() + " WHERE id_product = " + id_product + "; ";
            MySqlCommand command_product_quantity = new MySqlCommand(sql_product_quantity, connectDB);
            command_product_quantity.ExecuteNonQuery();

            connectDB.Close();
        }
    }
}
