using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace appRT
{
    public partial class Form1 : Form
    {
        public readonly int DEFAULT_MAX_ROWS = 50;
        public MyGetData db = new MyGetData();

        public Form1()
        {
            InitializeComponent();

            string ssql;

            // Preencher ComboBoxes
            ssql = "SELECT Id, nome_cliente FROM T_clientes";
            InitComboBox(comboBox1_clientes, ssql, "nome_cliente", "id", "-- Mostrar Todos --");
            InitComboBox(cmb_novo_select_cliente, ssql, "nome_cliente", "id", "-- Selecionar Cliente --");

            ssql = "SELECT Id, nome_funcionario FROM T_funcionarios";
            InitComboBox(comboBox2_funcionarios, ssql, "nome_funcionario", "id", "-- Mostrar Todos --");
            InitComboBox(cmb_novo_select_func, ssql, "nome_funcionario", "id", "-- Selecionar Funcionário --");

            
            // Preencher Gridview
            ssql = $"SET ROWCOUNT {DEFAULT_MAX_ROWS} " +
                    "SELECT T_registo_de_tempos.Id as ID, T_clientes.nome_cliente as Cliente, T_funcionarios.nome_funcionario as Funcionário, data as 'Data', tempo as Tempo, " +
                    "descritivo as Descrição, categoria as Categoria " +
                    "FROM T_registo_de_tempos " + 
                    "INNER JOIN T_clientes ON T_registo_de_tempos.cod_cliente = T_clientes.Id " +
                    "INNER JOIN T_funcionarios ON T_registo_de_tempos.cod_funcionario = T_funcionarios.Id " +
                    "ORDER BY Id DESC";
            

            dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;

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

            cmb_novo_categoria.SelectedIndex = 0;

            dt_novo_data.Value = DateTime.Now;
            Atualizar_contagem_estado();
            AtualizarEstatisticas();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Btn_clientes_Click(object sender, EventArgs e) { Form3Clientes f3 = new Form3Clientes(); f3.Show(); }
        private void Button1_Click(object sender, EventArgs e) { Form2Funcionarios f3 = new Form2Funcionarios(); f3.Show(); }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }
        private void ComboBox2_funcionarios_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT Id, nome_cliente FROM T_clientes";
            string texto = textBox1_clientes.Text.ToString();

            if (texto !="")
                ssql += $" WHERE nome_cliente LIKE '%{texto}%'";

            try
            {
                InitComboBox(comboBox1_clientes, ssql, "nome_cliente", "id", "-- Mostrar Todos --");
            }
            catch
            {
                comboBox1_clientes.DataSource = null;
                comboBox1_clientes.ResetText();
                comboBox1_clientes.Items.Clear();
                comboBox1_clientes.SelectedItem = null;
            }
        }


        private void TextBox2_funcionarios_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT Id, nome_funcionario FROM T_funcionarios";
            string texto1 = textBox2_funcionarios.Text.ToString();
            string filtro_funcionario = "";
            
            if (texto1 != "")
                filtro_funcionario = $" WHERE nome_funcionario LIKE '%{texto1}%'";

            ssql += filtro_funcionario;

            try
            {
                InitComboBox(comboBox2_funcionarios, ssql, "nome_funcionario", "id", "-- Mostrar Todos --");
            }
            catch
            {
                comboBox2_funcionarios.DataSource = null;
                comboBox2_funcionarios.Items.Clear();
                comboBox2_funcionarios.ResetText();
            }
        }


        private void Btn_novo_limpar_Click(object sender, EventArgs e) { limpar_form_novo_registo(); }
        private void Btn_novo_guardar_Click(object sender, EventArgs e) { guardar_registo_tempo(); }
        private void Cmb_novo_categoria_SelectedIndexChanged(object sender, EventArgs e) { }


        private void ToolStripButton1_Click(object sender, EventArgs e) { Form3Clientes f3 = new Form3Clientes(); f3.Show(); }
        private void Tsbtn_funcionarios_Click(object sender, EventArgs e) { Form2Funcionarios f3 = new Form2Funcionarios(); f3.Show(); }
        private void Tsbtn_painel_lateral_Click(object sender, EventArgs e) { alternarPainelLateral();}
        private void MostrarPainelLateralToolStripMenuItem_Click(object sender, EventArgs e) { alternarPainelLateral(); }
        private void Tsbtn_novo_registo_Click(object sender, EventArgs e) { alternarPainelNovoRegisto();}
        private void PainelDeNovoRegistoToolStripMenuItem_Click(object sender, EventArgs e) { alternarPainelNovoRegisto(); }
        private void AcercaDestaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e) { Acerca acercaForm = new Acerca(); acercaForm.Show();}
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void SairToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }
        private void NovoRegistoToolStripMenuItem_Click(object sender, EventArgs e) { panel_bottom.Visible = true; }
        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e) { Form3Clientes f3 = new Form3Clientes(); f3.Show();}
        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e) { Form2Funcionarios f3 = new Form2Funcionarios(); f3.Show();}
    }
}
