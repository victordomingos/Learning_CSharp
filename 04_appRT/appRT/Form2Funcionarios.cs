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
    public partial class Form2Funcionarios : Form
    {

        public Form2Funcionarios()
        {
            InitializeComponent();
        }

        private void Form2Funcionarios_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            string ssql = "SELECT id as ID, nome_funcionario as Nome, telefone as Telefone FROM T_funcionarios";
            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " funcionários";
            
        }
    }
}
