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

        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;
        }

        public void InitListBox(ListBox listb, string ssql, string displayM, string valueM)
        {
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            listb.DataSource = dt;
            listb.DisplayMember = displayM;
            listb.ValueMember = valueM;
        }

        public void EliminarRegisto()
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

                db.EliminarRegistoTempo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

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