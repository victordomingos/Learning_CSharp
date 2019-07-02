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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            Form3Clientes f3 = new Form3Clientes();
            //f3.BackColor = Color.Azure;
            f3.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2Funcionarios f3 = new Form2Funcionarios();
            //f3.BackColor = Color.Beige;
            f3.Show();
        }


        /*
        private void Button1_Click(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_clientes";
            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SC, ssql);

        }
        */

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
