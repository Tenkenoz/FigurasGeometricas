using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Trapeze
    {
        // Atributos
        private float mBaseMayor;     // base mayor
        private float mBaseMenor;     // base menor
        private float mHeight;        // altura
        private float mArea;          // área
        private float mPerimeter;     // perímetro
        private Graphics mGraphics;   // objeto para dibujar
        private Pen mPen;             // lápiz para dibujar
        private const float SF = 20;  // factor de escala para visualizar

        // Constructor
        public Trapeze()
        {
            mBaseMayor = 0.0f;
            mBaseMenor = 0.0f;
            mHeight = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }

        // Leer datos
        public void ReadData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtHeight)
        {
            try
            {
                mBaseMayor = float.Parse(txtBaseMayor.Text);
                mBaseMenor = float.Parse(txtBaseMenor.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch
            {
                MessageBox.Show("Error: dato no válido.");
            }
        }

        // Calcular área
        public void CalculateArea()
        {
            mArea = ((mBaseMayor + mBaseMenor) * mHeight) / 2;
        }

        // Calcular perímetro (solo suma las bases y lados inclinados estimados si fueran iguales)
        public void CalculatePerimeter()
        {
            // Aquí calculamos los lados inclinados suponiendo un trapecio isósceles
            float side = (float)Math.Sqrt(Math.Pow((mBaseMayor - mBaseMenor) / 2, 2) + Math.Pow(mHeight, 2));
            mPerimeter = mBaseMayor + mBaseMenor + 2 * side;
        }

        // Imprimir resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Inicializar todo
        public void InitializeData(TextBox txtBaseMayor, TextBox txtBaseMenor, TextBox txtHeight,
                                   TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mBaseMayor = 0.0f;
            mBaseMenor = 0.0f;
            mHeight = 0.0f;

            txtBaseMayor.Text = "";
            txtBaseMenor.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtBaseMayor.Focus();
            picCanvas.Refresh();
        }

        // Dibujar el trapecio
        public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mGraphics.Clear(picCanvas.BackColor);
            mPen = new Pen(Color.Blue, 2);

            float x = 50;
            float y = 50;

            float baseMayor = mBaseMayor * SF;
            float baseMenor = mBaseMenor * SF;
            float height = mHeight * SF;

            PointF p1 = new PointF(x + (baseMayor - baseMenor) / 2, y);          // esquina superior izquierda
            PointF p2 = new PointF(p1.X + baseMenor, y);                         // esquina superior derecha
            PointF p3 = new PointF(x + baseMayor, y + height);                   // esquina inferior derecha
            PointF p4 = new PointF(x, y + height);                               // esquina inferior izquierda

            mGraphics.DrawLine(mPen, p1, p2);
            mGraphics.DrawLine(mPen, p2, p3);
            mGraphics.DrawLine(mPen, p3, p4);
            mGraphics.DrawLine(mPen, p4, p1);
        }

        // Cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }

}
