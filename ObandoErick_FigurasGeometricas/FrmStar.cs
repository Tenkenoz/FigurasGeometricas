using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmStar : Form
    {
        Star objStar = new Star();

        private static FrmStar instance;
        public static FrmStar Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmStar();
                }
                return instance;
            }
        }

        public FrmStar()
        {
            InitializeComponent();
            txtRadio.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para el radio de la estrella
            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Por favor ingrese el radio de la estrella", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRadio.Focus();
                return;
            }

            if (!float.TryParse(txtRadio.Text, out float radius) || radius <= 0)
            {
                MessageBox.Show("El radio debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadio.SelectAll();
                txtRadio.Focus();
                return;
            }

            // Validación de rango máximo (opcional)
            const float maxRadius = 500;
            if (radius > maxRadius)
            {
                MessageBox.Show($"El radio no puede ser mayor que {maxRadius}", "Valor excedido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRadio.SelectAll();
                txtRadio.Focus();
                return;
            }

            // Si pasa las validaciones, ejecutar cálculos
            objStar.ReadData(txtRadio);
            objStar.CalculateArea();
            objStar.CalculatePerimeter();
            objStar.CalculateVertices();
            objStar.PrintData(txtPerimeter, txtArea);
            objStar.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objStar.InitializeData(txtRadio, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objStar.CloseForm(this);
        }
    }
}