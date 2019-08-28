using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appRT
{
    public partial class Form4AlteraTempos : Form
    {

        public void InitComboBox(ComboBox cmbx, string ssql, string displayM, string valueM, string defaultText)
        {
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            DataRow row = dt.NewRow();
            row[valueM] = -1;
            row[displayM] = defaultText;
            dt.Rows.InsertAt(row, 0);
            cmbx.DataSource = dt;
            cmbx.DisplayMember = displayM;
            cmbx.ValueMember = valueM;
        }

        public void InitListBox(ListBox listb, string ssql, string displayM, string valueM)
        {
            DataTable dt = db.BuscaDados(SConnection.SC, ssql);
            listb.DataSource = dt;
            listb.DisplayMember = displayM;
            listb.ValueMember = valueM;
        }

    }
}