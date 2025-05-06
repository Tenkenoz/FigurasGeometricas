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
    public partial class FrmSquare : Form
    {
        //Declaracion de variables
        Square ObjSquare = new Square();
        public FrmSquare()
        {
            InitializeComponent();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReset_Click(object sender, EventArgs e)
        {
           ObjSquare.InitializeData(txtSide, txtPerimeter, txtArea,picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            ObjSquare.CloseForm(this);
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            ObjSquare.ReadData(txtSide);
            ObjSquare.CalculatePerimeter();
            ObjSquare.CalculateArea();
            ObjSquare.PrintData(txtPerimeter, txtArea);
            ObjSquare.PlotShape(picCanvas);

        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void width_Click(object sender, EventArgs e)
        {

        }

        private void Area_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Height_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
