using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras
{
    internal class clsCirculo
    {
        private float radio;
        private double area;
        private double perimetro;
        private PointF pC;
        private Graphics mGraph;
        private const float facEscala = 25;
        private Pen myPen;

        float mWidht, mHeight, mcX, mcY;

        List<PointF> ListaPuntos = new List<PointF>();

        public clsCirculo()
        {
            radio = 0;
        }

        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            myPen = new Pen(Color.Black, 2);
            mWidht = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidht / 2;
            mcY = mHeight / 2;

            mGraph.DrawLine(myPen, 0, mcY, mWidht, mcY);
            mGraph.DrawLine(myPen, mcX, 0, mcX, mHeight);
        }

        public void ReadRadio(NumericUpDown nRadio)
        {
            radio = (float)nRadio.Value;
        }

        public void drawFigure(NumericUpDown nPuntos, PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();

            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

            myPen = new Pen(rColor, 3);

            mWidht = picCanvas.Width;
            mHeight = picCanvas.Height;
            mcX = mWidht / 2;
            mcY = mHeight / 2;

            float angAux = 0;
            int n = (int)nPuntos.Value;
            float anguloO = 360 / n;
            float x, y; 


            for(int i=0; i<n; i++)
            {

                //Se obtiene los puntos 
                double auxX, auxY; 


                double div = 3.141516 / 180; 

                
                auxX = (radio * Math.Cos(angAux *div)) + mcX;
                auxY = (radio * Math.Sin(angAux * div)) + mcY;
                x = (float)auxX; 
                y = (float)auxY;

                //Guarda dentro del vector de puntos
                ListaPuntos.Add(new Point((int)x, (int)y));

               
                angAux += anguloO;
            



            }

            //Se uno los puntos excepto el final y el inicial
            for (int i = 0; i < ListaPuntos.Count-1 ; i++)
            {
                
                
                mGraph.DrawLine(myPen, ListaPuntos[i], ListaPuntos[i+1]);
                
            }


            //Une los puntos finales y los iniciales

            PointF puntoFinal = ListaPuntos[ListaPuntos.Count-1];
            PointF puntoInicial = ListaPuntos[0];
            mGraph.DrawLine(myPen, puntoInicial, puntoFinal); 



        }
        public void DrawCircle(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            Random r = new Random();
            Color rColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

            myPen = new Pen(rColor, 3);

            mGraph.DrawEllipse(myPen,mcX,mcY,radio*2*facEscala,radio*2*facEscala);
            //mGraph.DrawEllipse(myPen, pC.X, pC.Y, 1, 1);
        }

        public void obtenerPoligono(NumericUpDown nPuntos)
        {
            //Imprime el nombre del poligono
            int puntos = Convert.ToInt32(nPuntos.Value);
            puntos = puntos - 3; 

            String[] nombreP = {"Triangulo", "Cuadrilatero", "Pentágono", "Hexágono", "Heptágono", "Octágono", "Eneágono", "Decágono", "Endecágono", "Dodecágono", "Tridecágono", "Tetradecágono", "Pentadecágono", "Hexadecágono", "Heptadecágono", "Octodecágono", "Eneadecágono", "Isodecágono"};


            for(int i =0; i<nombreP.Length; i++)
            {
                if(puntos == i)
                    MessageBox.Show(nombreP[i]);
            }

            int n = nombreP.Length; 

            MessageBox.Show(n.ToString()); 
            if(puntos+3 > n)
            {
                MessageBox.Show("Poligono de: " + (puntos+3) + " lados...");
            }
        }
        public void CalArea()
        {
            area = Math.PI * Math.Pow(radio, 2);
        }

        public void CalPerimetro()
        {
            perimetro = Math.PI * radio;
        }

        public void PrintResult(TextBox txtAreaC, TextBox txtPerimetroC)
        {
            txtAreaC.Text = area.ToString();
            txtPerimetroC.Text = perimetro.ToString();
        }

        public void ConvPunto(PointF mPoint)
        {
            pC = new PointF(mPoint.X,mPoint.Y);
            mcX = mPoint.X-(radio*facEscala) ;
            mcY = mPoint.Y-(radio*facEscala) ;
            
        }

    }
}
