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
        /// Datatable with the constraints outputs
        /// </summary>
        public OutputConstraints OutputConstraintList = new OutputConstraints();
        private void button_Constraint_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (OutputConstraintList.nfields == 0)
                {
                    OutputConstraintList = new OutputConstraints(Model.FilePath + @"\" + Model.FileNameWithoutExtension + ".outcons.csv");
                    sourceOutputConstraints = new BindingSource(OutputConstraintList.Items, null);
                    bindingNavigator_OutputConstraints.BindingSource = sourceOutputConstraints;
                    datagridview_OutputConstraints.DataSource = sourceOutputConstraints;

                    scatterXYControl_Constraints.Plot.Clear();
                    scatterXYControl_Constraints.XAxisMin = 0.0;
                    scatterXYControl_Constraints.XAxisMax = Model.Com_Ty_Parameters.Tmax;
                    scatterXYControl_Constraints.YAxisMin = 0.0;
                    scatterXYControl_Constraints.YAxisMax = 1.0;
                    scatterXYControl_Constraints.LockHorizontalAxis = false;
                    scatterXYControl_Constraints.LockVerticalAxis = false;
                    scatterXYControl_Constraints.Plot.AddHorizontalLine(0.0, color: Color.Black);
                    scatterXYControl_Constraints.Plot.AddVerticalLine(0.0, color: Color.Black);

                }
                else
                {
                    OutputConstraintList.Update();
                    sourceOutputConstraints = new BindingSource(OutputConstraintList.Items, null);
                    bindingNavigator_OutputConstraints.BindingSource = sourceOutputConstraints;
                    datagridview_OutputConstraints.DataSource = sourceOutputConstraints;
                }

            }
            catch (InvalidCastException exception)
            {
                MessageBox.Show(exception.Message);
            }



            comboBox_Constraints_numIS.DataSource = OutputConstraintList.NumIS;
            comboBox_Constraints_numIU.DataSource = OutputConstraintList.NumIU;
            comboBox_Constraints_numIS.SelectedIndex = 0;
            comboBox_Constraints_numIS.Select();
            comboBox_Constraints_numIU.SelectedIndex = 0;
            comboBox_Constraints_numIU.Select();
            comboBox_Constraints_Variable.SelectedIndex = 0;
            comboBox_Constraints_Variable.Select();
        }

        private void button_Constraints_Add_Variable_Click(object sender, EventArgs e)
        {
            int nline = scatterXYControl_Constraints.PlotLines.Count;

            scatterXYControl_Constraints.AddLine();
            //scatterXYControl_Constraints.PlotLines[0].LineStyle = LineStyle.Solid;
            //scatterXYControl_Constraints.PlotLines[0].Color = Color.Black;
            scatterXYControl_Constraints.PlotLines[nline].MarkerSize = 0;
            int numIS = Convert.ToInt32(comboBox_Constraints_numIS.SelectedItem);
            int numIU = Convert.ToInt32(comboBox_Constraints_numIU.SelectedItem);

            switch (comboBox_Constraints_Variable.Text)
            {
                case "v_hnew":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_hnew).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_hnew";
                    break;

                case "v_thnew":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_thnew).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_thnew";
                    break;
                case "v_hsat":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_hsat).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_hsat";
                    break;
                case "v_qvtb":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_qvtb).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_qvtb";
                    break;
                case "v_qvt":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_qvt).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_qvt";
                    break;
                case "v_qvb":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_qvb).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_qvb";
                    break;
                case "v_incvoldt":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_incvoldt).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_incvoldt";
                    break;
                case "v_Qs_layer":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_Qs_layer).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_Qs_layer";
                    break;
                case "v_Qs_all":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.v_Qs_all).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "v_Qs_all";
                    break;
                case "nrel":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.nrel).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "nrel";
                    break;
                case "h_width":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_width).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_width";
                    break;
                case "h_hsat_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_hsat_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_hsat_mean";
                    break;
                case "h_qent_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_qent_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_qent_mean";
                    break;
                case "h_incvoldt_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_incvoldt_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_incvoldt_mean";
                    break;
                case "h_dqhordx_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_dqhordx_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_dqhordx_mean";
                    break;
                case "h_dqhordx_all_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.h_dqhordx_all_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "h_dqhordx_all_mean";
                    break;
                case "inchnew_mean":
                    scatterXYControl_Constraints.PlotLines[nline].AddRange(OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.T).ToArray(), OutputConstraintList.Items.Where(x => x.IS == numIS).Where(x => x.IU == numIU).Select(x => x.inchnew_mean).ToArray());
                    scatterXYControl_Constraints.PlotLines[nline].Label = "inchnew_mean";
                    break;
                default:
                    break;



            }
            scatterXYControl_Constraints.Plot.Legend(true);
            scatterXYControl_Constraints.Render();
        }

        private void button_Constraints_Clear_Click(object sender, EventArgs e)
        {
            scatterXYControl_Constraints.Plot.Clear();

            scatterXYControl_Constraints.XAxisMin = 0.0;
            scatterXYControl_Constraints.XAxisMax = Model.Com_Ty_Parameters.Tmax;
            scatterXYControl_Constraints.YAxisMin = 0.0;
            scatterXYControl_Constraints.YAxisMax = 1.0;
            scatterXYControl_Constraints.LockHorizontalAxis = false;
            scatterXYControl_Constraints.LockVerticalAxis = false;
            scatterXYControl_Constraints.Plot.AddHorizontalLine(0.0, color: Color.Black);
            scatterXYControl_Constraints.Plot.AddVerticalLine(0.0, color: Color.Black);

            scatterXYControl_Constraints.Render();
        }


    }
}
