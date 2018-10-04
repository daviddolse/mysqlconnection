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
        MySqlConnection conn = new MySqlConnection("Server = localhost; User Id=''; Password=''; Database=db_cs1");
        MySqlDataAdapter adapter = new MySqlDataAdapter ();
        MySqlCommand command = new MySqlCommand();
        public DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetRecords();     
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
