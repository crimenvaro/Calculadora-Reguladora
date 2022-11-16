using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Calculadora c = new Frm_Calculadora();
            c.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Reguladora r = new Frm_Reguladora();
            r.Show();
        }
    }
}
