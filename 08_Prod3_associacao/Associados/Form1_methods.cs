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
                ssql = "SELECT associado.cod, nome, ano_nasc, sexo, quota, descritivo " +
                       "FROM associado " +
                       "INNER JOIN atividade ON associado.atividade_cod=atividade.cod ";

                grid1.DataSource = db.ObterDados(ssql);

                grid1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grid1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                grid1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                grid1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                grid1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grid1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                

                grid1.AllowUserToAddRows = false;
                grid1.ShowEditingIcon = false;
                grid1.RowHeadersVisible = false;
                grid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid1.ReadOnly = true;
            }
            else
            {

            }

        }
    }
}