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
    public partial class FrmTriangle : Form
    {
        //Declaracion de variables
        Triangle Objtriangle = new Triangle();
        private static FrmTriangle instance;
        public static FrmTriangle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTriangle();
                }
                return instance;
            }
        }
        public FrmTriangle()
        {
            InitializeComponent();
        }


        private void txtCalculate_Click_1(object sender, EventArgs e)
        {
            Objtriangle.ReadData(txtSide1, txtSide2, txtSide3);
            Objtriangle.CalculatePerimeter();
            Objtriangle.CalculateArea();
            Objtriangle.PrintData(txtPerimeter, txtArea);
            Objtriangle.PlotShape(picCanvas);
        }

        private void txtReset_Click_1(object sender, EventArgs e)
        {
            Objtriangle.InitializeData(txtSide1, txtSide2, txtSide3, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click_1(object sender, EventArgs e)
        {
            Objtriangle.CloseForm(this);
        }
    }
}
