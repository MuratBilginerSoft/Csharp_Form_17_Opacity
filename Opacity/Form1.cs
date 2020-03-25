using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opacity
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        double x;
        int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Opacity = 0.3;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //y = r.Next(1, 4);
            //x = y / 10;

            
            if (this.Opacity<1.0)
            {
                this.Opacity = this.Opacity + 0.1;

               
            }

            else
            {
                this.Opacity = 0.0;
            }
        }
    }
}
