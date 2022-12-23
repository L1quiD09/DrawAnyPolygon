using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class clsTriangulo
    {
        private PointF mPointInicial;
        private PointF mPointFinal;
        private PointF mP1;
        private PointF mP2;
        private Graphics mGraph;
        private const float facEscala = 25;
        private Pen myPen;

        float altura, mWidht,mHeight, mcX, mcY;

        public clsTriangulo()
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
        public void DrawTriangulo(PictureBox picCanvas, TextBox txtArea, TextBox txtPerimetro)
        {
            mGraph=picCanvas.CreateGraphics();
            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            
            myPen = new Pen(rColor,3);
            PointF vector = new PointF();
            vector.X = mPointFinal.X-mPointInicial.X;
            vector.Y = mPointFinal.Y - mPointInicial.Y;
            float lado = CalMagnitude(vector);
            float altura = CalAltura(lado);
            PointF pointAltura = PointAltura(vector, altura);
      
            float X = mPointInicial.X+(mPointFinal.X-mPointInicial.X)/2 + pointAltura.X;
            float Y = mPointInicial.Y+((mPointFinal.Y - mPointInicial.Y)/2) + pointAltura.Y;

            mP1.X = X;
            mP1.Y = Y;


            Console.WriteLine(pointAltura);
            Console.WriteLine(mPointInicial);
            Console.WriteLine(mPointFinal);
            Console.WriteLine(mP1);
            Console.WriteLine(lado);
            Console.WriteLine(altura);

            mGraph.DrawLine(myPen, ConvGrafico(mPointInicial), ConvGrafico(mPointFinal));
            mGraph.DrawLine(myPen, ConvGrafico(mPointFinal), ConvGrafico(mP1));
            mGraph.DrawLine(myPen, ConvGrafico(mP1), ConvGrafico(mPointInicial));

            txtArea.Text = CalArea(lado, altura).ToString();
            txtPerimetro.Text = CalPerimetro(lado).ToString();
            


        }

        
        public PointF ConvPunto(PointF mPoint)
        {
            float pX = (mPoint.X / 25) - 10;
            float pY = -(mPoint.Y / 25) + 10;
            PointF aux = new PointF(pX, pY);
            return (aux);

        }

        public PointF PointAltura(PointF mPoint, float altura)
        {
            PointF vecPerpendicular = new PointF();
            vecPerpendicular.X = -mPoint.Y;
            vecPerpendicular.Y = mPoint.X;
            float magVecPer = CalMagnitude(vecPerpendicular);
            vecPerpendicular.X = altura*(vecPerpendicular.X/magVecPer);
            vecPerpendicular.Y = altura*(vecPerpendicular.Y/magVecPer);
            return vecPerpendicular;
        }
        public float CalMagnitude(PointF mPoint)
        {
            double lado = Math.Sqrt(Math.Pow(mPoint.X, 2) + Math.Pow(mPoint.Y , 2));
            return (float)(lado);

        }
        public float CalAltura(float lado)
        {

            double altura = (Math.Sqrt(3)*lado)/2;
            return (float) altura;
        }
        public float CalArea(float lado, float alto)
        {
            float area = (lado * alto)/2;
            return area;
        }
        public float CalPerimetro(float lado)
        {
            float perimetro = 3*lado;
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
