﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Tab1
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        System.Media.SoundPlayer player1 = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();

            player.SoundLocation = "Introduction.wav";
            player1.SoundLocation = "Game.wav";
            player1.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
            Hide();
            player.Play();
        }
    }
}
