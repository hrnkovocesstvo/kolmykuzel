using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolmykuzel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPocitej_Click(object sender, EventArgs e)
        {
            kolmykuzel k = new kolmykuzel((double)numericUpDownPol1.Value, (double)numericUpDownPol2.Value, (double)numericUpDownVys.Value, textBoxJ.Text);
            textBox2.Text = $"oběm: {k.obem()} {k.getjednotka()}³{Environment.NewLine} povrch: {k.povrch()} {k.getjednotka()}² ";
        }
    }
}
