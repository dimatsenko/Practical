using Pract.Pract1;
using Pract.Pract3;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabul tabul = new Tabul();

            double xn, xk, h, a;

            xn = Convert.ToDouble(this.textBox1.Text);
            xk = Convert.ToDouble(this.textBox2.Text);
            h = Convert.ToDouble(this.textBox3.Text);
            a = Convert.ToDouble(this.textBox4.Text);

          
            dataGridView1.Rows.Clear();
            chart1.Series[0].Points.Clear();


            tabul.tab(xn, xk, h, a);
            for (int i = 0; i < tabul.n; i++)
            {
                dataGridView1.Rows.Add(Math.Round(tabul.xy[i, 0], 2).ToString(), 
                    Math.Round(tabul.xy[i, 1], 3).ToString());
                chart1.Series[0].Points.AddXY(tabul.xy[i, 0], tabul.xy[i, 1]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void îäíîâèì³ðíèéÌàñèâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract.Form2 f = new Pract.Form2();
            f.Show();
            this.Hide();
        }

        private void ðîáòàÇÌàñèâàìèToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void äâîâèì³ðíèéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract.Form3 f = new Pract.Form3();
            f.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract.Pract3.Form4 f = new Pract.Pract3.Form4();
            f.Show();
            this.Hide();
        }

        private void ôàéëèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pract.Pract4.Form1 f = new Pract.Pract4.Form1();
            f.Show();
            this.Hide();
        }
    }
}