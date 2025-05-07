using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmTrapeze : Form
    {
        Trapeze objTrapeze = new Trapeze();

        private static FrmTrapeze instance;
        public static FrmTrapeze Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapeze();
                }
                return instance;
            }
        }

        public FrmTrapeze()
        {
            InitializeComponent();
            txtMajorDiagonal.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para diagonal mayor
            if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text))
            {
                MessageBox.Show("Por favor ingrese la base mayor del trapecio", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMajorDiagonal.Text, out float majorBase) || majorBase <= 0)
            {
                MessageBox.Show("La base mayor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Validación para diagonal menor
            if (string.IsNullOrWhiteSpace(txtMinorDiagonal.Text))
            {
                MessageBox.Show("Por favor ingrese la base menor del trapecio", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMinorDiagonal.Text, out float minorBase) || minorBase <= 0)
            {
                MessageBox.Show("La base menor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinorDiagonal.SelectAll();
                txtMinorDiagonal.Focus();
                return;
            }

            // Validación para altura
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Por favor ingrese la altura del trapecio", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }

            if (!float.TryParse(txtHeight.Text, out float height) || height <= 0)
            {
                MessageBox.Show("La altura debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.SelectAll();
                txtHeight.Focus();
                return;
            }

            // Validación que base mayor > base menor
            if (majorBase <= minorBase)
            {
                MessageBox.Show("La base mayor debe ser mayor que la base menor", "Relación inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Si pasa todas las validaciones, ejecutar cálculos
            objTrapeze.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtHeight);
            objTrapeze.CalculateArea();
            objTrapeze.CalculatePerimeter();
            objTrapeze.PrintData(txtPerimeter, txtArea);
            objTrapeze.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objTrapeze.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objTrapeze.CloseForm(this);
        }

        // Event handlers vacíos
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void lblRadio_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}