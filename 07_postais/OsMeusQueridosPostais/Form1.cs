using System;
using System.Windows.Forms;

namespace OsMeusQueridosPostais
{

    public partial class Form1 : Form
    {
        public MyDatabase db = new MyDatabase();
        public int a_editar_registo = -1;

        public Form1()
        {
            InitializeComponent();

            string ssql;
     
            ssql = "SELECT codigo, nome FROM oferecedor ORDER BY nome";
            InitComboBox(cmb_oferecedor, ssql, "nome", "codigo", " -- Clique para selecionar -- ");
            InitComboBox(cmb_novaOferta_oferecedor, ssql, "nome", "codigo", " -- Pessoa que ofereceu -- ");

            ssql = "SELECT codigo, nome FROM recetor ORDER BY nome";
            InitComboBox(cmb_recetor, ssql, "nome", "codigo", " -- Clique para selecionar -- ");
            InitComboBox(cmb_novaOferta_recetor, ssql, "nome", "codigo", " -- Pessoa que recebeu -- ");

            ssql = "SELECT P.codigo, CONCAT(T.designacao, ' (',  P.ano, ')' ) as tipo_postal  " +
                   "FROM postal P " +
                   "INNER JOIN tipo T ON T.codigo=P.tipo " +
                   "ORDER BY tipo_postal";
            InitComboBox(cmb_novaOferta_postal, ssql, "tipo_postal", "codigo", " -- Postal recebido -- ");

            InitGrid();
            InitGridContactos();
        }

        private void Form1_Load(object sender, EventArgs e) {        }

        private void Label3_Click(object sender, EventArgs e) {        }
        private void Date_start_ValueChanged(object sender, EventArgs e) { InitGrid(); }
        private void Date_end_ValueChanged(object sender, EventArgs e){ InitGrid(); }
        private void Cmb_oferecedor_SelectedIndexChanged(object sender, EventArgs e) { InitGrid(); }
        private void Cmb_recetor_SelectedIndexChanged(object sender, EventArgs e){ InitGrid();}
        private void Btn_novaOferta_guardar_Click(object sender, EventArgs e) { InserirOuAtualizarOferta();}

        private void Btn_novaOfertaCancelar_Click(object sender, EventArgs e) { LimparNovaOferta(); }

        private void Btn_eliminarOferta_Click(object sender, EventArgs e)
        {
            db.EliminarRegistoOferta(Convert.ToInt32(grid1.SelectedRows[0].Cells[0].Value));
            InitGrid();
        }

        private void BtnCancelarPesquisa_Click(object sender, EventArgs e) { txt_pesquisa_contactos.Clear();}
        private void Txt_pesquisa_contactos_TextChanged(object sender, EventArgs e) { InitGridContactos(); }
        private void Rad_oferecedores_CheckedChanged(object sender, EventArgs e) { InitGridContactos(); }
        private void Rad_tudo_CheckedChanged(object sender, EventArgs e) { InitGridContactos(); }
        private void Rad_recetores_CheckedChanged(object sender, EventArgs e) { InitGridContactos(); }

        private void Btn_atualizar_contactos_Click(object sender, EventArgs e){ AtualizarContactos(); }
    }
}
