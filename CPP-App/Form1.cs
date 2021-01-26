using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPP_App.Nodes;

namespace CPP_App
{
    public partial class Form1 : Form
    {
        private Point originPoint;
        Graphics g;
        private int pixelsPerSquare = 15; //1 square (1 unit of graph) = 15 px
        private int scale = 1;
        private int timesClicked = 2;
        private List<PointF> integralPoints;
        private Parser parser;
        private Function function;
        private Plotter plotter;
        private TreeGenerator treeGenerator;
        private List<PointF> polyPoints;
        private bool btnPolySelectIsClicked;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Kien's CPP-App";
            tbRed.BackColor = Color.Red;
            tbPurple.BackColor = Color.Purple;
            tbGreen.BackColor = Color.Green;
            tbPink.BackColor = Color.HotPink;
            tbBlue.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            integralPoints = new List<PointF>();
            polyPoints = new List<PointF>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //infix formula of anlaytical derivative
                pbPlot.Refresh();
                tbAnalyticalDerivativeFormula.Text = "";
                tbNPoly.Text = "";
                tbInfixOriginalFunc.Text = "";
                tbIntegral.Text = "";
                lblUpper.Text = "?";
                lblLower.Text = "?";
                pbDerivative.Image = null;
                parser = new Parser(tbParse.Text);
                function = new Function(parser.BuildBinaryTree(parser.GetFormula().ToList<char>()));
                treeGenerator = new TreeGenerator(function);

                //tree for original funtion
                treeGenerator.GenerateTreeImage();
                pbOriginalFunction.ImageLocation = "binarytree.png";
                //infix
                tbInfixOriginalFunc.Text = function.GetInfixFormula();
                plotter = new Plotter(g, originPoint, pbPlot, pixelsPerSquare, scale);
                //plot original funtion
                plotter.PlotFunction(function,Pens.Red);
                                          
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(this.Cursor == Cursors.Cross && timesClicked >0)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                PointF coordinates = me.Location;
                integralPoints.Add(coordinates);
                g.DrawRectangle(Pens.Black, coordinates.X, coordinates.Y, 3, 3);
                timesClicked--;
            }
            if(timesClicked <= 0)
            {
                this.Cursor = Cursors.Default;
            }
            if(this.Cursor == Cursors.Hand && btnPolySelectIsClicked == true)
            {
                MouseEventArgs me = (MouseEventArgs)e;
                PointF coordinates = me.Location;
                polyPoints.Add(coordinates);
                g.DrawRectangle(Pens.Black, coordinates.X, coordinates.Y, 3, 3);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void pbPlot_Paint(object sender, PaintEventArgs e)
        {
            originPoint = new Point(pbPlot.Width / 2, pbPlot.Height / 2);
            g = pbPlot.CreateGraphics();
            int maxNrOfSqares = pbPlot.Width / pixelsPerSquare;
            for (int i = 0; i < maxNrOfSqares; i++)
            {
                //draw vertical lines in the negative side (of the x-axis)              
                e.Graphics.DrawLine(Pens.LightGray, originPoint.X - pixelsPerSquare * i * scale, 0, originPoint.X - pixelsPerSquare * i * scale, pbPlot.Height);
                //draw horizontal lines in the positive side (of the y-axis)
                e.Graphics.DrawLine(Pens.LightGray, 0, originPoint.Y - pixelsPerSquare * i * scale, pbPlot.Width, originPoint.Y - pixelsPerSquare * i * scale);
                //draw vertical lines in the positive side (of the x-axis)
                e.Graphics.DrawLine(Pens.LightGray, originPoint.X + pixelsPerSquare * i * scale, 0, originPoint.X + pixelsPerSquare * i * scale, pbPlot.Height);
                //draw horizontal lines in the negative side (of the y-xis)
                e.Graphics.DrawLine(Pens.LightGray, 0, originPoint.Y + pixelsPerSquare * i * scale, pbPlot.Width, originPoint.Y + pixelsPerSquare * i * scale);
            }
            //x-axis
            e.Graphics.DrawLine(Pens.Black, originPoint.X, 0, originPoint.X, pbPlot.Height);
            //y-axis
            e.Graphics.DrawLine(Pens.Black, 0, originPoint.Y, pbPlot.Width, originPoint.Y);
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                scale = trackBarForGraph.Value;
                pbPlot.Refresh();
                parser = new Parser(tbParse.Text);
                plotter = new Plotter(g, originPoint, pbPlot, pixelsPerSquare, scale);
                //plot original funtion
                if (function != null)
                {
                    function = new Function(parser.BuildBinaryTree(parser.GetFormula().ToList<char>()));
                    plotter.PlotFunction(function, Pens.Red);
                }               
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void tbParse_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            
        }

        private void btnSelectIntegral_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            tbIntegral.Text = "";
            lblLower.Text = "";
            lblUpper.Text = "";
            if (integralPoints.Count == 2 && Cursor.Current == Cursors.Default)
            {
                plotter.PlotRiemannIntegral(function,integralPoints);
                tbIntegral.Text = Math.Round(function.GetRiemannIntegral(integralPoints[0].X, integralPoints[1].X, originPoint.X,pixelsPerSquare,scale),3).ToString();
                if (integralPoints[0].X< integralPoints[1].X)
                {
                    lblLower.Text = Math.Round(Convert.ToDouble((integralPoints[0].X - originPoint.X)/(pixelsPerSquare*scale)),3).ToString();
                    lblUpper.Text = Math.Round(Convert.ToDouble((integralPoints[1].X - originPoint.X)/(pixelsPerSquare*scale)),3).ToString();
                }
                else
                {
                    lblLower.Text = Math.Round(Convert.ToDouble((integralPoints[1].X - originPoint.X) /(pixelsPerSquare*scale)),3).ToString();
                    lblUpper.Text = Math.Round(Convert.ToDouble((integralPoints[0].X - originPoint.X) / (pixelsPerSquare*scale)),3).ToString();
                }
                
                timesClicked += 2;
            }
            integralPoints.Clear();

        }

