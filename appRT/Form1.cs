using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace appRT
{
    public partial class Form1 : Form
    {
        string SC = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDKRT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*
        private void Button2_Click(object sender, EventArgs e)
        {
            MyGetData db = new MyGetData();
            DataTable dt = db.BuscaDados(SC);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        */
    }
}
