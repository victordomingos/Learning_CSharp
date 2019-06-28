namespace Prod1_Shrek_da_Silva
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_valor_base = new System.Windows.Forms.TextBox();
            this.chk_escalao10 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_desconto_socio_5 = new System.Windows.Forms.CheckBox();
            this.chk_agravamento_12e = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rad_sim = new System.Windows.Forms.RadioButton();
            this.rad_nao = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_concelho = new System.Windows.Forms.ComboBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl_ano_erro = new System.Windows.Forms.Label();
            this.lbl_valor_base_erro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor base";
            // 
            // txt_nome
            // 
            this.txt_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nome.Location = new System.Drawing.Point(113, 91);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(267, 20);
            this.txt_nome.TabIndex = 3;
            this.txt_nome.Text = "Shrek da Silva";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(113, 120);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 4;
            this.txt_ano.TextChanged += new System.EventHandler(this.Txt_ano_TextChanged);
            // 
            // txt_valor_base
            // 
            this.txt_valor_base.Location = new System.Drawing.Point(113, 146);
            this.txt_valor_base.Name = "txt_valor_base";
            this.txt_valor_base.Size = new System.Drawing.Size(100, 20);
            this.txt_valor_base.TabIndex = 5;
            this.txt_valor_base.TextChanged += new System.EventHandler(this.Txt_valor_base_TextChanged);
            // 
            // chk_escalao10
            // 
            this.chk_escalao10.AutoSize = true;
            this.chk_escalao10.Location = new System.Drawing.Point(113, 186);
            this.chk_escalao10.Name = "chk_escalao10";
            this.chk_escalao10.Size = new System.Drawing.Size(162, 17);
            this.chk_escalao10.TabIndex = 6;
            this.chk_escalao10.Text = "Desconto de escalão? (10%)";
            this.chk_escalao10.UseVisualStyleBackColor = true;
            this.chk_escalao10.CheckedChanged += new System.EventHandler(this.Chk_escalao10_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cálculo do Valor da Avença";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(455, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // chk_desconto_socio_5
            // 
            this.chk_desconto_socio_5.AutoSize = true;
            this.chk_desconto_socio_5.Location = new System.Drawing.Point(113, 209);
            this.chk_desconto_socio_5.Name = "chk_desconto_socio_5";
            this.chk_desconto_socio_5.Size = new System.Drawing.Size(144, 17);
            this.chk_desconto_socio_5.TabIndex = 9;
            this.chk_desconto_socio_5.Text = "Desconto de sócio? (5%)";
            this.chk_desconto_socio_5.UseVisualStyleBackColor = true;
            this.chk_desconto_socio_5.CheckedChanged += new System.EventHandler(this.Chk_desconto_socio_5_CheckedChanged);
            // 
            // chk_agravamento_12e
            // 
            this.chk_agravamento_12e.AutoSize = true;
            this.chk_agravamento_12e.Location = new System.Drawing.Point(113, 233);
            this.chk_agravamento_12e.Name = "chk_agravamento_12e";
            this.chk_agravamento_12e.Size = new System.Drawing.Size(148, 17);
            this.chk_agravamento_12e.TabIndex = 10;
            this.chk_agravamento_12e.Text = "Tem agravamento? (12 €)";
            this.chk_agravamento_12e.UseVisualStyleBackColor = true;
            this.chk_agravamento_12e.CheckedChanged += new System.EventHandler(this.Chk_agravamento_12e_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Reside no distrito?";
            // 
            // rad_sim
            // 
            this.rad_sim.AutoSize = true;
            this.rad_sim.Location = new System.Drawing.Point(113, 275);
            this.rad_sim.Name = "rad_sim";
            this.rad_sim.Size = new System.Drawing.Size(42, 17);
            this.rad_sim.TabIndex = 12;
            this.rad_sim.TabStop = true;
            this.rad_sim.Text = "Sim";
            this.rad_sim.UseVisualStyleBackColor = true;
            this.rad_sim.CheckedChanged += new System.EventHandler(this.Rad_sim_CheckedChanged);
            // 
            // rad_nao
            // 
            this.rad_nao.AutoSize = true;
            this.rad_nao.Location = new System.Drawing.Point(113, 299);
            this.rad_nao.Name = "rad_nao";
            this.rad_nao.Size = new System.Drawing.Size(45, 17);
            this.rad_nao.TabIndex = 13;
            this.rad_nao.TabStop = true;
            this.rad_nao.Text = "Não";
            this.rad_nao.UseVisualStyleBackColor = true;
            this.rad_nao.CheckedChanged += new System.EventHandler(this.Rad_nao_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Concelho";
            // 
            // cmb_concelho
            // 
            this.cmb_concelho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_concelho.FormattingEnabled = true;
            this.cmb_concelho.Items.AddRange(new object[] {
            "Amares",
            "Braga",
            "Guimarães"});
            this.cmb_concelho.Location = new System.Drawing.Point(112, 343);
            this.cmb_concelho.Name = "cmb_concelho";
            this.cmb_concelho.Size = new System.Drawing.Size(162, 21);
            this.cmb_concelho.TabIndex = 15;
            this.cmb_concelho.SelectedIndexChanged += new System.EventHandler(this.Cmb_concelho_SelectedIndexChanged);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calcular.Location = new System.Drawing.Point(384, 341);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 16;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultado.Location = new System.Drawing.Point(466, 343);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(146, 20);
            this.txt_resultado.TabIndex = 17;
            // 
            // lbl_ano_erro
            // 
            this.lbl_ano_erro.AutoSize = true;
            this.lbl_ano_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_ano_erro.Location = new System.Drawing.Point(216, 124);
            this.lbl_ano_erro.Name = "lbl_ano_erro";
            this.lbl_ano_erro.Size = new System.Drawing.Size(31, 13);
            this.lbl_ano_erro.TabIndex = 18;
            this.lbl_ano_erro.Text = "MSG";
            this.lbl_ano_erro.Visible = false;
            // 
            // lbl_valor_base_erro
            // 
            this.lbl_valor_base_erro.AutoSize = true;
            this.lbl_valor_base_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_valor_base_erro.Location = new System.Drawing.Point(216, 149);
            this.lbl_valor_base_erro.Name = "lbl_valor_base_erro";
            this.lbl_valor_base_erro.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor_base_erro.TabIndex = 19;
            this.lbl_valor_base_erro.Text = "MSG";
            this.lbl_valor_base_erro.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 375);
            this.Controls.Add(this.lbl_valor_base_erro);
            this.Controls.Add(this.lbl_ano_erro);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmb_concelho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rad_nao);
            this.Controls.Add(this.rad_sim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chk_agravamento_12e);
            this.Controls.Add(this.chk_desconto_socio_5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_escalao10);
            this.Controls.Add(this.txt_valor_base);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(640, 38);
            this.Name = "Form1";
            this.Text = "Associação Cultural do Pântano";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_valor_base;
        private System.Windows.Forms.CheckBox chk_escalao10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_desconto_socio_5;
        private System.Windows.Forms.CheckBox chk_agravamento_12e;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rad_sim;
        private System.Windows.Forms.RadioButton rad_nao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_concelho;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl_ano_erro;
        private System.Windows.Forms.Label lbl_valor_base_erro;
    }
}

