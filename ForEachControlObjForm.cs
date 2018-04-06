using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachControlObjToluA
{
    public partial class frmForEachControlObj : Form
    {
        public frmForEachControlObj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control Button in this. Controls)
            {
                Button.BackColor = Color.Crimson;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control Button in this.Controls)
            {
                Button.BackColor = Color.Gold;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            foreach (Control Label in this.Controls)
            {
                Label.BackColor = Color.Cyan;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control RadioButton in this.Controls)
            {
               RadioButton.BackColor = Color.Gainsboro;
            }
        }
    }
}
