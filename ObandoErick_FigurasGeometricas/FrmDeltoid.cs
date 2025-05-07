using System;
using System.Drawing;
using System.Windows.Forms;
using ObandoErick_GeometricFigures;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmDeltoid : Form
    {
        Deltoid objDeltoid = new Deltoid();

        private static FrmDeltoid instance;
        public static FrmDeltoid Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmDeltoid();
                }
                return instance;
            }
        }

        public FrmDeltoid()
        {
            InitializeComponent();
            txtMajorDiagonal.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para diagonal mayor
            if (string.IsNullOrWhiteSpace(txtMajorDiagonal.Text))
            {
                MessageBox.Show("Ingrese la diagonal mayor", "Dato faltante");
                txtMajorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMajorDiagonal.Text, out float majorDiagonal) || majorDiagonal <= 0)
            {
                MessageBox.Show("La diagonal mayor debe ser un número positivo", "Dato inválido");
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Validación para diagonal menor
            if (string.IsNullOrWhiteSpace(txtMinorDiagonal.Text))
            {
                MessageBox.Show("Ingrese la diagonal menor", "Dato faltante");
                txtMinorDiagonal.Focus();
                return;
            }

            if (!float.TryParse(txtMinorDiagonal.Text, out float minorDiagonal) || minorDiagonal <= 0)
            {
                MessageBox.Show("La diagonal menor debe ser un número positivo", "Dato inválido");
                txtMinorDiagonal.SelectAll();
                txtMinorDiagonal.Focus();
                return;
            }

            // Validación que diagonal mayor sea mayor que diagonal menor
            if (majorDiagonal <= minorDiagonal)
            {
                MessageBox.Show("La diagonal mayor debe ser mayor que la diagonal menor", "Dato inválido");
                txtMajorDiagonal.SelectAll();
                txtMajorDiagonal.Focus();
                return;
            }

            // Si pasa todas las validaciones, ejecutar lógica original
            objDeltoid.ReadData(txtMajorDiagonal, txtMinorDiagonal);
            objDeltoid.CalculateArea();
            objDeltoid.CalculatePerimeter();
            objDeltoid.PrintData(txtPerimeter, txtArea);
            objDeltoid.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objDeltoid.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objDeltoid.CloseForm(this);
        }

        // Event handlers vacíos
        private void txtBase_TextChanged(object sender, EventArgs e) { }
        private void txtSideA_TextChanged(object sender, EventArgs e) { }
    }
}