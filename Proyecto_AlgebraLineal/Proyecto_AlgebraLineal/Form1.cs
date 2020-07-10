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

namespace Proyecto_AlgebraLineal
{
    public partial class Form1 : Form
    {
        //son globales debido a su utilización en cada metodo de cambio de filtro
        Bitmap imagenOriginal;
        Bitmap imagenGris;
        Bitmap filtroAplicado;
        bool EscalaGris = false;
        Dictionary<int, string> letra;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Multiplicación_Matrices(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33)
        {
            int anchoImagen = imagenGris.Width, alturaImagen = imagenOriginal.Height;
            int[,] MatrizImagen = new int[anchoImagen, alturaImagen];
            int[,] nuevaMatriz = new int[anchoImagen, alturaImagen];
            Color nuevoColorPixeles;
            filtroAplicado = new Bitmap(anchoImagen, alturaImagen);

            for (int x = 0; x < anchoImagen; x++)
            {
                for (int y = 0; y < alturaImagen; y++)
                {
                    MatrizImagen[x, y] = imagenGris.GetPixel(x, y).R; //ASIGNACION DE PIXELES A MATRIZ DE LA IMAGEN ORIGINAL
                }
            }
          
            for (int i = 0; i < anchoImagen; i++)
            {
                for (int j = 0; j < alturaImagen; j++)
                {
                    //PRIMERA FILA
                    if (i == 0)//borde superior
                    {
                        if ((j == 0) || (j == alturaImagen - 1) || ((j > 0) && (j < alturaImagen - 1)))
                        {
                           
                            filtroAplicado.SetPixel(i, j, Color.Black);
                        }
                    }
                    //ULTIMA FILA
                    if (i == anchoImagen - 1) 
                    {
                        if ((j == 0) || (j == alturaImagen - 1) || ((j > 0) && (j < alturaImagen - 1))) 
                        {
                            filtroAplicado.SetPixel(i, j, Color.Black);
                        }
                    }//ESQUIANS
                    if (((j == 0) && (i > 0 && i < anchoImagen - 1)) || ((j == alturaImagen - 1) && (i > 0 && i < anchoImagen - 1)))
                    {
                            filtroAplicado.SetPixel(i, j, Color.Black);
                    }
                    //CENTROS 
                    if ((i > 0) && (j > 0) && (i < anchoImagen - 1) && (j < alturaImagen - 1)) //centros de matriz 3x3 o centro de toda la imagen
                    {
                        nuevaMatriz[i, j] = (int)(MatrizImagen[i - 1, j - 1] * a11 + MatrizImagen[i - 1, j] * a12 + MatrizImagen[i - 1, j + 1] * a13 
                                              + MatrizImagen[i, j - 1] * a21 + MatrizImagen[i, j] * a22 + MatrizImagen[i, j + 1] * a23 
                                             + MatrizImagen[i + 1, j - 1] * a31 + MatrizImagen[i + 1, j] * a32 + MatrizImagen[i + 1, j + 1] * a33);
                    }
                    //excesos en numero de byte en pixeles 
                    if (nuevaMatriz[i, j] > 255)
                    {
                        nuevaMatriz[i, j] = 255;
                    }
                    if (nuevaMatriz[i, j] < 0)
                    {
                        nuevaMatriz[i, j] = 0;
                    }

                    int matrizAColor = nuevaMatriz[i, j];
                    nuevoColorPixeles = Color.FromArgb(matrizAColor, matrizAColor, matrizAColor);
                    //se empieza a llenar matriz formando la nueva imagen en cada iteración
                    filtroAplicado.SetPixel(i, j, nuevoColorPixeles);
                }
            }
            pictureBox3.Image = filtroAplicado;
        }
    
