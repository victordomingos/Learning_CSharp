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
        public static readonly string DEFAULT_CMBX_TEXT = "-- Selecionar Categoria --";

        public Form1()
        {
            InitializeComponent();


            string ssql;

            // Preencher ComboBoxes
            ssql = "SELECT Id, designacao_categoria FROM categoria";
            InitComboBox(cmb_categorias, ssql, "designacao_categoria", "id", DEFAULT_CMBX_TEXT);

            
            /*

            // Preencher Gridview
            ssql =
                    "SELECT T_registo_de_tempos.Id as ID, T_clientes.nome_cliente as Cliente, T_funcionarios.nome_funcionario as Funcionário, data as 'Data', tempo as Tempo, " +
                    "descritivo as Descrição, categoria as Categoria " +
                    "FROM T_registo_de_tempos " +
                    "INNER JOIN T_clientes ON T_registo_de_tempos.cod_cliente = T_clientes.Id " +
                    "INNER JOIN T_funcionarios ON T_registo_de_tempos.cod_funcionario = T_funcionarios.Id " +
                    "ORDER BY Id DESC";


            grid.DataSource = db.ObterDados(ssql);
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.AllowUserToAddRows = false;
            grid.ShowEditingIcon = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;

            // Preencher combobox categorias
            var categorias = new List<string> { "-- Selecionar cat. --",
                "Contabilidade",
                "Recursos humanos",
                "Análise",
                "Correspondência",
                "Exterior",
                "Reuniões",
                "Mapas",
                "Outros",
            };

            foreach (var item in categorias)
                cmb_novo_categoria.Items.Add(item);

            cmb_categorias.SelectedIndex = 0;

            dt_novo_data.Value = DateTime.Now;

            //Atualizar_contagem_estado();

    */
            
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

    }
}
