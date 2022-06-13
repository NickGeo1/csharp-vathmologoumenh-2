using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atomiki_ergasia_2
{
    public partial class Form2 : Form
    {
        public Form2(int v) //Constractor that sets the numericUpDown1 value equal to v(p width)
        {
            InitializeComponent();
            numericUpDown1.Value = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms[1]).Setpwidth((int)numericUpDown1.Value);  //on button click, execute SetpWidth function of form1 with parameter the numericUpDown1 value     
            this.Close(); //close this form
        }

    }
}
