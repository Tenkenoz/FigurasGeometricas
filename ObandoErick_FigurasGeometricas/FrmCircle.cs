using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmCircle : Form
    {
        // Declaración de variables
        Circle ObjCircle = new Circle();

        private static FrmCircle instance;
        public static FrmCircle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmCircle();
                }
                return instance;
            }
        }

        public FrmCircle()
        {
            InitializeComponent();
            txtRadio.Focus();
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            ObjCircle.InitializeData(txtRadio, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            ObjCircle.CloseForm(this);
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            // Validación 1: Campo vacío
            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Debe ingresar el radio del círculo", "Dato faltante");
                txtRadio.Focus();
                return;
            }

            // Validación 2: Formato numérico
            if (!float.TryParse(txtRadio.Text, out float radius))
            {
                MessageBox.Show("El radio debe ser un valor numérico", "Formato incorrecto");
                txtRadio.SelectAll();
                txtRadio.Focus();
                return;
            }

            // Validación 3: Valor positivo
            if (radius <= 0)
            {
                MessageBox.Show("El radio debe ser mayor que cero", "Valor inválido");
                txtRadio.SelectAll();
                txtRadio.Focus();
                return;
            }

            // Si pasa las validaciones, ejecutar la lógica original
            ObjCircle.ReadData(txtRadio);
            ObjCircle.CalculatePerimeter();
            ObjCircle.CalculateArea();
            ObjCircle.PrintData(txtPerimeter, txtArea);
            ObjCircle.PlotShape(picCanvas);
        }

        // Event handlers vacíos
        private void lblSide_Click(object sender, EventArgs e) { }
        private void txtPerimeter_TextChanged(object sender, EventArgs e) { }
        private void txtArea_TextChanged(object sender, EventArgs e) { }
        private void txtSide_TextChanged(object sender, EventArgs e) { }
        private void Area_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void picCanvas_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
