using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class GraficoLineas
    {
  
            //Atributos
            private float x;
            private float y;
            private Graphics mGraphics; // graficos
            private const float SF = 20; // escala
            private Pen mPen; // lapiz

        //Constructor
        public GraficoLineas()
        {
            x = 0.0f;
            y = 0.0f;
        }
        //Funcion para leer los datos de entrada
        public void ReadData(TextBox txtX, TextBox txtY)
        {
            try
            {
                x = float.Parse(txtX.Text);
                y = float.Parse(txtY.Text);
            }
            catch
            {
                MessageBox.Show("Error los datos no validos");
            }
        }
        //Funcion para inicializar el grafico


        public void InitializeData( PictureBox picCanvas)
            {
                picCanvas.Refresh();
            }

        public void PlotShape(PictureBox picCanvas, float xa, float ya)
        {
            mGraphics = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 2);

            // Solo dibujar si ya hay un punto previo
          
                mGraphics.DrawLine(mPen, x, y, xa, ya);
                mGraphics.DrawEllipse(mPen, xa - SF / 2, ya - SF / 2, SF, SF);

            // Actualizar las coordenadas almacenadas
            x = xa;
            y = ya;
        }

        //Funcion quecierra un fomrulairo
        public void CloseForm(Form ObjForm)
            {
                ObjForm.Close();
            }
        }
}
