using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using FlowComLib;

namespace FlowModelLib
{
    public class Model_ty_model:INotifyPropertyChanged
    {
        /// <summary>
        /// Inputfile
        /// </summary>
        private string fileName;
        public string FileName         
        {
            get { return fileName; }
            set { fileName = value; OnPropertyChanged(); }
        }
        public string FilePath
        {
            get { return Path.GetDirectoryName(fileName); }
        }
        public string FileNameWithoutExtension
        {
            get { return Path.GetFileNameWithoutExtension(fileName); }
        }
        public string FileBoundary
        {
            get { return FilePath+@"\"+FileNameWithoutExtension+ ".wfbound"; }
        }
        //public string FileOutputConstraints
        //{
        //    get { return FilePath + @"\OUTPUTS\model_constraints.csv"; }
        //}
        //public string FileOutputSatElements
        //{
        //    get { return FilePath + @"\OUTPUTS\sat_outputs_elements.csv"; }
        //}
        //public string FileOutputSatNodes
        //{
        //    get { return FilePath + @"\OUTPUTS\sat_outputs_nodes.csv"; }
        //}
        //public string FileOutputUnsatElements
        //{
        //    get { return FilePath + @"\OUTPUTS\unsat_outputs_elements.csv"; }
        //}
        //public string FileOutputUnsatNodes
        //{
        //    get { return FilePath + @"\OUTPUTS\unsat_outputs_nodes.csv"; }
        //}

        /// <summary>       
        /// Calculation parameters of the model
        /// </summary>
        private Com_ty_parameters com_Ty_Parameters;
        public Com_ty_parameters Com_Ty_Parameters
        {
            get { return com_Ty_Parameters; }
            set { com_Ty_Parameters = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// List of materials
        /// </summary>
        private Com_ty_materials materials;
        public Com_ty_materials Materials
        {
            get { return materials; }
            set { materials = value; OnPropertyChanged(); }
        }

        private Com_ty_layers com_Ty_Layers = new Com_ty_layers();
        public Com_ty_layers Com_Ty_Layers
        {
            get { return com_Ty_Layers; }
            set { com_Ty_Layers = value; OnPropertyChanged(); }
        }

        private Model_ty_mesh model_Ty_Mesh;
        public Model_ty_mesh Model_Ty_Mesh
        {
            get { return model_Ty_Mesh; }
            set { model_Ty_Mesh = value; OnPropertyChanged(); }
        }

        private Com_ty_boundaries boundaries;
        public Com_ty_boundaries Boundaries
        {
            get { return boundaries; }
            set { boundaries = value; OnPropertyChanged(); }
        }
        #region Methods

        public Model_ty_model()
        {
            this.Com_Ty_Parameters = new Com_ty_parameters();
            this.Materials = new Com_ty_materials();
            this.Com_Ty_Layers = new Com_ty_layers();
            this.Model_Ty_Mesh = new Model_ty_mesh();
            this.Boundaries = new Com_ty_boundaries();
        }

        public void Initialize()
        {
            this.Com_Ty_Parameters.Initilize();
            this.Materials.Initialize();
            this.Com_Ty_Layers.Initialize();
            this.Model_Ty_Mesh.Initialize();
            this.Boundaries.Initialize();
        }
        #endregion


        #region Events
        //Event triggered when a property changes
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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


    }
}
