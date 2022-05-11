using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cédula = Convert.ToInt32(textBox1.Text);
            string Primernombre = Convert.ToString(textBox5.Text);
            string Segundonombre = Convert.ToString(textBox6.Text);
            string Primerapellido = Convert.ToString(textBox2.Text);
            string Segundopellido = Convert.ToString(textBox9.Text);
            string FecNcac = Convert.ToString(textBox7.Text);
            int Teléfono = Convert.ToInt32(textBox4.Text);
            string email = Convert.ToString(textBox3.Text);
            string Dirección = Convert.ToString(textBox8.Text);




            string salida = "La Cédula es      " + Convert.ToString(Cédula);
            salida += "EL Primer nombre es:      " + Convert.ToString(Primernombre);
                        salida +=  "El segundo nombre es:      " + Convert.ToString(Segundonombre);


            salida += "El primer apellido es:   " +Convert.ToString(Primerapellido);
            salida += "El segundo apellido es:  " + Convert.ToString(Segundopellido);
            salida += "La fecha de nacimiento es:  " + Convert.ToString(FecNcac);
            salida += "El teléfono es:  " + Convert.ToString(Teléfono);
            salida += "El email es:  " + Convert.ToString(email);
            salida += "La Direccion es:  " + Convert.ToString(Dirección);

            MessageBox.Show(salida);


        }
    }
}
