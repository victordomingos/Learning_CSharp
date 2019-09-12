namespace OsMeusQueridosPostais
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
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cmb_oferecedor = new System.Windows.Forms.ComboBox();
            this.cmb_recetor = new System.Windows.Forms.ComboBox();
            this.date_start = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabGerirContactos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid_postais = new System.Windows.Forms.DataGridView();
            this.btn_atualizar_postais = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid_tipos_postal = new System.Windows.Forms.DataGridView();
            this.btn_atualizar_tipos = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rad_tudo = new System.Windows.Forms.RadioButton();
            this.rad_recetores = new System.Windows.Forms.RadioButton();
            this.rad_oferecedores = new System.Windows.Forms.RadioButton();
            this.btn_cancelarPesquisaContactos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pesquisa_contactos = new System.Windows.Forms.TextBox();
            this.grid_contactos = new System.Windows.Forms.DataGridView();
            this.btn_atualizar_contactos = new System.Windows.Forms.Button();
            this.groupNovaOferta = new System.Windows.Forms.GroupBox();
            this.btn_novaOfertaCancelar = new System.Windows.Forms.Button();
            this.btn_novaOferta_guardar = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cmb_novaOferta_postal = new System.Windows.Forms.ComboBox();
            this.cmb_novaOferta_oferecedor = new System.Windows.Forms.ComboBox();
            this.cmb_novaOferta_recetor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabGerirContactos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_postais)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipos_postal)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contactos)).BeginInit();
            this.groupNovaOferta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(0, 84);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(796, 229);
            this.grid1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cmb_oferecedor
            // 
            this.cmb_oferecedor.FormattingEnabled = true;
            this.cmb_oferecedor.Location = new System.Drawing.Point(12, 31);
            this.cmb_oferecedor.Name = "cmb_oferecedor";
            this.cmb_oferecedor.Size = new System.Drawing.Size(166, 21);
            this.cmb_oferecedor.TabIndex = 2;
            this.cmb_oferecedor.SelectedIndexChanged += new System.EventHandler(this.Cmb_oferecedor_SelectedIndexChanged);
            // 
            // cmb_recetor
            // 
            this.cmb_recetor.FormattingEnabled = true;
            this.cmb_recetor.Location = new System.Drawing.Point(184, 31);
            this.cmb_recetor.Name = "cmb_recetor";
            this.cmb_recetor.Size = new System.Drawing.Size(166, 21);
            this.cmb_recetor.TabIndex = 3;
            this.cmb_recetor.SelectedIndexChanged += new System.EventHandler(this.Cmb_recetor_SelectedIndexChanged);
            // 
            // date_start
            // 
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_start.Location = new System.Drawing.Point(370, 31);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(162, 20);
            this.date_start.TabIndex = 4;
            this.date_start.Value = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.date_start.ValueChanged += new System.EventHandler(this.Date_start_ValueChanged);
            // 
            // date_end
            // 
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_end.Location = new System.Drawing.Point(545, 32);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(169, 20);
            this.date_end.TabIndex = 5;
            this.date_end.Value = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.date_end.ValueChanged += new System.EventHandler(this.Date_end_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabGerirContactos);
            this.panel1.Controls.Add(this.groupNovaOferta);
            this.panel1.Location = new System.Drawing.Point(0, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 255);
            this.panel1.TabIndex = 6;
            // 
            // tabGerirContactos
            // 
            this.tabGerirContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGerirContactos.Controls.Add(this.tabPage1);
            this.tabGerirContactos.Controls.Add(this.tabPage2);
            this.tabGerirContactos.Controls.Add(this.tabPage4);
            this.tabGerirContactos.Location = new System.Drawing.Point(489, 18);
            this.tabGerirContactos.Name = "tabGerirContactos";
            this.tabGerirContactos.SelectedIndex = 0;
            this.tabGerirContactos.Size = new System.Drawing.Size(307, 224);
            this.tabGerirContactos.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGerirContactos.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_postais);
            this.tabPage1.Controls.Add(this.btn_atualizar_postais);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(299, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Postais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_postais
            // 
            this.grid_postais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_postais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_postais.Location = new System.Drawing.Point(3, 3);
            this.grid_postais.Name = "grid_postais";
            this.grid_postais.Size = new System.Drawing.Size(292, 159);
            this.grid_postais.TabIndex = 1;
            // 
            // btn_atualizar_postais
            // 
            this.btn_atualizar_postais.Location = new System.Drawing.Point(172, 168);
            this.btn_atualizar_postais.Name = "btn_atualizar_postais";
            this.btn_atualizar_postais.Size = new System.Drawing.Size(124, 27);
            this.btn_atualizar_postais.TabIndex = 0;
            this.btn_atualizar_postais.Text = "Atualizar postais";
            this.btn_atualizar_postais.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grid_tipos_postal);
            this.tabPage2.Controls.Add(this.btn_atualizar_tipos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(299, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tipos de postal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grid_tipos_postal
            // 
            this.grid_tipos_postal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_tipos_postal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tipos_postal.Location = new System.Drawing.Point(3, 3);
            this.grid_tipos_postal.Name = "grid_tipos_postal";
            this.grid_tipos_postal.Size = new System.Drawing.Size(292, 159);
            this.grid_tipos_postal.TabIndex = 2;
            // 
            // btn_atualizar_tipos
            // 
            this.btn_atualizar_tipos.Location = new System.Drawing.Point(173, 168);
            this.btn_atualizar_tipos.Name = "btn_atualizar_tipos";
            this.btn_atualizar_tipos.Size = new System.Drawing.Size(122, 27);
            this.btn_atualizar_tipos.TabIndex = 1;
            this.btn_atualizar_tipos.Text = "Atualizar tipos";
            this.btn_atualizar_tipos.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rad_tudo);
            this.tabPage4.Controls.Add(this.rad_recetores);
            this.tabPage4.Controls.Add(this.rad_oferecedores);
            this.tabPage4.Controls.Add(this.btn_cancelarPesquisaContactos);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.txt_pesquisa_contactos);
            this.tabPage4.Controls.Add(this.grid_contactos);
            this.tabPage4.Controls.Add(this.btn_atualizar_contactos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(299, 198);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Contactos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rad_tudo
            // 
            this.rad_tudo.AutoSize = true;
            this.rad_tudo.Checked = true;
            this.rad_tudo.Location = new System.Drawing.Point(6, 35);
            this.rad_tudo.Name = "rad_tudo";
            this.rad_tudo.Size = new System.Drawing.Size(50, 17);
            this.rad_tudo.TabIndex = 8;
            this.rad_tudo.TabStop = true;
            this.rad_tudo.Text = "Tudo";
            this.rad_tudo.UseVisualStyleBackColor = true;
            this.rad_tudo.CheckedChanged += new System.EventHandler(this.Rad_tudo_CheckedChanged);
            // 
            // rad_recetores
            // 
            this.rad_recetores.AutoSize = true;
            this.rad_recetores.Location = new System.Drawing.Point(157, 35);
            this.rad_recetores.Name = "rad_recetores";
            this.rad_recetores.Size = new System.Drawing.Size(74, 17);
            this.rad_recetores.TabIndex = 7;
            this.rad_recetores.TabStop = true;
            this.rad_recetores.Text = "Recetores";
            this.rad_recetores.UseVisualStyleBackColor = true;
            this.rad_recetores.CheckedChanged += new System.EventHandler(this.Rad_recetores_CheckedChanged);
            // 
            // rad_oferecedores
            // 
            this.rad_oferecedores.AutoSize = true;
            this.rad_oferecedores.Location = new System.Drawing.Point(62, 35);
            this.rad_oferecedores.Name = "rad_oferecedores";
            this.rad_oferecedores.Size = new System.Drawing.Size(89, 17);
            this.rad_oferecedores.TabIndex = 6;
            this.rad_oferecedores.TabStop = true;
            this.rad_oferecedores.Text = "Oferecedores";
            this.rad_oferecedores.UseVisualStyleBackColor = true;
            this.rad_oferecedores.CheckedChanged += new System.EventHandler(this.Rad_oferecedores_CheckedChanged);
            // 
            // btn_cancelarPesquisaContactos
            // 
            this.btn_cancelarPesquisaContactos.Location = new System.Drawing.Point(191, 7);
            this.btn_cancelarPesquisaContactos.Name = "btn_cancelarPesquisaContactos";
            this.btn_cancelarPesquisaContactos.Size = new System.Drawing.Size(102, 23);
            this.btn_cancelarPesquisaContactos.TabIndex = 5;
            this.btn_cancelarPesquisaContactos.Text = "Cancelar pesquisa";
            this.btn_cancelarPesquisaContactos.UseVisualStyleBackColor = true;
            this.btn_cancelarPesquisaContactos.Click += new System.EventHandler(this.BtnCancelarPesquisa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pesquisar:";
            // 
            // txt_pesquisa_contactos
            // 
            this.txt_pesquisa_contactos.Location = new System.Drawing.Point(68, 9);
            this.txt_pesquisa_contactos.Name = "txt_pesquisa_contactos";
            this.txt_pesquisa_contactos.Size = new System.Drawing.Size(117, 20);
            this.txt_pesquisa_contactos.TabIndex = 3;
            this.txt_pesquisa_contactos.TextChanged += new System.EventHandler(this.Txt_pesquisa_contactos_TextChanged);
            // 
            // grid_contactos
            // 
            this.grid_contactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_contactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_contactos.Location = new System.Drawing.Point(3, 53);
            this.grid_contactos.Name = "grid_contactos";
            this.grid_contactos.Size = new System.Drawing.Size(292, 109);
            this.grid_contactos.TabIndex = 2;
            // 
            // btn_atualizar_contactos
            // 
            this.btn_atualizar_contactos.Location = new System.Drawing.Point(173, 168);
            this.btn_atualizar_contactos.Name = "btn_atualizar_contactos";
            this.btn_atualizar_contactos.Size = new System.Drawing.Size(122, 27);
            this.btn_atualizar_contactos.TabIndex = 1;
            this.btn_atualizar_contactos.Text = "Atualizar contactos";
            this.btn_atualizar_contactos.UseVisualStyleBackColor = true;
            // 
            // groupNovaOferta
            // 
            this.groupNovaOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupNovaOferta.AutoSize = true;
            this.groupNovaOferta.Controls.Add(this.btn_novaOfertaCancelar);
            this.groupNovaOferta.Controls.Add(this.btn_novaOferta_guardar);
            this.groupNovaOferta.Controls.Add(this.monthCalendar1);
            this.groupNovaOferta.Controls.Add(this.cmb_novaOferta_postal);
            this.groupNovaOferta.Controls.Add(this.cmb_novaOferta_oferecedor);
            this.groupNovaOferta.Controls.Add(this.cmb_novaOferta_recetor);
            this.groupNovaOferta.Location = new System.Drawing.Point(12, 20);
            this.groupNovaOferta.Name = "groupNovaOferta";
            this.groupNovaOferta.Size = new System.Drawing.Size(461, 222);
            this.groupNovaOferta.TabIndex = 4;
            this.groupNovaOferta.TabStop = false;
            this.groupNovaOferta.Text = "Registar ou alterar oferta";
            // 
            // btn_novaOfertaCancelar
            // 
            this.btn_novaOfertaCancelar.Location = new System.Drawing.Point(252, 171);
            this.btn_novaOfertaCancelar.Name = "btn_novaOfertaCancelar";
            this.btn_novaOfertaCancelar.Size = new System.Drawing.Size(88, 26);
            this.btn_novaOfertaCancelar.TabIndex = 5;
            this.btn_novaOfertaCancelar.Text = "Cancelar";
            this.btn_novaOfertaCancelar.UseVisualStyleBackColor = true;
            this.btn_novaOfertaCancelar.Click += new System.EventHandler(this.Btn_novaOfertaCancelar_Click);
            // 
            // btn_novaOferta_guardar
            // 
            this.btn_novaOferta_guardar.Location = new System.Drawing.Point(358, 171);
            this.btn_novaOferta_guardar.Name = "btn_novaOferta_guardar";
            this.btn_novaOferta_guardar.Size = new System.Drawing.Size(86, 26);
            this.btn_novaOferta_guardar.TabIndex = 4;
            this.btn_novaOferta_guardar.Text = "Guardar oferta";
            this.btn_novaOferta_guardar.UseVisualStyleBackColor = true;
            this.btn_novaOferta_guardar.Click += new System.EventHandler(this.Btn_novaOferta_guardar_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(12, 35);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // cmb_novaOferta_postal
            // 
            this.cmb_novaOferta_postal.FormattingEnabled = true;
            this.cmb_novaOferta_postal.Location = new System.Drawing.Point(251, 111);
            this.cmb_novaOferta_postal.Name = "cmb_novaOferta_postal";
            this.cmb_novaOferta_postal.Size = new System.Drawing.Size(193, 21);
            this.cmb_novaOferta_postal.TabIndex = 3;
            // 
            // cmb_novaOferta_oferecedor
            // 
            this.cmb_novaOferta_oferecedor.FormattingEnabled = true;
            this.cmb_novaOferta_oferecedor.Location = new System.Drawing.Point(252, 35);
            this.cmb_novaOferta_oferecedor.Name = "cmb_novaOferta_oferecedor";
            this.cmb_novaOferta_oferecedor.Size = new System.Drawing.Size(193, 21);
            this.cmb_novaOferta_oferecedor.TabIndex = 0;
            // 
            // cmb_novaOferta_recetor
            // 
            this.cmb_novaOferta_recetor.FormattingEnabled = true;
            this.cmb_novaOferta_recetor.Location = new System.Drawing.Point(251, 73);
            this.cmb_novaOferta_recetor.Name = "cmb_novaOferta_recetor";
            this.cmb_novaOferta_recetor.Size = new System.Drawing.Size(193, 21);
            this.cmb_novaOferta_recetor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pessoa que ofereceu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pessoa que recebeu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de início:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data de fim:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Btn_eliminarOferta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.cmb_recetor);
            this.Controls.Add(this.cmb_oferecedor);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grid1);
            this.Name = "Form1";
            this.Text = "Os Meus Queridos Postais!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabGerirContactos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_postais)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tipos_postal)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_contactos)).EndInit();
            this.groupNovaOferta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cmb_oferecedor;
        private System.Windows.Forms.ComboBox cmb_recetor;
        private System.Windows.Forms.DateTimePicker date_start;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_novaOferta_postal;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmb_novaOferta_recetor;
        private System.Windows.Forms.ComboBox cmb_novaOferta_oferecedor;
        private System.Windows.Forms.GroupBox groupNovaOferta;
        private System.Windows.Forms.Button btn_novaOferta_guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_novaOfertaCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabGerirContactos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView grid_postais;
        private System.Windows.Forms.Button btn_atualizar_postais;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView grid_tipos_postal;
        private System.Windows.Forms.Button btn_atualizar_tipos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView grid_contactos;
        private System.Windows.Forms.Button btn_atualizar_contactos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pesquisa_contactos;
        private System.Windows.Forms.RadioButton rad_tudo;
        private System.Windows.Forms.RadioButton rad_recetores;
        private System.Windows.Forms.RadioButton rad_oferecedores;
        private System.Windows.Forms.Button btn_cancelarPesquisaContactos;
    }
}

