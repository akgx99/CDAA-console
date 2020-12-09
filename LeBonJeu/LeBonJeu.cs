using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBonJeu
{
    public partial class LeBonJeu : Form
    {
        public LeBonJeu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1diag = new Form1();
            form1diag.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2diag = new Form2();
            form2diag.ShowDialog();
        }
    }
}
