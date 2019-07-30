using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _05_Prod2_produtos_e_categorias
{
    public partial class Form1 : Form
    {
        public MyDatabase db = new MyDatabase();
        public ContaProdutos contador = new ContaProdutos();
        public static readonly string DEFAULT_CMBX_TEXT = "-- Selecionar Categoria --";

        public Form1()
        {
            InitializeComponent();


            string ssql;

            // Preencher ComboBoxes
            ssql = "SELECT id, designacao_categoria FROM categoria";
            InitComboBox(cmb_categorias, ssql, "designacao_categoria", "id", DEFAULT_CMBX_TEXT);
                        
            // Preencher Gridview
            ssql = "SELECT produto.id as 'ID', produto.nomeproduto as 'Descrição do Produto',  " +
                          "CAST(preco as numeric(17,2)) as 'Preço', " +
                          "quantidade as 'Quantidade', designacao_categoria as Categoria " +
                   "FROM produto " +
                   "INNER JOIN categoria ON produto.categoria_id=categoria.id " +
                   "ORDER BY id ASC; ";


            grid.DataSource = db.ObterDados(ssql);

            
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            grid.AllowUserToAddRows = false;
            grid.ShowEditingIcon = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            

            //Atualizar_contagem_estado();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public void InitComboBox(ToolStripComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            // Preencher ComboBox
            DataTable dt = db.ObterDados(ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = DEFAULT_CMBX_TEXT;
            dt.Rows.InsertAt(row, 0);
            cmbx.ComboBox.DataSource = dt;
            cmbx.ComboBox.DisplayMember = displayM;
            cmbx.ComboBox.ValueMember = valueM;
        }

        private void Btn_categorias_Click(object sender, EventArgs e) { contador.ContarProdutos(grid); }

        private void Cmb_categorias_Click(object sender, EventArgs e) { }

        private void Cmb_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ssql;
            string filtro = " ";
            string id = cmb_categorias.SelectedIndex.ToString();

            if (id == "0")
                filtro = " ";
            else
                filtro = $"WHERE produto.categoria_id={id} ";
            
            ssql = "SELECT produto.id as 'ID', produto.nomeproduto as 'Descrição do Produto',  " +
                         "CAST(preco as numeric(17,2)) as 'Preço', " +
                         "quantidade as 'Quantidade', designacao_categoria as Categoria " +
                   "FROM produto " +
                   "INNER JOIN categoria ON produto.categoria_id=categoria.id " + filtro +
                   "ORDER BY id ASC; ";

            grid.DataSource = db.ObterDados(ssql);
        }
    }
}
