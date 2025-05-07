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
    public partial class FrmRhombus : Form
    {
        public FrmRhombus()
        {
            InitializeComponent();
        }
        Rhombus objRhombus = new Rhombus();
        // Singleton pattern
        private static FrmRhombus instance;
        public static FrmRhombus Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRhombus();
                }
                return instance;
            }
        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objRhombus.ReadData(txtMajorDiagonal, txtMinorDiagonal);
            objRhombus.CalculateArea();
            objRhombus.CalculatePerimeter();
            objRhombus.PrintData(txtPerimeter, txtArea);
            objRhombus.PlotShape(picCanvas);

        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objRhombus.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objRhombus.CloseForm(this);
        }
    }
}
