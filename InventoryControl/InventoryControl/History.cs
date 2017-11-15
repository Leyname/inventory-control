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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();

            listBox_Receipt.Items.Add("Время       Продукт       Поставщик       Количество       Цена");
            string sql_receipt = "SELECT date, name_product, name_provider, quantity_receipt, price  FROM receipt_of_products LEFT OUTER JOIN products ON receipt_of_products.id_product_receipt = products.id_product LEFT OUTER JOIN providers ON receipt_of_products.id_provider = providers.id_provider";
            MySqlCommand command_receipt = new MySqlCommand(sql_receipt, connectDB);
            MySqlDataReader reader_receipt = command_receipt.ExecuteReader();
            while (reader_receipt.Read())
            {
                listBox_Receipt.Items.Add(reader_receipt[0].ToString() + "      " + reader_receipt[1].ToString() + "      " + reader_receipt[2].ToString() + "      " + reader_receipt[3].ToString() + "      " + reader_receipt[4].ToString() + ";");
            }
            reader_receipt.Close();

            listBox_Purchase.Items.Add("Время       Продукт       Покупатель       Количество       Цена");
            string sql_purchase = "SELECT date, name_product, name_customer, quantity_purchase, price  FROM purchase_of_products LEFT OUTER JOIN products ON purchase_of_products.id_product_purchase = products.id_product LEFT OUTER JOIN customers ON purchase_of_products.id_customer = customers.id_customer";
            MySqlCommand command_purchase = new MySqlCommand(sql_purchase, connectDB);
            MySqlDataReader reader_purchase = command_purchase.ExecuteReader();
            while (reader_purchase.Read())
            {
                listBox_Purchase.Items.Add(reader_purchase[0].ToString() + "      " + reader_purchase[1].ToString() + "      " + reader_purchase[2].ToString() + "      " + reader_purchase[3].ToString() + "      " + reader_purchase[4].ToString() + ";");
            }
            reader_purchase.Close();

            connectDB.Close();
        }
    }
}
