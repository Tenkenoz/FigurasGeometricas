using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Rhomboid
    {
        // Atributos
        private float mBase;      // Base del romboide
        private float mHeight;    // Altura del romboide
        private float mArea;      // Área del romboide
        private float mPerimeter; // Perímetro del romboide
        private float mSide;      // Lado inclinado
        private Graphics mGraphics;
        private Pen mPen;
        private const float SF = 20; // Escala de dibujo

        // Constructor
        public Rhomboid()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mSide = 0.0f;
            mArea = 0.0f;
            mPerimeter = 0.0f;
            mPen = new Pen(Color.Blue, 2);
        }

        // Lectura de datos desde TextBoxes
        public void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cálculo del área
        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }

        // Cálculo del perímetro
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mSide);
        }

        // Mostrar resultados en los TextBoxes
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString("F2");
            txtArea.Text = mArea.ToString("F2");
        }

        // Inicialización de datos y limpieza de interfaz
        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            txtBase.Clear();
            txtHeight.Clear();
            txtSide.Clear();
            txtArea.Clear();
            txtPerimeter.Clear();
            txtBase.Focus();
            picCanvas.Refresh();
        }

        // Dibujar el romboide
        public void PlotShape(PictureBox picCanvas)
        {
            if (mBase <= 0 || mSide <= 0 || mHeight <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que cero para dibujar el romboide.", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float baseLength = mBase * SF;
            float sideOffset = mSide * SF;
            float height = mHeight * SF;

            float originX = 150;
            float originY = 100;

            PointF[] points = new PointF[4];
            points[0] = new PointF(originX, originY);                             // Superior izquierda
            points[1] = new PointF(originX + baseLength, originY);               // Superior derecha
            points[2] = new PointF(originX + baseLength - sideOffset, originY + height); // Inferior derecha
            points[3] = new PointF(originX - sideOffset, originY + height);      // Inferior izquierda

            mGraphics = picCanvas.CreateGraphics();
            mGraphics.DrawPolygon(mPen, points);
        }

        // Cerrar el formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }
}
