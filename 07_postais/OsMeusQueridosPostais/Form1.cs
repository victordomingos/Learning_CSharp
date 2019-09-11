using System;
using System.Windows.Forms;

namespace OsMeusQueridosPostais
{

    public partial class Form1 : Form
    {
        public MyDatabase db = new MyDatabase();

        public Form1()
        {
            InitializeComponent();

            string ssql;

            InitGrid();

            
            ssql = "SELECT codigo, nome " +
                   "FROM oferecedor " +
                   "ORDER BY codigo";
            InitComboBox(cmb_oferecedor, ssql, "nome", "codigo", " -- Clique para selecionar -- ");


            ssql = "SELECT codigo, nome " +
                   "FROM recetor " +
                   "ORDER BY codigo";
            InitComboBox(cmb_recetor, ssql, "nome", "codigo", " -- Clique para selecionar -- ");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Date_start_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
