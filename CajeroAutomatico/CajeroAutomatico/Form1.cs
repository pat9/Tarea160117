using System;
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
    public partial class frm_Cajero : Form
    {
        public frm_Cajero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Corregir_Click(object sender, EventArgs e)
        {
            if (txt_Cantidad.TextLength != 0)
            {
              txt_Cantidad.Text = txt_Cantidad.Text.Substring(0, txt_Cantidad.Text.Count() - 1);
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Retirar_Click(object sender, EventArgs e)
        {
            CajeroAutomatico cajero = new CajeroAutomatico();
            int dinero = Convert.ToInt32(txt_Cantidad.Text);
            cajero.ObtenerDatos(dinero);


            
            txt_Mil.Text =  cajero.CalcularBilletesMil().ToString();
            txt_Docientos.Text = cajero.CalcularBilletesDocientos().ToString();
            txt_Cien.Text =  cajero.CalcularBilletesCien().ToString();
            txt_Cincuenta.Text =  cajero.CalcularBilletesCincuenta().ToString();
            txt_Diez.Text =  cajero.CalcularMonedasDiez().ToString();
            txt_Peso.Text = cajero.CalcularMonedasPeso().ToString();
         
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Cantidad.Clear();
            txt_Cien.Clear();
            txt_Cincuenta.Clear();
            txt_Diez.Clear();
            txt_Docientos.Clear();
            txt_Mil.Clear();
            txt_Peso.Clear();
        }
    }
}
