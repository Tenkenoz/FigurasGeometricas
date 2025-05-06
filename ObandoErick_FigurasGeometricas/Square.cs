using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Square
    {
        //Atributos
        private float mSide; // lado
        private float mArea; // area
        private Graphics mGraphics; // graficos
        private const float SF = 20; // escala
        private Pen mPen; // lapiz
        private float mPerimeter; // perimetro
        //Constructor
        public Square()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        //Funcion para leer los datos de entrada
        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }

        //Funcion para calcular el area
        public void CalculateArea()
        {
            mArea = mSide * mSide;
        }
        //Funcion para calcular el perimetro
        public void CalculatePerimeter()
        {
            mPerimeter = 4 * mSide;
        }

        // Función que imprime el perimetro y el área del rectángulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rectángulo
        public void InitializeData(TextBox txtSide,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide.Text = ""; 
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto
            txtSide.Focus();
            picCanvas.Refresh();
        }

        //Funcoin de dibujar para dibujar
        public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);
            float size = mSide * SF;

            // Dibuja el cuadrado desde la esquina superior izquierda (0,0)
            mGraphics.DrawRectangle(mPen, 0, 0, size, size);

        }

        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
