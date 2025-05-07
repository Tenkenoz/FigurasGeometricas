using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmRhomboid : Form
    {
        Rhomboid objRhomboid = new Rhomboid();

        private static FrmRhomboid instance;
        public static FrmRhomboid Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRhomboid();
                }
                return instance;
            }
        }

        public FrmRhomboid()
        {
            InitializeComponent();
            txtBase.Focus();
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación para la base
            if (string.IsNullOrWhiteSpace(txtBase.Text))
            {
                MessageBox.Show("Por favor ingrese la base del romboide", "Dato faltante",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBase.Focus();
                return;
            }

            if (!float.TryParse(txtBase.Text, out float baseValue) || baseValue <= 0)
            {
                MessageBox.Show("La base debe ser un número positivo", "Dato inválido",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBase.SelectAll();
                txtBase.Focus();
                return;
            }

            // Validación para la altura
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Por favor ingrese la altura del romboide", "Dato faltante",
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

            // Validación para el lado
            if (string.IsNullOrWhiteSpace(txtSide.Text))
            {
                MessageBox.Show("Por favor ingrese el lado del romboide", "Dato faltante",
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

            // Validación que el lado sea mayor o igual a la altura
            if (side < height)
            {
                MessageBox.Show("El lado debe ser mayor o igual a la altura", "Relación inválida",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSide.SelectAll();
                txtSide.Focus();
                return;
            }

            // Si pasa todas las validaciones, ejecutar cálculos
            objRhomboid.ReadData(txtBase, txtHeight, txtSide);
            objRhomboid.CalculateArea();
            objRhomboid.CalculatePerimeter();
            objRhomboid.PrintData(txtPerimeter, txtArea);
            objRhomboid.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objRhomboid.InitializeData(txtBase, txtHeight, txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objRhomboid.CloseForm(this);
        }
    }
}