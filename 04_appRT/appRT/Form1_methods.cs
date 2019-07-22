using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appRT
{
    public partial class Form1: Form
    {

        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            // Preencher ComboBox
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;
        }


        public void Atualizar_contagem_estado()
        {
            int total_registos = db.ContarTotalRegistos();
            int contagem = dataGridView1.RowCount;

            if (contagem < total_registos)
                lbl_estado.Text = $"{total_registos} intervenções (a apresentar apenas os primeiros {contagem} registos)";
            else
                lbl_estado.Text = $"{contagem} intervenções";
        }


        public void AtualizarEstatisticas()
        {
            grid_stats.Rows.Clear();

            grid_stats.Rows.Add("Geral: ");
            grid_stats.Rows.Add("  - Total de registos", db.ContarTotalRegistos());
            grid_stats.Rows.Add("  - Registos este ano", db.ContarRegistosEsteAno());
            grid_stats.Rows.Add("  - Registos este mês", db.ContarRegistosEsteMes());

            if (comboBox1_clientes.SelectedIndex > 0)
            {
                string nome_cliente = comboBox1_clientes.Text;
                if (nome_cliente.Length > 30)
                    nome_cliente = nome_cliente.Substring(0, 30) + "…";

                int cod_cliente = Convert.ToInt32(comboBox1_clientes.SelectedValue);
                int registos_cliente_mes = db.ContarRegistosClienteEsteMes(cod_cliente);
                string minutos_cliente_mes = "BBB";

                grid_stats.Rows.Add();
                grid_stats.Rows.Add("Cliente: " + nome_cliente);
                grid_stats.Rows.Add("  - Registos este mês", registos_cliente_mes);
                grid_stats.Rows.Add("  - Minutos este mês", minutos_cliente_mes);
            }

            if (comboBox2_funcionarios.SelectedIndex > 0)
            {
                string nome_funcionario = comboBox2_funcionarios.Text;
                if (nome_funcionario.Length > 30)
                    nome_funcionario = nome_funcionario.Substring(0, 30) + "…";

                string minutos_funcionario_mes = "AAA";


                int cod_funcionario = Convert.ToInt32(comboBox2_funcionarios.SelectedValue);
                int registos_funcionario_mes = db.ContarRegistosFuncEsteMes(cod_funcionario);

                grid_stats.Rows.Add();
                grid_stats.Rows.Add("Func.: " + nome_funcionario);
                grid_stats.Rows.Add("  - Registos este mês", registos_funcionario_mes);
                grid_stats.Rows.Add("  - Minutos este mês", minutos_funcionario_mes);
            }

            grid_stats.ClearSelection();
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

            if (textBox1_clientes.Focused || textBox2_funcionarios.Focused)
                return;


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

                dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);

                if (has_filter == false)
                    Atualizar_contagem_estado();
                else
                    lbl_estado.Text = $"{dataGridView1.RowCount} intervenções";

                AtualizarEstatisticas();
            }
            catch (Exception)
            { throw; }
        }


        public void alternarPainelLateral()
        {
            if (panel1.Visible)
            {
                panel1.Hide();
                panel_bottom.Width += panel1.Width;
                dataGridView1.Width += panel1.Width;
                mostrarPainelLateralToolStripMenuItem.Checked = false;
            }
            else
            {
                panel1.Show();
                panel_bottom.Width -= panel1.Width;
                dataGridView1.Width -= panel1.Width;
                mostrarPainelLateralToolStripMenuItem.Checked = true;
                AtualizarEstatisticas();
            }
        }


        public void alternarPainelNovoRegisto()
        {
            if (panel_bottom.Visible)
            {
                panel_bottom.Hide();
                dataGridView1.Height += panel_bottom.Height;
                painelDeNovoRegistoToolStripMenuItem.Checked = false;
            }
            else
            {
                panel_bottom.Show();
                dataGridView1.Height -= panel_bottom.Height;
                painelDeNovoRegistoToolStripMenuItem.Checked = true;
            }
        }

        public void guardar_registo_tempo()
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

            ssql = "INSERT INTO T_registo_de_tempos VALUES (" +
                   $"'{cod_cliente}','{cod_funcionario}','{data}', {minutos}, " +
                   $"'{descritivo}', '{categoria}')";

            MessageBox.Show(ssql, "SQL Query:");
            db.InserirRegistoTempo(cod_cliente, cod_funcionario, data, minutos, descritivo, categoria);
            Filtrar_lista();
        }

        public void limpar_form_novo_registo()
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

    }



  }
