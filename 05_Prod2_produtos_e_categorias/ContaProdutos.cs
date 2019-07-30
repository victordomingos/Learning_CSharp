using System.Windows.Forms;

namespace prod2_app
{
    public class ContaProdutos
    {
        public void ContarProdutos(DataGridView grid)
        {
            string n = grid.Rows.Count.ToString();
            string msg = $"Nesta categoria, há neste momento um total de {n} produtos.";
            MessageBox.Show(msg, "Contagem de Produtos");
        }
    }
}
