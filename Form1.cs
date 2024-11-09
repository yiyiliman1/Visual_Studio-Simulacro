using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Este código se ejecuta al cargar el formulario y agrega las opciones al ListBox
            lstBxOpciones.Items.Add("DNI");
            lstBxOpciones.Items.Add("Pasaporte");
            lstBxOpciones.Items.Add("Carnet de Conducir");

            // ListBox para seleccionar un continente
            lstBxContinente.Items.Add("Asia");
            lstBxContinente.Items.Add("Europa");
            lstBxContinente.Items.Add("America");
            lstBxContinente.Items.Add("Oceania");
            lstBxContinente.Items.Add("Africa");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que haya una selección válida
            if (lstBxOpciones.SelectedItem != null)
            {
                // Obtenemos el elemento seleccionado
                string seleccion = lstBxOpciones.SelectedItem.ToString();

                // Mostramos la selección o la utilizamos como desees
                MessageBox.Show("Has seleccionado: " + seleccion);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarImagenContinente(string continente)
        {
            string imagenPath = GetContinenteImagePath(continente);

            if (!string.IsNullOrEmpty(imagenPath))
            {
                // Construimos la ruta completa de la imagen
                string fullPath = Path.Combine(Application.StartupPath, imagenPath);

                // Verificamos si la imagen existe en la ruta especificada
                if (File.Exists(fullPath))
                {
                    // Cargar y mostrar la imagen en el PictureBox
                    Foto.Image = Image.FromFile(fullPath);
                    Foto.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar la imagen al tamaño del PictureBox
                }
                else
                {
                    // Si no se encuentra la imagen, mostrar un mensaje de error
                    MessageBox.Show("No se encontró la imagen en la ruta: " + fullPath);
                }
            }
            else
            {
                MessageBox.Show("No se encontró la imagen del continente seleccionado.");
            }
        }

        // Función para obtener la ruta de la imagen según el continente
        private string GetContinenteImagePath(string continente)
        {
            switch (continente)
            {
                case "Asia":
                    return @"C:\Users\lili\source\repos\Simulacro\Img\Asia.png"; 
                case "Europa":
                    return @"C:\Users\lili\source\repos\Simulacro\Img\Europa.png"; 
                case "America":
                    return @"C:\Users\lili\source\repos\Simulacro\Img\America.png"; 
                case "Oceania":
                    return @"C:\Users\lili\source\repos\Simulacro\Img\Oceania.png"; 
                case "Africa":
                    return @"C:\Users\lili\source\repos\Simulacro\Img\Africa.jpg"; 
                default:
                    return string.Empty;
            }
        }

        private void lstBxContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos que se haya seleccionado un continente
            if (lstBxContinente.SelectedItem != null)
            {
                // Obtenemos el continente seleccionado
                string continenteSeleccionado = lstBxContinente.SelectedItem.ToString();

                // Llamamos a la función para mostrar la imagen del continente seleccionado
                MostrarImagenContinente(continenteSeleccionado);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No hay nada");
        }
    }
}
