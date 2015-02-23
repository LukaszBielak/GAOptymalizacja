using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAOptymalizacja
{
    public partial class Form1 : Form
    {
        List<string> controls;
        dynamic param = new ExpandoObject();

        public Form1()
        {
            InitializeComponent();            
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            if (initializeData() == true)
            {
                Facade fd = new Facade();
                var res = fd.startAlgorithm(param);

                wynik.Text = res.wynik;
                X1Dif.Text = res.X1Dif;
                X2Dif.Text = res.X2Dif;
                dlugoscChromosomu.Text = res.dlugoscChromosomu;
            }
            else
            {
                wynik.Text = "Bład initializacji!!!";
            }
            

        }





        private bool initializeData()
        {

            controls = new List<string>();
            controls.Add(funkcja.Text);
            controls.Add(X1Min.Text);
            controls.Add(X1Max.Text);
            controls.Add(X2Min.Text);
            controls.Add(X2Max.Text);
            controls.Add(wielkośćPopulacji.Text);
            controls.Add(krzyżowanieProp.Text);
            controls.Add(mutacjaProp.Text);
            controls.Add(Epoki.Text);
        
            foreach (var z in controls)
            {
                if (String.IsNullOrWhiteSpace(z))
                {
                    return false;
                }
                else
                {
                    param.funkcja = funkcja.Text;
                    param.X1Min = X1Min.Text;
                    param.X1Max = X1Max.Text;
                    param.X2Min = X2Min.Text;
                    param.X2Max = X2Max.Text;
                    param.wielkośćPopulacji = wielkośćPopulacji.Text;
                    param.krzyżowanieProp = krzyżowanieProp.Text;
                    param.mutacjaProp = mutacjaProp.Text;
                    param.Epoki = Epoki.Text;
                    param.X1Dif = X1Dif.Text;
                    param.X2Dif = X2Dif.Text;
                    param.dlugoscChromosomu = dlugoscChromosomu;
                    param.wynik = wynik;
                    param.plot1 = plot1;
                    
                }


            }
            return true;
        }
    }
}
