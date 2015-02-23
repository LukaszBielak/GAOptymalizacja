using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAOptymalizacja
{
    class Plot
    {
        
        public OxyPlot.PlotModel drawPlot(Dictionary<double, double> pointsGroup, double iterations)
        {
            
        //this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            var pm = new PlotModel
            {
                Title = "Wykres zbieżności",
                //Subtitle = "Example using the FunctionSeries",
                PlotType = PlotType.XY,
                Background = OxyColors.White
            };
            FunctionSeries series = new FunctionSeries();
            pm.Series.Add(series);
            pointsGroup.Distinct();
            foreach (KeyValuePair<double, double> point in pointsGroup)
            {
                series.Points.Add(new DataPoint(point.Key, point.Value));
            }
            
                       
            pm.Axes.Add(new LinearAxis(AxisPosition.Bottom, 0.0, iterations + (iterations/10), "Iteracje"));
            pm.Axes.Add(new LinearAxis(AxisPosition.Left, -5, 30, "Wartość  funkcji"));

            return pm;
            
        }
    }
}
