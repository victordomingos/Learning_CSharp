using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prod1_Shrek_da_Silva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            Int64 valor_base;
            Int16 ano;
            Double desc_escalao = 0.90;
            Double desc_socio = 0.95;
            Int64 agravamento = 12;
            Double reside_distrito = 0.99;
            Double reside_amares = 1.20;
            Int64 resultado;

            valor_base = Convert.ToInt64(txt_valor_base.Text);
            
            



            resultado = (Int64) (valor_base * desc_escalao * desc_socio * reside_distrito * reside_amares + agravamento);
            txt_resultado.Text = Convert.ToString(resultado);
        }
    }
}
