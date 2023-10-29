using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoDimentionalArray;

namespace Pract
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            int n = 0;
            n = Convert.ToInt32(textBox1.Text);

            Matrix matrix = new Matrix(n);



            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = n;

            int cellSize = 50;
            dataGridView1.RowTemplate.Height = cellSize;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = cellSize;
            }


            // Fill the DataGridView with matrix data
            for (int i = 0; i < n; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < n; j++)
                {
                    dataGridView1[j, i].Value = matrix.GetMatrix()[i, j];
                }
            }

            int minElement = matrix.FindMinElement(out int row, out int col);
            int distanceToDiagonal = matrix.GetDistanceToDiagonal(row, col);

            label2.Text = "Minimum Element: " + minElement; 
            label3.Text = "Distance to Diagonal: " + distanceToDiagonal;
        }

        




    }
}
