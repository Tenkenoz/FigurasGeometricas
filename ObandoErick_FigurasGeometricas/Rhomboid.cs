using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Rhomboid
    {
        //Atributos
        private float mBase; // base
        private float mHeight; // altura
        private float mArea; // area
        private float mPerimeter; // perimetro
        private float mSide; // lado
        private Graphics mGraphics; // graficos
        private const float SF = 20; // escala
        private Pen mPen; // lapiz

   
        //Constructor
        public Rhomboid()
        {
            mBase = 0.0f;
            mHeight = 0.0f;
            mPerimeter = 0.0f;
            mArea = 0.0f;
        }
        public void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            try
            {
                mBase = float.Parse(txtBase.Text);
                mHeight = float.Parse(txtHeight.Text);
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }

        public void CalculateArea()
        {
            mArea = mBase * mHeight;
        }
        public void CalculatePerimeter()
        {
            mPerimeter = 2 * (mBase + mSide);
        }
        // Función que imprime el perimetro y el área del rectángulo
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        //Funcion para inicializar los datos y graficos del triangulo
        public void InitializeData(TextBox txtBase, TextBox txtHeight, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            txtBase.Text = "";
            txtHeight.Text = "";
            txtSide.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtBase.Focus();
            txtHeight.Focus();
            txtSide.Focus();
            picCanvas.Refresh();
        }
        //Funcion para dibujar el romboide
        public void PlotShape(PictureBox picCanvas)
        {
            float baseLength = mBase * SF;
            float sideOffset = mSide * SF;
            float height = mHeight * SF;

            // Punto de partida (esquina superior izquierda)
            float originX = 150;
            float originY = 100;

            // Dibuja el romboide (paralelogramo)
            PointF[] points = new PointF[4];
            points[0] = new PointF(originX, originY); // Superior izquierda
            points[1] = new PointF(originX + baseLength, originY); // Superior derecha
            points[2] = new PointF(originX + baseLength - sideOffset, originY + height); // Inferior derecha
            points[3] = new PointF(originX - sideOffset, originY + height); // Inferior izquierda

            mGraphics.DrawPolygon(mPen, points);
        }



        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }


    }
}
