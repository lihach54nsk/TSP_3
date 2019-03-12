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

            double test = Convert.ToDouble(S0TextBox.Text);

            chart1.Series[0].Points.AddY(Convert.ToDouble(simulationMarkov.Sim(Convert.ToDouble(S0TextBox.Text),
                Convert.ToDouble(S1TextBox.Text), Convert.ToDouble(S2TextBox.Text))));
        }
    }
}