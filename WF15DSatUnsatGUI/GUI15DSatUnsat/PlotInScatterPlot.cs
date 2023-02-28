using FlowModelLib;
using GraphControls;
using ScottPlot;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GUI15DSATUNSAT
{
    public class PlotInScatterPlot
    {
        public static void PlotLayers(ScatterXYControl ScatterControl, Model_ty_model Model)
        {
            List<List<double>> xlayers = new List<List<double>>();
            List<List<double>> ylayers = new List<List<double>>();
            
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            double currenthlayer= - totalheight;
            double slopebottom = Model.Com_Ty_Layers.Slopebottom;
            

            for (int i=0;i<Model.Com_Ty_Layers.Count;i++)
            {
                List<double> xlayer = new List<double>();
                xlayer.Add(0.0);
                xlayer.Add(Model.Com_Ty_Layers.Width);
                xlayer.Add(Model.Com_Ty_Layers.Width);
                xlayer.Add(0.0);
                //xlayer.Add(0.0);

                List<double> ylayer = new List<double>();
                ylayer.Add(currenthlayer);
                ylayer.Add(currenthlayer - Model.Com_Ty_Layers.Width * slopebottom);
                ylayer.Add(currenthlayer + Model.Com_Ty_Layers.Layers[i].Height - Model.Com_Ty_Layers.Width * Model.Com_Ty_Layers.Layers[i].Slope);
                ylayer.Add(currenthlayer + Model.Com_Ty_Layers.Layers[i].Height);
                //ylayer.Add(currenthlayer);
                slopebottom = Model.Com_Ty_Layers.Layers[i].Slope;
                currenthlayer = currenthlayer + Model.Com_Ty_Layers.Layers[i].Height;

                xlayers.Add(xlayer);
                ylayers.Add(ylayer);
            }

            //for (int i = 0; i < Model.Com_Ty_Layers.Count; i++) { 
            //    ScatterControl.AddLine();
            //    int nline = ScatterControl.PlotLines.Count-1;
            //    ScatterControl.PlotLines[nline].LineStyle = LineStyle.Solid;
            //    ScatterControl.PlotLines[nline].Color = Color.Black;
            //    ScatterControl.PlotLines[nline].MarkerSize = 0;
            //    ScatterControl.PlotLines[nline].AddRange(xlayers[i].ToArray(), ylayers[i].ToArray());
            //}

            for (int i = 0; i < Model.Com_Ty_Layers.Count; i++)
            {
                //ScatterControl.AddLine();
                //int nline = ScatterControl.PlotLines.Count - 1;
                //ScatterControl.PlotLines[nline].LineStyle = LineStyle.Solid;
                //ScatterControl.PlotLines[nline].Color = Color.Black;
                //ScatterControl.PlotLines[nline].MarkerSize = 0;
                ScatterControl.Plot.AddPolygon(xlayers[i].ToArray(), ylayers[i].ToArray(), ScatterControl.Plot.GetNextColor(.1), lineWidth: 2);
            }

            ScatterControl.Render();

        }

        public static void PlotVerticalModules(ScatterXYControl ScatterControl, Model_ty_model Model)
        {
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            for (int i=0;i<Model.Model_Ty_Mesh.Vertical_Modules.Count;i++)
            {
                ScatterControl.AddLine();
                int nline = ScatterControl.PlotLines.Count - 1;
                ScatterControl.PlotLines[nline].LineStyle = LineStyle.Solid;
                ScatterControl.PlotLines[nline].LineWidth= 2;
                ScatterControl.PlotLines[nline].Color = Color.Red;
                ScatterControl.PlotLines[nline].MarkerSize = 0;

                double ztop = - Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[i].Vmod_x;
                double zbottom = - totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[i].Vmod_x;

                ScatterControl.PlotLines[nline].Add(Model.Model_Ty_Mesh.Vertical_Modules[i].Vmod_x, zbottom);
                ScatterControl.PlotLines[nline].Add(Model.Model_Ty_Mesh.Vertical_Modules[i].Vmod_x, ztop);
            }

            ScatterControl.Render();

        }
        public static void PlotHorizontalUnsatLayers(ScatterXYControl ScatterControl, Model_ty_model Model, int numIU)
        {
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            //double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;
            //double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;

            for (int i = 0; i < nlayers; i++)
            {
                double zbottom = -totalheight + Model.Com_Ty_Layers.Layers.Take(i).Sum(x => x.Height);

                ScatterControl.Plot.AddHorizontalLine(zbottom, color: Color.Green, width: 2);
            }

            ScatterControl.Render();
        }
    }
}
