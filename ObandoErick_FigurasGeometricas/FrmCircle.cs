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
    public partial class FrmCircle : Form
    {
        //Declaracion de variables
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
        }

        private void lblSide_Click(object sender, EventArgs e)
        {

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
            ObjCircle.ReadData(txtRadio);
            ObjCircle.CalculatePerimeter();
            ObjCircle.CalculateArea();
            ObjCircle.PrintData(txtPerimeter, txtArea);
            ObjCircle.PlotShape(picCanvas);
        }

        private void txtPerimeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