        private void Difuminado_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(0.0625, 0.125, 0.0625, 0.125, 0.25, 0.125, 0.0625, 0.125, 0.0625);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises.");
            }
           

        }

        private void Sobel_Inferior_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(-1, -2, -1, 0, 0, 0, 1, 2, 1);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
            
        }

        private void Sobel_Izq_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(1, 0, -1, 2, 0, -2, 1, 0, -1);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
           
        }

        private void Contorno_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(-1, -1, -1, -1, 8, -1, -1, -1, -1);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
           
        }

        private void Original_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(0, 0, 0, 0, 1, 0, 0, 0, 0);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
            
        }

        private void Realzar_Click(object sender, EventArgs e)
        {

            if (EscalaGris == true)
            {
                Multiplicación_Matrices(-2, -1, 0, -1, 1, 1, 0, 1, 2);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
           
        }

        private void Sobel_Superior_Click(object sender, EventArgs e)
        {

            if (EscalaGris == true)
            {
                Multiplicación_Matrices(1, 2, 1, 0, 0, 0, -1, -2, -1);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
           
        }

        private void Sobel_Derecho_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(-1, 0, 1, -2, 0, 2, -1, 0, 1);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }
           
        }

        private void Afilar_Click(object sender, EventArgs e)
        {
            if (EscalaGris == true)
            {
                Multiplicación_Matrices(0, -1, 0, -1, 5, -1, 0, -1, 0);
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }

           



        }

        string ruta;
        private void subir_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
           
            o.Filter="Image files(*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
            if (o.ShowDialog() == DialogResult.OK)
            {
                 imagenOriginal = new Bitmap(Image.FromFile(o.FileName));
                pictureBox1.Image = imagenOriginal;
                ruta = o.FileName;
            }
            if (pictureBox3 != null)
            {
                pictureBox3.Image = null;
            }
            if (pictureBox2!=null)
            {
                pictureBox2.Image = null;
            }
        }

        private void ConvertirGris_Click(object sender, EventArgs e)
        {
            int w = imagenOriginal.Width, h = imagenOriginal.Height;
            Color actual, nuevoColor;
            imagenGris = new Bitmap(w, h);
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    actual = imagenOriginal.GetPixel(x, y);
                    nuevoColor = Color.FromArgb(actual.R, actual.R, actual.R);
                    imagenGris.SetPixel(x, y, nuevoColor);

                }
            }
            pictureBox2.Image = imagenGris;
            EscalaGris = true;
        }

        private void Personalizado_Click_1(object sender, EventArgs e)
        {

            LlenadoDiccionario();

            if (EscalaGris == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""|| textBox4.Text == ""|| textBox5.Text == ""|| textBox6.Text == ""|| textBox7.Text == ""|| textBox8.Text == ""|| textBox9.Text == "")
                {
                    MessageBox.Show("Alguno de los espacios de la matriz personalizada está vacío");
                }
                else
                {
                    if (letra.ContainsValue(textBox1.Text.ToString()) || letra.ContainsValue(textBox2.Text.ToString()) || letra.ContainsValue(textBox3.Text.ToString()) || letra.ContainsValue(textBox4.Text.ToString()) || letra.ContainsValue(textBox5.Text.ToString()) || letra.ContainsValue(textBox6.Text.ToString()) || letra.ContainsValue(textBox7.Text.ToString()) || letra.ContainsValue(textBox8.Text.ToString()) || letra.ContainsValue(textBox9.Text.ToString()))
                    {
                        MessageBox.Show("Únicamente es válido el ingreso de números");
                    }
                    else
                    {
                        double a = Convert.ToDouble(textBox1.Text);
                        double b = Convert.ToDouble(textBox2.Text);
                        double c = Convert.ToDouble(textBox3.Text);
                        double d = Convert.ToDouble(textBox4.Text);
                        double e2 = Convert.ToDouble(textBox5.Text);
                        double f = Convert.ToDouble(textBox6.Text);
                        double g = Convert.ToDouble(textBox7.Text);
                        double h2 = Convert.ToDouble(textBox8.Text);
                        double i2 = Convert.ToDouble(textBox9.Text);
                        Multiplicación_Matrices(a, b, c, d, e2, f, g, h2, i2);
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show("No se ha convertido la imagen a una escala de grises");
            }

           

           
        }

        public void LlenadoDiccionario()
        {
            letra = new Dictionary<int, string>();
            letra.Add(1, "a");
            letra.Add(2, "b");
            letra.Add(3, "c");
            letra.Add(4, "d");
            letra.Add(32, "e");
            letra.Add(5, "f");
            letra.Add(6, "g");
            letra.Add(7, "h");
            letra.Add(8, "i");
            letra.Add(9, "j");
            letra.Add(10, "k");
            letra.Add(11, "l");
            letra.Add(12, "m");
            letra.Add(13, "n");
            letra.Add(14, "ñ");
            letra.Add(15, "o");
            letra.Add(16, "p");
            letra.Add(17, "q");
            letra.Add(18, "r");
            letra.Add(19, "s");
            letra.Add(20, "t");
            letra.Add(21, "u");
            letra.Add(22, "v");
            letra.Add(23, "w");
            letra.Add(24, "x");
            letra.Add(25, "y");
            letra.Add(26, "z");
            letra.Add(27, "_");
            letra.Add(28, "+");
            letra.Add(29, ":");
            letra.Add(30, ";");
            letra.Add(31, "*");

        }
        private void Guardar_Click(object sender, EventArgs e)
        {
            string nombreArchivo = Path.GetFileName(ruta);
           
           
            if(pictureBox3.Image == null)
            {
                MessageBox.Show("No hay filtro aplicado para guardar imagen");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter="Image files(*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
                saveFile.FileName = "Filtrada" + nombreArchivo;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.Image.Save(saveFile.FileName);
                    MessageBox.Show("Imagen guardada");
                }
            }
           
        }
    } 
}

