using System;
using System.Data;
using System.Windows.Forms;

namespace Associados
{
    public partial class Form1
    {
        // Inicializa e coloniza a grid, configurando-a de acordo com o tipo de dados a receber.
        // Valores válidos para o parâmetro 'categoria': "associados" ou "atividade".
        public void AtualizarGrid(string categoria)
        {
            string ssql;

            if (categoria == "associados")
            {
                ssql = "SELECT associado.cod as 'ID', nome as Nome, ano_nasc as 'Ano Nac.', sexo as 'Sexo', quota as Quota, descritivo as Atividade " +
                       "FROM associado " +
                       "INNER JOIN atividade ON associado.atividade_cod=atividade.cod ";

                grid1.DataSource = db.ObterDados(ssql);

                grid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grid1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grid1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                
            }
            else
            {
                ssql = "SELECT cod as 'Cod.', descritivo as Descritivo " +
                      "FROM atividade ";

                grid1.DataSource = db.ObterDados(ssql);

                grid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               
                grid1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            }
            grid1.AllowUserToAddRows = false;
            grid1.ShowEditingIcon = false;
            grid1.RowHeadersVisible = false;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid1.ReadOnly = true;

        }



        public void LimparNovoAssociado()
        {
            txt_nome.Clear();
            txt_ano.Clear();
            cmb_atividade.SelectedIndex = 0;
            rad_m.Checked = true;
            chk_quota.Checked = false;
        }

        public void InitComboBox(ComboBox cmbx)
        {
            string ssql = "SELECT cod, descritivo FROM atividade";
            DataTable dt = db.ObterDados(ssql);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = "descritivo";
            cmbx.ValueMember = "cod";
        }

        public void RegistarAssociado()
        {
            // Validar dados
            string nome = txt_nome.Text.Trim();
            bool is_ano_numeric = int.TryParse(txt_ano.Text, out int ano);
            string sexo = rad_f.Checked? "F": "M";
            bool quota = chk_quota.Checked;
            int atividade = Convert.ToInt32(cmb_atividade.SelectedValue.ToString());

            if (nome.Length == 0)
            {
                MessageBox.Show("Por favor, introduza o nome (campo obrigatório).");
                return;
            }

            if (is_ano_numeric)
            {
                if (ano < 1900 || ano > DateTime.Now.Year)
                { 
                    MessageBox.Show("Por favor, verifique o ano de nascimento. Nesta associação, por motivos de ordem técnica, ainda não são admitidos viajantes no tempo.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, verifique e corrija o ano de nascimento.");
                return;
            }


            // Inserir na base de dados
            db.InserirAssociado(nome, ano, sexo, quota, atividade);
        }


        public void AtualizarListaNomes()
        {
            string ssql;
            int atividade = Convert.ToInt32(cmb_atividade2.SelectedValue);

            ssql = $"SELECT cod, nome FROM associado WHERE atividade_cod={atividade} ORDER BY nome ASC";
            list_nomes.DataSource = db.ObterDados(ssql);
            list_nomes.DisplayMember = "nome";
            list_nomes.ValueMember = "cod";
        }


        public void MostrarContagensA()
        {
            string ssql;
            int h_futebol;
            int m_dancas;
            DataTable dt;
            string homem = "homens";
            string mulher = "mulheres";
            string plural1 = "s";
            string plural2 = "s";

            ssql = "SELECT COUNT(*) FROM associado WHERE SEXO='M' and atividade_cod=3";
            dt = db.ObterDados(ssql);
            h_futebol = Convert.ToInt32(dt.Rows[0][0].ToString ());

            ssql = "SELECT COUNT(*) FROM associado WHERE SEXO='F' and atividade_cod=1";
            dt = db.ObterDados(ssql);
            m_dancas = Convert.ToInt32(dt.Rows[0][0].ToString());

            if (h_futebol == 1)
            {
                homem = "homem";
                plural1 = "";
            }

            if (m_dancas == 1)
            {
                mulher = "mulher";
                plural2 = "";
            }
            
            txt_contagens.Text = $"Esta associação tem {h_futebol} {homem} inscrito{plural1} em futebol e {m_dancas} {mulher} inscrita{plural2} nas danças.";
        }




        public void MostrarContagensB()
        {
            string ssql;
            int bd_ativ_a;
            int grid_ativ_a = 0;
            DataTable dt;
            string plural1 = "s";
            
            ssql = "SELECT COUNT(*) FROM associado WHERE atividade_cod=1";
            dt = db.ObterDados(ssql);
            bd_ativ_a = Convert.ToInt32(dt.Rows[0][0].ToString());


            if (bd_ativ_a == 1)
            {
                plural1 = "";
            }

            
            for (int i = 0; i < grid1.Rows.Count; i++)
            {
                if (grid1.Rows[i].Cells[5].Value.ToString() == "A - Danças de Salão")
                    grid_ativ_a++;
            }
            txt_contagens.Text = $"Há na base de dados {bd_ativ_a} pessoa{plural1} inscrita{plural1} na atividade A; na grid, há {grid_ativ_a}.";
        }

    }
}