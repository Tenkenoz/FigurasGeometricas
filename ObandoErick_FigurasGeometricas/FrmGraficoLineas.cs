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
    public partial class FrmGraficoLineas : Form
    {
        GraficoLineas mGraficoLineas = new GraficoLineas();

        private static FrmGraficoLineas instance;
        public static FrmGraficoLineas Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmGraficoLineas();
                }
                return instance;
            }
        }
        public FrmGraficoLineas()
        {
            InitializeComponent();
        }

        private void lblGraphic_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                float x = e.X;
                float y = e.Y;
            }

            mGraficoLineas.PlotShape(picCanvas, e.X, e.Y);
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            mGraficoLineas.InitializeData(picCanvas);
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            mGraficoLineas.CloseForm(this);
        }
    }
}
