using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmRectangle : Form
    {
        //Declaracion de variables
        Rectangle ObjRectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void FrmRectangle_Load(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            ObjRectangle.ReadData(txtWidth, txtHeight);

            // Calcular el perímetro y el área
            ObjRectangle.CalculatePerimeter();
            ObjRectangle.CalculateArea();

            // Imprimir los resultados en los TextBox correspondientes
            ObjRectangle.PrintData(txtPerimeter, txtArea);

            // Graficar el rectángulo en el PictureBox
            ObjRectangle.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase Rectangle
            Rectangle rect = new Rectangle();

            // Inicializar los datos y controles
            ObjRectangle.InitializeData(txtWidth, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            ObjRectangle.CloseForm(this);
        }
    }
}
