﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_classes_Click(object sender, EventArgs e)
        {
            var FormStudents=new FormStudents();
            FormStudents.Show();
        }

        private void button_teachers_Click(object sender, EventArgs e)
        {
            var Formteacher = new Formteacher();
            Formteacher.Show();
        }
    }
}
