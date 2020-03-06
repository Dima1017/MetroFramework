using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;

namespace MetroFramework
{
    public partial class Вычитание : MetroFramework.Forms.MetroForm
    {
        public Вычитание()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MetroStyleManager metroStyleManager1 = null;
            this.StyleManager = metroStyleManager1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                int a, b;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                textBox1.Text = "";
                textBox2.Text = "";
                a = a - b;
                label1.Text = Convert.ToString(a);
            
        }
    }
}
