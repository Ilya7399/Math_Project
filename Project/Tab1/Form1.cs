using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tab1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();

            player.SoundLocation = "Introduction.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Width = 350;
            button1.Height = 80;
            int X = (this.Width / 2) - (button1.Width / 2);
            int Y = (this.Height / 2) - (button1.Height / 2);
            button1.Location = new Point(X, Y);
            player.Play();
        }
    }
}
