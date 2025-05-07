using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmEllipse : Form
    {
        Ellipse objEllipse = new Ellipse();

        private static FrmEllipse instance;
        public static FrmEllipse Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmEllipse();
                }
                return instance;
            }
        }

        public FrmEllipse()
        {
            InitializeComponent();
            txtSemiMajorAxis.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación eje semi-mayor
            if (string.IsNullOrWhiteSpace(txtSemiMajorAxis.Text))
            {
                MessageBox.Show("Por favor ingrese el valor del eje semi-mayor", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSemiMajorAxis.Focus();
                return;
            }

            if (!float.TryParse(txtSemiMajorAxis.Text, out float semiMayor) || semiMayor <= 0)
            {
                MessageBox.Show("El eje semi-mayor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSemiMajorAxis.SelectAll();
                txtSemiMajorAxis.Focus();
                return;
            }

            // Validación eje semi-menor
            if (string.IsNullOrWhiteSpace(txtSemiMinorAxis.Text))
            {
                MessageBox.Show("Por favor ingrese el valor del eje semi-menor", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSemiMinorAxis.Focus();
                return;
            }

            if (!float.TryParse(txtSemiMinorAxis.Text, out float semiMenor) || semiMenor <= 0)
            {
                MessageBox.Show("El eje semi-menor debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSemiMinorAxis.SelectAll();
                txtSemiMinorAxis.Focus();
                return;
            }

            // Validación relación entre ejes
            if (semiMayor <= semiMenor)
            {
                MessageBox.Show("El eje semi-mayor debe ser mayor que el eje semi-menor", "Relación inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSemiMajorAxis.SelectAll();
                txtSemiMajorAxis.Focus();
                return;
            }

            // Si pasan todas las validaciones
            objEllipse.ReadData(txtSemiMajorAxis, txtSemiMinorAxis);
            objEllipse.CalculateArea();
            objEllipse.CalculatePerimeter();
            objEllipse.PrintData(txtPerimeter, txtArea);
            objEllipse.DrawEllipse(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objEllipse.InitializeData(txtSemiMajorAxis, txtSemiMinorAxis, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objEllipse.CloseForms(this);
        }

        // Eventos vacíos
        private void fontDialog1_Apply(object sender, EventArgs e) {
        }
        private void groupBox1_Enter(object sender, EventArgs e) { 
        }
        private void lblProcess_Click(object sender, EventArgs e) {
        }
        private void lblRadio_Click(object sender, EventArgs e) {
        }
        private void label4_Click(object sender, EventArgs e) {
        }
    }
}