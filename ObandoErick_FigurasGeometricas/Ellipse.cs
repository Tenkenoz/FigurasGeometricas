using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Ellipse
    {
        private float mSemiMajorAxis; // Semi-eje mayor
        private float mSemiMinorAxis; // Semi-eje menor
        private float mPerimeter;     // Perímetro
        private float mArea;         // Área
        private Graphics mGraphics;  // Objeto para dibujar
        private Pen mPen;            // Lápiz para dibujar
        private const float SF = 20; // Factor de escala para visualizar

        // Constructor
        public Ellipse()
        {
            mSemiMajorAxis = 0.0f;
            mSemiMinorAxis = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
        }
        // Leer datos
        public void ReadData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis)
        {
            try
            {
                mSemiMajorAxis = float.Parse(txtSemiMajorAxis.Text);
                mSemiMinorAxis = float.Parse(txtSemiMinorAxis.Text);
            }
            catch
            {
                MessageBox.Show("Error: dato no válido para los ejes.");
            }
        }
        // Calcular área
        public void CalculateArea()
        {
            mArea = (float)Math.PI * mSemiMajorAxis * mSemiMinorAxis;
        }
        // Calcular perímetro
        public void CalculatePerimeter()
        {
            mPerimeter = (float)(Math.PI * (3 * (mSemiMajorAxis + mSemiMinorAxis) - Math.Sqrt((3 * mSemiMajorAxis + mSemiMinorAxis) * (mSemiMajorAxis + 3 * mSemiMinorAxis))));
        }
        // Imprimir resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        // Dibujar elipse
        public void DrawEllipse(PictureBox pictureBox)
        {
            mGraphics = pictureBox.CreateGraphics();
            mPen = new Pen(Color.Red, 2);
            mGraphics.Clear(Color.White);
            mGraphics.DrawEllipse(mPen, 0, 0, (int)(mSemiMajorAxis * SF), (int)(mSemiMinorAxis * SF));
            mGraphics.Dispose();
        }
        // Inicializar todo
        public void InitializeData(TextBox txtSemiMajorAxis, TextBox txtSemiMinorAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            txtSemiMajorAxis.Text = "";
            txtSemiMinorAxis.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            picCanvas.Refresh();
        }
        public void CloseForms(Form form)
        {
            form.Close();

        }
    }
}
