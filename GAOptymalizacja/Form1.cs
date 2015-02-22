using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAOptymalizacja
{
    public partial class Form1 : Form
    {
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
                    GA algorithm = new GA();
                    algorithm.evolve();
                }
                   
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
