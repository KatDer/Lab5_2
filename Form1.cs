using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int tmp2 = Int32.Parse(txtMinutes.Text);
            tmp += 1;
            txtSeconds.Text = tmp.ToString();
            

            if (tmp == 60)
               
            {
                tmp2 += 1;
                txtMinutes.Text = tmp2.ToString();
                txtSeconds.Text = 0.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = true;
            textBox1.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Stop();
            txtMinutes.Text = "0";
            txtSeconds.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
