using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SIR_Model;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace SIR_Model_GUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Generate();
            trackBarB.Value = (int)(Convert.ToDouble(textBoxB.Text)*100);
            trackBarK.Value = (int)(Convert.ToDouble(textBoxK.Text)*100);
        }



        private void Generate()
        {
            var start = dateTimePickerStart.Value;
            var end = dateTimePickerEnd.Value;
            var b = Convert.ToDouble(textBoxB.Text);
            var k = Convert.ToDouble(textBoxK.Text);
            var s_0 = Convert.ToDouble(textBoxS_0.Text);
            var i_0 = Convert.ToDouble(textBoxI_0.Text);

            SIRModel model = new SIRModel(s_0, i_0);
            var results = model.Calculate(start, end, b, k);

            var myModel = new PlotModel { Title = "Covid-19 Infections" };
            var minValue = DateTimeAxis.ToDouble(start);
            var maxValue = DateTimeAxis.ToDouble(end);
            myModel.Axes.Add(new DateTimeAxis { MajorStep = 50, Position = AxisPosition.Bottom, Minimum = minValue, Maximum = maxValue, StringFormat = "dd/MM/yy" });
            var scatterSeries = new ScatterSeries { MarkerType = MarkerType.Circle,MarkerFill= OxyColor.FromRgb(0, 155, 186) };

            foreach (KeyValuePair<DateTime, double> kvp in results)
            {
                scatterSeries.Points.Add(new ScatterPoint(DateTimeAxis.ToDouble(kvp.Key), kvp.Value));
            }

            myModel.Series.Add(scatterSeries);
            this.plotView1.Model = myModel;
        }

        private void trackBarK_Scroll(object sender, EventArgs e)
        {
            textBoxK.Text = (trackBarK.Value/100.0).ToString();
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            textBoxB.Text = (trackBarB.Value/100.0).ToString();
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxK_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxS_0_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void textBoxI_0_TextChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
