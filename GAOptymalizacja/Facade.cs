using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAOptymalizacja
{
    class Facade : Form1
    {
        Plot plt = new Plot();
        public dynamic startAlgorithm(dynamic param)
        {
            dynamic result = new ExpandoObject(); 

            List<int> partialLengths = new List<int>();
            double[,] limitation = new double[,] { { Double.Parse(param.X1Max, CultureInfo.InvariantCulture), Double.Parse(param.X1Min, CultureInfo.InvariantCulture) }, { Double.Parse(param.X2Max, CultureInfo.InvariantCulture), Double.Parse(param.X2Min, CultureInfo.InvariantCulture) } };

            double length = 0;
            for (int r = 0; r <= 1; r++)
            {
                double partialLenght = chromosomeLenght(limitation[r, 0], limitation[r, 1]);
                length = length + partialLenght;
                partialLengths.Add((int)partialLenght);

            }

            GA algorithm = new GA(param.funkcja, param.X1Max, param.X1Min, param.X2Max, param.X2Min, param.wielkośćPopulacji, param.krzyżowanieProp, param.mutacjaProp, param.Epoki, partialLengths);

            result.X1Dif = partialLengths.ElementAt(0).ToString();
            result.X2Dif = partialLengths.ElementAt(1).ToString();
            int CL = partialLengths.ElementAt(0) + partialLengths.ElementAt(1);
            result.dlugoscChromosomu = CL.ToString();

            var best = algorithm.evolve();

            result.wynik = best.Last().Value.ToString();

            param.plot1.Model = plt.drawPlot(best, Double.Parse(param.Epoki, CultureInfo.InvariantCulture));

            return result;

        }

        private double chromosomeLenght(double max, double min)
        {
            double zm = (max - min) * Math.Pow(10, 4);
            int pow = 0;
            double parialLenght = 0;
            do
            {
                pow++;
                parialLenght = Math.Pow(2, pow);

            } while (parialLenght < zm);

            return pow;
        }
        
    }
}

