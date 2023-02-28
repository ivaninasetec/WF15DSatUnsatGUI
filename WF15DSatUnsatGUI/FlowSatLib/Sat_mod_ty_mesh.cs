using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

using FlowComLib;

namespace FlowSatLib
{
    public class Sat_mod_ty_mesh
    {
        private int nn;
        public int Nn
        {
            get { return nn; }
            set { nn = value; }
        }

        private int nc;
        public int Nc
        {
            get { return nc; }
            set { nc = value; }
        }

        private int nnc;
        public int Nnc
        {
            get { return nnc; }
            set { nnc = value; }
        }

        private int nelemh_count;
        public int Nelemh_count
        {
            get { return nelemh_count; }
            set { nelemh_count = value; }
        }

        private Vector<int> nelemh;
        public Vector<int> Nelemh
        {
            get { return nelemh; }
            set { nelemh = value; }
        }

        private int nnodh_count;
        public int Nnodh_count
        {
            get { return nnodh_count; }
            set { nnodh_count = value; }
        }

        private int nnodclassh_count;
        public int Nnodclassh_count
        {
            get { return nnodclassh_count; }
            set { nnodclassh_count = value; }
        }

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        private int vmod_count;
        public int Vmod_count
        {
            get { return vmod_count; }
            set { vmod_count = value; }
        }

        private Vector<double> vmod_x;
        public Vector<double> Vmod_x
        {
            get { return vmod_x; }
            set { vmod_x = value; }
        }

        private Vector<int> vmod_idnod;
        public Vector<int> Vmod_idnod
        {
            get { return vmod_idnod; }
            set { vmod_idnod = value; }
        }

        private Vector<double> vmod_qent;
        public Vector<double> Vmod_qent
        {
            get { return vmod_qent; }
            set { vmod_qent = value; }
        }

        private Vector<double> vmod_nrel;
        public Vector<double> Vmod_nrel
        {
            get { return vmod_nrel; }
            set { vmod_nrel = value; }
        }

        Sat_mod_ty_mesh(int nvmod)
        {
            this.Vmod_count = nvmod;
            this.Nelemh = Vector<int>.Build.Dense(nvmod);
            this.Vmod_x = Vector<double>.Build.Dense(nvmod);
            this.Vmod_qent = Vector<double>.Build.Dense(nvmod);
            this.Vmod_nrel = Vector<double>.Build.Dense(nvmod);
            this.Vmod_nrel = Vector<double>.Build.Dense(nvmod,1.0);
        }


        public void Set_z(ref Sat_mod_ty_nodes nodes, ref Com_ty_layers layers)
        {
            nodes.Z = (this.Width - nodes.X) * layers.Slopebottom;
        }


    }
}
