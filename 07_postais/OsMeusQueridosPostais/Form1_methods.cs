using System;
using System.Data;
using System.Windows.Forms;

namespace OsMeusQueridosPostais
{
    public partial class Form1
    {
        public void InitGrid()
        {
            string ssql;
            string start = date_start.Value.ToString("yyyy/MM/dd");
            string end = date_end.Value.ToString("yyyy/MM/dd");
            string filtro = "";

            if (int.TryParse(cmb_oferecedor.SelectedValue.ToString(), out int id_oferecedor))
            {
                if (cmb_oferecedor.SelectedIndex > 0)
                {
                    filtro += $" AND oferta.oferecedor={id_oferecedor} ";
                }
            }

            if (int.TryParse(cmb_recetor.SelectedValue.ToString(), out int id_recetor))
            { 
                if (cmb_recetor.SelectedIndex > 0)
                {
                    filtro += $" AND oferta.recetor={id_recetor} ";
                }
            }

            ssql = "SELECT oferta.codigo as ID, oferta.data_hora as Data, oferecedor.nome as Remetente, " +
                   "recetor.nome as Recetor, postal.tipo as Tipo, postal.ano as Ano " +
                   "FROM oferta " +
                   "INNER JOIN oferecedor ON oferecedor.codigo = oferta.oferecedor " +
                   "INNER JOIN recetor ON recetor.codigo = oferta.recetor " +
                   "INNER JOIN postal ON postal.codigo = oferta.postal " +
                   $"WHERE (oferta.data_hora BETWEEN '{start}' AND '{end}')  {filtro} " +
                   "ORDER BY data_hora DESC";

            grid1.DataSource = db.ObterDados(ssql);

            grid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid1.AllowUserToAddRows = false;
            grid1.ShowEditingIcon = false;
            grid1.RowHeadersVisible = false;
            grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid1.ReadOnly = true;
        }


        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            // Preencher ComboBox
            DataTable dt = db.ObterDados(ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;
        }

        private void InserirOuAtualizarOferta()
        {
            string data_hora = monthCalendar1.SelectionRange.Start.ToString("yyyy/MM/dd");
            int oferecedor = Convert.ToInt32(cmb_novaOferta_oferecedor.SelectedValue);
            int recetor = Convert.ToInt32(cmb_novaOferta_recetor.SelectedValue);
            int postal = Convert.ToInt32(cmb_novaOferta_postal.SelectedValue);

            if (oferecedor == -1 || recetor == -1 || postal == -1)
            {
                MessageBox.Show("Por favor preencha todas as informações necessárias.");
                return;
            }

            db.InserirRegistoOferta(a_editar_registo, data_hora, oferecedor, recetor, postal);
            InitGrid();
            
        }

        public void LimparNovaOferta()
        {
            a_editar_registo = -1;
            cmb_novaOferta_oferecedor.SelectedIndex = 0;
            cmb_novaOferta_recetor.SelectedIndex = 0;
            cmb_novaOferta_postal.SelectedIndex = 0;
            monthCalendar1.SetDate(DateTime.Now);
        }
    }


}