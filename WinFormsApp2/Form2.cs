using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OneDimentionalArray;


namespace Pract
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double[] novemberTemperatures = {-5, -8, -12, -15, -7, -9, -10, -11, -13, -6};
            NovemberTemperatureData data = new NovemberTemperatureData(novemberTemperatures);

            int daysBelowMinus10 = data.CountDaysBelowMinus10();

            label1.Text = "Кількість значень нижче -10:  " + daysBelowMinus10;

            foreach (double temperature in novemberTemperatures)
                dataGridView1.Rows.Add(temperature);
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
