using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{

    internal class Trapezoid
    {
        // Puntos del trapezoide
        private PointF A, B, C, D;
        private float mArea;
        private float mPerimeter;
        private Graphics mGraphics;
        private Pen mPen;
        private const float SF = 20; // Factor de escala para visualizar

        public Trapezoid()
        {
            A = B = C = D = new PointF(0, 0);
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }
        public void InitializeData(TextBox txtX1, TextBox txtY1,
                           TextBox txtX2, TextBox txtY2,
                           TextBox txtX3, TextBox txtY3,
                           TextBox txtX4, TextBox txtY4,
                           TextBox txtPerimeter, TextBox txtArea,
                           PictureBox picCanvas)
        {
            // Reiniciar puntos a (0,0)
            A = B = C = D = new PointF(0, 0);
            mArea = 0.0f;
            mPerimeter = 0.0f;

            // Limpiar cajas de texto
            txtX1.Text = "";
            txtY1.Text = "";
            txtX2.Text = "";
            txtY2.Text = "";
            txtX3.Text = "";
            txtY3.Text = "";
            txtX4.Text = "";
            txtY4.Text = "";

            txtPerimeter.Text = "";
            txtArea.Text = "";

            // Enfocar el primer campo
            txtX1.Focus();

            // Limpiar el canvas
            picCanvas.Refresh();
        }


        // Leer datos desde 8 TextBox: x1,y1,x2,y2,x3,y3,x4,y4
        public void ReadData(TextBox txtX1, TextBox txtY1,
                             TextBox txtX2, TextBox txtY2,
                             TextBox txtX3, TextBox txtY3,
                             TextBox txtX4, TextBox txtY4)
        {
            try
            {
                float x1 = float.Parse(txtX1.Text);
                float y1 = float.Parse(txtY1.Text);
                float x2 = float.Parse(txtX2.Text);
                float y2 = float.Parse(txtY2.Text);
                float x3 = float.Parse(txtX3.Text);
                float y3 = float.Parse(txtY3.Text);
                float x4 = float.Parse(txtX4.Text);
                float y4 = float.Parse(txtY4.Text);

                A = new PointF(x1, y1);
                B = new PointF(x2, y2);
                C = new PointF(x3, y3);
                D = new PointF(x4, y4);
            }
            catch
            {
                MessageBox.Show("Error: dato no válido.");
            }
        }

        // Calcular área usando fórmula del polígono
        public void CalculateArea()
        {
            float sum1 = A.X * B.Y + B.X * C.Y + C.X * D.Y + D.X * A.Y;
            float sum2 = A.Y * B.X + B.Y * C.X + C.Y * D.X + D.Y * A.X;
            mArea = 0.5f * Math.Abs(sum1 - sum2);
        }

        // Calcular perímetro
        public void CalculatePerimeter()
        {
            mPerimeter = Distance(A, B) + Distance(B, C) + Distance(C, D) + Distance(D, A);
        }

        // Calcular distancia entre dos puntos
        private float Distance(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        // Imprimir resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Dibujar el trapezoide escalado
        public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mGraphics.Clear(picCanvas.BackColor);
            mPen = new Pen(Color.Blue, 2);

            // Aplicar factor de escala a las coordenadas
            PointF p1 = new PointF(A.X * SF, A.Y * SF);
            PointF p2 = new PointF(B.X * SF, B.Y * SF);
            PointF p3 = new PointF(C.X * SF, C.Y * SF);
            PointF p4 = new PointF(D.X * SF, D.Y * SF);

            PointF[] points = new PointF[] { p1, p2, p3, p4, p1 }; // Cierra el polígono
            mGraphics.DrawLines(mPen, points);
        }

        // Cerrar formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }


}
