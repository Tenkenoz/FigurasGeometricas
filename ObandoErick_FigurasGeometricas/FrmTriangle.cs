using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmTriangle : Form
    {
        Triangle ObjTriangle = new Triangle();

        private static FrmTriangle instance;
        public static FrmTriangle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTriangle();
                }
                return instance;
            }
        }

        public FrmTriangle()
        {
            InitializeComponent();
            txtSide1.Focus();
        }

        private void txtCalculate_Click_1(object sender, EventArgs e)
        {
            // Validación para lado 1
            if (!ValidateSide(txtSide1, "lado 1")) return;

            // Validación para lado 2
            if (!ValidateSide(txtSide2, "lado 2")) return;

            // Validación para lado 3
            if (!ValidateSide(txtSide3, "lado 3")) return;

            // Obtener valores numéricos
            float side1 = float.Parse(txtSide1.Text);
            float side2 = float.Parse(txtSide2.Text);
            float side3 = float.Parse(txtSide3.Text);

            // Validación de desigualdad triangular
            if (!IsValidTriangle(side1, side2, side3))
            {
                MessageBox.Show("Los lados no forman un triángulo válido.\nLa suma de dos lados debe ser mayor que el tercero.",
                              "Triángulo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si pasa todas las validaciones, ejecutar cálculos
            ObjTriangle.ReadData(txtSide1, txtSide2, txtSide3);
            ObjTriangle.CalculatePerimeter();
            ObjTriangle.CalculateArea();
            ObjTriangle.PrintData(txtPerimeter, txtArea);
            ObjTriangle.PlotShape(picCanvas);
        }

        private bool ValidateSide(TextBox textBox, string sideName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"Por favor ingrese el {sideName} del triángulo", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            if (!float.TryParse(textBox.Text, out float side) || side <= 0)
            {
                MessageBox.Show($"El {sideName} debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }

            return true;
        }

        private bool IsValidTriangle(float a, float b, float c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        private void txtReset_Click_1(object sender, EventArgs e)
        {
            ObjTriangle.InitializeData(txtSide1, txtSide2, txtSide3, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click_1(object sender, EventArgs e)
        {
            ObjTriangle.CloseForm(this);
        }

        private void lblGraphic_Click(object sender, EventArgs e)
        {
            // Evento vacío
        }
    }
}
