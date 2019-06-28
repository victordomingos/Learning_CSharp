// Produção 1 (C#) - Cálculo do Valor da Avença
// 2019-06-27 
// Victor Domingos

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prod1_Shrek_da_Silva
{
    public partial class Form1 : Form
    {
        // se ano de nascimento for 2000 ou superior, tem desconto de 10 % (passa a 90)
        // se desconto de escalão ativo, desconta outros 10 % sobre 100(passa a 80)
        // se desconto de sócio ativo, desconta 5 % (75)
        // se tem agravamento, acresce 12(não é percentagem)(87)
        // se reside no distrito desconta 1 % (86) 
        // se o concelho for Amares, desconta 20 % (66)(considere Braga, Amares e Guimarães, como concelhos para a combobox)

        private readonly double percent_desc_ano = 10;
        private readonly double percent_desc_escalao = 10;
        private readonly double percent_desc_socio = 5;
        private readonly double valor_agravamento = 12;
        private readonly double percent_desc_reside_distrito = 1;
        private readonly double percent_desc_reside_amares = 20;

        public Form1()
        {
            InitializeComponent();
        }

        // Calcula o montante do desconto a partir do valor base e da percentagem do desconto
        // Ex. Valor base 200, com 10 % desconto --> 20
        private double CalcularDesconto(double valor_base, double percent_desc)
        {
            return valor_base * percent_desc / 100;
        }


        private bool IsFormValid()
        {
            bool form_status = true;
            int ano_atual = System.DateTime.Now.Year;
            int ano;
            double valor_base;
            Color bad_field_color = Color.LightSalmon;

            try
            {
                ano = Convert.ToInt32(txt_ano.Text);
                
                if ((ano > ano_atual) || (ano < ano_atual - 150))
                {
                    // ano fora do intervalo.
                    txt_ano.BackColor = bad_field_color;
                    lbl_ano_erro.Text = "O ano encontra-se fora do intervalo.";
                    lbl_ano_erro.Visible = true;
                    form_status = false;
                }
                else
                {
                    txt_ano.BackColor = Color.White;
                    lbl_ano_erro.Visible = false;
                }
            }
            catch (Exception)
            {
                lbl_ano_erro.Text = "Por favor introduza um número válido.";
                lbl_ano_erro.Visible = true;
                txt_ano.BackColor = bad_field_color;
                form_status = false;
            }


            try
            {
                valor_base = Convert.ToDouble(txt_valor_base.Text);

                if (valor_base <= 0)
                {
                    // valor base fora do intervalo.
                    txt_valor_base.BackColor = bad_field_color;
                    lbl_valor_base_erro.Text = "O valor base deve ser positivo.";
                    lbl_valor_base_erro.Visible = true;
                    form_status = false;
                }
                else
                {
                    txt_valor_base.BackColor = Color.White;
                    lbl_valor_base_erro.Visible = false;
                }
            }
            catch (Exception)
            {
                txt_valor_base.BackColor = bad_field_color;
                lbl_valor_base_erro.Text = "Por favor introduza um número válido.";
                lbl_valor_base_erro.Visible = true;
                form_status = false;
            }

            // reside distrito ?
            // concelho ?

            return form_status;
        }


        private void CalcularTudo()
        {
            double valor_base;
            double resultado;
            short ano;

            if (!IsFormValid())
                return;

            // Descontos e agravamentos começam a zero e só são alterados se for necessário.
            double desc_ano = 0;
            double desc_escalao = 0;
            double desc_socio = 0;
            double agravamento = 0;
            double desc_reside_distrito = 0;
            double desc_reside_amares = 0;

            valor_base = Convert.ToDouble(txt_valor_base.Text);
            ano = Convert.ToInt16(txt_ano.Text);


            // Alterar os valores de descontos e agravamentos de acordo com input
            if (ano >= 2000)
                desc_ano = CalcularDesconto(valor_base, percent_desc_ano);

            if (chk_escalao10.Checked)
                desc_escalao = CalcularDesconto(valor_base, percent_desc_escalao);

            if (chk_desconto_socio_5.Checked)
                desc_socio = CalcularDesconto(valor_base, percent_desc_socio);

            if (chk_agravamento_12e.Checked)
                agravamento = valor_agravamento;

            if (rad_sim.Checked)
                desc_reside_distrito = CalcularDesconto(valor_base, percent_desc_reside_distrito);

            if (cmb_concelho.Text == "Amares")
                desc_reside_amares = CalcularDesconto(valor_base, percent_desc_reside_amares);


            // Calcular e mostrar resultado
            resultado = valor_base - desc_ano - desc_escalao - desc_socio - desc_reside_distrito - desc_reside_amares + agravamento;
            txt_resultado.Text = Convert.ToString(resultado);
        }


        private void Btn_calcular_Click(object sender, EventArgs e) { CalcularTudo(); }
        private void Txt_ano_TextChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Txt_valor_base_TextChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Chk_escalao10_CheckedChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Chk_desconto_socio_5_CheckedChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Chk_agravamento_12e_CheckedChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Rad_sim_CheckedChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Rad_nao_CheckedChanged(object sender, EventArgs e) { CalcularTudo(); }
        private void Cmb_concelho_SelectedIndexChanged(object sender, EventArgs e) { CalcularTudo(); }
    }
}
