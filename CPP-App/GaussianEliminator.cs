using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CPP_App
{
    public class GaussianEliminator
    {
        public GaussianEliminator()
        {

        }


        public double[] GaussianElim(Matrix mtr,int nrOfPolyPoints)
        {
            double[][] matrix = mtr.GetMatrix();
            double pivot = 0;
            double factor = 0;
            for (int i = 0; i < nrOfPolyPoints; i++)
            {
                pivot = matrix[i][i];
                for (int j = i; j <= nrOfPolyPoints; j++)
                {
                    matrix[i][j] = matrix[i][j] / pivot;
                }

                for (int k = 0; k < nrOfPolyPoints; k++)
                {
                    if (k != i && matrix[k][i] != 0)
                    {
                        factor = matrix[k][i];
                        for (int m = i; m <= nrOfPolyPoints; m++)
                        {
                            matrix[k][m] = matrix[k][m] - factor * matrix[i][m];
                        }
                    }
                }
            }

            double[] coefficient = new double[nrOfPolyPoints];
            for (int i = 0; i < nrOfPolyPoints; i++)
            {
                coefficient[i] = matrix[i][nrOfPolyPoints];
            }
            return coefficient;
        }
    }
}
