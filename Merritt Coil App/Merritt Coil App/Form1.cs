using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merritt_Coil_App
{
    public partial class Form1 : Form
    {
        double width = 1;
        double length = 1;
        double muNot = 4 * Math.PI * Math.Pow(10, 7);
        double unitCurrent = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double ax = 0.0;
            double ay = 0.0;
            double az = 0.0;
            try
            {
                ax = Convert.ToDouble(axText.Text);
                ay = Convert.ToDouble(ayText.Text);
                az = Convert.ToDouble(azText.Text);
            }catch(Exception excep)
            {
                bFieldText.Text = "Error casting vector fields, check numbers and try again.";
                return;
            }

            double[] answers = BFieldEquation(ax, ay, az);

            bFieldText.Text = "B = " + answers[0].ToString("0.##") + "âx + " + answers[1].ToString("0.##") + "ây + " + answers[2].ToString("0.##") + "âz";
        }

        private double[] BFieldEquation(double x, double y, double z)
        {
            //enter equation stuff here
            double[] retVals = { x, y, z };

            double c1 = x + length;
            double c2 = x - length;
            double c3 = x - length;
            double c4 = x + length;

            double d1 = y + width;
            double d2 = y + width;
            double d3 = y - width;
            double d4 = y - width;

            double r1 = Math.Sqrt(Math.Pow((x + length), 2) + Math.Pow((y + width), 2) + Math.Pow(z, 2));
            double r2 = Math.Sqrt(Math.Pow((x - length), 2) + Math.Pow((y + width), 2) + Math.Pow(z, 2));
            double r3 = Math.Sqrt(Math.Pow((x - length), 2) + Math.Pow((y - width), 2) + Math.Pow(z, 2));
            double r4 = Math.Sqrt(Math.Pow((x + length), 2) + Math.Pow((y - width), 2) + Math.Pow(z, 2));

            double Bx = z*((1/(r1*(r1+d1))) - (1/(r2*(r2+d2))) + (1/(r3*(r3+d3))) - (1/(r4*(r4+d4))));
            double By = z*((1/(r1*(r1+c1))) - (1/(r2*(r2+c2))) + (1/(r3*(r3+c3))) - (1/(r4*(r4+c4))));
            double Bz = (-1) * ((c1/(r1*(r1+d1))) + (d1/(r1*(r1+c1)))) + ((c2/(r2*(r2+d2))) + (d2/(r2*(r2+c2)))) - ((c3/(r3*(r3+d3))) + (d3/(r3*(r3+c3)))) + ((c4/(r4*(r4+d4))) + (d4/(r4*(r4+c4))));
            Bx = Bx * (muNot * unitCurrent) / (4 * Math.PI);
            By = By * (muNot * unitCurrent) / (4 * Math.PI);
            Bz = Bz * (muNot * unitCurrent) / (4 * Math.PI);

            retVals[0] = Bx;
            retVals[1] = By;
            retVals[2] = Bz;

            return retVals;
        }

        /*private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
