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
    public partial class FrmTrapeze : Form
    {
        public FrmTrapeze()
        {
            InitializeComponent();
        }
        Trapeze objTrapeze = new Trapeze();
        // Singleton pattern
        private static FrmTrapeze instance;
        public static FrmTrapeze Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmTrapeze();
                }
                return instance;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objTrapeze.ReadData(txtMajorDiagonal, txtMinorDiagonal, txtHeight);
            objTrapeze.CalculateArea();
            objTrapeze.CalculatePerimeter();
            objTrapeze.PrintData(txtPerimeter, txtArea);
            objTrapeze.PlotShape(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objTrapeze.InitializeData(txtMajorDiagonal, txtMinorDiagonal, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objTrapeze.CloseForm(this);
        }
    }
}
