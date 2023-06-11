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
        public OutputUnsatNodes OutputUnsatNodesList = new OutputUnsatNodes();
        private void button_UnsatNodes_Update_Click(object sender, EventArgs e)
        {
            try
            {
                //if (OutputUnsatNodesList.nfields == 0)
                //{
                    OutputUnsatNodesList = new OutputUnsatNodes(Model.FilePath + @"\" + Model.FileNameWithoutExtension + ".outnodu.csv");
                    sourceOutputUnsatNodes = new BindingSource(OutputUnsatNodesList.Items, null);
                    bindingNavigator_OutputUnsatNodes.BindingSource = sourceOutputUnsatNodes;
                    dataGridView_OutputUnsatNodes.DataSource = sourceOutputUnsatNodes;

                    

                    int numIU = 1;
                    int nlayers = Model.Com_Ty_Layers.Layers.Count;
                    double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
                    double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;
                    double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;

                    scatterXYControl_UnsatNodes.Plot.Clear();
                    scatterXYControl_UnsatNodes.XAxisMin = -1.0; 
                    scatterXYControl_UnsatNodes.XAxisMax = 1.0;
                    scatterXYControl_UnsatNodes.YAxisMin = zbottom;
                    scatterXYControl_UnsatNodes.YAxisMax = ztop;
                    scatterXYControl_UnsatNodes.LockHorizontalAxis = false;
                    scatterXYControl_UnsatNodes.LockVerticalAxis = false;
                    scatterXYControl_UnsatNodes.Plot.AddHorizontalLine(0.0, color: Color.Brown, width: 2);
                    scatterXYControl_UnsatNodes.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

                //}
                //else
                //{
                //    OutputUnsatNodesList.Update();
                //    sourceOutputUnsatNodes = new BindingSource(OutputUnsatNodesList.Items, null);
                //    bindingNavigator_OutputUnsatNodes.BindingSource = sourceOutputUnsatNodes;
                //    dataGridView_OutputUnsatNodes.DataSource = sourceOutputUnsatNodes;
                //}

            }
            catch (InvalidCastException exception)
            {
                MessageBox.Show(exception.Message);
            }

            //PlotInScatterPlot.PlotLayers(scatterXYControl_UnsatNodes_Layers, Model);
            //PlotInScatterPlot.PlotVerticalModules(scatterXYControl_UnsatNodes_Layers, Model);

            comboBox_UnsatNodes_numIU.DataSource = OutputUnsatNodesList.NumIU;
            comboBox_UnsatNodes_numIU.SelectedIndex = 0;
            comboBox_UnsatNodes_numIU.Select();

            comboBox_UnsatNodes_T.DataSource = OutputUnsatNodesList.T;
            comboBox_UnsatNodes_T.SelectedIndex = 0;
            comboBox_UnsatNodes_T.Select();

            comboBox_UnsatNodes_Variable.SelectedIndex = 0;
            comboBox_UnsatNodes_Variable.Select();
        }

        private void button_UnsatNodes_Add_Variable_Click(object sender, EventArgs e)
        {
            string timeformat = OutputUnsatNodesList.TimeNumberFormat;
            int nline;

            int numIU = Convert.ToInt32(comboBox_UnsatNodes_numIU.SelectedItem);
            string tvalue = (string)comboBox_UnsatNodes_T.SelectedItem;
            //int numIU = Convert.ToInt32(comboBox_UnsatNodes_numIU.SelectedItem);

            //t,is,x,z,head,qent,qincvol,qhor,dqhordx,dqhordx_from_incvol,qhor_all,dqhordx_all,dqhordx_from_incvol_all

            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU-1].Vmod_x;
            double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU-1].Vmod_x;

            switch (comboBox_UnsatNodes_Variable.Text)
            {
                case "Head":
                    nline = scatterXYControl_UnsatNodes.PlotLines.Count;
                    scatterXYControl_UnsatNodes.AddLine();
                    scatterXYControl_UnsatNodes.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_UnsatNodes.PlotLines[nline].AddRange(OutputUnsatNodesList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.h).ToArray(), OutputUnsatNodesList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x).ToArray());
                    scatterXYControl_UnsatNodes.PlotLines[nline].Label = "T=" + tvalue.ToString() + " IU=" + numIU.ToString();
                    break;
                case "Volumentric Water Content":
                    nline = scatterXYControl_UnsatNodes.PlotLines.Count;
                    scatterXYControl_UnsatNodes.AddLine();
                    scatterXYControl_UnsatNodes.PlotLines[nline].MarkerSize = 0;
                    scatterXYControl_UnsatNodes.PlotLines[nline].AddRange(OutputUnsatNodesList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => x.th).ToArray(), OutputUnsatNodesList.Items.Where(x => x.IU == numIU).Where(x => x.T.ToString(timeformat) == tvalue).Select(x => ztop + x.x).ToArray());
                    scatterXYControl_UnsatNodes.PlotLines[nline].Label = "qent (T=" + tvalue.ToString() + " IU=" + numIU.ToString() + ")";
                    break;

                default:
                    break;
            }
            scatterXYControl_UnsatNodes.Plot.Legend(true);
            scatterXYControl_UnsatNodes.Render();

            scatterXYControl_UnsatNodes.Plot.Legend(true);
            scatterXYControl_UnsatNodes.Render();
        }

        private void button_UnsatNodes_Clear_Click(object sender, EventArgs e)
        {
            
            int numIU = 1;
            int nlayers = Model.Com_Ty_Layers.Layers.Count;
            double totalheight = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            double ztop = -Model.Com_Ty_Layers.Layers[nlayers - 1].Slope * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;
            double zbottom = -totalheight - Model.Com_Ty_Layers.Slopebottom * Model.Model_Ty_Mesh.Vertical_Modules[numIU - 1].Vmod_x;

            scatterXYControl_UnsatNodes.Plot.Clear();
            scatterXYControl_UnsatNodes.XAxisMin = -Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            scatterXYControl_UnsatNodes.XAxisMax = Model.Com_Ty_Layers.Layers.Sum(x => x.Height);
            scatterXYControl_UnsatNodes.YAxisMin = zbottom;
            scatterXYControl_UnsatNodes.YAxisMax = ztop;
            scatterXYControl_UnsatNodes.LockHorizontalAxis = false;
            scatterXYControl_UnsatNodes.LockVerticalAxis = false;
            scatterXYControl_UnsatNodes.Plot.AddHorizontalLine(0.0, color: Color.Brown, width:2);
            scatterXYControl_UnsatNodes.Plot.AddVerticalLine(0.0, color: Color.Black, width: 2);

            scatterXYControl_UnsatNodes.Render();

            //PlotInScatterPlot.PlotLayers(scatterXYControl_UnsatNodes_Layers, Model);
            //PlotInScatterPlot.PlotVerticalModules(scatterXYControl_UnsatNodes_Layers, Model);
        }

        private void comboBox_UnsatNodes_numIU_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;

            button_UnsatElements_Clear_Click(sender, e);
            PlotInScatterPlot.PlotHorizontalUnsatLayers(scatterXYControl_UnsatNodes, Model, Convert.ToInt16(cmb.Text));
        }


    }
}
