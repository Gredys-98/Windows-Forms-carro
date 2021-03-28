using Carrito_1.Class1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Carrito_1
{
    public partial class Form1 : Form
    {
        Carro carrito;
       
        string[] archivosMP3;
        string[] rutasarchivosMP3;
        private string ruta = " ";
        public Form1()
        {

            InitializeComponent();
        }
        WindowsMediaPlayer sonido;


        private void button1crear_Click(object sender, EventArgs e)
        {
            // crear carrito
            carrito = new Carro("toyota", 150);
            carrito.marca = "Toyota";
            carrito.Color = "azul";
            carrito.velo_max = 150;
            string marc = carrito.DAtoscarrito();
            label1datos.Text = marc;
            string color = carrito.dAtoscarrito();
            label1datos2.Text = color;
        }

        private void button1encender_Click(object sender, EventArgs e)
        {

            string respuesta = carrito.encendermotor();
            label1encender.Text = respuesta;
        }

        private void button2acelerar_Click(object sender, EventArgs e)
        {

            if (carrito.EstaEncendido())
            {
                label2velocidad.Text = carrito.acelerar();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.encendermotor()}esta apagado");

            }
        }
        private void button3Frenar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                label3Frenar.Text = carrito.frenare();
            }
            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.encendermotor()}esta apagado");
            }
        }

        private void button1apagar_Click(object sender, EventArgs e)
        {
            string res = carrito.apagarmotor();        
            label1apagar.Text = carrito.apagarmotor();

        }
        private void BtnAdjuntar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchios = new OpenFileDialog();
            CajaDeBusquedaDeArchios.Multiselect = true;
            if (CajaDeBusquedaDeArchios.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivosMP3 = CajaDeBusquedaDeArchios.SafeFileNames;
                rutasarchivosMP3 = CajaDeBusquedaDeArchios.FileNames;
                foreach (var archivosMP3 in archivosMP3)
                {
                    ListaCanciones.Items.Add(archivosMP3);
                }
                Reproductor.URL = rutasarchivosMP3[0];
                ListaCanciones.SelectedIndex = 0;
            }
        }

        private void ListaCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
                Reproductor.URL = rutasarchivosMP3[ListaCanciones.SelectedIndex];
            }

            else
            {
                MessageBox.Show($"lo lamento el carro {carrito.encendermotor()}esta apagado");
            }
        }
        private void button1interizquierdo_Click(object sender, EventArgs e)
        {
            string luces = carrito.IntermtenteIzquierdo();
          label1intermienteizquierdo.Text = luces;
        }

        private void button2interderecho_Click(object sender, EventArgs e)
        {
            string lucesd = carrito.IntermtenteDerecho();
          label1interderecho.Text = lucesd;
        }
    }

}

            
     

        
   
