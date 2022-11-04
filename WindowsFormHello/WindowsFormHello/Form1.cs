using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormHello
{
    public partial class Form1 : Form
    {
        public object Label1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
        }

        private void BTNHello_Click(object sender, EventArgs e)
        {
            label1.Visible =  true;
            if (label1.Text == "")
            {
                label1.Text = "Hello Word!";  
                pictureBox1.Visible = true;
            }
            else
            {
                label1.Text = "";
                pictureBox1.Visible = false;
            }
          
        }
    }
}

