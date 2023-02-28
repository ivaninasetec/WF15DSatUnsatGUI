using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;

using FlowComLib;

namespace FlowSatLib
{
    public class Sat_mod_ty_elements:Com_ty_elements
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


        private Vector<double> z;
        public Vector<double> Z
        {
            get { return z; }
            set { z = value; }
        }

        private Vector<double> hz;
        public Vector<double> Hz
        {
            get { return hz; }
            set { hz = value; }
        }

        private Vector<double> hzold;
        public Vector<double> Hzold
        {
            get { return hzold; }
            set { hzold = value; }
        }

        private Vector<double> dhdx;
        public Vector<double> Dhdx
        {
            get { return dhdx; }
            set { dhdx = value; }
        }

        private Vector<double> dhzdx;
        public Vector<double> Dhzdx
        {
            get { return dhzdx; }
            set { dhzdx = value; }
        }

        private Vector<double> h0;
        public Vector<double> H0
        {
            get { return h0; }
            set { h0 = value; }
        }

        private Vector<double> h1;
        public Vector<double> H1
        {
            get { return h1; }
            set { h1 = value; }
        }

        private Vector<double> z0;
        public Vector<double> Z0
        {
            get { return z0; }
            set { z0 = value; }
        }

        private Vector<double> z1;
        public Vector<double> Z1
        {
            get { return z1; }
            set { z1 = value; }
        }

        private Vector<double> dhdx0;
        public Vector<double> Dhdx0
        {
            get { return dhdx0; }
            set { dhdx0 = value; }
        }

        private Vector<double> dhdx1;
        public Vector<double> Dhdx1
        {
            get { return dhdx1; }
            set { dhdx1 = value; }
        }

        private Vector<double> dhzdx0;
        public Vector<double> Dhzdx0
        {
            get { return dhzdx0; }
            set { dhzdx0 = value; }
        }

        private Vector<double> dhzdx1;
        public Vector<double> Dhzdx1
        {
            get { return dhzdx1; }
            set { dhzdx1 = value; }
        }

        private Vector<double> q0;
        public Vector<double> Q0
        {
            get { return q0; }
            set { q0 = value; }
        }

        private Vector<double> q1;
        public Vector<double> Q1
        {
            get { return q1; }
            set { q1 = value; }
        }

        private Vector<double> q0_all;
        public Vector<double> Q0_all
        {
            get { return q0_all; }
            set { q0_all = value; }
        }

        private Vector<double> q1_all;
        public Vector<double> Q1_all
        {
            get { return q1_all; }
            set { q1_all = value; }
        }

        private Vector<double> q;
        public Vector<double> Q
        {
            get { return q; }
            set { q = value; }
        }

        private Vector<double> q_all;
        public Vector<double> Q_all
        {
            get { return q_all; }
            set { q_all = value; }
        }

        private Vector<double> k0;
        public Vector<double> K0
        {
            get { return k0; }
            set { k0 = value; }
        }

        private Vector<double> k1;
        public Vector<double> K1
        {
            get { return k1; }
            set { k1 = value; }
        }

        private Vector<double> k0_all;
        public Vector<double> K0_all
        {
            get { return k0_all; }
            set { k0_all = value; }
        }

        private Vector<double> k1_all;
        public Vector<double> K1_all
        {
            get { return k1_all; }
            set { k1_all = value; }
        }

        private Vector<double> k;
        public Vector<double> K
        {
            get { return k; }
            set { k = value; }
        }




        public Sat_mod_ty_elements(in int ne, in int nn, in int nc) : base(ne, nn, nc)
        {

        }

    }
}
