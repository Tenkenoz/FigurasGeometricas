using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmSemicircle : Form
    {
        Semicircle objSemicircle = new Semicircle();

        private static FrmSemicircle instance;
        public static FrmSemicircle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmSemicircle();
                }
                return instance;
            }
        }

        public FrmSemicircle()
        {
            InitializeComponent();
            txtRadius.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para el radio
            if (string.IsNullOrWhiteSpace(txtRadius.Text))
            {
                MessageBox.Show("Por favor ingrese el radio del semicírculo", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRadius.Focus();
                return;
            }

            if (!float.TryParse(txtRadius.Text, out float radius) || radius <= 0)
            {
                MessageBox.Show("El radio debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadius.SelectAll();
                txtRadius.Focus();
                return;
            }

            // Si pasa la validación, ejecutar cálculos
            objSemicircle.ReadData(txtRadius);
            objSemicircle.CalculateArea();
            objSemicircle.CalculatePerimeter();
            objSemicircle.PrintData(txtPerimeter, txtArea);
            objSemicircle.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objSemicircle.CloseForm(this);
        }

        private void lblRadio_Click(object sender, EventArgs e)
        {
            // Evento vacío
        }
    }
}