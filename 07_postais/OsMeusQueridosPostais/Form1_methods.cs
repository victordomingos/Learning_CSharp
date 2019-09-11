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
            int id_oferecedor = -1;
            int id_recetor = -1;

            if (int.TryParse(cmb_oferecedor.SelectedValue.ToString(), out id_oferecedor) && cmb_oferecedor.SelectedIndex != -1)
                { filtro += $" AND oferta.oferecedor={id_oferecedor} "; }
            else
                { MessageBox.Show("A");
                filtro += ""; }


            if (int.TryParse(cmb_recetor.SelectedValue.ToString(), out id_recetor) && cmb_recetor.SelectedIndex != -1)
                { filtro += $" AND oferta.recetor={id_recetor} "; }
            else
                { MessageBox.Show("B");
                filtro += ""; }


            ssql = "SELECT oferta.codigo as ID, oferta.data_hora as Data, oferecedor.nome as Remetente, " +
                   "recetor.nome as Recetor, postal.tipo as Tipo, postal.ano as Ano " +
                   "FROM oferta " +
                   "INNER JOIN oferecedor ON oferecedor.codigo = oferta.oferecedor " +
                   "INNER JOIN recetor ON recetor.codigo = oferta.recetor " +
                   "INNER JOIN postal ON postal.codigo = oferta.postal " +
                   $"WHERE (oferta.data_hora BETWEEN '{start}' AND '{end}')  {filtro} " +
                   "ORDER BY data_hora DESC";
            MessageBox.Show(ssql);

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
    }


}