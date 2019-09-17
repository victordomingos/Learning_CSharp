using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Associados
{
    public partial class Form1 : Form
    {
        public MyDatabase db = new MyDatabase();
        public Form1()
        {
            InitializeComponent();
            AtualizarGrid("associados");
            InitComboBox(cmb_atividade);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) { grid1.DataSource = null; }

        private void toolStripButton2_Click(object sender, EventArgs e) { AtualizarGrid("atividades"); }

        private void toolStripButton3_Click(object sender, EventArgs e) { AtualizarGrid("associados"); }

        private void btn_limpar_Click(object sender, EventArgs e) { LimparNovoAssociado();}

        private void btn_registar_Click(object sender, EventArgs e) { RegistarAssociado(); }
    }
}
