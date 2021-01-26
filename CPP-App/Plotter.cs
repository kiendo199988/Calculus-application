using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace CPP_App
{
    public class Plotter
    {
        private Graphics graphics;
        private Point origin;
        private int pixelsPerSquare;
        private int scale;
        private PictureBox pbPlot;
        //private List<PointF> integralBounds;
        

        public Plotter(Graphics g, Point origin, PictureBox pbPlot, int pixelsPerSquare, int scale)
        {
            graphics = g;
            this.origin = origin;
            this.pixelsPerSquare = pixelsPerSquare;
            this.scale = scale;
            this.pbPlot = pbPlot;
            //integralBounds = integrals;
        }

        public void PlotFunction(Function f, Pen p)
        {
            double x = 0;
            double x2 = 0;
            double y = 0;
            double y2 = 0;
            for (double i = -origin.X; i < origin.X; i++)
            {
                x = i / pixelsPerSquare;
                x2 = (i + 1) / pixelsPerSquare;
                if ((f.GetRootNode().CheckDomain(x) && f.GetRootNode().CheckDomain(x2)) == true)
                {
                    //first y-coordinate of the graph
                    y = f.GetValue(x);
                    x = origin.X + x * pixelsPerSquare * scale;
                    y = origin.Y - y * pixelsPerSquare * scale;
                    //second y-coordinate of the graph
                    y2 = f.GetValue(x2);
                    x2 = origin.X + x2 * pixelsPerSquare * scale;
                    y2 = origin.Y - y2 * pixelsPerSquare * scale;
                    //connect 2 points
                    if (Math.Abs(y) < 9999999 && Math.Abs(y2) < 9999999)
                    {
                        graphics.DrawLine(p, Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(x2), Convert.ToSingle(y2));
                        
                    }
                }
            }
            
        }      

        //plot integral
        public void PlotRiemannIntegral(Function function, List<PointF> integralBounds)
        {
            double x1 = 0;
            double y1 = 0;
            if (integralBounds[0].X <= integralBounds[1].X)
            {
                for (double i = integralBounds[0].X; i <= integralBounds[1].X; i++)
                {
                    x1 = (i - origin.X) / (pixelsPerSquare * scale);
                    if (function.GetRootNode().CheckDomain(x1))
                    {
                        //first y-coordinate of the graph
                        y1 = function.GetValue(x1);
                        x1 = origin.X + x1 * pixelsPerSquare * scale;
                        y1 = origin.Y - y1 * pixelsPerSquare * scale;

                        if (Math.Abs(y1) < 9999999)
                        {
                            graphics.DrawLine(Pens.Blue, Convert.ToSingle(x1), Convert.ToSingle(origin.Y), Convert.ToSingle(x1), Convert.ToSingle(y1));
                        }
                    }
                }
            }
            else
            {
                for (double i = integralBounds[1].X; i <= integralBounds[0].X; i++)
                {
                    x1 = (i - origin.X) / (pixelsPerSquare * scale);
                    if (function.GetRootNode().CheckDomain(x1))
                    {
                        //first y-coordinate of the graph
                        y1 = function.GetValue(x1);
                        x1 = origin.X + x1 * pixelsPerSquare * scale;
                        y1 = origin.Y - y1 * pixelsPerSquare * scale;

                        if (Math.Abs(y1) < 9999999)
                        {
                            graphics.DrawLine(Pens.Blue, Convert.ToSingle(x1), Convert.ToSingle(origin.Y), Convert.ToSingle(x1), Convert.ToSingle(y1));
                        }
                    }
                }
            }
            
        } 
        
        //draw the npoly point from input text
        public void DrawNPolyPoints(List<NPolyCoordinate> nPolyCoordinates)
        {
            foreach(NPolyCoordinate c in nPolyCoordinates)
            {
                graphics.DrawRectangle(Pens.Black, Convert.ToSingle(origin.X + c.X() * pixelsPerSquare * scale),Convert.ToSingle(origin.Y - c.Y() * pixelsPerSquare * scale), 3, 3);
            }
        }
    }
}
