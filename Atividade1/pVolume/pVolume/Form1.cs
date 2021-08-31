using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class btnFechar : Form
    {
        public btnFechar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double altura, raio;// Declara as variaveis 
            if ((double.TryParse(txtRaio.Text, out altura)) && (double.TryParse(txtAltura.Text, out raio)))
            {
                double cVolume = Math.PI * Math.Pow(raio, 2) * altura;// realizar o calculo pelo metodo MATH 
                txtCVCilindro.Text = cVolume.ToString("N3");// variável numérica com três casa após a virgula
            }
            else 
                MessageBox.Show(" Valores Invalidos!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();//limpa  o campo Textbox
            txtRaio.Clear();//limpa  o campo Textbox
            txtCVCilindro.Clear();//limpa  o campo Textbox
            txtRaio.Focus();// Evento chama o curso para TextBox txtRaio
        }

        private void txtRaio_Validating(object sender, CancelEventArgs e)
        {
            
            if ((txtRaio.Text == "") ||(txtRaio.Text==" "))// campo não pode ser vazio ou conter espaço , Textbox
            {
                MessageBox.Show("O campo 'Informe Raio', não pode ser vazio!");
                txtRaio.Focus();// Evento chama o curso para TextBox txtRaio
            }
        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {   

            if ((txtAltura.Text == "") || (txtAltura.Text == " "))// campo não pode ser vazio ou conter espaço , Textbox
            {
                MessageBox.Show("O campo 'Infome Altura' não pode ser vazio! ");
                txtAltura.Focus();// Evento chama o curso para TextBox txtAltura
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fechar(object sender, EventArgs e)
        {
             
        }
    }
}
