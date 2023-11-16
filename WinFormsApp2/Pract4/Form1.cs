using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract.Pract4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArraysAB a = new ArraysAB(10); // Adjust the size as needed
            string filePathRead = "C:\\Users\\dimat\\source\\repos\\Practical\\WinFormsApp2\\Pract4\\ArrayFile.txt";

            try
            {
                // Read from file
                FileRead fileReader = new FileRead();
                fileReader.Read(filePathRead, a);

                // Display the read array in label1
                ShowArray arrayShower = new ShowArray();
                label1.Text = "Масив з файлу: " + arrayShower.WriteArray(a.a);

                label2.Text = "Результат: " +  a.DetermineSituation(); 

            }
            catch (AccessViolationException ex)
            {
                // Handle the exception (e.g., show an error message)
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}