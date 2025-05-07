using System;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmRectangle : Form
    {
        Rectangle ObjRectangle = new Rectangle();

        private static FrmRectangle instance;
        public static FrmRectangle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRectangle();
                }
                return instance;
            }
        }

        public FrmRectangle()
        {
            InitializeComponent();
            txtWidth.Focus();
        }

        private void txtCalculate_Click_1(object sender, EventArgs e)
        {
            // Validación para el ancho
            if (string.IsNullOrWhiteSpace(txtWidth.Text))
            {
                MessageBox.Show("Por favor ingrese el ancho del rectángulo", "Dato faltante",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWidth.Focus();
                return;
            }

            if (!float.TryParse(txtWidth.Text, out float width) || width <= 0)
            {
                MessageBox.Show("El ancho debe ser un número positivo", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtWidth.SelectAll();
                txtWidth.Focus();
                return;
            }

            // Validación para el alto
            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Por favor ingrese el alto del rectángulo", "Dato faltante",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus();
                return;
            }

            if (!float.TryParse(txtHeight.Text, out float height) || height <= 0)
            {
                MessageBox.Show("El alto debe ser un número positivo", "Dato inválido",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.SelectAll();
                txtHeight.Focus();
                return;
            }

            // Ejecutar cálculos si las validaciones son correctas
            ObjRectangle.ReadData(txtWidth, txtHeight);
            ObjRectangle.CalculatePerimeter();
            ObjRectangle.CalculateArea();
            ObjRectangle.PrintData(txtPerimeter, txtArea);
            ObjRectangle.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click_1(object sender, EventArgs e)
        {
            ObjRectangle.CloseForm(this);
        }

        // Event handlers vacíos
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label1_Click_2(object sender, EventArgs e) { }
        private void FrmRectangle_Load(object sender, EventArgs e) { }
    }
}