        private void btnWolfram_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void btnMcLaurinAnalytically_Click(object sender, EventArgs e)
        {
            int invalidSeries = 0;
            for (int i = 1; i <= 8; i++)
            {
                if (function.GetMclaurinSeriesAnalytically(i) != null)
                {
                    plotter.PlotFunction(function.GetMclaurinSeriesAnalytically(i), Pens.HotPink);
                }
                else
                {
                    invalidSeries++;
                }
            }
            if (invalidSeries > 0)
            {
                MessageBox.Show("No valid McLaurin series of this order");
            }
        }

        private void btnAnalyticalDerivative_Click(object sender, EventArgs e)
        {
            tbAnalyticalDerivativeFormula.Text = "";
            //plot analytical derivative
            plotter.PlotFunction(function.GetDerivative(), Pens.Purple);
            tbAnalyticalDerivativeFormula.Text = function.GetDerivative().Simplify().GetInfixFormula();
            //tree for derivative
            treeGenerator.GenerateTreeImageForDerivative();
            pbDerivative.ImageLocation = "derivativetree.png";
        }

        private void btnNewtonDerivative_Click(object sender, EventArgs e)
        {
            //plot newton quotient
            plotter.PlotFunction(function.GetNewtonQuotientFunction(0.1),Pens.Green);
        }

        private void btnMcLaurinNewton_Click(object sender, EventArgs e)
        {
            int invalidSeries = 0;
            for(int i = 1; i <= 8; i++)
            {
                if (function.GetMclaurinSeriesByNewton(i) != null)
                {
                    plotter.PlotFunction(function.GetMclaurinSeriesByNewton(i), Pens.Orange);
                }
                else
                {
                    invalidSeries++;
                }
            }
            if (invalidSeries > 0)
            {
                MessageBox.Show("No valid McLaurin series of this order");
            }
        }

        private void btnPolySelect_Click(object sender, EventArgs e)
        {
            polyPoints.Clear();
            pbPlot.Refresh();
            tbNPoly.Text = "";
            this.Cursor = Cursors.Hand;
            btnPolySelectIsClicked = true;
            
        }

        private void btnGetPoly_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            Matrix m = new Matrix(polyPoints, originPoint, pixelsPerSquare, scale);
            NPolynomialGenerator nPolynomialGenerator = new NPolynomialGenerator(m);
            Function nPoly = nPolynomialGenerator.GetNPolyFunction();
            tbNPoly.Text = nPoly.GetInfixFormula();
            plotter = new Plotter(g, originPoint, pbPlot, pixelsPerSquare, scale);
            plotter.PlotFunction(nPoly,Pens.Blue);
            //polyPoints.Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnZeroGradientNPoly_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddNPolyPoints_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbPlot.Refresh();
        }

        private void btnPlotNPoly2_Click(object sender, EventArgs e)
        {
            parser = new Parser(tbAddCoordinates.Text);
            plotter = new Plotter(g, originPoint, pbPlot, pixelsPerSquare, scale);
            List<NPolyCoordinate> coordinates = new List<NPolyCoordinate>();
            coordinates = parser.GetListOfCoordinates(tbAddCoordinates.Text.ToList<char>());
            plotter.DrawNPolyPoints(coordinates);
            Matrix m = new Matrix(coordinates);
            NPolynomialGenerator nPolynomialGenerator = new NPolynomialGenerator(m);
            Function nPoly = nPolynomialGenerator.GetNPolyFunction();
            tbNPoly.Text = nPoly.GetInfixFormula();
            plotter.PlotFunction(nPoly, Pens.Blue);
        }

        private void btnPlotNMinus1Poly2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            
        }
    }
}
