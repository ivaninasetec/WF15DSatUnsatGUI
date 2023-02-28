using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FlowModelLib;


namespace FlowModelLib
{

    public class Model_ty_mesh : INotifyPropertyChanged
    {
        /// <summary>
        /// Nodes per element (only implemented nn=0
        /// </summary>
        private int nn;
        public int Nn
        {
            get { return nn; }
            //set { nn = value; }
        }
        /// <summary>
        /// Class of nodes (only implemented nc=0
        /// </summary>
        private int nc;
        public int Nc
        {
            get { return nc; }
            //set { nc = value; }
        }
        ///// <summary>
        ///// Number of vertical modules
        ///// </summary>
        //private int vmod_count;
        //public int Vmod_count
        //{
        //    get { return vertical_Modules.Count; }
        //}
        /// <summary>
        /// List with ID, position in X and number of elements of vertical modules
        /// </summary>

        private BindingList<Model_ty_verticalmodule> vertical_Modules;
        public BindingList<Model_ty_verticalmodule> Vertical_Modules
        {
            get { return vertical_Modules; }
            set { vertical_Modules = value; OnPropertyChanged(); }
        }
        #region Constructor
        public Model_ty_mesh()
        {
            this.Vertical_Modules = new BindingList<Model_ty_verticalmodule>();
            this.Initialize();
        }
        #endregion

        #region Methods
        public void Initialize()
        {
            this.nn= 2;
            this.nc= 0;
            this.vertical_Modules.Clear();
            Model_ty_verticalmodule tempvertmod = new Model_ty_verticalmodule();
            tempvertmod.Initialize();
            this.vertical_Modules.Add(tempvertmod);
        }

        #endregion

        #region Not implemented

        //private int nnc;
        //public int Nnc
        //{
        //    get { return nnc; }
        //    set { nnc = value; }
        //}

        //private int nelemv_count;
        //public int Nelemv_count
        //{
        //    get { return nelemv_count; }
        //    set { nelemv_count = value; }
        //}

        //private int nelemh_count;
        //public int Nelemh_count
        //{
        //    get { return nelemh_count; }
        //    set { nelemh_count = value; }
        //}

        //private int[] nelemv;
        //public int[] Nelemv
        //{
        //    get { return nelemv; }
        //    set { nelemv = value; OnPropertyChanged(); }
        //}

        //private int[] nelemh;
        //public int[] Nelemh
        //{
        //    get { return nelemh; }
        //    set { nelemh = value; OnPropertyChanged(); }
        //}

        //private int nnodh_count;
        //public int Nnodh_count
        //{
        //    get { return nnodh_count; }
        //    set { nnodh_count = value; }
        //}

        //private int nnodclassh_count;
        //public int Nnodclassh_count
        //{
        //    get { return nnodclassh_count; }
        //    set { nnodclassh_count = value; }
        //}

        //private int nnodv_count;
        //public int Nnodv_count
        //{
        //    get { return nnodv_count; }
        //    set { nnodv_count = value; }
        //}

        //private int nnodclassv_count;
        //public int Nnodclassv_count
        //{
        //    get { return nnodclassv_count; }
        //    set { nnodclassv_count = value; }
        //}

        //private double width;
        //public double Width
        //{
        //    get { return width; }
        //    set { width = value; }
        //}

        //private double height;
        //public double Height
        //{
        //    get { return height; }
        //    set { height = value; }
        //}



        //private double[] vmod_x;
        //public double[] Vmod_x
        //{
        //    get { return vmod_x; }
        //    set { vmod_x = value; }
        //}

        //private int[] vmod_idnod;
        //public int[] Vmod_idnod
        //{
        //    get { return vmod_idnod; }
        //    set { vmod_idnod = value; }
        //}

        //public void Allocateall(in int nlayers, in int nvmod)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void Deallocateall()
        //{
        //    throw new System.NotImplementedException();
        //}
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
