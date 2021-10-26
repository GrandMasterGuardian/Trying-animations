using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1OK_Click(object sender, EventArgs e)
        {
            Animation_1_panel_1();
            panel2.Visible = true;
            Animation_1_panel_2();
        }
        async void Animation_1_panel_1()
        {
            while(panel1.Location.X > 177)
            {
                await Task.Delay(1);
                panel1.Location = new Point(panel1.Location.X - 1, panel1.Location.Y);
            }
        }
        async void Animation_1_panel_2()
        {
            while(panel2.Location.X > 187)
            {
                await Task.Delay(1);
                panel2.Location = new Point(panel2.Location.X - panel2.Location.X/50, panel2.Location.Y);
            }
        }
        async void Animation_2_panel_1()
        {
            while (panel1.Location.X < 187)
            {
                await Task.Delay(1);
                panel1.Location = new Point(panel1.Location.X + 1, panel1.Location.Y);
            }
        }
        async void Animation_2_panel_2()
        {
            int i = 537;
            while (panel2.Location.X < 536)
            {
                await Task.Delay(130);
                panel2.Location = new Point(panel2.Location.X + (i - panel2.Location.X)/2, panel2.Location.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanLocation.Text = panel1.Location.X.ToString() + "\n" + panel2.Location.X.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2Back_Click(object sender, EventArgs e)
        {
            Animation_2_panel_1();
            Animation_2_panel_2();
        }
    }
}
