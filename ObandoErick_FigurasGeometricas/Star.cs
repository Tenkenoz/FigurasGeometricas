using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    internal class Star
    {
        // Atributos
        private float radio;
        private float mPerimetro;
        private float mArea;
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF[] vertices;

        // Constructor
        public Star()
        {
            radio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;
            vertices = new PointF[10]; // Estrella de 5 puntas (10 vértices alternando exterior/interior)
        }

        // Leer datos
        public void ReadData(TextBox txtRadio)
        {
            try
            {
                radio = float.Parse(txtRadio.Text);
                if (radio <= 0)
                    throw new Exception("El radio debe ser mayor a 0.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "¡Datos no válidos!");
            }
        }

        // Calcular los vértices
        public void CalculateVertices()
        {
            float anguloCentral = (float)(2 * Math.PI / 10); // 36°
            float radioInterno = radio * 0.5f;

            for (int i = 0; i < 10; i++)
            {
                float angulo = i * anguloCentral - (float)Math.PI / 2; // Rotar para que empiece hacia arriba

                float r = (i % 2 == 0) ? radio : radioInterno;

                vertices[i] = new PointF(
                    r * (float)Math.Cos(angulo),
                    r * (float)Math.Sin(angulo)
                );
            }
        }

        // Calcular perímetro
        public void CalculatePerimeter()
        {
            mPerimetro = 0;

            for (int i = 0; i < 10; i++)
            {
                PointF p1 = vertices[i];
                PointF p2 = vertices[(i + 1) % 10];
                mPerimetro += (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            }
        }

        // Calcular área usando fórmula de polígono
        public void CalculateArea()
        {
            mArea = 0;

            for (int i = 0; i < 10; i++)
            {
                PointF p1 = vertices[i];
                PointF p2 = vertices[(i + 1) % 10];
                mArea += p1.X * p2.Y - p2.X * p1.Y;
            }

            mArea = Math.Abs(mArea) / 2.0f;
        }

        // Imprimir datos en los TextBox
        public void PrintData(TextBox txtPerimetro, TextBox txtArea)
        {
            txtPerimetro.Text = mPerimetro.ToString("0.00");
            txtArea.Text = mArea.ToString("0.00");
        }

        // Dibujar la estrella centrada en el PictureBox
        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.Clear(picCanvas.BackColor);
            mPen = new Pen(Color.Red, 2);

            PointF centro = new PointF(picCanvas.Width / 2, picCanvas.Height / 2);
            PointF[] verticesEscalados = new PointF[10];

            for (int i = 0; i < 10; i++)
            {
                verticesEscalados[i] = new PointF(
                    centro.X + vertices[i].X * SF,
                    centro.Y - vertices[i].Y * SF // Invertir Y
                );
            }

            mGraph.DrawPolygon(mPen, verticesEscalados);
        }

        // Inicializar datos
        public void InitializeData(TextBox txtRadio, TextBox txtPerimetro, TextBox txtArea, PictureBox picCanvas)
        {
            radio = 0.0f;
            mPerimetro = 0.0f;
            mArea = 0.0f;

            txtRadio.Text = "";
            txtPerimetro.Text = "";
            txtArea.Text = "";

            txtRadio.Focus();
            picCanvas.Refresh();
        }

        // Cerrar formulario
        public void CloseForm(Form objForm)
        {
            objForm.Close();
        }
    }

}
