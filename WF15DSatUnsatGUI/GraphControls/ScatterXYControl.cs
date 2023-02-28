using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using System.Runtime.CompilerServices;
using System.CodeDom.Compiler;
using ScottPlot.Plottable;

namespace GraphControls
{
    public partial class ScatterXYControl: UserControl,INotifyPropertyChanged

    {
        //public Color backcolor = ScatterXYControl.formsPlot_scatterXYControl.BackColor;
        //[Description("Back color of graph"), Category("Appearance")]
        //public Color BackColor {
        //  get => formsPlot_scatterXYControl.BackColor;
        //  set { formsPlot_scatterXYControl.BackColor = value; OnPropertyChanged(); }
        //}

        //private List<PointLine> pointLines = new List<PointLine>();
        ///// <summary>
        ///// List of PointLines
        ///// </summary>
        //[Description("List of PointLine classes to plot"), Category("Data"),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        //public List<PointLine> PointLines
        //{
        //    get => pointLines;
        //    set { pointLines = value; OnPropertyChanged(); }
        //}

        [Description("Plot"), Category("Data")]
        public ScottPlot.Plot Plot
        {
            get => formsPlot_scatterXYControl.Plot;
        }

        [Description("ScatterPLotLine"), Category("Data")]
        public List<ScottPlot.Plottable.ScatterPlotList<double>> PlotLines = new List<ScottPlot.Plottable.ScatterPlotList<double>>();

        

        private string title;
        /// <summary>
        /// Title
        /// </summary>
        [Description("Title of the Chart"), Category("Data")]
        public string Title
        {
            get => title;
            set { title = value; formsPlot_scatterXYControl.Plot.Title(title); OnPropertyChanged(); }
        }

        private string xlabel;
        /// <summary>
        /// Label on the x axis
        /// </summary>
        [Description("Label on the x axis"), Category("Data")]
        public string Xlabel
        {
            get => xlabel;
            set { xlabel = value; formsPlot_scatterXYControl.Plot.XLabel(xlabel); OnPropertyChanged(); }
        }

        private string ylabel;
        /// <summary>
        /// Label on the Y axis
        /// </summary>
        [Description("Label on the YAxis"), Category("Data")]
        public string Ylabel
        {
            get => ylabel;
            set { ylabel = value; formsPlot_scatterXYControl.Plot.YLabel(ylabel); OnPropertyChanged(); }
        }

        [Description("XAxis"), Category("Data")]
        public ScottPlot.Renderable.Axis XAxis
        {
            get => Plot.XAxis;
        }
        [Description("YAxis"), Category("Data")]
        public ScottPlot.Renderable.Axis YAxis
        {
            get => Plot.YAxis;
        }
        private double xAxisMin;
        [Description("Minimum value for X Axis"), Category("Data")]
        public double XAxisMin
        {
            get => Plot.GetAxisLimits().XMin;
            set { xAxisMin = value; Plot.SetAxisLimitsX(value, Plot.GetAxisLimits().XMax); OnPropertyChanged(); }
        }
        private double xAxisMax;
        [Description("Maximum value for X Axis"), Category("Data")]
        public double XAxisMax
        {
            get => Plot.GetAxisLimits().XMax;
            set { xAxisMax = value; Plot.SetAxisLimitsX(Plot.GetAxisLimits().XMin, value); OnPropertyChanged(); }
        }
        [Description("Lock X axis"), Category("Data")]
        public bool LockHorizontalAxis
        {
            get => formsPlot_scatterXYControl.Configuration.LockHorizontalAxis;
            set { formsPlot_scatterXYControl.Configuration.LockHorizontalAxis = value; OnPropertyChanged(); }
        }
        private double yAxisMin;
        [Description("Minimum value for Y Axis"), Category("Data")]
        public double YAxisMin
        {
            get => Plot.GetAxisLimits().YMin;
            set { yAxisMin = value; Plot.SetAxisLimitsY(value, Plot.GetAxisLimits().YMax); OnPropertyChanged();}
        }
        private double yAxisMax;
        [Description("Maximum value for Y Axis"), Category("Data")]
        public double YAxisMax
        {
            get => Plot.GetAxisLimits().YMax;
            set { yAxisMax = value; Plot.SetAxisLimitsY(Plot.GetAxisLimits().YMin, value); OnPropertyChanged(); }
            }
        [Description("Lock X axis"), Category("Data")]
        public bool LockVerticalAxis
        {
            get => formsPlot_scatterXYControl.Configuration.LockVerticalAxis;
            set { formsPlot_scatterXYControl.Configuration.LockVerticalAxis = value; OnPropertyChanged(); }
        }

        public ScatterXYControl()
        {
            InitializeComponent();
            formsPlot_scatterXYControl.Dock = DockStyle.Fill;
            formsPlot_scatterXYControl.Plot.YAxis.IsVisible= true;
            this.xAxisMin = Plot.GetAxisLimits().XMin;
            this.xAxisMax = Plot.GetAxisLimits().XMax;
            this.yAxisMin = Plot.GetAxisLimits().YMin;
            this.yAxisMax = Plot.GetAxisLimits().YMax;


            //RefreshLines();

            //double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            //double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            //formsPlot_scatterXYControl.Plot.AddScatterLines(dataX, dataY,Color.Black,3,LineStyle.Dash);

            //formsPlot_scatterXYControl.Refresh();
        }



    //public void RefreshLines()
    //    {
    //        formsPlot_scatterXYControl.Plot.Clear();
            
    //        if (!(pointLines is null))
    //        for(int i=0;i<pointLines.Count;i++)
    //        {
    //                if (pointLines[i].Points.Count!=0) 
    //                    formsPlot_scatterXYControl.Plot.AddScatterLines(pointLines[i].X.ToArray(), pointLines[i].Y.ToArray(), pointLines[i].Color, 3, pointLines[i].Linestyle);
    //        }
    //        formsPlot_scatterXYControl.Refresh();
    //    }

        

        public void RemoveLines()
        {
            Plot.Clear();
        }
        public void AddLine()
        {
            PlotLines.Add(this.Plot.AddScatterList());
        }

        public void RemoveLine(int nline)
        {
            PlotLines.RemoveAt(nline);
            OnPropertyChanged();
        }

        public void Render()
        {
            formsPlot_scatterXYControl.Render();
        }

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        { 
            formsPlot_scatterXYControl.Render();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private void button_ResetY_Click(object sender, EventArgs e)
        {
            this.YAxisMin = yAxisMin;
            this.YAxisMax = yAxisMax;
        }

        private void button_ResetX_Click(object sender, EventArgs e)
        {
            this.XAxisMin = xAxisMin;
            this.XAxisMax = xAxisMax;
        }

        private void button_Zoom_Inc_Y_Click(object sender, EventArgs e)
        {
            Plot.AxisZoom(1.0, 1.5);
            formsPlot_scatterXYControl.Render();
        }

        private void button_Zoom_Dec_Y_Click(object sender, EventArgs e)
        {
            Plot.AxisZoom(1.0, 1.0/1.5);
            formsPlot_scatterXYControl.Render();
        }

        private void button_Zoom_Inc_X_Click(object sender, EventArgs e)
        {
            Plot.AxisZoom(1.5, 1.0);
            formsPlot_scatterXYControl.Render();
        }

        private void button_Zoom_Dec_X_Click(object sender, EventArgs e)
        {
            Plot.AxisZoom(1.0/1.5, 1.0);
            formsPlot_scatterXYControl.Render();
        }

        private void button_Extent_Click(object sender, EventArgs e)
        {
            Plot.AxisAuto();
            formsPlot_scatterXYControl.Render();
        }
    }
}
