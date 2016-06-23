using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Boolean a1,a2;
        public Form1()
        {
            InitializeComponent();
            a1 = true;
            a2 = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1,n2;
            if (Double.TryParse(num1.Text, out n1)&& Double.TryParse(num2.Text, out n2))
                answer.Text = (n1+n2).ToString();
            else
                answer.Text = "Invalid Number";
        }

        private void num2_Enter(object sender, EventArgs e)
        {
            if (a2)
            {
                num2.Text = "";
                a2 = false;
            }
        }

        private void num1_Enter(object sender, EventArgs e)
        {
            if (a1)
            {
                num1.Text = "";
                a1 = false;
            }
        }
    }
}
