using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class clsRectangulo
    {
        private PointF mPointInicial;
        private PointF mPointFinal;
        private PointF mP1;
        private PointF mP2;
        private Graphics mGraph;
        private const float facEscala = 25;
        private Pen myPen;

        float ancho, alto, mWidht,mHeight, mcX, mcY;

        public clsRectangulo()
        {
            mPointInicial.X = 0; 
            mPointInicial.Y=0;
            mPointFinal = new Point(0,0);
        }

        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            myPen = new Pen(Color.Black, 2);
            mWidht = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidht / 2;
            mcY = mHeight/ 2;

            mGraph.DrawLine(myPen, 0, mcY, mWidht, mcY);
            mGraph.DrawLine(myPen, mcX, 0, mcX, mHeight);
        }

        public void ReadPointI(TextBox txtXi, TextBox txtYi)
        {
            mPointInicial.X = float.Parse(txtXi.Text);
            mPointInicial.Y = float.Parse(txtYi.Text);
        }
        public void ReadPointF(TextBox txtXf, TextBox txtYf)
        {
            mPointFinal.X = float.Parse(txtXf.Text);
            mPointFinal.Y = float.Parse(txtYf.Text);
        }
        public void DrawRectangulo(PictureBox picCanvas, TextBox txtArea, TextBox txtPerimetro)
        {
            mGraph=picCanvas.CreateGraphics();
            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

            myPen = new Pen(rColor,3);

            ancho = CalAncho(mPointInicial,mPointFinal);

            alto = CalAlto(mPointInicial,mPointFinal);

            mP1.X = mPointFinal.X - ancho;
            mP1.Y = mPointFinal.Y;

            mP2.X = mPointFinal.X;
            mP2.Y = mPointFinal.Y-alto;

            Console.WriteLine(mPointInicial);
            Console.WriteLine(mPointFinal);
            Console.WriteLine(mP1);
            Console.WriteLine(mP2);

            mGraph.DrawLine(myPen, ConvGrafico(mPointInicial), ConvGrafico(mP2));
            mGraph.DrawLine(myPen, ConvGrafico(mP2), ConvGrafico(mPointFinal));
            mGraph.DrawLine(myPen, ConvGrafico(mPointFinal), ConvGrafico(mP1));
            mGraph.DrawLine(myPen, ConvGrafico(mP1), ConvGrafico(mPointInicial));

            txtArea.Text = CalArea(ancho, alto).ToString();
            txtPerimetro.Text = CalPerimetro(ancho, alto).ToString();


        }

        
        public PointF ConvPunto(PointF mPoint)
        {
            float pX = (mPoint.X / 25) - 10;
            float pY = -(mPoint.Y / 25) + 10;
            PointF aux = new PointF(pX, pY);
            return (aux);

        }
        public float CalAncho(PointF mPointInicial, PointF mPointFinal)
        {
            ancho = mPointFinal.X - mPointInicial.X;
            return ancho;
        }
        public float CalAlto(PointF mPointInicial, PointF mPointFinal)
        {
            alto = mPointFinal.Y - mPointInicial.Y;
            return alto;
        }
        public float CalArea(float ancho, float alto)
        {
            float area = ancho * alto;
            return area;
        }
        public float CalPerimetro(float ancho, float alto)
        {
            float perimetro = (2*ancho) + (2*alto);
            return perimetro;
        }
        public PointF ConvGrafico(PointF mPoint)
        {
            PointF aux = new PointF(0, 0);
            aux.X = facEscala * mPoint.X + mcX;
            aux.Y = mcY-facEscala * mPoint.Y ;
            return aux;
        }
    }
}
