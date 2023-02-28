using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

using FlowComLib;

namespace FlowSatLib
{
    public class Sat_mod_ty_nodes:Com_ty_nodes
    {
        private Vector<double> results_qent;
        public Vector<double> Results_qent
        {
            get { return results_qent; }
            set { results_qent = value; } 
        }

        private Vector<double> results_incvoldt;
        public Vector<double> Results_incvoldt
        {
            get { return results_incvoldt; }
            set { results_incvoldt = value; }
        }

        private Vector<double> results_qhor;
        public Vector<double> Results_qhor
        {
            get { return results_qhor; }
            set { results_qhor = value; }
        }

        private Vector<double> results_dqhordx;
        public Vector<double> Results_dqhordx
        {
            get { return results_dqhordx; }
            set { results_dqhordx = value; }
        }

        private Vector<double> results_dqhordx_from_incvoldt;
        public Vector<double> Results_dqhordx_from_incvoldt
        {
            get { return results_dqhordx_from_incvoldt; }
            set { results_dqhordx_from_incvoldt = value; }
        }

        private Vector<double> results_qhor_all;
        public Vector<double> Results_qhor_all
        {
            get { return results_qhor_all; }
            set { results_qhor_all = value; }
        }

        private Vector<double> results_dqhordx_all;
        public Vector<double> Results_dqhordx_all
        {
            get { return results_dqhordx_all; }
            set { results_dqhordx_all = value; }
        }

        private Vector<double> results_dqhordx_from_incvoldt_all;
        public Vector<double> Results_dqhordx_from_incvoldt_all
        {
            get { return results_dqhordx_from_incvoldt_all; }
            set { Results_dqhordx_from_incvoldt_all = value; }
        }


        public Sat_mod_ty_nodes(in int nnc, in int nn, in int nc): base(nnc, nn, nc)
        {

        }

        public void Set_hinit()
        {
            this.Hinit.Map(x => 0.0,this.Hinit);
            this.Dhinit.Map(x => 0.0, this.Dhinit);
        }

        public void Set_z(in double slope, in double lenght)
        {
            double lenghttemp = lenght;
            double slopetemp = slope;
            this.Z.Map2((z, x) => (lenghttemp - x) * slopetemp, this.X, this.Z);
        }




    }
}
