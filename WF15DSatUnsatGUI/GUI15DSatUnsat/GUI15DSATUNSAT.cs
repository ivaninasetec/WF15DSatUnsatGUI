using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowModelLib;
using FlowComLib;
using Microsoft.VisualBasic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Globalization;
using System.Xml;

namespace GUI15DSATUNSAT
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {


        #region Constructor
        /// <summary>
        /// Constructor of the Windows form
        /// </summary>
        public MainForm()
        {
            //Initialize Form
            InitializeComponent();
            AllPanelsOff();
            panel_Input.Visible = true;

            openFileDialog_FileInput.InitialDirectory = Application.StartupPath;
            Set_Help("", ""); //Clear help textbox and colour backgound.

            //Create Model
            Model = new Model_ty_model();           

            CreateBindings();
            AssignBindings();

        }

        #endregion


        #region Methods

        private void NewModel()
        {
            Model = new Model_ty_model();
        }
        
        private void AllPanelsOff()
        {
            panel_Input.Visible = false;
            panel_Calculate.Visible = false; 
            panel_OutputConstraints.Visible = false; 
            panel_OutputSatNodes.Visible = false;
            panel_OutputSatElements.Visible = false;
            panel_OutputUnsatNodes.Visible = false;
            panel_OutputUnsatElements.Visible = false;
        }
        
        #endregion

        #region treeview
        private void TreeView_Main_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            AllPanelsOff();

            switch (e.Node.Name)
            {
                case "node_Input": panel_Input.Visible = true; break;
                case "node_Parameters":
                    panel_Input.Visible = true;
                    tab_Inputs.SelectedTab = tab_Parameters;
                    break;
                case "node_Materials":
                    panel_Input.Visible = true;
                    tab_Inputs.SelectedTab = tab_Materials;
                    break;

                case "node_Layers":
                    panel_Input.Visible = true;
                    tab_Inputs.SelectedTab = tab_Layers;
                    break;
                case "node_Mesh":
                    panel_Input.Visible = true;
                    tab_Inputs.SelectedTab = tab_Mesh;
                    break;
                case "node_Boundary":
                    panel_Input.Visible = true;
                    tab_Inputs.SelectedTab = tab_Boundaries;
                    break;
                case "node_Calculate":
                    panel_Calculate.Visible = true;
                    break;

                case "node_Output":
                    panel_OutputConstraints.Visible = true;
                    tabControl_OutputConstraints.SelectedTab = tab_OutputConstraints_Graph;
                    break;

                case "node_Constraints":
                    panel_OutputConstraints.Visible = true;
                    tabControl_OutputConstraints.SelectedTab = tab_OutputConstraints_Graph;
                    break;

                case "node_SatNodes":
                    panel_OutputSatNodes.Visible = true;
                    tabControl_OutputSatNodes.SelectedTab = tabPage_SatNodes_Graph;
                    break;

                case "node_SatElements":
                    panel_OutputSatElements.Visible = true;
                    tabControl_OutputSatElements.SelectedTab = tabPage_SatElements_Graph;
                    break;

                case "node_UnsatNodes":
                    panel_OutputUnsatNodes.Visible = true;
                    tabControl_OutputUnsatNodes.SelectedTab = tabPage_UnsatNodes_Graph;
                    break;

                case "node_UnsatElements":
                    panel_OutputUnsatElements.Visible = true;
                    tabControl_OutputUnsatElements.SelectedTab = tabPage_UnsatElements_Graph;
                    break;


                default:
                    break;
            }
        }

        #endregion

        //// fileName should consist of the CSV file name with full path
        //private DataTable LoadCSVOnDataTable(string fileName, string tablename)
        //{
        //    DataTable result;
        //    //DataTable result = new DataTable();
        //    try
        //    {
        //        ReadCSV csv = new ReadCSV(fileName, tablename);

        //        try
        //        {
        //            result = csv.readCSV;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        result = null;
        //        //throw new Exception(ex.Message);
        //    }

        //    return result;
        //}

        //// fileName should consist of the CSV file name with full path
        //private DataGridView LoadCSVOnDataGridView(string fileName, string tablename)
        //{
        //    DataGridView result = new DataGridView();
        //    try
        //    {
        //        ReadCSV csv = new ReadCSV(fileName,tablename);

        //        try
        //        {
        //            result.DataSource = csv.readCSV;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    return result;
        //}

        //private DataGridView LoadDataTableOnDataGridView(DataTable DataTableObj)
        //{
        //    DataGridView result = new DataGridView();
        //    try
        //        {
        //        result.DataSource = DataTableObj;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //    return result;

        //}










        #region MainToolStipButtons
        private void toolStripButton_Main_New_Click(object sender, EventArgs e)
        {
            this.NewModel();
        }

        private void ToolStripButton_openfile_Click(object sender, EventArgs e)
        {
            openFileDialog_FileInput.FileName = "*.wfsuinp";
            openFileDialog_FileInput.ShowDialog();
            //folderBrowserDialog_outputs.ShowDialog();
            Model.Initialize();
            Model_ty_inputs.s_model_inputs_header(textBox_Header, Model.FileName);
            Model_ty_inputs.s_model_inputs_parameters(ref Model, Model.FileName);
            ChangeTypeSolution(Model.Com_Ty_Parameters.Typesolution);
            Model_ty_inputs.s_model_inputs_materials(ref Model, Model.FileName);
            Model_ty_inputs.s_model_inputs_layers(ref Model, Model.FileName);
            Model_ty_inputs.s_model_inputs_mesh(ref Model, Model.FileName);
            Model_ty_inputs.s_model_inputs_boundary(ref Model, Model.FileBoundary);
            //CreateBindings();
            //AssignBindings();

            ////BindingSource sourceMaterials = new BindingSource(com_Ty_Material, null);
            //datagridview_materials.DataSource = sourceMaterials;
            //com_Ty_Material.ResetBindings();
            //textBox_Layers_Width.DataBindings.Clear();
            //textBox_Layers_Width.DataBindings.Add(binding_Layers_Width);


        }

        private void toolStripButton_Main_Calc_Click(object sender, EventArgs e)
        {
            if (File.Exists(Model.FilePath+"\\"+Model.FileNameWithoutExtension+ ".outcons.csv"))
            {
                DialogResult result = MessageBox.Show("There is a previous calculation, do you want to overwrite?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                    StartCalculation();
                }
            }
            else
            {
                SaveFile();
                StartCalculation();
            }

        }

        #endregion

        #region FileDialogs

        private void openFileDialog_FileInput_FileOk(object sender, CancelEventArgs e)
        {
            Model.FileName = openFileDialog_FileInput.FileName;
            toolStripStatusLabel_FileName.Text = Model.FileName;
        }

        private void toolStripButton_Main_Saveas_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void saveFileDialog_Output_FileOk(object sender, CancelEventArgs e)
        {
            Model.FileName= saveFileDialog_Output.FileName;
            SaveFile();
        }

        #endregion



        #region events
        //Event triggered when a property changes
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            if (name == "Topboundbyh") { radioButton_Layers_Topboundbyh.Checked = this.Model.Com_Ty_Layers.Topboundbyh; radioButton_Layers_Topboundbyq.Checked = !this.Model.Com_Ty_Layers.Topboundbyh; }
            if (name == "Bottombyphl") { radioButton_Layers_Bottombyphl.Checked = this.Model.Com_Ty_Layers.Bottombyphl; radioButton_Layers_BottomImpermeable.Checked = !this.Model.Com_Ty_Layers.Bottombyphl; }
            if (name == "Commandlines")
            {
                for (int i = 0; i < commandlines.Count; i++)
                {
                    this.Set_Line_Calc(commandlines[i]);
                }
            }

            //if (name == "Model_Ty_Mesh")
            //{
            //    if (!(Model_Ty_Mesh.Nelemv is null))
            //        if (Model_Ty_Mesh.Nelemv.Length == Com_Ty_Layers.Layers.Count)
            //            for (int i = 0; i < Model_Ty_Mesh.Nelemv.Length; i++)
            //            {
            //                Com_Ty_Layers.Layers[i].Meshelements = Model_Ty_Mesh.Nelemv[i];
            //            }
            //}
            //if ((name == "Com_Ty_Layer"))
            //{
            //    if (!(Com_Ty_Layers.Layers is null))
            //        if (Model_Ty_Mesh.Nelemv.Length == Com_Ty_Layers.Layers.Count)
            //            for (int i = 0; i < Model_Ty_Mesh.Nelemv.Length; i++)
            //            {
            //                Model_Ty_Mesh.Nelemv[i] = Com_Ty_Layers.Layers[i].Meshelements;
            //            }
            //}
        }






        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { Wf15dsatunsatCalculation?.OutCalc.Close(); }
            catch { }
        }

        private void toolStripButton_Main_StopCalc_Click(object sender, EventArgs e)
        {
            Wf15dsatunsatCalculation?.Stop();
        }

        private void toolStripButton_Main_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog_Output.InitialDirectory = Model.FilePath;
            saveFileDialog_Output.Filter = openFileDialog_FileInput.Filter;
            saveFileDialog_Output.FileName = Model.FileName;
            saveFileDialog_Output.OverwritePrompt = false;

            if (File.Exists(Model.FileName))
                {
                DialogResult result = MessageBox.Show("File exist, do you want to overwrite?", "Confirmation", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    SaveFile();
                }
            }
            else
            {
                saveFileDialog_Output.FileName = @"*.wfsuinp";
                saveFileDialog_Output.OverwritePrompt = true;
                saveFileDialog_Output.ShowDialog();
            }
        }

        private void SaveFile()
        {
            if (Model.FileName == "") SaveFileAs(); else
            {
                if (File.Exists(Model.FileName)) File.Delete(Model.FileName);
                Model_ty_outputs.s_model_output_header(textBox_Header, Model.FileName);
                Model_ty_outputs.s_model_output_parameters(Model, Model.FileName);
                Model_ty_outputs.s_model_output_materials(Model, Model.FileName);
                Model_ty_outputs.s_model_output_layers(Model, Model.FileName);
                Model_ty_outputs.s_model_output_mesh(Model, Model.FileName);

                if (File.Exists(Model.FileBoundary)) File.Delete(Model.FileBoundary);
                Model_ty_outputs.s_model_output_boundary(Model, Model.FileBoundary);
            }
        }

        private void SaveFileAs() 
        {
            saveFileDialog_Output.InitialDirectory = Model.FilePath;
            saveFileDialog_Output.Filter = openFileDialog_FileInput.Filter;
            saveFileDialog_Output.FileName = @"*.wfsuinp";
            saveFileDialog_Output.OverwritePrompt = true;
            saveFileDialog_Output.ShowDialog();
        }

        private void StartCalculation()
        {
            if (Wf15dsatunsatCalculation is null) Wf15dsatunsatCalculation = new Model_Calc(Model.FileName);

            if (Wf15dsatunsatCalculation.Calculating == true)
            {
                MessageBox.Show("There is currently a calculation running, wait to finish");
            }
            else
            {
                this.AllPanelsOff();
                treeView_Main.SelectedNode = treeView_Main.Nodes["node_Calculate"];
                panel_Calculate.Visible = true;
                treeView_Main.SelectedNode = treeView_Main.Nodes["node_Calculate"];
                treeView_Main.Nodes["node_Calculate"].EnsureVisible();

                //Wf15dsatunsatCalculation = new Model_Calc(Model.FileName);

                Wf15dsatunsatCalculation.Run();
                timer_CalculationTimestep.Start();
                toolStripProgressBar_Calculating.Maximum = 100;
            }
        }


    }
}
