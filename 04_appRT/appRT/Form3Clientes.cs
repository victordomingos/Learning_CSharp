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
    public partial class Form3Clientes : Form
    {
        public Form3Clientes()
        {
            InitializeComponent();
        }

        private void Form3Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

            string ssql = "SELECT id as ID, nome_cliente as Nome, cidade as Cidade, pais as País FROM T_clientes";
            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);
            
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lbl_status.Text = Convert.ToString(dataGridView1.Rows.Count) + " clientes";

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
