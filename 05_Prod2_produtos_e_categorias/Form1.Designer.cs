namespace _05_Prod2_produtos_e_categorias
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_ficheiro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ajuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmb_categorias = new System.Windows.Forms.ToolStripComboBox();
            this.btn_categorias = new System.Windows.Forms.ToolStripButton();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDestaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(0, 52);
            this.grid.Name = "grid";
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(624, 484);
            this.grid.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ficheiro,
            this.menu_ajuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_ficheiro
            // 
            this.menu_ficheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menu_ficheiro.Name = "menu_ficheiro";
            this.menu_ficheiro.Size = new System.Drawing.Size(61, 20);
            this.menu_ficheiro.Text = "Ficheiro";
            // 
            // menu_ajuda
            // 
            this.menu_ajuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDestaAplicaçãoToolStripMenuItem});
            this.menu_ajuda.Name = "menu_ajuda";
            this.menu_ajuda.Size = new System.Drawing.Size(50, 20);
            this.menu_ajuda.Text = "Ajuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_categorias,
            this.btn_categorias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmb_categorias
            // 
            this.cmb_categorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categorias.Name = "cmb_categorias";
            this.cmb_categorias.Size = new System.Drawing.Size(180, 25);
            this.cmb_categorias.SelectedIndexChanged += new System.EventHandler(this.Cmb_categorias_SelectedIndexChanged);
            this.cmb_categorias.Click += new System.EventHandler(this.Cmb_categorias_Click);
            // 
            // btn_categorias
            // 
            this.btn_categorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_categorias.Image = ((System.Drawing.Image)(resources.GetObject("btn_categorias.Image")));
            this.btn_categorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_categorias.Name = "btn_categorias";
            this.btn_categorias.Size = new System.Drawing.Size(47, 22);
            this.btn_categorias.Text = "Contar";
            this.btn_categorias.Click += new System.EventHandler(this.Btn_categorias_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(213, 17);
            this.lbl_status.Text = "A obter informação da base de dados...";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // acercaDestaAplicaçãoToolStripMenuItem
            // 
            this.acercaDestaAplicaçãoToolStripMenuItem.Name = "acercaDestaAplicaçãoToolStripMenuItem";
            this.acercaDestaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.acercaDestaAplicaçãoToolStripMenuItem.Text = "Acerca desta aplicação...";
            this.acercaDestaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.AcercaDestaAplicaçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grid);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestão de Produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmb_categorias;
        private System.Windows.Forms.ToolStripMenuItem menu_ficheiro;
        private System.Windows.Forms.ToolStripMenuItem menu_ajuda;
        private System.Windows.Forms.ToolStripButton btn_categorias;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDestaAplicaçãoToolStripMenuItem;
    }
}

