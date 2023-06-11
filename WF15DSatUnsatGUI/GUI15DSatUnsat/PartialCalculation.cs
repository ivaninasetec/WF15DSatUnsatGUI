using FlowModelLib;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI15DSATUNSAT
{


    public partial class MainForm : Form, INotifyPropertyChanged
    {

        public Model_Calc Wf15dsatunsatCalculation;

        public ScottPlot.Plot pltCalculation;

        private List<string> commandlines = new List<string>();
        public List<string> Commandlines { get { return commandlines; } set { commandlines = value; OnPropertyChanged(); } }

        private void readCalculationConsole()
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            string[] datatemp;
            string[] separatingStrings = { " ", "\t" };
            double timetemp;
            double timesteptemp;
            string linetemp;
            List<string> lines = new List<string>();
            //var scatterlist = scatterXYControl_Calculate_Timestep.Plot.AddScatterList();

            //Read all file
            //if (System.IO.File.Exists(Wf15dsatunsatCalculation.FilePath + @"\consoleoutput.txt"))

            if (!(Wf15dsatunsatCalculation.Memfile is null))

            {
                scatterXYControl_Calculate_Timestep.Plot.RenderLock();
                
                Wf15dsatunsatCalculation.Memfile.Position = 0;
                StreamReader reader = new StreamReader(Wf15dsatunsatCalculation.Memfile);
                linetemp = reader.ReadLine();
                do
                {
                    if (linetemp != "") lines.Add(linetemp);
                    Set_Line_Calc(linetemp);
                    linetemp = reader.ReadLine();
                } while (linetemp != null);
                Wf15dsatunsatCalculation.WriterMemfile.Close();
                reader.Dispose();
                Wf15dsatunsatCalculation.Memfile.Dispose();
                Wf15dsatunsatCalculation.Memfile = new MemoryStream();
                Wf15dsatunsatCalculation.WriterMemfile = new StreamWriter(Wf15dsatunsatCalculation.Memfile);

                //richTextBoxCalculation.Update();
                //string[] lines = System.IO.File.ReadAllLines(Wf15dsatunsatCalculation.FilePath + @"\consoleoutput.txt");


                //System.IO.File.Delete(Wf15dsatunsatCalculation.FilePath + @"\consoleoutput.txt");




                for (int i = 0; i < lines.Count; i++)
                {
                    if (!(lines[i] is null))
                    {
                        datatemp = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
                        if (datatemp.Length > 10)
                            if (datatemp[0] != "C")
                            {
                                timetemp = Convert.ToDouble(datatemp[8], cultureUS); // Need to use invoke to consider different threads
                                timesteptemp = Convert.ToDouble(datatemp[10], cultureUS);
                                if (scatterXYControl_Calculate_Timestep.PlotLines.Count == 0)
                                {
                                    scatterXYControl_Calculate_Timestep.AddLine();
                                    scatterXYControl_Calculate_Timestep.PlotLines[0].LineStyle = LineStyle.Solid;
                                    scatterXYControl_Calculate_Timestep.PlotLines[0].Color = Color.Black;
                                    scatterXYControl_Calculate_Timestep.PlotLines[0].MarkerSize = 0;
                                    scatterXYControl_Calculate_Timestep.XAxisMin = 0.0;
                                    scatterXYControl_Calculate_Timestep.XAxisMax = Model.Com_Ty_Parameters.Tmax;
                                    scatterXYControl_Calculate_Timestep.LockHorizontalAxis = false;
                                    scatterXYControl_Calculate_Timestep.YAxisMin = 0.0;
                                }

                                //if (scatterXYControl_Calculate_Timestep.PlotLines.Count == 0) scatterXYControl_Calculate_Timestep.Plot.AddScatterList();
                                Wf15dsatunsatCalculation.Currenttime = timetemp;
                                scatterXYControl_Calculate_Timestep.PlotLines[0].Add(timetemp, timesteptemp);
                                //scatterlist.Add(timetemp, timesteptemp);
                            }
                    }
                }
                //scatterXYControl_Calculate_Timestep.Plot.RenderUnlock();
                scatterXYControl_Calculate_Timestep.Render();
                //scatterXYControl_Calculate_Timestep.Plot.Render();
                //scatterXYControl_Calculate_Timestep.Refresh();
            }
        }

        private void timer_CalculationTimestep_Tick(object sender, EventArgs e)
        {
            if ( Model.Com_Ty_Parameters.Tmax - Model.Com_Ty_Parameters.Tinit>0) toolStripProgressBar_Calculating.Value = Convert.ToInt32(100.0 * (Wf15dsatunsatCalculation.Currenttime - Model.Com_Ty_Parameters.Tinit) / (Model.Com_Ty_Parameters.Tmax - Model.Com_Ty_Parameters.Tinit));

            readCalculationConsole();
            toolStripStatusLabel_CalculationStatus.BackColor = Color.Blue;
            toolStripStatusLabel_CalculationStatus.ForeColor = Color.White;
            toolStripStatusLabel_CalculationStatus.Text = "Calculating...";
            if (!Wf15dsatunsatCalculation.Calculating)
            {
                toolStripStatusLabel_CalculationStatus.BackColor = Color.Red;
                toolStripStatusLabel_CalculationStatus.ForeColor = Color.White;
                toolStripStatusLabel_CalculationStatus.Text = "Calculation Stopped";
                richTextBoxCalculation.SelectionColor = Color.Red;
                richTextBoxCalculation.AppendText("Calculation Stopped" + Environment.NewLine);
                timer_CalculationTimestep.Stop();
            }
            else { 
            if (Wf15dsatunsatCalculation.OutCalc.HasExited)
            {
                Wf15dsatunsatCalculation.Calculating = false;
                if (Wf15dsatunsatCalculation.OutCalc.ExitCode < 0)
                {
                    toolStripStatusLabel_CalculationStatus.BackColor = Color.Red;
                    toolStripStatusLabel_CalculationStatus.ForeColor = Color.White;
                    toolStripStatusLabel_CalculationStatus.Text = "Calculation Error (" + Wf15dsatunsatCalculation.OutCalc.ExitCode.ToString() + ")";
                    richTextBoxCalculation.SelectionColor = Color.Red;
                    richTextBoxCalculation.AppendText(Wf15dsatunsatCalculation.OutCalc.StandardError.ReadToEnd() + Environment.NewLine);
                }
                else
                {
                    toolStripStatusLabel_CalculationStatus.BackColor = Color.Green;
                    toolStripStatusLabel_CalculationStatus.ForeColor = Color.White;
                    toolStripStatusLabel_CalculationStatus.Text = "Calculation finished (" + Wf15dsatunsatCalculation.OutCalc.ExitCode.ToString() + ")";
                    richTextBoxCalculation.SelectionColor = Color.Green;
                    richTextBoxCalculation.AppendText("C Calculation success!" + Environment.NewLine);
                }

                

                timer_CalculationTimestep.Stop();
            }
            }

            richTextBoxCalculation.ScrollToCaret();
        }

        public void Set_Line_Calc(string line)
        {
            //textBox_CalcOutput.Text = textBox_CalcOutput.Text + line + "/r/n
            if (!(line is null)) if (line!="") {
                    if (richTextBoxCalculation.Lines.Count() > 1000) //To avoid run out of memory
                    {
                        //richTextBoxCalculation.Clear(); 
                        richTextBoxCalculation.Select(0, richTextBoxCalculation.GetFirstCharIndexFromLine(richTextBoxCalculation.Lines.Length - 500));
                        richTextBoxCalculation.SelectedText = "";
                    }
                    if (line.Substring(1, 1) == "C") richTextBoxCalculation.SelectionColor = Color.Green;
                    else if (line.Substring(1, 1) == "P") richTextBoxCalculation.SelectionColor = Color.Blue;
                    else richTextBoxCalculation.SelectionColor = Color.Black;
                    richTextBoxCalculation.AppendText(line+Environment.NewLine); 
                    }
            //if (scatterXYControl_Calculate_Timestep.PointLines.Count==0) scatterXYControl_Calculate_Timestep.AddLine();
            //scatterXYControl_Calculate_Timestep.PointLines[0].AddPoint(Wf15dsatunsatCalculation.Time[Wf15dsatunsatCalculation.Time.Count-1], Wf15dsatunsatCalculation.TimeStep[Wf15dsatunsatCalculation.TimeStep.Count - 1]);
            //scatterXYControl_Calculate_Timestep.RefreshLines();
            //textBox_Parameters_Tprintinc.Text = line;
        }

    }
}
