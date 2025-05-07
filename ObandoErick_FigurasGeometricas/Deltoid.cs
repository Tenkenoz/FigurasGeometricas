using System.Drawing;
using System.Windows.Forms;

namespace ObandoErick_GeometricFigures
{
        internal class Deltoid
        {
            // Attributes
            private float sideA;
            private float sideB;
            private float majorDiagonal;
            private float minorDiagonal;
            private float perimeter;
            private float area;
            private Graphics graphic;
            private Pen pen;
            private const float SCALE_FACTOR = 20;

            // Constructor
            public Deltoid()
            {
                sideA = 0.0f;
                sideB = 0.0f;
                majorDiagonal = 0.0f;
                minorDiagonal = 0.0f;
                perimeter = 0.0f;
                area = 0.0f;
                pen = new Pen(Color.DarkGreen, 2);
            }

            // Method to read data from TextBoxes
            public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtMajorDiagonal, TextBox txtMinorDiagonal)
            {
                try
                {
                    sideA = float.Parse(txtSideA.Text);
                    sideB = float.Parse(txtSideB.Text);
                    majorDiagonal = float.Parse(txtMajorDiagonal.Text);
                    minorDiagonal = float.Parse(txtMinorDiagonal.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid input values. Please enter valid numbers.", "Input Error");
                }
            }

            // Calculate area: (MajorDiagonal * MinorDiagonal)/2
            public void CalculateArea()
            {
                area = (majorDiagonal * minorDiagonal) / 2;
            }

            // Calculate perimeter: 2 * (SideA + SideB)
            public void CalculatePerimeter()
            {
                perimeter = 2 * (sideA + sideB);
            }

            // Display results in the TextBoxes
            public void PrintData(TextBox txtPerimeter, TextBox txtArea)
            {
                txtPerimeter.Text = perimeter.ToString("0.00");
                txtArea.Text = area.ToString("0.00");
            }

            // Draw the kite (deltoid)
            public void PlotShape(PictureBox canvas)
            {
                graphic = canvas.CreateGraphics();
                graphic.Clear(canvas.BackColor);

                // Convert real measurements to pixels
                float scaledMajorDiagonal = majorDiagonal * SCALE_FACTOR;
                float scaledMinorDiagonal = minorDiagonal * SCALE_FACTOR;

                // Calculate kite points
                PointF center = new PointF(canvas.Width / 2, canvas.Height / 2);
                PointF top = new PointF(center.X, center.Y - scaledMajorDiagonal / 2);
                PointF bottom = new PointF(center.X, center.Y + scaledMajorDiagonal / 2);
                PointF left = new PointF(center.X - scaledMinorDiagonal / 2, center.Y);
                PointF right = new PointF(center.X + scaledMinorDiagonal / 2, center.Y);

                // Connect points to form the kite
                graphic.DrawLine(pen, top, left);
                graphic.DrawLine(pen, left, bottom);
                graphic.DrawLine(pen, bottom, right);
                graphic.DrawLine(pen, right, top);
            }

            // Reset all values and drawing
            public void InitializeData(TextBox txtSideA, TextBox txtSideB, TextBox txtMajorDiagonal, TextBox txtMinorDiagonal,
                                       TextBox txtPerimeter, TextBox txtArea, PictureBox canvas)
            {
                sideA = 0.0f;
                sideB = 0.0f;
                majorDiagonal = 0.0f;
                minorDiagonal = 0.0f;
                perimeter = 0.0f;
                area = 0.0f;

                txtSideA.Text = "";
                txtSideB.Text = "";
                txtMajorDiagonal.Text = "";
                txtMinorDiagonal.Text = "";
                txtPerimeter.Text = "";
                txtArea.Text = "";

                txtSideA.Focus();
                canvas.Refresh();
            }

            // Method to close the form
            public void CloseForm(Form form)
            {
                form.Close();
            }
        }
    }


