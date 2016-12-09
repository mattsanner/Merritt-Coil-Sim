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

            bFieldText.Text = "B = " + answers[0] + "âx + " + answers[1] + "ây + " + answers[2] + "âz";
        }

        private double[] BFieldEquation(double x, double y, double z)
        {
            //enter equation stuff here
            double[] retVals = { x, y, z };

            return retVals;
        }

        /*private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }*/
    }
}
