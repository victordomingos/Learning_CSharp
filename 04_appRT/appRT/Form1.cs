using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace appRT
{
    public partial class Form1 : Form
    {
        public readonly int DEFAULT_MAX_ROWS = 20;

        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            // Preencher ComboBox
            MyGetData db = new MyGetData();
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;

        }
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
            ssql = $"SET ROWCOUNT {DEFAULT_MAX_ROWS} SELECT Id as ID, cod_cliente as Cliente, " +
                    "cod_funcionario as Funcionário, data as Data, tempo as Tempo, " +
                    "descritivo as Descrição, categoria as Categoria " +
                    "FROM T_registo_de_tempos " +
                    "ORDER BY Id DESC";

            MyGetData db = new MyGetData();
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
            

            Atualizar_contagem_estado();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        public void Atualizar_contagem_estado()
        {
            MyGetData db = new MyGetData();
            DataTable dt = db.BuscaDados(SConnection.SC, "SELECT COUNT(Id) from T_registo_de_tempos;");
            int contagem = dataGridView1.RowCount;
            var total_registos = Convert.ToInt32(dt.Rows[0][0]);

            if (contagem < total_registos)
                lbl_estado.Text = $"{total_registos} intervenções (a apresentar apenas os primeiros {contagem} registos)";
            else
                lbl_estado.Text = $"{contagem} intervenções";
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
                //comboBox1_clientes.SelectedText = "hI!";

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void TextBox2_funcionarios_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT Id, nome_funcionario FROM T_funcionarios";
            string texto1 = textBox2_funcionarios.Text.ToString();
            //string texto2 = textBox1_clientes.Text.ToString();
            string filtro_funcionario = "";
            string filtro_cliente = "";

            if (texto1 != "")
                filtro_funcionario = $" WHERE nome_funcionario LIKE '%{texto1}%'";

            //if (texto2 != "")
            //    filtro_cliente = " AND nome_cliente LIKE '%" + texto2 + "%'";

            ssql += filtro_funcionario + filtro_cliente;
            //MessageBox.Show(ssql);

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

        
        private void Filtrar_lista()
        {
            string ssql;
            string filtro_cliente = "";
            string filtro_funcionario = "";
            string operador = "";
            string filtro = "";
            bool has_filter = false;
            string ssql_prefix = "";

            try
            {
                Int16 cod_cliente = Convert.ToInt16(comboBox1_clientes.SelectedValue.ToString());
                Int16 cod_funcionario = Convert.ToInt16(comboBox2_funcionarios.SelectedValue.ToString());

                if (cod_cliente != 0)
                {
                    if (cod_cliente == -1)
                    {
                        has_filter = false;
                        filtro_cliente = "";
                    }
                    else
                    {
                        filtro_cliente = $"cod_cliente='{cod_cliente}'";
                        has_filter = true;
                    }
                }


                if (cod_funcionario != 0)
                {
                    if (cod_funcionario == -1)
                        filtro_funcionario = "";
                    else
                    {
                        if (has_filter)
                            operador = " and ";

                        filtro_funcionario = $"cod_funcionario='{cod_funcionario}'";
                        has_filter = true;
                    }
                }

                if (has_filter)
                    filtro = " WHERE " + filtro_cliente + operador + filtro_funcionario;
                else
                    ssql_prefix = $"SET ROWCOUNT {DEFAULT_MAX_ROWS} ";

                ssql = "SELECT Id as ID, cod_cliente as Cliente, cod_funcionario as Funcionário, " +
                       "data as Data, tempo as Tempo, descritivo as Descrição, categoria as Categoria " +
                       "FROM T_registo_de_tempos";
                ssql = ssql_prefix + ssql + filtro + " ORDER BY Id DESC";

                MyGetData db = new MyGetData();
                dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);

                if (has_filter == false)
                    Atualizar_contagem_estado();
                else
                    lbl_estado.Text = $"{dataGridView1.RowCount} intervenções";
            }
            catch (Exception)
                { throw; }
        }

        private void Btn_novo_limpar_Click(object sender, EventArgs e)
        {
            string ssql;

            ssql = "SELECT Id, nome_cliente FROM T_clientes";
            InitComboBox(cmb_novo_select_cliente, ssql, "nome_cliente", "id", "-- Selecionar Cliente --");

            ssql = "SELECT Id, nome_funcionario FROM T_funcionarios";
            InitComboBox(cmb_novo_select_func, ssql, "nome_funcionario", "id", "-- Selecionar Funcionário --");

            txt_novo_desc.Text = "";
            txt_novo_tempo.Text = "";
            dt_novo_data.Value = DateTime.Now;
        }

        private void Btn_novo_guardar_Click(object sender, EventArgs e)
        {
            string ssql;
            
            string cod_cliente = cmb_novo_select_cliente.SelectedValue.ToString();
            string cod_funcionario = cmb_novo_select_func.SelectedValue.ToString();
            string data = dt_novo_data.Value.ToString();
            string tempo = txt_novo_tempo.Text;
            Int32 minutos;
            string descritivo = txt_novo_desc.Text;
            string categoria = cmb_novo_categoria.Text;

            // TODO: Fazer validação de dados antes de avançar!
            if (cod_cliente == "-1")
            {
                MessageBox.Show("Antes de guardar um novo registo, deve selecionar o cliente.", "Atenção!");
                cmb_novo_select_cliente.Focus();
                return;
            }

            if (cod_funcionario == "-1")
            {
                MessageBox.Show("Antes de guardar um novo registo, deve selecionar o funcionário.", "Atenção!");
                cmb_novo_select_cliente.Focus();
                return;
            }

            try
            {
                minutos = Convert.ToInt32(txt_novo_tempo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, introduza corretamente o tempo (número de minutos).", "Atenção!");
                txt_novo_tempo.Focus();
                return;
            }

            if (txt_novo_desc.Text == "")
            {
                MessageBox.Show("Por favor, introduza a descrição do serviço.", "Atenção!");
                txt_novo_desc.Focus();
                return;
            }

            if (cmb_novo_categoria.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor, selecione a categoria de serviço.", "Atenção!");
                cmb_novo_categoria.Focus();
                return;
            }


            ssql =  "INSERT INTO T_registo_de_tempos VALUES (" +
                   $"'{cod_cliente}','{cod_funcionario}','{data}', {minutos}, " +
                   $"'{descritivo}', '{categoria}')";
            MessageBox.Show(ssql, "SQL Query:");
            Filtrar_lista();
        }

        private void Cmb_novo_categoria_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
