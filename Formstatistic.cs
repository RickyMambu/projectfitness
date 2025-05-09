﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfitness
{
    public partial class Formstatistic : Form
    {
        public Formstatistic()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formstatistic formRegister = new Formstatistic();
            formRegister.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formRegister = new Form1();
            formRegister.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formupdate formRegister = new Formupdate();
            formRegister.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormVerification2 formRegister = new FormVerification2();
            formRegister.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDashboard formRegister = new FormDashboard();
            formRegister.Show();
            this.Hide();
        }
    }
}
