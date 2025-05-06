using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Triangle
    {
        //Atributos
        private float mSide1; // lado 1
        private float mSide2; // lado 2
        private float mSide3; // lado 3
        private float mArea; // area
        private Graphics mGraphics; // graficos
        private const float SF = 20; // escala
        private Pen mPen; // lapiz
        private float mPerimeter; // perimetro
        //Constructor
        public Triangle()
        {
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mSide3 = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        //Funcion para leer los datos de entrada
        public void ReadData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3)
        {
            try
            {
                mSide1 = float.Parse(txtSide1.Text);
                mSide2 = float.Parse(txtSide2.Text);
                mSide3 = float.Parse(txtSide3.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }

        //Funcion para calcular el area
        public void CalculateArea()
        {
            // Usando la fórmula de Herón para calcular el área de un triángulo
            float s = (mSide1 + mSide2 + mSide3) / 2; // semiperímetro
            mArea = (float)Math.Sqrt(s * (s - mSide1) * (s - mSide2) * (s - mSide3));
        }
        //Funcion para calcular el perimetro
        public void CalculatePerimeter()
        {
            mPerimeter = mSide1 + mSide2 + mSide3;
        }

        // Función que imprime el perimetro y el área del rectángulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que inicializa los datos y controles del rectángulo
        public void InitializeData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3,
                                    TextBox txtPerimeter, TextBox txtArea,
                                    PictureBox picCanvas)
        {
            mSide1 = 0.0f;
            mSide2 = 0.0f;
            mSide3 = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;

            txtSide1.Text = "";
            txtSide2.Text = "";
            txtSide3.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto
            txtSide1.Focus();
            picCanvas.Refresh();
        }

        //Funcion de dibujar para dibujar
   
            public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);

            // Verifica si los lados forman un triángulo válido
            if (mSide1 + mSide2 <= mSide3 || mSide1 + mSide3 <= mSide2 || mSide2 + mSide3 <= mSide1)
            {
                MessageBox.Show("Los lados no forman un triángulo válido.");
                return;
            }

            float margin = 130f; // para que no se pegue al borde

            // Puntos base
            PointF A = new PointF(margin, margin);
            PointF B = new PointF(margin + mSide1 * SF, margin);

            // Teorema del coseno para hallar el punto C
            float a = mSide1, b = mSide2, c = mSide3;
            float cosGamma = (a * a + b * b - c * c) / (2 * a * b);
            float sinGamma = (float)Math.Sqrt(1 - cosGamma * cosGamma);

            float xC = margin + b * cosGamma * SF;
            float yC = margin - b * sinGamma * SF;  // hacia arriba

            PointF C = new PointF(xC, yC);

            mGraphics.DrawPolygon(mPen, new PointF[] { A, B, C });
        }

        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
