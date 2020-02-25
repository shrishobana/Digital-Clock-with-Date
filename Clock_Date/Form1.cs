using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Date
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.ToString("HH:MM:ss");
            lbdate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbday.Text = DateTime.Now.ToString("dddd");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbtime_Click(object sender, EventArgs e)
        {

        }
    }
}
