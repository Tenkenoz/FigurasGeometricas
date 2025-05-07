using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmSquare : Form
    {
        Square ObjSquare = new Square();

        private static FrmSquare instance;
        public static FrmSquare Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmSquare();
                }
                return instance;
            }
        }

        public FrmSquare()
        {
            InitializeComponent();
            txtSide.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para el lado del cuadrado
            if (string.IsNullOrWhiteSpace(txtSide.Text))
            {
                MessageBox.Show("Por favor ingrese el lado del cuadrado", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSide.Focus();
                return;
            }

            if (!float.TryParse(txtSide.Text, out float side) || side <= 0)
            {
                MessageBox.Show("El lado debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.SelectAll();
                txtSide.Focus();
                return;
            }

            // Si pasa la validación, ejecutar cálculos
            ObjSquare.ReadData(txtSide);
            ObjSquare.CalculatePerimeter();
            ObjSquare.CalculateArea();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        // Event handlers vacíos (se mantienen)
        private void txtWidth_TextChanged(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtHeight_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }
        private void width_Click(object sender, EventArgs e) { }
        private void Area_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void Height_Click(object sender, EventArgs e) { }
        private void picCanvas_Click(object sender, EventArgs e) { }
    }
}