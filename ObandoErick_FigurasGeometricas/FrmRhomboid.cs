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
    public partial class FrmRhomboid : Form
    {
        public FrmRhomboid()
        {
            InitializeComponent();
        }
        Rhomboid objRhomboid = new Rhomboid();
        private static FrmRhomboid instance;
        public static FrmRhomboid Instance {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRhomboid();
                }
                return instance;
            }
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
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
