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
    public partial class Acerca : Form
    {
        public Acerca()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://no-title.victordomingos.com");
            this.Close();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Acerca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Acerca_KeyUp(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/akveo/eva-icons");
            this.Close();
        }
    }
}
