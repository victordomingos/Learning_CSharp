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
            ssql = $"SET ROWCOUNT {DEFAULT_MAX_ROWS} " +
                   "SELECT T_registo_de_tempos.Id as ID, data as 'Data', tempo as Tempo, " +
                   "descritivo as Descrição, categoria as Categoria " +
                   "FROM T_registo_de_tempos " +
                   "ORDER BY Id DESC";

            dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            var linhas_selecionadas = dataGridView1.SelectedRows.Count;

            if (linhas_selecionadas == 0)
            {
                MessageBox.Show($"{dataGridView1.SelectedRows.Count} linhas selecionadas.",
                                "Eliminar registo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else if (linhas_selecionadas == 1)
            {
                string txt_registo = "Por favor, confirme se deseja mesmo apagar o registo selecionado:\n\n" +
                                     $"ID: {dataGridView1.SelectedRows[0].Cells[0].Value}\n" +
                                     $"Data: {dataGridView1.SelectedRows[0].Cells[1].Value}\n" +
                                     $"Tempo: {dataGridView1.SelectedRows[0].Cells[2].Value}\n" +
                                     $"Descrição: {dataGridView1.SelectedRows[0].Cells[3].Value}\n" +
                                     $"Categoria: {dataGridView1.SelectedRows[0].Cells[4].Value}\n" +
                                     "\nPretende mesmo eliminar este registo?";
                MessageBox.Show(txt_registo, 
                                "Eliminar registo", 
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                
                // Apagar

            }
            else
            {
                string txt_registos = $"{linhas_selecionadas} registos selecionados." +
                                     "\n\nPor motivos de segurança, apenas é permitido eliminar um único registo de cada vez. " +
                                     "Por favor, selecione apenas uma linha e tente novamente.";
                MessageBox.Show(txt_registos,
                                "Eliminar registo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Hand);
            }

        }
    }
}
