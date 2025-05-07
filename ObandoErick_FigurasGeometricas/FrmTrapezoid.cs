using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmTrapezoid : Form
    {
        Trapezoid objTrapezoid = new Trapezoid();

        private static FrmTrapezoid instance;
        public static FrmTrapezoid Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapezoid();
                }
                return instance;
            }
        }

        public FrmTrapezoid()
        {
            InitializeComponent();
            txtX1.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación de coordenadas X
            if (!ValidateCoordinate(txtX1, "X1") || !ValidateCoordinate(txtX2, "X2") ||
                !ValidateCoordinate(txtX3, "X3") || !ValidateCoordinate(txtX4, "X4"))
                return;

            // Validación de coordenadas Y
            if (!ValidateCoordinate(txtY1, "Y1") || !ValidateCoordinate(txtY2, "Y2") ||
                !ValidateCoordinate(txtY3, "Y3") || !ValidateCoordinate(txtY4, "Y4"))
                return;

            // Si pasa todas las validaciones, ejecutar cálculos
            objTrapezoid.ReadData(txtX1, txtY1, txtX2, txtY2, txtX3, txtY3, txtX4, txtY4);
            objTrapezoid.CalculateArea();
            objTrapezoid.CalculatePerimeter();
            objTrapezoid.PrintData(txtPerimeter, txtArea);
            objTrapezoid.PlotShape(picCanvas);
        }

        private bool ValidateCoordinate(TextBox textBox, string coordinateName)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show($"Por favor ingrese la coordenada {coordinateName}", "Dato faltante",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }

            if (!float.TryParse(textBox.Text, out _))
            {
                MessageBox.Show($"La coordenada {coordinateName} debe ser un número válido", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                return false;
            }

            return true;
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtX1, txtY1, txtX2, txtY2, txtX3, txtY3, txtX4, txtY4,
                                       txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objTrapezoid.CloseForm(this);
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            // Evento vacío
        }
    }
}