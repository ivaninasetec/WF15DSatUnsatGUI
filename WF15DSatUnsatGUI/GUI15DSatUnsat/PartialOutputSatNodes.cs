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
        /// Datatable with the Outputs at the nodes in the 1DSat modules
        /// </summary>
        public OutputSatNodes OutputSatNodesList = new OutputSatNodes();
        private void button_SatNodes_Update_Click(object sender, EventArgs e)
        {
            try
            {
                //if (OutputSatNodesList.nfields == 0)
                //{
                    OutputSatNodesList = new OutputSatNodes(Model.FilePath + @"\" + Model.FileNameWithoutExtension + ".outnods.csv");
                    sourceOutputSatNodes = new BindingSource(OutputSatNodesList.Items, null);
                    bindingNavigator_OutputSatNodes.BindingSource = sourceOutputSatNodes;
                    dataGridView_OutputSatNodes.DataSource = sourceOutputSatNodes;


                    int nlayers = Model.Com_Ty_Layers.Layers.Count;
                    double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height) + Model.Com_Ty_Layers.Slopebottom * Model.Com_Ty_Layers.Width;

                    double zbottom = -totalheight;

                    scatterXYControl_SatNodes_Layers.Plot.Clear();
                    scatterXYControl_SatNodes_Layers.XAxisMin = 0.0;
                    scatterXYControl_SatNodes_Layers.XAxisMax = Model.Com_Ty_Layers.Width;
                    scatterXYControl_SatNodes_Layers.YAxisMin = zbottom;
                    scatterXYControl_SatNodes_Layers.YAxisMax = 0.0; 
                    scatterXYControl_SatNodes_Layers.LockHorizontalAxis = false;
                    scatterXYControl_SatNodes_Layers.LockVerticalAxis = false;
                    scatterXYControl_SatNodes_Layers.Plot.AddHorizontalLine(0.0, color: Color.Black);
                    scatterXYControl_SatNodes_Layers.Plot.AddVerticalLine(0.0, color: Color.Black);

                    scatterXYControl_SatNodes_Others.Plot.Clear();
                    scatterXYControl_SatNodes_Others.XAxisMin = 0.0;
                    scatterXYControl_SatNodes_Others.XAxisMax = Model.Com_Ty_Layers.Width;
                    scatterXYControl_SatNodes_Others.YAxisMin = -1.0;
                    scatterXYControl_SatNodes_Others.YAxisMax = 1.0;
                    scatterXYControl_SatNodes_Others.LockHorizontalAxis = false;
                    scatterXYControl_SatNodes_Others.LockVerticalAxis = false;
                    scatterXYControl_SatNodes_Others.Plot.AddHorizontalLine(0.0, color: Color.Black);
                    scatterXYControl_SatNodes_Others.Plot.AddVerticalLine(0.0, color: Color.Black);

                //}
                //else
                //{
                //    OutputSatNodesList.Update();
                //    sourceOutputSatNodes = new BindingSource(OutputSatNodesList.Items, null);
                //    bindingNavigator_OutputSatNodes.BindingSource = sourceOutputSatNodes;
                //    dataGridView_OutputSatNodes.DataSource = sourceOutputSatNodes;
                //}

            }
            catch (InvalidCastException exception)
            {
                MessageBox.Show(exception.Message);
            }

            PlotInScatterPlot.PlotLayers(scatterXYControl_SatNodes_Layers, Model);
            PlotInScatterPlot.PlotVerticalModules(scatterXYControl_SatNodes_Layers, Model);

            comboBox_SatNodes_numIS.DataSource = OutputSatNodesList.NumIS;
            comboBox_SatNodes_numIS.SelectedIndex = 0;
            comboBox_SatNodes_numIS.Select();
            //comboBox_SatNodes_numIU.DataSource = OutputSatNodesList.NumIU;
            //comboBox_SatNodes_numIU.SelectedIndex = 0;
            //comboBox_SatNodes_numIU.Select();
            comboBox_SatNodes_T.DataSource = OutputSatNodesList.T;
            comboBox_SatNodes_T.SelectedIndex = 0;
            comboBox_SatNodes_T.Select();

            comboBox_SatNodes_Variable.SelectedIndex = 0;
            comboBox_SatNodes_Variable.Select();
        }

        private void button_SatNodes_Add_Variable_Click(object sender, EventArgs e)
        {
            string timeformat = OutputSatNodesList.TimeNumberFormat;
            int nline;

            int numIS = Convert.ToInt32(comboBox_SatNodes_numIS.SelectedItem);
            string tvalue = (string)comboBox_SatNodes_T.SelectedItem;

            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height) + Model.Com_Ty_Layers.Slopebottom * Model.Com_Ty_Layers.Width;

            double zbottom = -totalheight + Model.Com_Ty_Layers.Layers.Take(numIS - 1).Sum(x => x.Height);

            //int numIU = Convert.ToInt32(comboBox_SatNodes_numIU.SelectedItem);

            //t,is,x,z,head,qent,qincvol,qhor,dqhordx,dqhordx_from_incvol,qhor_all,dqhordx_all,dqhordx_from_incvol_all

            switch (comboBox_SatNodes_Variable.Text)
            {
                //case "x":
                //    scatterXYControl_SatNodes_Layers.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray());
                //    scatterXYControl_SatNodes_Layers.PlotLines[nline].Label = "x";
                //    break;

                //case "z":
                //    scatterXYControl_SatNodes_Layers.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.z).ToArray());
                //    scatterXYControl_SatNodes_Layers.PlotLines[nline].Label = "z";
                //    break;
                case "head":
                    nline = scatterXYControl_SatNodes_Layers.PlotLines.Count;
                    scatterXYControl_SatNodes_Layers.AddLine();
                    scatterXYControl_SatNodes_Layers.PlotLines[nline].MarkerSize = 0;
                    //scatterXYControl_SatNodes_Layers.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.head+x.z + zbottom).ToArray());
                    scatterXYControl_SatNodes_Layers.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.head + x.z).ToArray());
                    scatterXYControl_SatNodes_Layers.PlotLines[nline].Label = "T="+ tvalue.ToString()+" IS="+numIS.ToString();
                    break;
                case "qent":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qent).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "qent (T="+ tvalue.ToString()+" IS="+numIS.ToString()+")";
                    break;
                case "qincvol":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qincvol).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "qincvol (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "qhor":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qhor).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "qhor (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "dqhordx":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "dqhord (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "dqhordx_from_incvol":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvol).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "dqhordx_from_incvol (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "qhor_all":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.qhor_all).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "qhor_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "dqhordx_all":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_all).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "dqhordx_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                case "dqhordx_from_incvol_all":
                    nline = scatterXYControl_SatNodes_Others.PlotLines.Count;
                    scatterXYControl_SatNodes_Others.AddLine();
                    scatterXYControl_SatNodes_Others.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_SatNodes_Others.PlotLines[nline].AddRange(OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.x).ToArray(), OutputSatNodesList.Items.Where(x => x.IS == numIS).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.dqhordx_from_incvol_all).ToArray());
                    scatterXYControl_SatNodes_Others.PlotLines[nline].Label = "dqhordx_from_incvol_all (T=" + tvalue.ToString() + " IS=" + numIS.ToString() + ")";
                    break;
                default:
                    break;
            }
            scatterXYControl_SatNodes_Layers.Plot.Legend(true);
            scatterXYControl_SatNodes_Layers.Render();

            scatterXYControl_SatNodes_Others.Plot.Legend(true);
            scatterXYControl_SatNodes_Others.Render();
        }

        private void button_SatNodes_Clear_Click(object sender, EventArgs e)
        {
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height) + Model.Com_Ty_Layers.Slopebottom * Model.Com_Ty_Layers.Width;

            double zbottom = -totalheight;

            scatterXYControl_SatNodes_Layers.Plot.Clear();

            scatterXYControl_SatNodes_Layers.XAxisMin = 0.0;
            scatterXYControl_SatNodes_Layers.XAxisMax = Model.Com_Ty_Layers.Width;
            scatterXYControl_SatNodes_Layers.YAxisMin = zbottom;
            scatterXYControl_SatNodes_Layers.YAxisMax = 0.0;
            scatterXYControl_SatNodes_Layers.LockHorizontalAxis = false;
            scatterXYControl_SatNodes_Layers.LockVerticalAxis = false;
            scatterXYControl_SatNodes_Layers.Plot.AddHorizontalLine(0.0, color: Color.Black);
            scatterXYControl_SatNodes_Layers.Plot.AddVerticalLine(0.0, color: Color.Black);

            scatterXYControl_SatNodes_Others.Plot.Clear();
            scatterXYControl_SatNodes_Others.XAxisMin = 0.0;
            scatterXYControl_SatNodes_Others.XAxisMax = Model.Com_Ty_Layers.Width;
            scatterXYControl_SatNodes_Others.YAxisMin = -1.0;
            scatterXYControl_SatNodes_Others.YAxisMax = 1.0;
            scatterXYControl_SatNodes_Others.LockHorizontalAxis = false;
            scatterXYControl_SatNodes_Others.LockVerticalAxis = false;
            scatterXYControl_SatNodes_Others.Plot.AddHorizontalLine(0.0, color: Color.Black);
            scatterXYControl_SatNodes_Others.Plot.AddVerticalLine(0.0, color: Color.Black);

            scatterXYControl_SatNodes_Layers.Render();
            scatterXYControl_SatNodes_Others.Render();

            PlotInScatterPlot.PlotLayers(scatterXYControl_SatNodes_Layers, Model);
            PlotInScatterPlot.PlotVerticalModules(scatterXYControl_SatNodes_Layers, Model);
        }

    }
}
