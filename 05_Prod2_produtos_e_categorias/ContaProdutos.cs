using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Prod2_produtos_e_categorias
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
