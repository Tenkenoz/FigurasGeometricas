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
    public partial class FrmEllipse : Form
    {
        Ellipse objEllipse = new Ellipse();
        // Singleton pattern
        private static FrmEllipse instance;
        public static FrmEllipse Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmEllipse();
                }
                return instance;
            }
        }
        public FrmEllipse()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblProcess_Click(object sender, EventArgs e)
        {

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCalculate_Click(object sender, EventArgs e)
        {
            objEllipse.ReadData(txtSemiMajorAxis, txtSemiMinorAxis);
            objEllipse.CalculateArea();
            objEllipse.CalculatePerimeter();
            objEllipse.PrintData(txtPerimeter, txtArea);
            objEllipse.DrawEllipse(picCanvas);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            objEllipse.InitializeData(txtSemiMajorAxis, txtSemiMinorAxis, txtPerimeter, txtArea, picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            objEllipse.CloseForms(this);
        }
    }
}
