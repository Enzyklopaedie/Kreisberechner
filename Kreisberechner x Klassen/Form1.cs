using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kreisberechner_x_Klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kreis k = new Kreis();
            double durchm;
            double umf;
            double flaech;

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            durchm = Convert.ToDouble(textBox2.Text);
            k.eingabe_durchmesser(durchm);

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            umf = Convert.ToDouble(textBox3.Text);
            k.eingabe_umfang(umf);

            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            flaech = Convert.ToDouble(textBox4.Text);
            k.eingabe_flaeche(flaech);

            k.berradius();

            textBox1.Text = k.radius.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kreis k = new Kreis();
            double rad;
            double umf;
            double flaech;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            rad = Convert.ToDouble(textBox1.Text);
            k.eingabe_radius(rad);

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            umf = Convert.ToDouble(textBox3.Text);
            k.eingabe_umfang(umf);

            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            flaech = Convert.ToDouble(textBox4.Text);
            k.eingabe_flaeche(flaech);
            k.berdurchmesser();
            textBox2.Text = k.durchmesser.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kreis k = new Kreis();
            double rad;
            double durchm;
            double flaech;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            rad = Convert.ToDouble(textBox1.Text);
            k.eingabe_radius(rad);

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            durchm = Convert.ToDouble(textBox2.Text);
            k.eingabe_durchmesser(durchm);

            if (textBox4.Text == "")
            {
                textBox4.Text = "0";
            }
            flaech = Convert.ToDouble(textBox4.Text);
            k.eingabe_flaeche(flaech);
            k.berumfang();
            textBox3.Text = k.umfang.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kreis k = new Kreis();
            double rad;
            double durchm;
            double umf;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            rad = Convert.ToDouble(textBox1.Text);
            k.eingabe_radius(rad);

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            durchm = Convert.ToDouble(textBox2.Text);
            k.eingabe_durchmesser(durchm);

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }
            umf = Convert.ToDouble(textBox3.Text);
            k.eingabe_umfang(umf);
            k.berflaeche();
            textBox4.Text = k.flaecheninhalt.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
