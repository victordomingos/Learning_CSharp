using System;
using System.Windows.Forms;

namespace appRT
{
    public partial class Form4AlteraTempos : Form
    {
        public readonly int DEFAULT_MAX_ROWS = 50;
        public MyGetData db = new MyGetData();

        public Form4AlteraTempos()
        {
            InitializeComponent();
            string ssql;

            // inicializar listbox clientes
            ssql = "SELECT DISTINCT T_clientes.nome_cliente as Cliente, T_clientes.id as id " +
                    "FROM T_registo_de_tempos " +
                    "INNER JOIN T_clientes ON T_registo_de_tempos.cod_cliente = T_clientes.Id " +
                    "ORDER BY Cliente";
            InitListBox(listb_cliente, ssql, "Cliente", "id");

            // atualizar listbox funcionarios
            ssql = "SELECT DISTINCT T_funcionarios.nome_funcionario as Funcionario, T_funcionarios.id as id " +
                    "FROM T_registo_de_tempos " +
                    "INNER JOIN T_funcionarios ON T_registo_de_tempos.cod_funcionario = T_funcionarios.Id " +
                    "ORDER BY Funcionario";
            InitListBox(listb_funcionario, ssql, "Funcionario", "id");

            // atualizar comboboxes ano e mes
            ssql = "SELECT DISTINCT CONVERT(CHAR(4), YEAR(data)) as 'Ano' " +
                   "FROM T_registo_de_tempos " +
                   "ORDER BY 'Ano';";
            InitComboBox(cmb_ano, ssql, "Ano", "Ano", "-- Mostrar Todos --");

            ssql = "SELECT DISTINCT FORMAT(data, 'MMMM', 'pt-PT') as 'mes', MONTH(data) as 'num_mes' " +
                   "FROM T_registo_de_tempos " +
                   "ORDER BY 'num_mes'";
            InitComboBox(cmb_mes, ssql, "mes", "num_mes", "-- Mostrar Todos --");


            // atualizar listbox meses
            ssql = "SELECT DISTINCT FORMAT(data, 'MMMM', 'pt-PT') as 'mes', MONTH(data) as 'num_mes' " +
                   "FROM T_registo_de_tempos " +
                   "ORDER BY 'num_mes'";
            InitListBox(listb_meses, ssql, "mes", "num_mes");


            // Preencher Gridview
            
            AtualizarGrid();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = true;
            dataGridView1.RowHeadersVisible = true;
            dataGridView1.ReadOnly = false;

        }

        private void ToolStripStatusLabel2_Click(object sender, EventArgs e) { }
        private void Label3_Click(object sender, EventArgs e) { }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Label4_Click(object sender, EventArgs e) { }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ListBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Label5_Click(object sender, EventArgs e) { }
        private void Form4AlteraTempos_Load(object sender, EventArgs e) { }
        private void Label6_Click(object sender, EventArgs e) { }

        private void Btn_eliminar_Click(object sender, EventArgs e) { EliminarRegisto(); }
    }
}
