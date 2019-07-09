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

            string ssql;
            MyGetData db = new MyGetData();

            // Preencher ComboBox
            ssql = "SELECT * FROM T_clientes";
            comboBox1.DataSource = db.BuscaDados(SC, ssql);
            comboBox1.DisplayMember = "nome_cliente";
            comboBox1.ValueMember = "id";

            //comboBox1.Items.Insert(1, Item);


            // Preencher Gridview
            ssql = "SELECT * FROM T_registo_de_tempos";
            dataGridView1.DataSource = db.BuscaDados(SC, ssql);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " intervenções";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ssql;
            string filtro;
            string cod_cliente = comboBox1.SelectedValue.ToString();
            //MessageBox.Show(cod_cliente);

            if (cod_cliente == "0")
                filtro = "";
            else
                filtro = "WHERE cod_cliente='" + cod_cliente + "'";

            ssql = "SELECT * FROM T_registo_de_tempos " + filtro;

            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SC, ssql);
            
            lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " intervenções";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_clientes";
            string texto = textBox1.Text.ToString();

            if (texto !="")
                ssql += " WHERE nome_cliente LIKE '%" + texto + "%'";

            MyGetData db = new MyGetData();
            comboBox1.DataSource = db.BuscaDados(SC, ssql);
            comboBox1.DisplayMember = "nome_cliente";
            comboBox1.ValueMember = "id";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
