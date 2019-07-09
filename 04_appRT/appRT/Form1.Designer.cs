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
            this.textBox2_funcionarios = new System.Windows.Forms.TextBox();
            this.comboBox2_funcionarios = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clientes
            // 
            this.btn_clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btn_funcionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(42, 17);
            this.lbl_estado.Text = "estado";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_estado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 430);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
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
            this.dataGridView1.Size = new System.Drawing.Size(610, 286);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // comboBox1_clientes
            // 
            this.comboBox1_clientes.FormattingEnabled = true;
            this.comboBox1_clientes.Location = new System.Drawing.Point(6, 45);
            this.comboBox1_clientes.Name = "comboBox1_clientes";
            this.comboBox1_clientes.Size = new System.Drawing.Size(183, 21);
            this.comboBox1_clientes.TabIndex = 6;
            this.comboBox1_clientes.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox1_clientes
            // 
            this.textBox1_clientes.Location = new System.Drawing.Point(6, 19);
            this.textBox1_clientes.Name = "textBox1_clientes";
            this.textBox1_clientes.Size = new System.Drawing.Size(183, 20);
            this.textBox1_clientes.TabIndex = 7;
            this.textBox1_clientes.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1_clientes);
            this.groupBox1.Controls.Add(this.comboBox1_clientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2_funcionarios);
            this.groupBox2.Controls.Add(this.textBox2_funcionarios);
            this.groupBox2.Location = new System.Drawing.Point(213, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 79);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por funcionário";
            // 
            // textBox2_funcionarios
            // 
            this.textBox2_funcionarios.Location = new System.Drawing.Point(6, 19);
            this.textBox2_funcionarios.Name = "textBox2_funcionarios";
            this.textBox2_funcionarios.Size = new System.Drawing.Size(183, 20);
            this.textBox2_funcionarios.TabIndex = 0;
            // 
            // comboBox2_funcionarios
            // 
            this.comboBox2_funcionarios.FormattingEnabled = true;
            this.comboBox2_funcionarios.Location = new System.Drawing.Point(6, 45);
            this.comboBox2_funcionarios.Name = "comboBox2_funcionarios";
            this.comboBox2_funcionarios.Size = new System.Drawing.Size(183, 21);
            this.comboBox2_funcionarios.TabIndex = 1;
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
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem3.Text = "Ajuda";
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.janelaToolStripMenuItem.Text = "Visualização";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_funcionarios);
            this.Controls.Add(this.btn_clientes);
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
    }
}

