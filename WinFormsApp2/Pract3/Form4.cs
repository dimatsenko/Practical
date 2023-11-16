using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract.Pract3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBox1.Text);
                int b = Convert.ToInt32(this.textBox2.Text);

                // Очищаємо попередні значення на Label перед виведенням нового результату
                label3.Text = "результат: ";

                CalculationsAB calculations = new CalculationsAB(a, b);
                int result = calculations.Count();
                label3.Text += result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть числові значення в обидва текстові поля.");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(this.textBox3.Text);
                int b = Convert.ToInt32(this.textBox4.Text);
                int c = Convert.ToInt32(this.textBox5.Text);

                // Очищаємо попередні значення на Label перед виведенням нового результату
                label4.Text = "результат: ";

                CalculationsABC calculations = new CalculationsABC(a, b, c);
                int result = calculations.D();
                label4.Text += result;
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть числові значення в усі три текстові поля.");
            }
        }
    }
}
