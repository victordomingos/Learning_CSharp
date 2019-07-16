using System;
using System.Windows.Forms;
using System.Data;


namespace appRT
{
    public partial class Form1 : Form
    {

        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            // Preencher ComboBox
            MyGetData db = new MyGetData();
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;

        }
        public Form1()
        {
            InitializeComponent();

            string ssql;
            
            // Preencher ComboBoxes
            ssql = "SELECT * FROM T_clientes";
            InitComboBox(comboBox1_clientes, ssql, "nome_cliente", "id", "-- Mostrar Todos --");
            InitComboBox(cmb_novo_select_cliente, ssql, "nome_cliente", "id", "-- Selecionar Cliente --");

            ssql = "SELECT * FROM T_funcionarios";
            InitComboBox(comboBox2_funcionarios, ssql, "nome_funcionario", "id", "-- Mostrar Todos --");
            InitComboBox(cmb_novo_select_func, ssql, "nome_funcionario", "id", "-- Selecionar Funcionário --");

            // Preencher Gridview
            ssql = "SELECT Id as ID, cod_cliente as Cliente, cod_funcionario as Funcionário, data as Data, tempo as Tempo, descritivo as Descrição FROM T_registo_de_tempos";
            MyGetData db = new MyGetData();
            dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " intervenções";
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Btn_clientes_Click(object sender, EventArgs e)
        {
            Form3Clientes f3 = new Form3Clientes();
            //f3.BackColor = Color.Azure;
            f3.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2Funcionarios f3 = new Form2Funcionarios();
            //f3.BackColor = Color.Beige;
            f3.Show();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }
        private void ComboBox2_funcionarios_SelectedIndexChanged(object sender, EventArgs e) { Filtrar_lista(); }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_clientes";
            string texto = textBox1_clientes.Text.ToString();

            if (texto !="")
                ssql += " WHERE nome_cliente LIKE '%" + texto + "%'";

            try
            {
                InitComboBox(comboBox1_clientes, ssql, "nome_cliente", "id", "-- Mostrar Todos --");
            }
            catch
            {
                comboBox1_clientes.DataSource = null;
                comboBox1_clientes.ResetText();
                comboBox1_clientes.Items.Clear();
                comboBox1_clientes.SelectedItem = null;
                //comboBox1_clientes.SelectedText = "hI!";

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }


        private void TextBox2_funcionarios_TextChanged(object sender, EventArgs e)
        {
            string ssql = "SELECT * FROM T_funcionarios";
            string texto1 = textBox2_funcionarios.Text.ToString();
            //string texto2 = textBox1_clientes.Text.ToString();
            string filtro_funcionario = "";
            string filtro_cliente = "";

            if (texto1 != "")
                filtro_funcionario = " WHERE nome_funcionario LIKE '%" + texto1 + "%'";

            //if (texto2 != "")
            //    filtro_cliente = " AND nome_cliente LIKE '%" + texto2 + "%'";

            ssql += filtro_funcionario + filtro_cliente;
            //MessageBox.Show(ssql);

            try
            {
                InitComboBox(comboBox2_funcionarios, ssql, "nome_funcionario", "id", "-- Mostrar Todos --");
            }
            catch
            {
                comboBox2_funcionarios.DataSource = null;
                comboBox2_funcionarios.Items.Clear();
                comboBox2_funcionarios.ResetText();
            }
        }

        
        private void Filtrar_lista()
        {
            string ssql;
            string filtro_cliente = "";
            string filtro_funcionario = "";
            string operador = "";
            string filtro = "";
            bool has_filter = false;

            try
            {
                Int16 cod_cliente = Convert.ToInt16(comboBox1_clientes.SelectedValue.ToString());
                Int16 cod_funcionario = Convert.ToInt16(comboBox2_funcionarios.SelectedValue.ToString());

                if (cod_cliente !=  0)
                {
                    if (cod_cliente == -1)
                    {
                        has_filter = false;
                        filtro_cliente = "";
                    }
                    else
                    {
                        filtro_cliente = "cod_cliente='" + cod_cliente + "'";
                        has_filter = true;
                    }
                }


                if (cod_funcionario != 0)
                {
                    if (cod_funcionario == -1)
                    {
                        filtro_funcionario = "";
                    }
                    else
                    {
                        if (has_filter)
                            operador = " and ";

                        filtro_funcionario = "cod_funcionario='" + cod_funcionario + "'";
                        has_filter = true;
                    }
                }

                if (has_filter)
                {
                    filtro = " WHERE " + filtro_cliente + operador + filtro_funcionario;
                }


                ssql = "SELECT Id as ID, cod_cliente as Cliente, cod_funcionario as Funcionário, data as Data, tempo as Tempo, descritivo as Descrição FROM T_registo_de_tempos" + filtro;
                MessageBox.Show(ssql);

                MyGetData db = new MyGetData();
                dataGridView1.DataSource = db.BuscaDados(SConnection.SC, ssql);

                lbl_estado.Text = Convert.ToString(dataGridView1.Rows.Count) + " intervenções";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void Btn_novo_limpar_Click(object sender, EventArgs e)
        {
            string ssql;

            ssql = "SELECT * FROM T_clientes";
            InitComboBox(cmb_novo_select_cliente, ssql, "nome_cliente", "id", "-- Selecionar Cliente --");

            ssql = "SELECT * FROM T_funcionarios";
            InitComboBox(cmb_novo_select_func, ssql, "nome_funcionario", "id", "-- Selecionar Funcionário --");

            txt_novo_desc.Text = "";
            txt_novo_tempo.Text = "";
            dt_novo_data.Value = DateTime.Now;

        }
    }
}
