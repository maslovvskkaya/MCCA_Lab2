using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MCCA_Lab1
{
    interface IInterface
    {
        double F(double x, double y);
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Gener ob2 = new Gener(double.Parse(textBox1.Text),
double.Parse(textBox2.Text), double.Parse(textBox3.Text),
double.Parse(textBox4.Text), int.Parse(textBox5.Text));
            double[,] X_Y = ob2.Generator();
            Analiz ob4 = new Analiz();
            funk F1 = new funk();
            funk F3 = new funk();
            int KOl_p = ob4.Sraw(X_Y, F1.F, F3.F_1);
            textBox7.Text = KOl_p.ToString();
            Area_P ob5 = new Area_P(KOl_p,
            int.Parse(textBox5.Text));
            textBox6.Text = (ob5.Area(double.Parse(textBox1.Text),
            double.Parse(textBox2.Text), double.Parse(textBox3.Text),
            double.Parse(textBox4.Text))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graf ob1 = new Graf(double.Parse(textBox1.Text),
           double.Parse(textBox2.Text), double.Parse(textBox3.Text),
           double.Parse(textBox4.Text));
            ob1.Grafik(chart1);

        }

        
    }
    }


