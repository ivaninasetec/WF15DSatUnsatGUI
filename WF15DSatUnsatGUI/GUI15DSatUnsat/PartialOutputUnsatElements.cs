using FlowModelLib;
using GraphControls;
using ScottPlot.Drawing.Colormaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI15DSATUNSAT
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        /// <summary>
        /// Datatable with the Outputs at the Ekements in the 1DUnsat modules
        /// </summary>
        public OutputUnsatElements OutputUnsatElementsList = new OutputUnsatElements();
        private void button_UnsatElements_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (OutputUnsatElementsList.nfields == 0)
                {
                    OutputUnsatElementsList = new OutputUnsatElements(Model.FilePath + @"\" + Model.FileNameWithoutExtension + ".outelmu.csv");
                    sourceOutputUnsatElements = new BindingSource(OutputUnsatElementsList.Items, null);
                    bindingNavigator_OutputUnsatElements.BindingSource = sourceOutputUnsatElements;
                    dataGridView_OutputUnsatElements.DataSource = sourceOutputUnsatElements;

                    int numIU = 1;
                    
                    int nlayers = Model.Com_Ty_Layers.Layers.Count;
                    double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
                    double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;
                    double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;


                    scatterXYControl_UnsatElements.Plot.Clear();
                    scatterXYControl_UnsatElements.XAxisMin = - Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
                    scatterXYControl_UnsatElements.XAxisMax = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
                    scatterXYControl_UnsatElements.YAxisMin = zbottom;
                    scatterXYControl_UnsatElements.YAxisMax = ztop;
                    scatterXYControl_UnsatElements.LockHorizontalAxis = false;
                    scatterXYControl_UnsatElements.LockVerticalAxis = false;
                    scatterXYControl_UnsatElements.Plot.AddHorizontalLine(0.0, color: Color.Brown, width: 2);
                    scatterXYControl_UnsatElements.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

                }
                else
                {
                    OutputUnsatElementsList.Update();
                    sourceOutputUnsatElements = new BindingSource(OutputUnsatElementsList.Items, null);
                    bindingNavigator_OutputUnsatElements.BindingSource = sourceOutputUnsatElements;
                    dataGridView_OutputUnsatElements.DataSource = sourceOutputUnsatElements;
                }

            }
            catch (InvalidCastException exception)
            {
                MessageBox.Show(exception.Message);
            }

            //PlotInScatterPlot.PlotLayers(scatterXYControl_UnsatElements, Model);
            //PlotInScatterPlot.PlotVerticalModules(scatterXYControl_UnsatElements, Model);


            comboBox_UnsatElements_numIU.DataSource = OutputUnsatElementsList.NumIU;
            comboBox_UnsatElements_numIU.SelectedIndex = 0;
            comboBox_UnsatElements_numIU.Select();

            comboBox_UnsatElements_T.DataSource = OutputUnsatElementsList.T;
            comboBox_UnsatElements_T.SelectedIndex = 0;
            comboBox_UnsatElements_T.Select();

            comboBox_UnsatElements_Variable.SelectedIndex = 0;
            comboBox_UnsatElements_Variable.Select();
        }

        private void button_UnsatElements_Add_Variable_Click(object sender, EventArgs e)
        {
            string timeformat = OutputUnsatElementsList.TimeNumberFormat;
            int nline;

            int numIU = Convert.ToInt32(comboBox_UnsatElements_numIU.SelectedItem);
            string tvalue = (string)comboBox_UnsatElements_T.SelectedItem;
            //int numIU = Convert.ToInt32(comboBox_UnsatElements_numIU.SelectedItem);

            //t,iu,nelem,x0,x1,hnew,hold,thnew,thold,qent,qsal,qmed,incvoldt,kmed,h0,h1,th0,th1,k0,k1,dhdx0,dhdx1,dhxdx0,dhxdx1,dhdxmed,dhxdxmed
            // Head, Volumetric Water Content, qent, qsal,qmed,incvoldt,k,dhdx,dhxdx

            double[] x0, x1, y0, y1;
            List<double> xtp, ytp;

            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU-1].Vmod_x;
            double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU-1].Vmod_x;


            switch (comboBox_UnsatElements_Variable.Text)
            {

                case "Head":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop+x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop+x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h0).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "Head";
                    break;

                case "Volumetric Water Content":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.th0).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.th1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "wc";
                    break;

                case "qent":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qent).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qent).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "qent";
                    break;

                case "qsal":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qsal).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qsal).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "qsal";
                    break;

                case "qmed":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qmed).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qmed).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "qmed";
                    break;

                case "incvoldt":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.incvoldt).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.incvoldt).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "incvoldt";
                    break;

                case "k":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.k0).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.k1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "k";
                    break;

                case "dhdx":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhdx0).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhdx1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "dhdx";
                    break;

                case "dhxdx":
                    nline = scatterXYControl_UnsatElements.PlotLines.Count;
                    scatterXYControl_UnsatElements.AddLine();
                    scatterXYControl_UnsatElements.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x0).ToArray();
                    x1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhxdx0).ToArray();
                    y1 = OutputUnsatElementsList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhxdx1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_UnsatElements.PlotLines[nline].AddRange(ytp.ToArray(), xtp.ToArray());
                    scatterXYControl_UnsatElements.PlotLines[nline].Label = "dhxdx";
                    break;

                default:
                    break;
            }
            scatterXYControl_UnsatElements.Plot.Legend(true);
            scatterXYControl_UnsatElements.Render();

        }

        private void button_UnsatElements_Clear_Click(object sender, EventArgs e)
        {
            
            int numIU = 1;
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;
            double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;


            scatterXYControl_UnsatElements.Plot.Clear();
            scatterXYControl_UnsatElements.XAxisMin = -Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            scatterXYControl_UnsatElements.XAxisMax = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            scatterXYControl_UnsatElements.YAxisMin = zbottom;
            scatterXYControl_UnsatElements.YAxisMax = ztop;
            scatterXYControl_UnsatElements.LockHorizontalAxis = false;
            scatterXYControl_UnsatElements.LockVerticalAxis = false;
            scatterXYControl_UnsatElements.Plot.AddHorizontalLine(0.0, color: Color.Black, width: 2);
            scatterXYControl_UnsatElements.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

            scatterXYControl_UnsatElements.Render();

            
            //PlotInScatterPlot.PlotVerticalModules(scatterXYControl_SatElements_Layers, Model);

        }

        private void comboBox_UnsatElements_numIU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            button_UnsatElements_Clear_Click(sender, e);
            PlotInScatterPlot.PlotHorizontalUnsatLayers(scatterXYControl_UnsatElements, Model, Convert.ToInt16(cmb.Text));
        }

    }
}
