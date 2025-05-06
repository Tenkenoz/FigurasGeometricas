using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Rectangle
    {
        //Atributos
        private float mWidth; // ancho
        private float mHeight; // alto
        private float mArea; // area
        private Graphics mGraphics; // graficos
        private const float SF = 20; // escala
        private Pen mPen; // lapiz
        private float mPerimeter; // perimetro
        //Constructor
        public Rectangle()
        {
            mWidth = 0.0f;
            mHeight = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }
        //Funcion para leer los datos de entrada
        public void ReadData(TextBox txtWidth,TextBox txtHeight)
        {
            try
            {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }

        //Funcion para calcular el area
        public void CalculateArea()
        {
            mArea = mWidth * mHeight;
        }
        //Funcion para calcular el perimetro
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mWidth + mHeight);
        }

        // Función que imprime el perimetro y el área del rectángulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rectángulo
        public void InitializeData(TextBox txtWidth, TextBox txtHeight,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            mWidth = 0.0f; mHeight = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtWidth.Text = ""; txtHeight.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto
            txtWidth.Focus();
            picCanvas.Refresh();
        }

        //Funcoin de dibujar para dibujar
        public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);
            mGraphics.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);//Grafica la linea en el canva

        }

        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
