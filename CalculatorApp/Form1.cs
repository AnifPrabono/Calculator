﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nilai1, nilai2, hasil;

            if (operator1.SelectedIndex == -1)
            {
                MessageBox.Show("Operator Belum Dipilih");
            }
            else if (operator1.SelectedIndex == 0)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 + nilai2;
                hasilakhir.Text = hasil.ToString();
            }
            else if (operator1.SelectedIndex == 1)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 - nilai2;
                hasilakhir.Text = hasil.ToString();
            }
            else if (operator1.SelectedIndex == 2)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 / nilai2;
                hasilakhir.Text = hasil.ToString();
            }
            else if (operator1.SelectedIndex == 3)
            {
                nilai1 = Double.Parse(angka1.Text);
                nilai2 = Double.Parse(angka2.Text);
                hasil = nilai1 * nilai2;
                hasilakhir.Text = hasil.ToString();
            }
            else if (operator1.SelectedIndex == 4) ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}