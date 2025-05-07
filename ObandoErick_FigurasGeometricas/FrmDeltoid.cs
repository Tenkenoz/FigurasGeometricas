using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObandoErick_GeometricFigures;

namespace ObandoErick_FigurasGeometricas
{
    public partial class FrmDeltoid : Form
    {
        public FrmDeltoid()
        {
            InitializeComponent();
        }

        Deltoid objDeltoid = new Deltoid();
        // Singleton pattern
        private static FrmDeltoid instance;
        public static FrmDeltoid Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmDeltoid();
                }
                return instance;
            }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            objDeltoid.InitializeData(txtSideA, txtSideB, txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objDeltoid.ReadData(txtSideA, txtSideB,txtMajorDiagonal,txtMinorDiagonal);
            objDeltoid.CalculateArea();
            objDeltoid.CalculatePerimeter();
            objDeltoid.PrintData(txtPerimeter, txtArea);
            objDeltoid.PlotShape(picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objDeltoid.CloseForm(this);
        }

        private void txtSideA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
