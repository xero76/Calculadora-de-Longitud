using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_Unidades_de_Longitud
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdconvertir_Click(object sender, EventArgs e)
        {
            cLongitudes x = new cLongitudes();


            double valor_ingresado;

            valor_ingresado = double.Parse(txtvalor.Text);
            if (cmborigen.Text == "Milimetros" && cmbdestino.Text == "Milimetros")
            {
                lblresultado.Text = Convert.ToString(x.mil_mil(valor_ingresado));
            }
            else if (cmborigen.Text == "Milimetros" && cmbdestino.Text == "Centimetros")
            {
                lblresultado.Text = Convert.ToString(x.mil_cen(valor_ingresado));
            }
            else if (cmborigen.Text == "Milimetros" && cmbdestino.Text == "Decimetros")
            {
                lblresultado.Text = Convert.ToString(x.mil_dec(valor_ingresado));
            }
            else if (cmborigen.Text == "Milimetros" && cmbdestino.Text == "Metros")
            {
                lblresultado.Text = Convert.ToString(x.mil_metr(valor_ingresado));
            }
            else if (cmborigen.Text == "Milimetros" && cmbdestino.Text == "Kilometros")
            {
                lblresultado.Text = Convert.ToString(x.mil_km(valor_ingresado));
            } 
            else if (cmborigen.Text == "Decimetros" && cmbdestino.Text == "Milimetros")
            {
                lblresultado.Text = Convert.ToString(x.dec_mil(valor_ingresado));
            }
            else if (cmborigen.Text == "Decimetros" && cmbdestino.Text == "Centimetros")
            {
                lblresultado.Text = Convert.ToString(x.dec_cen(valor_ingresado));
            }
            else if (cmborigen.Text == "Decimetros" && cmbdestino.Text == "Decimetros")
            {
                lblresultado.Text = Convert.ToString(x.dec_dec(valor_ingresado));
            }
            else if (cmborigen.Text == "Decimetros" && cmbdestino.Text == "Metros")
            {
                lblresultado.Text = Convert.ToString(x.dec_metr(valor_ingresado));
            }
            else if (cmborigen.Text == "Decimetros" && cmbdestino.Text == "Kilometros")
            {
                lblresultado.Text = Convert.ToString(x.dec_km(valor_ingresado));
            }
            else if (cmborigen.Text == "Centimetros" && cmbdestino.Text == "Milimetros")
            {
                lblresultado.Text = Convert.ToString(x.cen_mil(valor_ingresado));
            }
            else if (cmborigen.Text == "Centimetros" && cmbdestino.Text == "Centimetros")
            {
                lblresultado.Text = Convert.ToString(x.cen_cen(valor_ingresado));
            }
            else if (cmborigen.Text == "Centimetros" && cmbdestino.Text == "Decimetros")
            {
                lblresultado.Text = Convert.ToString(x.cen_dec(valor_ingresado));
            }
            else if (cmborigen.Text == "Centimetros" && cmbdestino.Text == "Metros")
            {
                lblresultado.Text = Convert.ToString(x.cen_metr(valor_ingresado));
            }
            else if (cmborigen.Text == "Centimetros" && cmbdestino.Text == "Kilometros")
            {
                lblresultado.Text = Convert.ToString(x.cen_km(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Milimetros")
            {
                lblresultado.Text = Convert.ToString(x.metr_mil(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Centimetros")
            {
                lblresultado.Text = Convert.ToString(x.metr_cen(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Decimetros")
            {
                lblresultado.Text = Convert.ToString(x.metr_dec(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Metros")
            {
                lblresultado.Text = Convert.ToString(x.metr_metr(valor_ingresado));
            }
            else if (cmborigen.Text == "Metros" && cmbdestino.Text == "Kilometros")
            {
                lblresultado.Text = Convert.ToString(x.metr_km(valor_ingresado));
            }
            else if (cmborigen.Text == "Kilometros" && cmbdestino.Text == "Milimetros")
            {
                lblresultado.Text = Convert.ToString(x.km_mil(valor_ingresado));
            }
            else if (cmborigen.Text == "Kilometros" && cmbdestino.Text == "Centimetros")
            {
                lblresultado.Text = Convert.ToString(x.km_cen(valor_ingresado));
            }
            else if (cmborigen.Text == "Kilometros" && cmbdestino.Text == "Decimetros")
            {
                lblresultado.Text = Convert.ToString(x.km_dec(valor_ingresado));
            }
            else if (cmborigen.Text == "Kilometros" && cmbdestino.Text == "Metros")
            {
                lblresultado.Text = Convert.ToString(x.km_metr(valor_ingresado));
            }
            else if (cmborigen.Text == "Kilometros" && cmbdestino.Text == "Kilometros")
            {
                lblresultado.Text = Convert.ToString(x.km_km(valor_ingresado));
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido");
            }
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por usar el programa... Feliz día!!!");
            Application.Exit();
        }
    }
}
 
    

