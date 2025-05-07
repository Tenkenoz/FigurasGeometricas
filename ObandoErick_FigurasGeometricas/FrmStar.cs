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
    public partial class FrmStar : Form
    {
        public FrmStar()
        {
            InitializeComponent();
        }
        Star objStar = new Star();
        // Singleton pattern
        private static FrmStar instance;
        public static FrmStar Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmStar();
                }
                return instance;
            }
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objStar.ReadData(txtRadio);
            objStar.CalculateArea();
            objStar.CalculatePerimeter();
            objStar.CalculateVertices();
            objStar.PrintData(txtPerimeter, txtArea);
            objStar.PlotShape(picCanvas);


        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objStar.InitializeData(txtRadio, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objStar.CloseForm(this);
        }
    }
}
