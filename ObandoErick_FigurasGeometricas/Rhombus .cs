using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Rhombus
    {
        //Atributos
        private float mMajorDiagonal; // DiagonalMayor
        private float mMinorDiagonal; // DiagonalMayor
        private float mArea; // area
        private Graphics mGraphics; // graficos
        private const float SF = 20; // escala
        private Pen mPen; // lapiz
        private float mPerimeter; // perimetro
        //Constructor
        public Rhombus()
        {
            mMajorDiagonal = 0.0f;
            mMinorDiagonal = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        //Funcion para leer los datos de entrada
        public void ReadData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal)
        {
            try
            {
                mMajorDiagonal = float.Parse(txtMajorDiagonal.Text);
                mMinorDiagonal = float.Parse(txtMinorDiagonal.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }

        //Funcion para calcular el area
        public void CalculateArea()
        {
            mArea = (mMajorDiagonal * mMinorDiagonal) / 2;
        }
        //Funcion para calcular el perimetro
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (float)Math.Sqrt(Math.Pow(mMajorDiagonal / 2, 2) + Math.Pow(mMinorDiagonal / 2, 2));
        }

        // Función que imprime el perimetro y el área del rectángulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rectángulo
        public void InitializeData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
      
            mMajorDiagonal = 0.0f;
            mMinorDiagonal = 0.0f;

            mPerimeter = 0.0f; mArea = 0.0f;

            txtMajorDiagonal.Text = "";
            txtMinorDiagonal.Text = "";

            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto
            txtMajorDiagonal.Focus();
            txtMinorDiagonal.Focus();
            picCanvas.Refresh();
        }

        //Funcion de dibujar para dibujar

        public void PlotShape(PictureBox picCanvas)
        {
            if (mMajorDiagonal <= 0 || mMinorDiagonal <= 0)
                return; // No se puede dibujar con valores no válidos

            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            float centerX = picCanvas.Width / 2;
            float centerY = picCanvas.Height / 2;

            float halfMajor = (mMajorDiagonal / 2) * SF;
            float halfMinor = (mMinorDiagonal / 2) * SF;

            // Definir los 4 vértices del rombo
            PointF top = new PointF(centerX, centerY - halfMinor);    // superior
            PointF right = new PointF(centerX + halfMajor, centerY);  // derecha
            PointF bottom = new PointF(centerX, centerY + halfMinor); // inferior
            PointF left = new PointF(centerX - halfMajor, centerY);   // izquierda

            // Dibujar el rombo
            PointF[] rhombusPoints = { top, right, bottom, left };
            mGraphics.DrawPolygon(mPen, rhombusPoints);
        }


        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
