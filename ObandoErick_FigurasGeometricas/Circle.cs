using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Circle
    {
        // Atributos
        private float mRadius;        // radio
        private float mArea;         // área
        private float mPerimeter;    // perímetro
        private Graphics mGraphics;  // objeto para dibujar
        private Pen mPen;            // lápiz para dibujar
        private const float SF = 20; // factor de escala para visualizar

        // Constructor
        public Circle()
        {
            mRadius = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }

        // Leer datos
        public void ReadData(TextBox txtRadius)
        {
            try
            {
                mRadius = float.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Error: dato no válido para el radio.");
            }
        }

        // Calcular área
        public void CalculateArea()
        {
            mArea = (float)Math.PI * (float)Math.Pow(mRadius, 2);
        }

        // Calcular perímetro
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (float)Math.PI * mRadius;
        }

        // Imprimir resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Inicializar todo
        public void InitializeData(TextBox txtRadio, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            mRadius = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;

            txtRadio.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtRadio.Focus();
            picCanvas.Refresh();
        }

        // Dibujar el círculo
        public void PlotShape(PictureBox picCanvas)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);

            float diameter = 2 * mRadius * SF;

            // Coordenadas para centrar el círculo en el PictureBox
            float x = (picCanvas.Width - diameter) / 2;
            float y = (picCanvas.Height - diameter) / 2;
            mGraphics.DrawEllipse(mPen, x, y, diameter, diameter);
        }
        // Cerrar el formulario

        public void CloseForm(Form ObjForm)

        {
            ObjForm.Close();
        }
    }

}
