using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_testing_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_1.Text) || string.IsNullOrEmpty(txtBox_2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Terisi");
            }
            else {
                int angka1 = int.Parse(txtBox_1.Text);
                int angka2 = int.Parse(txtBox_2.Text);
                int hasil = angka1 + angka2;
                string hasilString = Convert.ToString(hasil);
                lblHasil.Text = hasilString;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBox_1.Clear();
            txtBox_2.Clear();
            lblHasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_1.Text) || string.IsNullOrEmpty(txtBox_2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Terisi");
            }
            else {
                int a,b,c;
                a = int.Parse(txtBox_1.Text);
                b = int.Parse(txtBox_2.Text);
                c = a - b;
                this.lblHasil.Text = c.ToString();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_1.Text) || string.IsNullOrEmpty(txtBox_2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Terisi");
            }
            else {
                int d, f, h;
                d = int.Parse(txtBox_1.Text);
                f = int.Parse(txtBox_2.Text);
                h = d / f;
                lblHasil.Text = f.ToString();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBox_1.Clear();
            txtBox_2.Clear();
            lblHasil.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_1.Text) || string.IsNullOrEmpty(txtBox_2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Terisi");
            }
            else {
                int a, b, c;
                a = int.Parse(txtBox_1.Text);
                b = int.Parse(txtBox_2.Text);
                c = a * b;
                lblHasil.Text = c.ToString();
            }

        }
    }
}
