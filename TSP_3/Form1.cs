using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSP_3
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void StartButton_Click(object sender, EventArgs e)
        {
            SimulationMarkov simulationMarkov = new SimulationMarkov();

            double[] matrix =
                { Convert.ToDouble(S0S0TextBox.Text), Convert.ToDouble(S0S1TextBox.Text), Convert.ToDouble(S0S2TextBox.Text),
                  Convert.ToDouble(S1S0TextBox.Text), Convert.ToDouble(S1S1TextBox.Text),Convert.ToDouble(S1S2TextBox.Text),
                  Convert.ToDouble(S2S0TextBox.Text), Convert.ToDouble(S2S1TextBox.Text),Convert.ToDouble(S2S2TextBox.Text) };

            double mean = 0;

            for (int i = 0; i < Convert.ToInt32(NumberOfExperimentsTextBox.Text); i++)
            {
                var result = Convert.ToDouble(simulationMarkov.Sim(Convert.ToDouble(S0TextBox.Text),
                    Convert.ToDouble(S1TextBox.Text), Convert.ToDouble(S2TextBox.Text), matrix));
                mean += result;
                chart1.Series[0].Points.AddY(result);
            }
            MeanShotsTextBox.Text = (mean / Convert.ToDouble(NumberOfExperimentsTextBox.Text)).ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            MeanShotsTextBox.Clear();
        }
    }
}