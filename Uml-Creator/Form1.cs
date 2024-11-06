using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uml_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Hide();
        }

        private void buttonHide1_Click(object sender, EventArgs e)
        {
            buttonHide1.Hide();
        }


        private void taha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THIS IS MTB !!!");
            this.Close();

        private void buttonloubna_Click(object sender, EventArgs e)
        {
            buttonloubna.Hide();

        }
    }
}
