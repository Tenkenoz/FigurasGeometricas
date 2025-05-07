using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObandoErick_GeometricFigures
{
    internal class Deltoid
    {
        //Atributos
        private float majorDiagonal;
        private float minorDiagonal;
        private float perimeter;
        private float area;

        // Para el dibujo
        private Graphics graphic;
        private readonly Pen pen = new Pen(Color.DarkGreen, 2);
        private const float SCALE_FACTOR = 20;

        // Lee únicamente las diagonales
        public void ReadData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal)
        {
            try
            {
                majorDiagonal = float.Parse(txtMajorDiagonal.Text);
                minorDiagonal = float.Parse(txtMinorDiagonal.Text);
            }
            catch
            {
                MessageBox.Show("Valores de diagonal no válidos. Introduce números válidos.", "Error de entrada");
            }
        }

        // Área = (D * d) / 2
        public void CalculateArea()
        {
            area = (majorDiagonal * minorDiagonal) / 2;
        }

        public void CalculatePerimeter()
        {
            float halfD = majorDiagonal / 2;
            float halfd = minorDiagonal / 2;

            // Lados cortos: forman un triángulo con (d/2, D/2)
            float shortSide = (float)Math.Sqrt(halfD * halfD + halfd * halfd);

            // Lados largos: también forman triángulos rectángulos, mismos cálculos si simétrico
            // Para un deltoide simétrico como el de tu dibujo, ambos pares se calculan igual
            float longSide = shortSide; // Aquí puedes personalizar si tus lados no son iguales

            perimeter = 2 * shortSide + 2 * longSide;
        }


        // Muestra resultados
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString("0.00");
            txtArea.Text = area.ToString("0.00");
        }

        // Dibuja el rombo (deltoide) usando sólo las diagonales
        public void PlotShape(PictureBox canvas)
        {
            graphic = canvas.CreateGraphics();
            graphic.Clear(canvas.BackColor);

            float scaledMajor = majorDiagonal * SCALE_FACTOR;
            float scaledMinor = minorDiagonal * SCALE_FACTOR;

            // Centro del PictureBox
            PointF center = new PointF(canvas.Width / 2f, canvas.Height / 2f);

            // Puntos extremos de las diagonales (para calcular los vértices)
            PointF top = new PointF(center.X, center.Y - scaledMajor / 2);
            PointF bottom = new PointF(center.X, center.Y + scaledMajor);
            PointF left = new PointF(center.X - scaledMinor/3, center.Y);
            PointF right = new PointF(center.X + scaledMinor/3 , center.Y);

            // Dibuja sólo los 4 lados exteriores del deltoide
            graphic.DrawLine(pen, top, left);
            graphic.DrawLine(pen, left, bottom);
            graphic.DrawLine(pen, bottom, right);
            graphic.DrawLine(pen, right, top);
        }


        // Reinicia todo
        public void InitializeData(TextBox txtMajorDiagonal, TextBox txtMinorDiagonal,
                                   TextBox txtPerimeter, TextBox txtArea,
                                   PictureBox canvas)
        {
            majorDiagonal = 0;
            minorDiagonal = 0;
            perimeter = 0;
            area = 0;

            txtMajorDiagonal.Text = "";
            txtMinorDiagonal.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";

            txtMajorDiagonal.Focus();
            canvas.Refresh();
        }

        // Cierra el formulario
        public void CloseForm(Form form)
        {
            form.Close();
        }
    }
}
