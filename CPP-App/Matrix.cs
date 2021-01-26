using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CPP_App
{
    public class Matrix
    {
        private double[][] matrix;
        private List<PointF> polyPoints;
        private List<NPolyCoordinate> nPolyCoordinates;
        private Point origin;
        private int pixelsPerSquare;
        private int scale;

        public Matrix(List<PointF> polyPoints, Point originPoint, int pixelsPerSquare, int scale)
        {
            this.polyPoints = polyPoints;
            this.origin = originPoint;
            this.pixelsPerSquare = pixelsPerSquare;
            this.scale = scale;
            matrix = new double[polyPoints.Count][];
            for (int i = 0; i < polyPoints.Count; i++)
            {
                matrix[i] = new double[polyPoints.Count + 1];
                for (int j = 0; j <= polyPoints.Count ; j++)
                {
                    if (j < polyPoints.Count)
                    {
                        matrix[i][j] = Math.Pow((polyPoints[i].X - origin.X) / (pixelsPerSquare * scale), j);
                    }
                    else if (j == polyPoints.Count)
                    {
                        matrix[i][j] = (origin.Y - polyPoints[i].Y) / (pixelsPerSquare * scale);
                    }
                }                   
            }
        }

        public Matrix(List<NPolyCoordinate> nPolyCoordinates)
        {
            this.nPolyCoordinates = nPolyCoordinates;
            matrix = new double[nPolyCoordinates.Count][];
            for (int i = 0; i < nPolyCoordinates.Count; i++)
            {
                matrix[i] = new double[nPolyCoordinates.Count + 1];
                for (int j = 0; j <= nPolyCoordinates.Count; j++)
                {
                    if (j < nPolyCoordinates.Count)
                    {
                        matrix[i][j] = Math.Pow(nPolyCoordinates[i].X(), j);
                    }
                    else if (j == nPolyCoordinates.Count)
                    {
                        matrix[i][j] = nPolyCoordinates[i].Y();
                    }
                }
            }
        }

        //store the coefficient to the matrix from the set of points
        public double[][] GetMatrix()
        {
            return matrix;
        }

        public List<PointF> GetPoints()
        {
            return polyPoints;
        }

        public List<NPolyCoordinate> GetnPolyCoordinates()
        {
            return this.nPolyCoordinates;
        }
        //multiply a row
        public double[][] Multiply(double[][] matrix, int rowIndex, double multiplier)
        {
            for (int i = 0; i <= polyPoints.Count; i++)
            {
                matrix[rowIndex][i] *= multiplier;
            }
            return matrix;
        }

        //add 2 rows
        public double[][] Add(double[][] matrix, int first, int second)
        {
            for (int i = 0; i <= polyPoints.Count; i++)
            {
                matrix[second][i] += matrix[first][i];
            }
            return matrix;
        }

        //substract 2 rows
        public double[][] Substract(double[][] matrix, int first, int second)
        {
            for (int i = 0; i <= polyPoints.Count; i++)
            {
                matrix[second][i] -= matrix[first][i];
            }
            return matrix;
        }


    }
     
}
