using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace appRT
{
    public partial class Form1 : Form
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

                var hoje_ano = DateTime.Now.Year;
                var hoje_mes = DateTime.Now.Month;
                
                // contar minutos todos do cliente, apenas do mês atual
                string ssql = "SELECT SUM(tempo) FROM T_registo_de_tempos " +
                              "WHERE YEAR(data)=YEAR(CURRENT_TIMESTAMP) " +
                              "AND MONTH(data)=MONTH(CURRENT_TIMESTAMP) " +
                              $"AND cod_cliente='{cod_cliente}';";

                int minutos_cliente_mes = Convert.ToInt32(db.BuscaDados(SConnection.SC, ssql).Rows[0][0]);
                
                // converter minutos do mes p/ HH:MM a mostrar na gridview 2
                var h_cliente = minutos_cliente_mes / 60;
                var m_cliente = minutos_cliente_mes % 60;
                string s_minutos_cliente_mes = $"{h_cliente}h{m_cliente}m";


                grid_stats.Rows.Add();
                grid_stats.Rows.Add("Cliente: " + nome_cliente);
                grid_stats.Rows.Add("  - Registos este mês", registos_cliente_mes);
                grid_stats.Rows.Add("  - Tempo serviço este mês", s_minutos_cliente_mes);
            }

            if (comboBox2_funcionarios.SelectedIndex > 0)
            {
                string nome_funcionario = comboBox2_funcionarios.Text;
                if (nome_funcionario.Length > 30)
                    nome_funcionario = nome_funcionario.Substring(0, 30) + "…";

                int cod_funcionario = Convert.ToInt32(comboBox2_funcionarios.SelectedValue);
                int registos_funcionario_mes = db.ContarRegistosFuncEsteMes(cod_funcionario);

                // contar minutos todos do funcionario, apenas do mês atual
                string ssql = "SELECT SUM(tempo) FROM T_registo_de_tempos " +
                              "WHERE YEAR(data)=YEAR(CURRENT_TIMESTAMP) " +
                              "AND MONTH(data)=MONTH(CURRENT_TIMESTAMP) " +
                              $"AND cod_funcionario='{cod_funcionario}';";

                int minutos_func_mes = Convert.ToInt32(db.BuscaDados(SConnection.SC, ssql).Rows[0][0]);

                // converter minutos do mes p/ HH:MM a mostrar na gridview 2
                var h_func = minutos_func_mes / 60;
                var m_func = minutos_func_mes % 60;
                string s_minutos_func_mes = $"{h_func}h{m_func}m";

                grid_stats.Rows.Add();
                grid_stats.Rows.Add("Func.: " + nome_funcionario);
                grid_stats.Rows.Add("  - Registos este mês", registos_funcionario_mes);
                grid_stats.Rows.Add("  - Minutos este mês", s_minutos_func_mes);
            }

            grid_stats.ClearSelection();

            AtualizarTempoServicoEstado2();
        }

        private void AtualizarTempoServicoEstado2()
        {
            // atualizar contagem de tempo de serviço, a mostrar na barra de estado, no lado direito
            int minutos_total = 0;
            int minutos_mes_atual = 0;

            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                int minutos_linha = Convert.ToInt32(linha.Cells[4].Value);
                var hoje_ano = DateTime.Now.Year;
                var hoje_mes = DateTime.Now.Month;

                var linha_data = Convert.ToDateTime(linha.Cells[3].Value);
                var linha_ano = linha_data.Year;
                var linha_mes = linha_data.Month;

                minutos_total += minutos_linha;

                if (hoje_ano == linha_ano && hoje_mes == linha_mes)
                    minutos_mes_atual += minutos_linha;
            }

            // converter p/ H:M
            var h_total = minutos_total / 60;
            var m_total = (minutos_total % 60);
            var h_mes = minutos_mes_atual / 60;
            var m_mes = (minutos_mes_atual % 60);

            //var hm_mes_atual = ;
            estado_2.Text = "Tempo de serviço: ";
            if (minutos_total == 0)
                estado_2.Text = "";
            else
            {
                if (h_total != 0) estado_2.Text += $"{h_total}h";
                if (m_total != 0) estado_2.Text += $"{m_total}m";

                if (minutos_mes_atual != 0)
                {
                    estado_2.Text += $" (";
                    if (h_mes != 0) estado_2.Text += $"{ h_mes}h";
                    if (m_mes != 0) estado_2.Text += $"{m_total}m";

                    estado_2.Text += " este mês)";
                }
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
            if (!panel_bottom.Visible)
                return;

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
            if (!panel_bottom.Visible)
                return;

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
