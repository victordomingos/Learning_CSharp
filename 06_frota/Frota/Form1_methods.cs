using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Frota
{
    public partial class Form1 : Form
    {

        public void InitGrid()
        {
            string ssql;

            ssql = "SELECT id, veiculo_id as Veículo, condutor_id as Condutor, data as Data, distancia as Distância " +
                   "FROM viagem " +
                   "ORDER BY data DESC";

            grid.DataSource = db.ObterDados(ssql);

            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            grid.AllowUserToAddRows = false;
            grid.ShowEditingIcon = false;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = true;
            lbl_distancia.Text = ObterDistanciaTotal();
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

        public void LimparFormulario()
        {
            cmb_condutor.SelectedIndex = 0;
            cmb_veiculo.SelectedIndex = 0;
            txt_distancia.Clear();
            calendario.SetDate(System.DateTime.Now);
        }

        public void InserirViagem()
        {
            // validar dados
            int veiculo_id = Convert.ToInt32(cmb_veiculo.SelectedValue.ToString());
            int condutor_id = Convert.ToInt32(cmb_condutor.SelectedValue.ToString());
            double distancia = Convert.ToDouble(txt_distancia.Text);
            MessageBox.Show(distancia.ToString());

            string data_hora = calendario.SelectionEnd.ToString("yyyy/MM/dd  HH:mm:ss.fff");

            // inserir dados
            var result = db.InserirRegistoViagem(veiculo_id, condutor_id, distancia, data_hora);

            // messagebox caso resultado seja != 0 (erro)
            InitGrid();
        }

        public string ObterDistanciaTotal()
        {
            double soma = 0;

            foreach (DataGridViewRow item in grid.Rows)
                { soma += Convert.ToDouble(item.Cells["Distância"].Value); }

            return Convert.ToString(soma);
        }

        public void AlternarNovoRegisto()
        {
            if (!panel1.Visible)
            {
                panel1.Visible = true;
                grid.Width -= panel1.Width;
            }
            else
            {
                panel1.Hide();
                grid.Width += panel1.Width;
            }
        }
        
        public void EliminarRegisto()
        {
            int id = Convert.ToInt32(grid.SelectedRows[0].Cells[0].Value);
            // eliminar registo na BD.


        }



    }


}

