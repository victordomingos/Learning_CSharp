namespace appRT
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
            this.btn_clientes = new System.Windows.Forms.Button();
            this.btn_funcionarios = new System.Windows.Forms.Button();
            this.lbl_estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1_clientes = new System.Windows.Forms.ComboBox();
            this.textBox1_clientes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2_funcionarios = new System.Windows.Forms.ComboBox();
            this.textBox2_funcionarios = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_novo_tempo = new System.Windows.Forms.TextBox();
            this.dt_novo_data = new System.Windows.Forms.DateTimePicker();
            this.txt_novo_desc = new System.Windows.Forms.TextBox();
            this.cmb_novo_select_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_novo_select_func = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_novo_limpar = new System.Windows.Forms.Button();
            this.btn_novo_guardar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(12, 27);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_clientes.TabIndex = 2;
            this.btn_clientes.Text = "Clientes";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.Btn_clientes_Click);
            // 
            // btn_funcionarios
            // 
            this.btn_funcionarios.Location = new System.Drawing.Point(93, 27);
            this.btn_funcionarios.Name = "btn_funcionarios";
            this.btn_funcionarios.Size = new System.Drawing.Size(75, 23);
            this.btn_funcionarios.TabIndex = 3;
            this.btn_funcionarios.Text = "Funcionários";
            this.btn_funcionarios.UseVisualStyleBackColor = true;
            this.btn_funcionarios.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbl_estado
            // 
            this.lbl_estado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(42, 17);
            this.lbl_estado.Text = "estado";
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_estado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 419);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // comboBox1_clientes
            // 
            this.comboBox1_clientes.FormattingEnabled = true;
            this.comboBox1_clientes.Location = new System.Drawing.Point(6, 45);
            this.comboBox1_clientes.Name = "comboBox1_clientes";
            this.comboBox1_clientes.Size = new System.Drawing.Size(160, 21);
            this.comboBox1_clientes.TabIndex = 6;
            this.comboBox1_clientes.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox1_clientes
            // 
            this.textBox1_clientes.Location = new System.Drawing.Point(6, 19);
            this.textBox1_clientes.Name = "textBox1_clientes";
            this.textBox1_clientes.Size = new System.Drawing.Size(160, 20);
            this.textBox1_clientes.TabIndex = 7;
            this.textBox1_clientes.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_clientes);
            this.groupBox1.Controls.Add(this.comboBox1_clientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2_funcionarios);
            this.groupBox2.Controls.Add(this.textBox2_funcionarios);
            this.groupBox2.Location = new System.Drawing.Point(190, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por funcionário";
            // 
            // comboBox2_funcionarios
            // 
            this.comboBox2_funcionarios.FormattingEnabled = true;
            this.comboBox2_funcionarios.Location = new System.Drawing.Point(6, 45);
            this.comboBox2_funcionarios.Name = "comboBox2_funcionarios";
            this.comboBox2_funcionarios.Size = new System.Drawing.Size(160, 21);
            this.comboBox2_funcionarios.TabIndex = 1;
            this.comboBox2_funcionarios.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_funcionarios_SelectedIndexChanged);
            // 
            // textBox2_funcionarios
            // 
            this.textBox2_funcionarios.Location = new System.Drawing.Point(6, 19);
            this.textBox2_funcionarios.Name = "textBox2_funcionarios";
            this.textBox2_funcionarios.Size = new System.Drawing.Size(160, 20);
            this.textBox2_funcionarios.TabIndex = 0;
            this.textBox2_funcionarios.TextChanged += new System.EventHandler(this.TextBox2_funcionarios_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.janelaToolStripMenuItem,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Ficheiro";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(49, 20);
            this.toolStripMenuItem2.Text = "Filtrar";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.janelaToolStripMenuItem.Text = "Visualização";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem3.Text = "Ajuda";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btn_novo_guardar);
            this.groupBox3.Controls.Add(this.btn_novo_limpar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmb_novo_select_func);
            this.groupBox3.Controls.Add(this.cmb_novo_select_cliente);
            this.groupBox3.Controls.Add(this.txt_novo_desc);
            this.groupBox3.Controls.Add(this.txt_novo_tempo);
            this.groupBox3.Controls.Add(this.dt_novo_data);
            this.groupBox3.Location = new System.Drawing.Point(12, 580);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 124);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo registo";
            // 
            // txt_novo_tempo
            // 
            this.txt_novo_tempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_novo_tempo.Location = new System.Drawing.Point(501, 56);
            this.txt_novo_tempo.Name = "txt_novo_tempo";
            this.txt_novo_tempo.Size = new System.Drawing.Size(121, 20);
            this.txt_novo_tempo.TabIndex = 0;
            // 
            // dt_novo_data
            // 
            this.dt_novo_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_novo_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_novo_data.Location = new System.Drawing.Point(501, 29);
            this.dt_novo_data.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dt_novo_data.Name = "dt_novo_data";
            this.dt_novo_data.Size = new System.Drawing.Size(121, 20);
            this.dt_novo_data.TabIndex = 1;
            this.dt_novo_data.Value = new System.DateTime(2019, 7, 16, 10, 5, 39, 0);
            // 
            // txt_novo_desc
            // 
            this.txt_novo_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_novo_desc.Location = new System.Drawing.Point(81, 82);
            this.txt_novo_desc.Name = "txt_novo_desc";
            this.txt_novo_desc.Size = new System.Drawing.Size(541, 20);
            this.txt_novo_desc.TabIndex = 2;
            // 
            // cmb_novo_select_cliente
            // 
            this.cmb_novo_select_cliente.FormattingEnabled = true;
            this.cmb_novo_select_cliente.Location = new System.Drawing.Point(81, 28);
            this.cmb_novo_select_cliente.Name = "cmb_novo_select_cliente";
            this.cmb_novo_select_cliente.Size = new System.Drawing.Size(269, 21);
            this.cmb_novo_select_cliente.TabIndex = 3;
            // 
            // cmb_novo_select_func
            // 
            this.cmb_novo_select_func.FormattingEnabled = true;
            this.cmb_novo_select_func.Location = new System.Drawing.Point(81, 55);
            this.cmb_novo_select_func.Name = "cmb_novo_select_func";
            this.cmb_novo_select_func.Size = new System.Drawing.Size(269, 21);
            this.cmb_novo_select_func.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Funcionário:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tempo (minutos):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descrição:";
            // 
            // btn_novo_limpar
            // 
            this.btn_novo_limpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo_limpar.Location = new System.Drawing.Point(642, 51);
            this.btn_novo_limpar.Name = "btn_novo_limpar";
            this.btn_novo_limpar.Size = new System.Drawing.Size(89, 23);
            this.btn_novo_limpar.TabIndex = 10;
            this.btn_novo_limpar.Text = "Limpar";
            this.btn_novo_limpar.UseVisualStyleBackColor = true;
            this.btn_novo_limpar.Click += new System.EventHandler(this.Btn_novo_limpar_Click);
            // 
            // btn_novo_guardar
            // 
            this.btn_novo_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_novo_guardar.Location = new System.Drawing.Point(642, 80);
            this.btn_novo_guardar.Name = "btn_novo_guardar";
            this.btn_novo_guardar.Size = new System.Drawing.Size(89, 23);
            this.btn_novo_guardar.TabIndex = 11;
            this.btn_novo_guardar.Text = "Guardar";
            this.btn_novo_guardar.UseVisualStyleBackColor = true;
            this.btn_novo_guardar.Click += new System.EventHandler(this.Btn_novo_guardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_funcionarios);
            this.Controls.Add(this.btn_clientes);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project Kronos App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clientes;
        private System.Windows.Forms.Button btn_funcionarios;
        private System.Windows.Forms.ToolStripStatusLabel lbl_estado;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1_clientes;
        private System.Windows.Forms.TextBox textBox1_clientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox2_funcionarios;
        private System.Windows.Forms.TextBox textBox2_funcionarios;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_novo_select_func;
        private System.Windows.Forms.ComboBox cmb_novo_select_cliente;
        private System.Windows.Forms.TextBox txt_novo_desc;
        private System.Windows.Forms.TextBox txt_novo_tempo;
        private System.Windows.Forms.DateTimePicker dt_novo_data;
        private System.Windows.Forms.Button btn_novo_guardar;
        private System.Windows.Forms.Button btn_novo_limpar;
    }
}

