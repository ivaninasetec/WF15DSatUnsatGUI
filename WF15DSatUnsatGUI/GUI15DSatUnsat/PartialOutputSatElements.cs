using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;

namespace GUI15DSATUNSAT
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        /// <summary>
        /// Datatable with the Outputs at the Ekements in the 1DSat modules
        /// </summary>
        public OutputSatElements OutputSatElementsList = new OutputSatElements();
        private void button_SatElements_Update_Click(object sender, EventArgs e)
        {
            try
            {
                //if (OutputSatElementsList.nfields == 0)
                //{
                    OutputSatElementsList = new OutputSatElements(Model.FilePath + @"\" + Model.FileNameWithoutExtension + ".outelms.csv");
                    sourceOutputSatElements = new BindingSource(OutputSatElementsList.Items, null);
                    bindingNavigator_OutputSatElements.BindingSource = sourceOutputSatElements;
                    dataGridView_OutputSatElements.DataSource = sourceOutputSatElements;


                    int nlayers = Model.Com_Ty_Layers.Layers.Count;
                    double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height)+Model.Com_Ty_Layers.Slopebottom* Model.Com_Ty_Layers.Width;

                    double zbottom = -totalheight;

                    scatterXYControl_SatElements_Layers.Plot.Clear();
                    scatterXYControl_SatElements_Layers.XAxisMin = 0.0;
                    scatterXYControl_SatElements_Layers.XAxisMax = Model.Com_Ty_Layers.Width;
                    scatterXYControl_SatElements_Layers.YAxisMin = zbottom;
                    scatterXYControl_SatElements_Layers.YAxisMax = 0.0;
                    scatterXYControl_SatElements_Layers.LockHorizontalAxis = false;
                    scatterXYControl_SatElements_Layers.LockVerticalAxis = false;
                    scatterXYControl_SatElements_Layers.Plot.AddHorizontalLine(0.0, color: Color.Black, width: 2);
                    scatterXYControl_SatElements_Layers.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

                    scatterXYControl_SatElements_Others.Plot.Clear();
                    scatterXYControl_SatElements_Others.XAxisMin = 0.0;
                    scatterXYControl_SatElements_Others.XAxisMax = Model.Com_Ty_Layers.Width;
                    scatterXYControl_SatElements_Others.YAxisMin = -1.0;
                    scatterXYControl_SatElements_Others.YAxisMax = 1.0;
                    scatterXYControl_SatElements_Others.LockHorizontalAxis = false;
                    scatterXYControl_SatElements_Others.LockVerticalAxis = false;
                    scatterXYControl_SatElements_Others.Plot.AddHorizontalLine(0.0, color: Color.Black);
                    scatterXYControl_SatElements_Others.Plot.AddVerticalLine(0.0, color: Color.Black);

                //}
                //else
                //{
                //    OutputSatElementsList.Update();
                //    sourceOutputSatElements = new BindingSource(OutputSatElementsList.Items, null);
                //    bindingNavigator_OutputSatElements.BindingSource = sourceOutputSatElements;
                //    dataGridView_OutputSatElements.DataSource = sourceOutputSatElements;
                //}

            }
            catch (InvalidCastException exception)
            {
                MessageBox.Show(exception.Message);
            }

            PlotInScatterPlot.PlotLayers(scatterXYControl_SatElements_Layers, Model);
            PlotInScatterPlot.PlotVerticalModules(scatterXYControl_SatElements_Layers, Model);


            comboBox_SatElements_numIS.DataSource = OutputSatElementsList.NumIS;
            comboBox_SatElements_numIS.SelectedIndex = 0;
            comboBox_SatElements_numIS.Select();
            //comboBox_SatElements_numIU.DataSource = OutputSatElementsList.NumIU;
            //comboBox_SatElements_numIU.SelectedIndex = 0;
            //comboBox_SatElements_numIU.Select();
            comboBox_SatElements_T.DataSource = OutputSatElementsList.T;
            comboBox_SatElements_T.SelectedIndex = 0;
            comboBox_SatElements_T.Select();

            comboBox_SatElements_Variable.SelectedIndex = 0;
            comboBox_SatElements_Variable.Select();
        }

        private void button_SatElements_Add_Variable_Click(object sender, EventArgs e)
        {
            string timeformat = OutputSatElementsList.TimeNumberFormat;
            int nline;
            
            int numIS = Convert.ToInt32(comboBox_SatElements_numIS.SelectedItem);
            string tvalue = (string)comboBox_SatElements_T.SelectedItem;
            //int numIU = Convert.ToInt32(comboBox_SatElements_numIU.SelectedItem);

            //t,is,ie,x0,x1,z0,z1,h0,h1,h,dhdx,dhzdx,qent,incvoldt,dqhordx,dqhordx_all,dqhordx_from_incvoldt,dqhordx_from_incvoldt_all,q,q_all
            double[] x0, x1, y0, y1;
            List<double> xtp, ytp;

            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height) + Model.Com_Ty_Layers.Slopebottom * Model.Com_Ty_Layers.Width; ;
            
            double zbottom = - totalheight + Model.Com_Ty_Layers.Layers.Take(numIS-1).Sum(x=> x.Height);

            switch (comboBox_SatElements_Variable.Text)
            {
                //case "x":
                //    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                //    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                //    xtp = new List<double>();

                //    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]);}


                //    scatterXYControl_SatElements_Layers.PlotLines[nline].AddRange(xtp.ToArray(), xtp.ToArray());
                //    scatterXYControl_SatElements_Layers.PlotLines[nline].Label = "x";
                //    break;

                //case "z":
                //    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                //    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                //    xtp = new List<double>();

                //    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                //    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.z0).ToArray();
                //    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.z1).ToArray();
                //    ytp = new List<double>();

                //    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                //    scatterXYControl_SatElements_Layers.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                //    scatterXYControl_SatElements_Layers.PlotLines[nline].Label = "z";
                //    break;

                case "head":
                    nline = scatterXYControl_SatElements_Layers.PlotLines.Count;
                    scatterXYControl_SatElements_Layers.AddLine();
                    scatterXYControl_SatElements_Layers.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    //y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h0+x.z0 + zbottom).ToArray();
                    //y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h1 + x.z1 + zbottom).ToArray();
                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h0 + x.z0).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h1 + x.z1).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Layers.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Layers.PlotLines[nline].Label = "T=" + tvalue.ToString() + " IS=" + numIS.ToString(); ;
                    break;

                case "dhdx":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhdx).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhdx).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dhdx (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "dhzdx":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhzdx).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dhzdx).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dhzdx (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "qent":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qent).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qent).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "qent (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "incvoldt":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.incvoldt).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.incvoldt).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "incvoldt (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "dqhordx":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dqhordx (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "dqhordx_all":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_all).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_all).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dqhordx_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "dqhordx_from_incvoldt":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvoldt).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvoldt).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dqhordx_from_incvoldt (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "dqhordx_from_incvoldt_all":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvoldt_all).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvoldt_all).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "dqhordx_from_incvoldt_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "q":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.q).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.q).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "q (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                case "q_all":
                    nline = scatterXYControl_SatElements_Others.PlotLines.Count;
                    scatterXYControl_SatElements_Others.AddLine();
                    scatterXYControl_SatElements_Others.PlotLines[nline].MarkerSize = 0;

                    x0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x0).ToArray();
                    x1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x1).ToArray();
                    xtp = new List<double>();

                    for (int i = 0; i < x0.Length; i++) { xtp.Add(x0[i]); xtp.Add(x1[i]); }

                    y0 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.q_all).ToArray();
                    y1 = OutputSatElementsList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.q_all).ToArray();
                    ytp = new List<double>();

                    for (int i = 0; i < y0.Length; i++) { ytp.Add(y0[i]); ytp.Add(y1[i]); }

                    scatterXYControl_SatElements_Others.PlotLines[nline].AddRange(xtp.ToArray(), ytp.ToArray());
                    scatterXYControl_SatElements_Others.PlotLines[nline].Label = "q_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;

                default:
                    break;
            }
            scatterXYControl_SatElements_Layers.Plot.Legend(true);
            scatterXYControl_SatElements_Layers.Render();

            scatterXYControl_SatElements_Others.Plot.Legend(true);
            scatterXYControl_SatElements_Others.Render();
        }

        private void button_SatElements_Clear_Click(object sender, EventArgs e)
        {
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height) + Model.Com_Ty_Layers.Slopebottom * Model.Com_Ty_Layers.Width; ;

            double zbottom = - totalheight;

            scatterXYControl_SatElements_Layers.Plot.Clear();

            scatterXYControl_SatElements_Layers.XAxisMin = 0.0;
            scatterXYControl_SatElements_Layers.XAxisMax = Model.Com_Ty_Layers.Width;
            scatterXYControl_SatElements_Layers.YAxisMin = zbottom;
            scatterXYControl_SatElements_Layers.YAxisMax = 0.0;
            scatterXYControl_SatElements_Layers.LockHorizontalAxis = false;
            scatterXYControl_SatElements_Layers.LockVerticalAxis = false;
            scatterXYControl_SatElements_Layers.Plot.AddHorizontalLine(0.0, color: Color.Black, width: 2);
            scatterXYControl_SatElements_Layers.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

            scatterXYControl_SatElements_Others.Plot.Clear();
            scatterXYControl_SatElements_Others.XAxisMin = 0.0;
            scatterXYControl_SatElements_Others.XAxisMax = Model.Com_Ty_Layers.Width;
            scatterXYControl_SatElements_Others.YAxisMin = -1.0;
            scatterXYControl_SatElements_Others.YAxisMax = 1.0;
            scatterXYControl_SatElements_Others.LockHorizontalAxis = false;
            scatterXYControl_SatElements_Others.LockVerticalAxis = false;
            scatterXYControl_SatElements_Others.Plot.AddHorizontalLine(0.0, color: Color.Black);
            scatterXYControl_SatElements_Others.Plot.AddVerticalLine(0.0, color: Color.Black);

            scatterXYControl_SatElements_Layers.Render();
            scatterXYControl_SatElements_Others.Render();

            PlotInScatterPlot.PlotLayers(scatterXYControl_SatElements_Layers, Model);
            PlotInScatterPlot.PlotVerticalModules(scatterXYControl_SatElements_Layers, Model);

        }


    }
}
