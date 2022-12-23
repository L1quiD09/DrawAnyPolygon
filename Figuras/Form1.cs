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
    public partial class Form1 : Form
    { 
        clsRectangulo Rec1 = new clsRectangulo();
        clsTriangulo Tri1 = new clsTriangulo();
        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPerimetro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDrawAxis_Click(object sender, EventArgs e)
        {
            Rec1.DrawAxis(picCanvas);
            Tri1.DrawAxis(picCanvas);
        }

        private void btnDrawRec_Click(object sender, EventArgs e)
        {
            Rec1.ReadPointI(txtXi, txtYi);

            Rec1.ReadPointF(txtXf, txtYf);
            Rec1.DrawRectangulo(picCanvas, txtArea, txtPerimetro);
        }

        private void btnDrawTri_Click(object sender, EventArgs e)
        {
            Tri1.ReadPointI(txtTXi, txtTYi);

            Tri1.ReadPointF(txtTXf, txtTYf);
            Tri1.DrawTriangulo(picCanvas, txtAreaT, txtPerimetroT);
        }
    }
}
