using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    public partial class frmCirculo : Form
    {
        clsCirculo objCircle = new clsCirculo();

        List<PointF> ListaPuntos = new List<PointF>();
        public frmCirculo()
        {
            InitializeComponent();
        }

        private void frmCirculo_Load(object sender, EventArgs e)
        {

        }

        private void btnDrawAxis_Click(object sender, EventArgs e)
        {
            objCircle.DrawAxis(picCanvas);
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            objCircle.ReadRadio(nRadio);
            objCircle.DrawCircle(picCanvas);
            objCircle.drawFigure(numericUpDownP, picCanvas);
            objCircle.DrawAxis(picCanvas);
            objCircle.CalArea();
            objCircle.CalPerimetro();
            objCircle.PrintResult(txtAreaC, txtPerimetroC);
            objCircle.obtenerPoligono(numericUpDownP);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            nRadio.Value = 1;
            txtAreaC.Text = "";
            txtPerimetroC.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            /*PointF aux = new PointF();
            aux.X = e.X;
            aux.Y = e.Y;
            objCircle.ConvPunto(aux);*/
            PointF aux = new PointF(e.X, e.Y);
            
            objCircle.ReadRadio(nRadio);
            objCircle.ConvPunto(aux); 
            objCircle.DrawCircle(picCanvas);
            
            
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }
    }
}
