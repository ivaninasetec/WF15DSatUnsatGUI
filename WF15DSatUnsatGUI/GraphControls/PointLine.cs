using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DW = System.Drawing;
using ScottPlot;
using System.Windows.Forms;
using System.IO.Compression;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GraphControls
{

    //public struct pt
    //   {
    //        public double x;
    //        public double y;
    //   }
    //[Serializable]
    //public class PointLine: INotifyPropertyChanged
    //{

    //    private List<pt> points;
    //    /// <summary>
    //    /// One point of the line
    //    /// </summary>
    //    public List<pt> Points
    //    {
    //        get => points;
    //        set { points = value; OnPropertyChanged(); }
    //    }


    //    /// <summary>
    //    /// X Coordinates of the points
    //    /// </summary>
    //    public List<double> X
    //    {
    //        get => Points.Select(x=>x.x).ToList();
    //    }

    //    /// <summary>
    //    /// Y Coordinates of the points
    //    /// </summary>
    //    public List<double> Y
    //    {
    //        get => Points.Select(x => x.y).ToList();
    //    }
    //    private DW.Color color;
    //    /// <summary>
    //    /// Color of the line
    //    /// </summary>
    //    public DW.Color Color
    //    {
    //        get => color;
    //        set { color = value; OnPropertyChanged(); }
    //    }

    //    private LineStyle linestyle;
    //    /// <summary>
    //    /// Linestyle
    //    /// </summary>
    //    public LineStyle Linestyle
    //    {
    //        get => linestyle;
    //        set { linestyle = value; OnPropertyChanged(); }

    //        }


    //    /// <summary>
    //    /// Constructor without arguments
    //    /// </summary>
    //    public PointLine()
    //    {
    //        points = new List<pt>();
    //        pt temppt = new pt();
    //        temppt.x = 0.0;
    //        temppt.y = 0.0;
    //        points.Add(temppt);

    //        color = DW.Color.Black;
    //        linestyle = new LineStyle();
    //        linestyle = LineStyle.Solid;
    //        OnPropertyChanged();
    //    }

    //    public PointLine(List<double> _x, List<double> _y)
    //    {
    //        points = new List<pt>();

    //        color = DW.Color.Black;
    //        linestyle = new LineStyle();
    //        linestyle = LineStyle.Solid;

    //        int npoints = Math.Min(_x.Count,_y.Count);

    //        pt temppt = new pt();
    //        for (int i = 0;i < npoints; i++)
    //        {
    //            if (!((_x[i] is double.NaN)|(_y[i] is double.NaN))){
    //                temppt.x = _x[i];
    //                temppt.y = _y[i];
    //                points.Add(temppt);
    //            }
    //        }
    //        OnPropertyChanged();
    //    }
    //    public void AddPoint(double xx, double yy)
    //    {
    //        pt temppt = new pt();
    //        temppt.x = xx;
    //        temppt.y = yy;

    //        Points.Add(temppt);
    //        OnPropertyChanged();
    //    }
    //    public void OrderArcendingByX()
    //    {
    //        points.OrderBy(x => x.x);
    //        OnPropertyChanged();
    //    }
    //    public void OrderDescendingByX()
    //    {
    //        points.OrderBy(x => x.x).Reverse();
    //        OnPropertyChanged();
    //    }
    //    public void OrderArcendingByY()
    //    {
    //        points.OrderBy(x => x.x);
    //        OnPropertyChanged();
    //    }
    //    public void OrderDescendingByY()
    //    {
    //        points.OrderBy(x => x.y).Reverse();
    //        OnPropertyChanged();
    //    }

    //    #region Events
    //    public event PropertyChangedEventHandler PropertyChanged;
    //    protected void OnPropertyChanged([CallerMemberName] string name = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }
    //    #endregion

    //}
}
