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
    public partial class FrmTrapezoid : Form
    {
        public FrmTrapezoid()
        {
            InitializeComponent();
        }

        Trapezoid objTrapezoid = new Trapezoid();
        // Singleton pattern
        private static FrmTrapezoid instance;
        public static FrmTrapezoid Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapezoid();
                }
                return instance;
            }
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objTrapezoid.ReadData(txtX1,txtY1, txtX2, txtY2, txtX3, txtY3, txtX4, txtY4);
            objTrapezoid.CalculateArea();
            objTrapezoid.CalculatePerimeter();
            objTrapezoid.PrintData(txtPerimeter, txtArea);
            objTrapezoid.PlotShape(picCanvas);


        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objTrapezoid.InitializeData(txtX1, txtY1, txtX2, txtY2, txtX3, txtY3, txtX4, txtY4, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objTrapezoid.CloseForm(this);
        }
    }
}
