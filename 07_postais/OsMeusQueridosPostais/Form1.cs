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

            /*
            ssql = "SELECT id, CONCAT(matricula, '  -  ', marca, ' ', modelo) as descritivo " +
                   "FROM veiculo " +
                   "ORDER BY id";
            InitComboBox(cmb_veiculo, ssql, "descritivo", "id", " -- Selecionar veículo -- ");


            ssql = "SELECT id, nome " +
                   "FROM condutor " +
                   "ORDER BY id";
            InitComboBox(cmb_condutor, ssql, "nome", "id", " -- Selecionar condutor -- ");
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
