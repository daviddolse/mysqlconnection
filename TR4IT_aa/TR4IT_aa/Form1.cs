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


namespace TR4IT_aa
{
    public partial class Form1 : Form
    {

		const string DATABASE = "db_cs1";
		const string SERVER = "localhost";
		const string USER = "root";
		const string PASS = "root";
		const string PORT = "3306";

		MySqlConnection conn;
		MySqlDataAdapter adapter;
		MySqlCommand command;
		DataSet ds;

        public Form1()
        {
            InitializeComponent();
			OpenConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			
        }

        private void Form1_Load(object sender, EventArgs e)
        {
			GetRecords();  
        }

		private void OpenConnection()
		{
			conn = new MySqlConnection($"Server={SERVER};Port={PORT};Database={DATABASE};Uid={USER};Pwd={PASS};");
			conn.Open();
		}

        public void GetRecords()
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("Select * from tbl_tasks", conn);
            adapter.Fill(ds, "tbl_tasks");

            dataGridView1.DataSource = ds;
            dataGridView1.DataSource = "tbl_tasks";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
