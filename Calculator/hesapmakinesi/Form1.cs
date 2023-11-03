using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum =false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if(txtsonuc.Text=="0" || optDurum) 
                txtsonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtsonuc.Text += btn.Text;
        }

        private void opthesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniopt= btn.Text;

            lbsonuc.Text = lbsonuc.Text + " " + txtsonuc.Text + " "+yeniopt;
            switch(opt)
            {
                case "+":txtsonuc.Text = (sonuc + Double.Parse(txtsonuc.Text)).ToString(); break;
                case "-": txtsonuc.Text = (sonuc - Double.Parse(txtsonuc.Text)).ToString(); break;
                case "/": txtsonuc.Text = (sonuc / Double.Parse(txtsonuc.Text)).ToString(); break;
                case "*": txtsonuc.Text = (sonuc * Double.Parse(txtsonuc.Text)).ToString(); break;
            }
            sonuc= double.Parse(txtsonuc.Text);
            txtsonuc.Text=sonuc.ToString();
            opt = yeniopt;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtsonuc.Text = "0";
            lbsonuc.Text = "";
            opt = "";
            sonuc = 0;
            optDurum = false; sonuc = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbsonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtsonuc.Text = (sonuc + Double.Parse(txtsonuc.Text)).ToString(); break;
                case "-": txtsonuc.Text = (sonuc - Double.Parse(txtsonuc.Text)).ToString(); break;
                case "/": txtsonuc.Text = (sonuc / Double.Parse(txtsonuc.Text)).ToString(); break;
                case "*": txtsonuc.Text = (sonuc * Double.Parse(txtsonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtsonuc.Text);
            txtsonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtsonuc.Text== "0")
            {
                txtsonuc.Text= "0";
            }
            else if(optDurum)
            {
                txtsonuc.Text = "0";
            }

            if(!txtsonuc.Text.Contains(","))
            {
                txtsonuc.Text += ",";
            }
            optDurum = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seniseviyorm");
        }
    }
}
