using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аптечная_сетьDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптечная_сетьDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var Form1 = new Form1();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись учтена!");
        }
    }
}
