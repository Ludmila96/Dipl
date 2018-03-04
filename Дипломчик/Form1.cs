using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дипломчик
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

        private void button1_Click(object sender, EventArgs e)
        {
            ExperimentalDataProvider data = new ExperimentalDataProvider();
            
            ExperimentalDataRecord r = data.getExperimentalData();
            double pDov = r.getP();
            List<double> m = r.getArr();
            textBox1.Text = pDov.ToString();

            for (int i =0; i<m.Count; i++)
            {
                textBox2.Text += m[i].ToString() + "\r\n";
            }

           List<double> xNew = Statistika.Calculation(data);
            for (int i = 0; i < xNew.Count; i++)
                textBox3.Text += xNew[i].ToString() + "\r\n";

            List<double> gran = Statistika.Bin(xNew);
            for (int i = 0; i < gran.Count; i++)
                textBox4.Text += gran[i].ToString() + "\r\n";

            Evaluation ev = Statistika.Probability(gran, xNew);

            List<double> mi = ev.getM();
            for (int i = 0; i < mi.Count; i++)
                textBox5.Text += mi[i].ToString() + "\r\n";

            List<double> Pi = ev.getP();
            for (int i = 0; i < Pi.Count; i++)
                textBox6.Text += Pi[i].ToString() + "\r\n";

            List<double> pi = ev.getp();
            for (int i = 0; i < pi.Count; i++)
                textBox7.Text += pi[i].ToString() + "\r\n";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
