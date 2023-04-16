using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        database database = new database();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//максимальна букв в поле и прятать пароль 
        {
            pass.PasswordChar = '*';
            login.MaxLength = 50;
            pass.MaxLength = 50;

        }

       

        private void btnEnt_Click(object sender, EventArgs e)
        {
            var loginU = login.Text;
            var passU = pass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();  
            DataTable table = new DataTable();

            string querystring = $"select Id, login, password from [Table] where login = '{loginU}' and password = '{passU}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("красавец");
            }
            else
            {
                MessageBox.Show("чурка");
            }
        }
        private void label1_Click(object sender, EventArgs e)//не ображать внимания
        {

        }

        private void label2_Click(object sender, EventArgs e)//не ображать внимания
        {

        }
        private void label3_Click(object sender, EventArgs e)//не ображать внимания
        {

        }
    }
}
