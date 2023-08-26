using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Заболевания
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pol F2;
        Form7 F7;
        private void button1_Click(object sender, EventArgs e)
        {
            F2 = new Pol();
            F2.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F7 = new Form7();
            F7.ShowDialog(this);
        }
    }
}
