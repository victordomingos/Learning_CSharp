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
            comboBox1_clientes.DataSource = db.BuscaDados(SC, ssql);
            comboBox1_clientes.DisplayMember = "nome_cliente";
            comboBox1_clientes.ValueMember = "id";


            // Preencher ComboBox
            ssql = "SELECT * FROM T_funcionarios";
            comboBox2_funcionarios .DataSource = db.BuscaDados(SC, ssql);
            comboBox2_funcionarios.DisplayMember = "nome";
            comboBox2_funcionarios.ValueMember = "id";

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

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }
        private void ComboBox2_funcionarios_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_clientes";
            string texto = textBox1_clientes.Text.ToString();

            if (texto !="")
                ssql += " WHERE nome_cliente LIKE '%" + texto + "%'";

            MyGetData db = new MyGetData();
            comboBox1_clientes.DataSource = db.BuscaDados(SC, ssql);
            comboBox1_clientes.DisplayMember = "nome_cliente";
            comboBox1_clientes.ValueMember = "id";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void TextBox2_funcionarios_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_funcionarios";
            string texto = textBox2_funcionarios.Text.ToString();

            if (texto != "")
                ssql += " WHERE nome LIKE '%" + texto + "%'";

            MyGetData db = new MyGetData();
            comboBox2_funcionarios.DataSource = db.BuscaDados(SC, ssql);
            comboBox2_funcionarios.DisplayMember = "nome";
            comboBox2_funcionarios.ValueMember = "id";
        }

        
        private void Filtrar_lista()
        {
            string ssql;
            string filtro_cliente = "";
            string filtro_funcionario = "";
            string operador = "";
            string filtro = "";
            bool has_filter = false;
            string cod_cliente = comboBox1_clientes.SelectedValue.ToString();
            string cod_funcionario = comboBox2_funcionarios.SelectedValue.ToString();

            //MessageBox.Show(cod_cliente);
            if (string.IsNullOrEmpty(cod_cliente))
                cod_cliente = "0";
            if (string.IsNullOrEmpty(cod_funcionario))
                cod_funcionario = "0";
            //TODO: DEBUG


            if (cod_cliente != "0") {
                filtro_cliente = "cod_cliente='" + cod_cliente + "'";
                has_filter = true;
            }

            if (cod_funcionario != "0") {
                if (has_filter)
                    operador = " and ";

                filtro_funcionario = "cod_funcionario='" + cod_funcionario + "'";
                has_filter = true;
            }

            if (has_filter) {
                filtro = " WHERE " + filtro_cliente + operador + filtro_funcionario;
            }

            ssql = "SELECT * FROM T_registo_de_tempos" + filtro;

            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SC, ssql);

            lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " intervenções";
        }

    }
}
