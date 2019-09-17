namespace Associados
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_registo_associado = new System.Windows.Forms.Panel();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.cmb_atividade = new System.Windows.Forms.ComboBox();
            this.rad_m = new System.Windows.Forms.RadioButton();
            this.rad_f = new System.Windows.Forms.RadioButton();
            this.chk_quota = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_registar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_registo_associado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(946, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Ficheiro";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 22);
            this.toolStripButton1.Text = "Limpar Grid";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton2.Text = "Atividades";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(86, 22);
            this.toolStripButton3.Text = "Associados";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(510, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 437);
            this.panel1.TabIndex = 3;
            // 
            // panel_registo_associado
            // 
            this.panel_registo_associado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_registo_associado.AutoSize = true;
            this.panel_registo_associado.BackColor = System.Drawing.SystemColors.Control;
            this.panel_registo_associado.Controls.Add(this.btn_registar);
            this.panel_registo_associado.Controls.Add(this.btn_limpar);
            this.panel_registo_associado.Controls.Add(this.label5);
            this.panel_registo_associado.Controls.Add(this.label4);
            this.panel_registo_associado.Controls.Add(this.label3);
            this.panel_registo_associado.Controls.Add(this.label2);
            this.panel_registo_associado.Controls.Add(this.chk_quota);
            this.panel_registo_associado.Controls.Add(this.rad_f);
            this.panel_registo_associado.Controls.Add(this.rad_m);
            this.panel_registo_associado.Controls.Add(this.cmb_atividade);
            this.panel_registo_associado.Controls.Add(this.txt_ano);
            this.panel_registo_associado.Controls.Add(this.txt_nome);
            this.panel_registo_associado.Controls.Add(this.label1);
            this.panel_registo_associado.Location = new System.Drawing.Point(0, 319);
            this.panel_registo_associado.Name = "panel_registo_associado";
            this.panel_registo_associado.Size = new System.Drawing.Size(504, 170);
            this.panel_registo_associado.TabIndex = 4;
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(0, 52);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(504, 261);
            this.grid1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registar associado";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(10, 58);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(293, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(310, 58);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 2;
            // 
            // cmb_atividade
            // 
            this.cmb_atividade.FormattingEnabled = true;
            this.cmb_atividade.Location = new System.Drawing.Point(10, 105);
            this.cmb_atividade.Name = "cmb_atividade";
            this.cmb_atividade.Size = new System.Drawing.Size(168, 21);
            this.cmb_atividade.TabIndex = 3;
            // 
            // rad_m
            // 
            this.rad_m.AutoSize = true;
            this.rad_m.Checked = true;
            this.rad_m.Location = new System.Drawing.Point(419, 59);
            this.rad_m.Name = "rad_m";
            this.rad_m.Size = new System.Drawing.Size(34, 17);
            this.rad_m.TabIndex = 4;
            this.rad_m.TabStop = true;
            this.rad_m.Text = "M";
            this.rad_m.UseVisualStyleBackColor = true;
            // 
            // rad_f
            // 
            this.rad_f.AutoSize = true;
            this.rad_f.Location = new System.Drawing.Point(459, 59);
            this.rad_f.Name = "rad_f";
            this.rad_f.Size = new System.Drawing.Size(31, 17);
            this.rad_f.TabIndex = 5;
            this.rad_f.TabStop = true;
            this.rad_f.Text = "F";
            this.rad_f.UseVisualStyleBackColor = true;
            // 
            // chk_quota
            // 
            this.chk_quota.AutoSize = true;
            this.chk_quota.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_quota.Location = new System.Drawing.Point(184, 107);
            this.chk_quota.Name = "chk_quota";
            this.chk_quota.Size = new System.Drawing.Size(119, 17);
            this.chk_quota.TabIndex = 6;
            this.chk_quota.Text = "Tem a quota paga?";
            this.chk_quota.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ano de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Atividade:";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(335, 134);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 11;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_registar
            // 
            this.btn_registar.Location = new System.Drawing.Point(416, 134);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(75, 23);
            this.btn_registar.TabIndex = 12;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 514);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.panel_registo_associado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The NPK Assotiation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_registo_associado.ResumeLayout(false);
            this.panel_registo_associado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_registo_associado;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_quota;
        private System.Windows.Forms.RadioButton rad_f;
        private System.Windows.Forms.RadioButton rad_m;
        private System.Windows.Forms.ComboBox cmb_atividade;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.Button btn_limpar;
    }
}

