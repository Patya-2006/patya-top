﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "topaDataSet.Фильтр_ПИ". При необходимости она может быть перемещена или удалена.
            this.фильтр_ПИTableAdapter.Fill(this.topaDataSet.Фильтр_ПИ);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             private
         }


        }
    }
}