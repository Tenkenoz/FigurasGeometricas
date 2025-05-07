using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmRhombus : Form
    {
        Rhombus objRhombus = new Rhombus();

        private static FrmRhombus instance;
        public static FrmRhombus Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRhombus();
                }
                return instance;
            }
        }

        public FrmRhombus()
        {
            InitializeComponent();
            txtMajorDiagonal.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para diagonal mayor
            if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text))
            {
                MessageBox.Show("Por favor ingrese la diagonal mayor", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMajorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMajorDiagonal.Text, out float majorDiagonal) || majorDiagonal <= 0)
            {
                MessageBox.Show("La diagonal mayor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Validación para diagonal menor
            if (string.IsNullOrWhiteSpace(txtMinorDiagonal.Text))
            {
                MessageBox.Show("Por favor ingrese la diagonal menor", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMinorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMinorDiagonal.Text, out float minorDiagonal) || minorDiagonal <= 0)
            {
                MessageBox.Show("La diagonal menor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinorDiagonal.SelectAll();
                txtMinorDiagonal.Focus();
                return;
            }

            // Validación que diagonal mayor sea mayor que diagonal menor
            if (majorDiagonal <= minorDiagonal)
            {
                MessageBox.Show("La diagonal mayor debe ser mayor que la diagonal menor", "Relación inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Si pasa todas las validaciones, ejecutar cálculos
            objRhombus.ReadData(txtMajorDiagonal, txtMinorDiagonal);
            objRhombus.CalculateArea();
            objRhombus.CalculatePerimeter();
            objRhombus.PrintData(txtPerimeter, txtArea);
            objRhombus.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objRhombus.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objRhombus.CloseForm(this);
        }
    }
}