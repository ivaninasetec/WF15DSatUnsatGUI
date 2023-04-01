using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowModelLib
{
    public class Model_Calc : INotifyPropertyChanged
    {
        private CultureInfo cultureUS = new CultureInfo("en-US");
        public bool Calculating = false;

        private string fileInput;
        /// <summary>
        /// Full path and name of Input file
        /// </summary>
        public string FileInput
        {
            get { return fileInput; }
            set { fileInput = value;  }
        }

        /// <summary>
        /// Path of the input file
        /// </summary>
        public string FilePath
        {
            get { return Path.GetDirectoryName(FileInput); }
        }
        /// <summary>
        /// Only Name of input file
        /// </summary>
        public string FileName
        {
            get { return Path.GetFileName(FileInput); }
        }
        
        private ProcessStartInfo OutCalcInfo;

        private List<string> commandLines = new List<string>();
        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        public List<string> CommandLines
        {
            get { return commandLines; }
            set { commandLines = value; OnPropertyChanged(); }
        }

        #region Calculation Output in commandline
        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private List<int> iterationsModel = new List<int>();
        public List<int> IterationsModel
        {
            get { return iterationsModel; }
            set { iterationsModel = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private List<int> iterationsUnsat = new List<int>();
        public List<int> IterationsUnsat
        {
            get { return iterationsUnsat; }
            set { iterationsUnsat = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private List<int> iterationsSat = new List<int>();
        public List<int> IterationsSat
        {
            get { return iterationsSat; }
            set { iterationsSat = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private double currenttime =0.0;
        public double Currenttime
        {
            get { return currenttime; }
            set { currenttime = value; }
        }

        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private List<double> time = new List<double>();
        public List<double> Time
        {
            get { return time; }
            set { time = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Actual buffer of the running calculation
        /// </summary>
        private List<double> timeStep = new List<double>();
        public List<double> TimeStep
        {
            get { return time; }
            set { time = value; OnPropertyChanged(); }
        }

        public MemoryStream Memfile = new MemoryStream();
        public StreamWriter WriterMemfile;
        public Process OutCalc;

        #endregion



        //public List<string> AllLines= new List<string>();

        /// <summary>
        /// Read the actual buffer of output lines
        /// </summary>
        /// <returns>A list of strings with outputs</returns>
        public List<string> ReadBuffer()
        {
            List<string> tempbuffer = new List<string>(CommandLines);
            CommandLines.Clear();
            //AllLines.AddRange(tempbuffer);
            return tempbuffer;
        }
        public Model_Calc(string _FileInput)
        {
            WriterMemfile = new StreamWriter(Memfile);

            this.FileInput = _FileInput;
            OutCalcInfo = new ProcessStartInfo(Path.GetDirectoryName(Application.ExecutablePath)+@"\wf15dsatunsat.exe");
            OutCalcInfo.Arguments = this.FileName;
            OutCalcInfo.CreateNoWindow = true;
            OutCalcInfo.UseShellExecute = false;
            OutCalcInfo.WindowStyle = ProcessWindowStyle.Hidden;
            OutCalcInfo.RedirectStandardInput = false;
            OutCalcInfo.RedirectStandardOutput = true;
            OutCalcInfo.RedirectStandardError = true;
            
            OutCalcInfo.WorkingDirectory = FilePath;

        }

        public void Run()
        {
            //File.Delete(FilePath + @"\consoleoutput.txt");
            this.Calculating = true;
            OutCalc = Process.Start(OutCalcInfo);
            OutCalc.EnableRaisingEvents = true;
            OutCalc.OutputDataReceived += OutCalc_OutputDataReceived;
            OutCalc.BeginOutputReadLine(); // Start the asynchronous read of the sort output stream.

        }
        public void Stop()
        {
            //File.Delete(FilePath + @"\consoleoutput.txt");
            try
            {
                Process.GetProcessById(OutCalc.Id);
                OutCalc.Kill();
                OutCalc.Dispose();
                this.Calculating = false;
            }
            catch
            {
                this.Calculating = false;
            }  
        }


        #region Events
        protected void OutCalc_OutputDataReceived(object sender, DataReceivedEventArgs outLine)
        {
            
            
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                WriterMemfile.WriteLine(outLine.Data + "\r\n");
                try {WriterMemfile.Flush(); }
                catch { }
                    
                OnPropertyChanged();
                //System.IO.File.AppendAllText(FilePath + @"\consoleoutput.txt", outLine.Data+"\r\n");
                
                //string tempstring = outLine.Data;
                //string[] datatemp;
                //string[] separatingStrings = { " ", "\t" };

                //datatemp = tempstring.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
                //if (datatemp[0] != "C")
                //{
                //    iterationsModel.Add(Convert.ToInt32(datatemp[2], cultureUS));
                //    iterationsUnsat.Add(Convert.ToInt32(datatemp[4], cultureUS));
                //    iterationsSat.Add(Convert.ToInt32(datatemp[6], cultureUS));
                //    time.Add(Convert.ToDouble(datatemp[8], cultureUS));
                //    timeStep.Add(Convert.ToDouble(datatemp[10], cultureUS));
                //}


                //CommandLines.Add(outLine.Data);
                //OnPropertyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

    }
}
