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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void счет_фактурыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.счет_фактурыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аптечная_сетьDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аптечная_сетьDataSet._Счет_фактуры". При необходимости она может быть перемещена или удалена.
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            var Form1 = new Form1();
            Form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Запись учтена!");
        }
    }
}
