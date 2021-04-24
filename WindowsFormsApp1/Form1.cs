using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();

        public Form1(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void iniciarbtn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }
    }
}
