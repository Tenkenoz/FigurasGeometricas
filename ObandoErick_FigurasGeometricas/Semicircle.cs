using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Semicircle
    {
        // Atributos
        private float mRadius;        // radio
        private float mArea;         // área
        private float mPerimeter;    // perímetro
        private Graphics mGraphics;  // objeto para dibujar
        private Pen mPen;            // lápiz para dibujar
        private const float SF = 20; // factor de escala para visualizar

        // Constructor
        public Semicircle()
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
            mArea = ((float)Math.PI * (float)Math.Pow(mRadius, 2))/2;
        }

        // Calcular perímetro
        public void CalculatePerimeter()
        {
            mPerimeter = (float)Math.PI * mRadius;
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

      
            mGraphics.DrawArc(mPen, 0, 0, (int)(mRadius * SF), (int)(mRadius * SF), 0, 180);

            

        }
        // Cerrar el formulario

        public void CloseForm(Form ObjForm)

        {
            ObjForm.Close();
        }
    }
}
