using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAOptymalizacja
{
    public partial class Form1 : Form
    {
        Plot plt = new Plot();
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            bool initialized = initializeData();

                if(initialized == false)
                {
                    wynik.Text = "Bład initializacji!";
                }
                else
                {
                    List<int> partialLengths = new List<int>();
                    double[,] limitation = new double[,] { { Double.Parse(X1Max.Text, CultureInfo.InvariantCulture), Double.Parse(X1Min.Text, CultureInfo.InvariantCulture) }, { Double.Parse(X2Max.Text, CultureInfo.InvariantCulture), Double.Parse(X2Min.Text, CultureInfo.InvariantCulture) } };

                    double length = 0;
                    for (int r = 0; r <= 1; r++)
                    {
                        double partialLenght = chromosomeLenght(limitation[r, 0], limitation[r, 1]);
                        length = length + partialLenght;
                        partialLengths.Add((int)partialLenght);

                    }

                    GA algorithm = new GA(funkcja.Text, X1Max.Text, X1Min.Text, X2Max.Text, X2Min.Text, wielkośćPopulacji.Text, krzyżowanieProp.Text, mutacjaProp.Text, Epoki.Text, partialLengths);

                    X1Dif.Text = partialLengths.ElementAt(0).ToString();
                    X2Dif.Text = partialLengths.ElementAt(1).ToString();
                    int CL = partialLengths.ElementAt(0) + partialLengths.ElementAt(1);
                    dlugoscChromosomu.Text = CL.ToString();

                    var best = algorithm.evolve();

                    wynik.Text = best.Last().Value.ToString();

                    plot1.Model = plt.drawPlot(best, Double.Parse(Epoki.Text, CultureInfo.InvariantCulture));
                }
                   
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

        private bool initializeData()
        {

            List<string> controls = new List<string>();
            controls.Add(funkcja.Text);
            controls.Add(X1Min.Text);
            controls.Add(X1Max.Text);
            controls.Add(X2Min.Text);
            controls.Add(X2Max.Text);
            controls.Add(wielkośćPopulacji.Text);
            controls.Add(krzyżowanieProp.Text);
            controls.Add(mutacjaProp.Text);
            controls.Add(Epoki.Text);


            foreach(var z in controls)
            {
                if(String.IsNullOrWhiteSpace(z))
                {
                    return false;
                }             

            }
            return true;
        }

        

   
    }
}
