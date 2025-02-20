using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace DerinlikOlcum
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            CreateGraph(zedGraphControl1);
        }

        private void CreateGraph(ZedGraphControl zedGraphControl1)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set graph title and axis labels
            myPane.Title.Text = "My First ZedGraph";
            myPane.XAxis.Title.Text = "X Axis";
            myPane.YAxis.Title.Text = "Y Axis";

            // Create data points
            PointPairList points = new PointPairList();
            for (int i = 0; i < 10; i++)
            {
                points.Add(i, Math.Sin(i)); // Example: X = i, Y = sin(i)
            }

            // Create a curve with the data
            LineItem myCurve = myPane.AddCurve("Sine Wave", points, System.Drawing.Color.Blue, SymbolType.Circle);

            // Refresh the graph
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            

        }
       

    }
}
