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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string propertiesDB = "server=localhost;user=root;database=inventory_control;password=0000;";
            MySqlConnection connectDB = new MySqlConnection(propertiesDB);
            connectDB.Open();
            string sql_customers = "INSERT INTO customers (name_customer, address, phone_number, mail) VALUES ('" + textBox_Name.Text + "', '" + textBox_Address.Text + "', '" + textBox_Number.Text + "', '" + textBox_Mail.Text + "'); ";
            MySqlCommand command_customers = new MySqlCommand(sql_customers, connectDB);
            command_customers.ExecuteNonQuery();
            connectDB.Close();
            Close();
        }
    }
}
