﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajeroAutomatico
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
            CajeroAutomatico obj = new CajeroAutomatico();
            //int dinero = Convert.ToInt32(textBox1.Text);

            //obj.ObtenerDatos(dinero);
        
        
            
            /*
            MessageBox.Show("Billetes 1000: " + obj.CalcularBilletesMil().ToString());
            MessageBox.Show("Billetes 200: " + obj.CalcularBilletesDocientos().ToString());
            MessageBox.Show("Billetes 100: " + obj.CalcularBilletesCien().ToString());
            MessageBox.Show("Billetes 50: " + obj.CalcularBilletesCincuenta().ToString());
            MessageBox.Show("Monedas 10: " + obj.CalcularMonedasDiez().ToString());
            MessageBox.Show("Monedas 1: " + obj.CalcularMonedasPeso().ToString());
            */
        }
    }
}