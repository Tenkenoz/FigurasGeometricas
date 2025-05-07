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
    public partial class FrmSemicircle : Form

    {
        Semicircle objSemicircle = new Semicircle();
        // Singleton pattern
        private static FrmSemicircle instance;
        public static FrmSemicircle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmSemicircle();
                }
                return instance;
            }
        }
        public FrmSemicircle()
        {
            InitializeComponent();
        }

        private void lblRadio_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objSemicircle.ReadData(txtRadius);
            objSemicircle.CalculateArea();
            objSemicircle.CalculatePerimeter();
            objSemicircle.PrintData(txtPerimeter, txtArea);
            objSemicircle.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objSemicircle.InitializeData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objSemicircle.CloseForm(this);
        }
    }
}
