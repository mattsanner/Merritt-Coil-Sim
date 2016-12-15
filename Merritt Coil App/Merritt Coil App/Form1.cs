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
        public double width = 1;
        public double length = 1;
        public double muNot = 4 * Math.PI * Math.Pow(10, (-7));
        public double unitCurrent = 1;
        //public double[] coilPositionZ = { -0.3033, -0.07686, .07686, .3033 };
        public double[] coilPositionZ = { -0.5055, -.1281, .1281, .5055 };
        public double[] coilTurns = { 26, 11, 11, 26 };

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

            double[] answer0 = BFieldEquation(ax, ay, az, 0);
            double[] answer1 = BFieldEquation(ax, ay, az, 1);
            double[] answer2 = BFieldEquation(ax, ay, az, 2);
            double[] answer3 = BFieldEquation(ax, ay, az, 3);

            double[] answers = { 0.0, 0.0, 0.0 };

            answers[0] = answer0[0] + answer1[0] + answer2[0] + answer3[0];
            answers[1] = answer0[1] + answer1[1] + answer2[1] + answer3[1];
            answers[2] = answer0[2] + answer1[2] + answer2[2] + answer3[2];


            bFieldText.Text = "B = " + answers[0].ToString("0.########") + "âx + " + answers[1].ToString("0.########") + "ây + " + answers[2].ToString("0.########") + "âz";

            double[] H = GimmeThatHField(answers);

            Htext.Text = "H = " + H[0].ToString("0.########") + "âx + " + H[1].ToString("0.########") + "ây + " + H[2].ToString("0.########") + "âz";
        }

        private double[] BFieldEquation(double x, double y, double z, int coilNumber)
        {
            //enter equation stuff here
            double[] retVals = { x, y, z };

            double[] c = { 0.0, (x + length/2),
                            (x - length/2),
                            (x - length/2),
                            (x + length/2)};

            double[] d = {0.0, (y + width/2),
                            (y + width/2),
                            (y - width/2),
                            (y - width/2) };

            double[] r = { 0.0, 0.0, 0.0, 0.0, 0.0 };
            r[1] = Math.Sqrt(Math.Pow((x + length/2), 2) + Math.Pow((y + width/2), 2) + Math.Pow((z-coilPositionZ[coilNumber]), 2));
            r[2] = Math.Sqrt(Math.Pow((x - length/2), 2) + Math.Pow((y + width/2), 2) + Math.Pow((z-coilPositionZ[coilNumber]), 2));
            r[3] = Math.Sqrt(Math.Pow((x - length/2), 2) + Math.Pow((y - width/2), 2) + Math.Pow((z-coilPositionZ[coilNumber]), 2));
            r[4] = Math.Sqrt(Math.Pow((x + length/2), 2) + Math.Pow((y - width/2), 2) + Math.Pow((z-coilPositionZ[coilNumber]), 2));

            double Bx = 0.0;
            double By = 0.0;
            double Bz = 0.0;

            for(int i = 1; i <= 4; i++)
            {
                Bx = Bx + Math.Pow((-1), (i+1)) * (z - coilPositionZ[coilNumber]) / (r[i] * (r[i] + d[i]));
                By = By + Math.Pow((-1), (i+1)) * (z - coilPositionZ[coilNumber]) / (r[i] * (r[i] + c[i]));
                Bz = Bz + Math.Pow((-1), i) * ((c[i] / (r[i]*(r[i] + d[i]))) + (d[i] / (r[i] * (r[i] + c[i]))));
            }

            Bx = Bx * (coilTurns[coilNumber] * muNot * unitCurrent) / (4 * Math.PI);
            By = By * (coilTurns[coilNumber] * muNot * unitCurrent) / (4 * Math.PI);
            Bz = Bz * (coilTurns[coilNumber] * muNot * unitCurrent) / (4 * Math.PI);

            retVals[0] = Bx;
            retVals[1] = By;
            retVals[2] = Bz;

            return retVals;
        }

        public double[] GimmeThatHField(double[] theB)
        {
            //B = mu*H - H = B/Mu
            double[] answers = { (theB[0] / muNot), (theB[1] / muNot), (theB[2] / muNot) };
            return answers;
        }

        /*private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
