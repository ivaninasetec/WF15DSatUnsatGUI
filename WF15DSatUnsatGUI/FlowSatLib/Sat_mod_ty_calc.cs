using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.LinearAlgebra;
using Inasetec.MathNet.Numerics.LinearAlgebra;


using FlowComLib;

namespace FlowSatLib
{

    public class Sat_mod_ty_calc:Com_ty_calc
    {
        public Sat_mod_ty_calc(ref Com_ty_nodes nodes, ref Com_ty_elements elements, ref Com_ty_parameters parameters):base(ref nodes,ref elements,ref parameters)
        {
            //this.Elements = new Sat_mod_ty_elements(2,3,4);
            this.Elements = (Sat_mod_ty_elements)elements;
            this.Nodes = (Sat_mod_ty_nodes)nodes;
            this.Parameters = (Sat_mod_ty_parameters)parameters;

            //This is the additional constructor

            int nnc = nodes.Count;
            this.Elements = (Sat_mod_ty_elements)this.Elements;

            this.Nrel = Vector<double>.Build.Dense(nnc, 1.0); //If null
            this.Slopeold = Vector<double>.Build.Dense(nnc); //If null 
            this.Solution = Vector<double>.Build.Dense(nnc); //If null
            this.Perm = Vector<int>.Build.Dense(nnc);

            this.Elements.Results_qent = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.Results_incvoldt = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.Results_dqhordx = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.Results_dqhordx_from_incvoldt = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.Results_dqhordx_all = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.Results_dqhordx_from_incvoldt_all = Vector<double>.Build.Dense(this.Elements.Count,0.0);
            this.Elements.X0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.X1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Z = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Hz = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Hzold = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhdx = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhzdx = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.H0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.H1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Z0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Z1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhdx0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhdx1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhzdx0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Dhzdx1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q0_all = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q1_all = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.Q_all = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.K0 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.K1 = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.K0_all = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.K1_all = Vector<double>.Build.Dense(this.Elements.Count);
            this.Elements.K = Vector<double>.Build.Dense(this.Elements.Count);

            this.Nodes.Results_qent = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_incvoldt = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_qhor = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_dqhordx = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_dqhordx_from_incvoldt = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_dqhordx_all = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);
            this.Nodes.Results_dqhordx_from_incvoldt_all = Vector<double>.Build.Dense(this.Nodes.Count, 0.0);

            //Here to allocate matrix
            this.Shapematrix();

            this.Slopeold.Map(x => 0.0, this.Slopeold);

        }

        private Sat_mod_ty_nodes nodes;
        public new Sat_mod_ty_nodes Nodes
        {
            get { return nodes; }
            set { nodes = value; }
        }

        private Sat_mod_ty_elements elements;
        public new Sat_mod_ty_elements Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        private Sat_mod_ty_parameters parameters;
        public new Sat_mod_ty_parameters Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }

        private Com_ty_layers layers;
        public Com_ty_layers Layers
        {
            get { return layers; }
            set { layers = value; }
        }

        private Vector<double> nrel;
        public Vector<double> Nrel
        {
            get { return nrel; }
            set { nrel = value; }
        }

        private Matrix<double> mxmass;
        public Matrix<double> Mxmass
        {
            get { return mxmass; }
            set { mxmass = value; }
        }

        private Matrix<double> mxstiff;
        public Matrix<double> Mxstiff
        {
            get { return mxstiff; }
            set { mxstiff = value; }
        }

        private Matrix<double> mxload;
        public Matrix<double> Mxload
        {
            get { return mxload; }
            set { mxload = value; }
        }

        private Matrix<double> mxbound;
        public Matrix<double> Mxbound
        {
            get { return mxbound; }
            set { mxbound = value; }
        }

        public void Build_linearsystem(in bool istimedependant,in int option = 0)
        {
            const int OPTIONBASIS_H = 1, OPTIONBASIS_DH = 2, OPTIONBASIS_H_H = 3, OPTIONBASIS_H_DH = 4, OPTIONBASIS_DH_H = 5, OPTIONBASIS_DH_DH = 6;


            int opt = option;
            const double PERMEABILITY_AIR = 1.0; //1.0m/s


            Vector<double> henodes = Vector<double>.Build.Dense(this.Elements.Nn * (this.Elements.Nc + 1));
            Vector<double> henodesold = Vector<double>.Build.Dense(this.Elements.Nn * (this.Elements.Nc + 1));
            Vector<double> nrelnodes = Vector<double>.Build.Dense(this.Elements.Nn * (this.Elements.Nc + 1));

            int nelem = this.Elements.Count;
            int numnod = this.Elements.Nn;
            int numclass = this.Elements.Nc + 1;
            int numnodclass = numnod * numclass;

            //Some internal functions to define Linear system:
            Func<Vector<double>, int, Vector<double>> F_identity = (chi, e) => Vector<double>.Build.Dense(chi.Count, 1.0);
            Func<Vector<double>, int, Vector<double>> F_mass = (chi, e) =>
            {
                Vector<double> nreltemp = Vector<double>.Build.Dense(chi.Count);
                Vector<double> headtemp = Vector<double>.Build.Dense(chi.Count);
                Vector<double> headold = Vector<double>.Build.Dense(chi.Count);

                int nstartelem = this.Elements.Idnode[e, 0];
                int nendelem = this.Elements.Idnode[e, numnodclass - 1];
                switch (opt)
                {
                    case 1:
                        henodes = this.Nodes.Htemp.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                    case 2:
                        henodes = this.Nodes.Hold.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                    default:
                        henodes = this.Nodes.Hnew.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                }

                henodesold = this.Nodes.Hold.SubVector(nstartelem, nendelem - nstartelem);
                nrelnodes = this.Nrel.SubVector(nstartelem, nendelem - nstartelem);

                headtemp = Com_fem_shapefunctions.Interp_on_element(chi, henodes);
                headold = Com_fem_shapefunctions.Interp_on_element(chi, henodesold);
                nreltemp = Com_fem_shapefunctions.Interp_on_element(chi, nrelnodes);

                //Final definition of mass matrix:
                return nreltemp.PointwiseMultiply(this.Layers.Get_water_inc_med(headold, headtemp));
            };

            Func<Vector<double>, int, Vector<double>> F_stiff = (chi, e) =>
            {
                Vector<double> nreltemp = Vector<double>.Build.Dense(chi.Count);
                Vector<double> headonchi = Vector<double>.Build.Dense(chi.Count);
                Vector<double> headold = Vector<double>.Build.Dense(chi.Count);
                Vector<double> kmed = Vector<double>.Build.Dense(chi.Count);
                Matrix<double> head = Matrix<double>.Build.Dense(chi.Count,this.Layers.Count+1);

                int nstartelem = this.Elements.Idnode[e, 0];
                int nendelem = this.Elements.Idnode[e, numnodclass - 1];
                switch (opt)
                {
                    case 1:
                        henodes = this.Nodes.Htemp.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                    case 2:
                        henodes = this.Nodes.Hold.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                    default:
                        henodes = this.Nodes.Hnew.SubVector(nstartelem, nendelem - nstartelem);
                        break;
                }

                //Vector<double> ksat = Vector<double>.Build.Dense(this.Layers.Count);
                Vector<double> ksat = Vector<double>.Build.DenseOfArray(this.Layers.Layers.Select(x => x.Material.Ksat).Append<double>(PERMEABILITY_AIR).ToArray()); //array with ksat and last element ksat=1m3/s.

                henodesold = this.Nodes.Hold.SubVector(nstartelem, nendelem - nstartelem);
                nrelnodes = this.Nrel.SubVector(nstartelem, nendelem - nstartelem);

                headonchi = Com_fem_shapefunctions.Interp_on_element(chi, henodes);
                headold = Com_fem_shapefunctions.Interp_on_element(chi, henodesold);
                head = this.Layers.Get_inc_h_from0(headonchi); //This is a matrix [chi,Layers+1]

                kmed = head.Multiply(ksat); // [head]{ksat} [chixlay+1]{lay+1}

                kmed = kmed.Map2((k, hchi) => { if (hchi <= 0) return ksat[0]; else return Math.Abs(k / hchi); }, headonchi); //kmed =ksat if headonchi <=0, else kmed = kmed/headonchi

                return kmed.PointwiseMultiply(headonchi);
            };

            //Continue buildsystem:
            if (istimedependant) this.Buildcoefmatrix(F_mass, ref this.mxmass,this.Parameters.Masslump, OPTIONBASIS_H_H);
            if (istimedependant) this.Buildcoefmatrix(F_stiff, ref this.mxstiff, false, OPTIONBASIS_DH_DH);
            if (!istimedependant) this.Buildcoefmatrix(F_identity, ref this.mxload, false, OPTIONBASIS_H_H);
            if (!istimedependant) this.S_aux_buildcoefbound(ref this.mxbound);

            if (istimedependant) //Updated when it is time dependant
            {
                this.Mx = this.Mxmass / this.Time.Dt + this.Mxstiff + this.Mxbound;
                this.Rhs = this.Mxmass.Multiply(this.Nodes.Hold) / this.Time.Dt - this.Mxstiff.Multiply(this.Nodes.Z) + this.Mxload.Multiply(this.Nodes.Qent);
            }

        }

        private void S_aux_buildcoefbound(ref Matrix<double> mx)
        {
            double ksal;

            double multksal = Math.Min(this.Parameters.Multksal, (this.Nodes.Hold[this.Nodes.Count - 2] / 2.0 + this.Nodes.Z[this.Nodes.Count - 2] - this.Nodes.Z[this.Nodes.Count - 1]) / Math.Abs(this.Nodes.X[this.Nodes.Count - 1] - this.Nodes.X[this.Nodes.Count - 2])); //As boundary dh/ dx is the min between multk and(0.5·hi - 1 + (zi - 1 - zi)) / (xi - 1 - xi)(CHECK: Put hold, maybe can put htemp)
            int nnodes = this.Nodes.Count;
            if (this.Nodes.Htemp[nnodes - 1] == 0.0)
            {
                ksal = 0.0;
            }
            else
            {
                Vector<double> ktemp = Vector<double>.Build.DenseOfArray(this.Layers.Layers.Select(x => x.Material.Ksat).ToArray());
                ktemp.Append<double>(1.0);
                Vector<double> htemp = this.Layers.Get_inc_h_from0(this.Nodes.Htemp[nnodes - 1]);
                ksal = ktemp.DotProduct(htemp) / this.Nodes.Htemp[nnodes - 1] * multksal;
            }
            mx.Clear();
            mx[nnodes, nnodes] = ksal;
        }
        /// <summary>
        /// Update value of Hnew from Htemp considering the linear system soltion. If Crelax = 1 then HNew is Solution, if crelax is 0 then no update and HNew=HTemp. The max possible value for HNew is 0.0 so it is updated only until HNew>=0.0
        /// </summary>
        public new void Update_hnew_from_solution()
        {
            this.Nodes.Hnew = (this.Nodes.Htemp + this.Parameters.Crelax * (this.Solution - this.Nodes.Htemp)).PointwiseMaximum(0.0);
        }
        /// <summary>
        /// Make the prediction of Htemp for the new iterations, considering calculated HNew and also Hold in case.
        /// </summary>
        public new void Estimate_htemp_for_new_iteration()
        {
            this.Nodes.Htemp = this.Nodes.Hnew;
        }
        /// <summary>
        /// This Method update the property class Elements whith all the results of the calculations on the elements integrating the results on nodes.
        /// </summary>
        public void Get_results_elements()
        {
            const int QUADRATURE_ORDER = 40;
            int e;

            Vector<double> ksat1 = Vector<double>.Build.Dense(this.Layers.Count + 1, 0.0);
            Vector<double> ksat = Vector<double>.Build.Dense(this.Layers.Count + 1, 1.0);
            ksat.SetSubVector(0, this.Layers.Count, Vector<double>.Build.DenseOfEnumerable(this.Layers.Layers.Select(x => x.Material.Ksat)));
            ksat1[0] = this.Layers.Layers[0].Material.Ksat;


            //Some internal functions to use in the constructors
            Vector<double> f_qent_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Qent.GetElements(this.Elements.Idnode.Row(el)));


            Vector<double> f_h_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Hnew.GetElements(this.Elements.Idnode.Row(el)));

            Vector<double> f_hold_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Hold.GetElements(this.Elements.Idnode.Row(el)));

            Vector<double> f_z_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Z.GetElements(this.Elements.Idnode.Row(el)));

            Vector<double> f_hz_chi(Vector<double> chi, int el) => (f_h_chi(chi, el) + f_z_chi(chi, el));

            Vector<double> f_hzold_chi(Vector<double> chi, int el) => (f_hold_chi(chi, el) + f_z_chi(chi, el));

            Vector<double> f_dhdx_chi(Vector<double> chi, int el) {
                Vector<double> x = this.Nodes.X.GetElements(this.Elements.Idnode.Row(el));
                Vector<double> hnew = this.Nodes.Hnew.GetElements(this.Elements.Idnode.Row(el));

                return Com_fem_shapefunctions.Dphi1d(chi, x).Multiply(hnew);
            }

            Vector<double> f_dhzdx_chi(Vector<double> chi, int el)
            {
                Vector<double> x = this.Nodes.X.GetElements(this.Elements.Idnode.Row(el));
                Vector<double> hnew = this.Nodes.Hnew.GetElements(this.Elements.Idnode.Row(el));
                Vector<double> z = this.Nodes.Z.GetElements(this.Elements.Idnode.Row(el));

                return Com_fem_shapefunctions.Dphi1d(chi, x).Multiply(hnew + z);
            }

            Vector<double> f_incvoldt_chi(Vector<double> chi, int el)
            {
                Vector<double> hnewtmp = f_h_chi(chi, el);
                Vector<double> holdtmp = f_hold_chi(chi, el);
                Vector<double> nreltmp = Com_fem_shapefunctions.Interp_on_element(chi, this.Nrel.GetElements(this.Elements.Idnode.Row(el)));
                Vector<double> thsatres_temp = this.Layers.Get_water_inc_med(holdtmp, hnewtmp);

                return (hnewtmp - holdtmp) * nreltmp * thsatres_temp / this.Time.Dt;
            }

            Vector<double> f_dqhordx_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Results_dqhordx.GetElements(this.Elements.Idnode.Row(el)));

            Vector<double> f_dqhordx_all_chi(Vector<double> chi, int el) => Com_fem_shapefunctions.Interp_on_element(chi, this.Nodes.Results_dqhordx_all.GetElements(this.Elements.Idnode.Row(el)));

            Vector<double> f_dqhordx_from_incvoldt_all_chi(Vector<double> chi, int el) => f_qent_chi(chi, el) - f_incvoldt_chi(chi, el);

            Vector<double> f_dqhordx_from_incvoldt_chi(Vector<double> chi, int el)
            {
                const double MIN_HEAD = 1E-10;

                Vector<double> hnew = f_h_chi(chi, el);
                Matrix<double> head = this.Layers.Get_inc_h_from0(hnew);
                Vector<double> flux_ratio_for_layer1 = Vector<double>.Build.Dense(chi.Count);
                Vector<double> incvoldt_chi = f_incvoldt_chi(chi, el);
                Vector<double> qent = f_qent_chi(chi, el);

                for (int i = 0; i < chi.Count; i++)
                    if (head.Row(i).Sum() < MIN_HEAD)
                        flux_ratio_for_layer1[i] = 1.0;
                    else
                        flux_ratio_for_layer1[i] = head.Row(i).DotProduct(ksat1) / head.Row(i).DotProduct(ksat);

                return flux_ratio_for_layer1.PointwiseMultiply(qent - incvoldt_chi);
            }

            Vector<double> f_k_chi(Vector<double> chi, int el)
            {
                const double MIN_HEAD = 1E-10;
                Vector<double> hnew = f_h_chi(chi, el);
                Matrix<double> head = this.Layers.Get_inc_h_from0(hnew);
                Vector<double> output = Vector<double>.Build.Dense(chi.Count);

                for (int i = 0; i < chi.Count; i++)
                    if (head.Row(i).Sum() < MIN_HEAD)
                        output[i] = ksat[0];
                    else
                        output[i] = head.Row(i).DotProduct(ksat) / head.Row(i).Sum();

                return output;
            }

            Vector<double> f_q_all_chi(Vector<double> chi, int el)
            {
                Vector<double> hnew = f_h_chi(chi, el);
                Matrix<double> head = this.Layers.Get_inc_h_from0(hnew);
                return (head.Multiply(ksat)).PointwiseMultiply(f_dhzdx_chi(chi, el));
            }

            Vector<double> f_q_chi(Vector<double> chi, int el)
            {
                Vector<double> hnew = f_h_chi(chi, el);
                Matrix<double> head = this.Layers.Get_inc_h_from0(hnew);
                return (head.Multiply(ksat1)).PointwiseMultiply(f_dhzdx_chi(chi, el));
            }

            //Now the code to calculate the results in each element:

            for (e = 0; e < this.Elements.Count; e++)
            {
                double elength = this.Elements.Lenght[e];
                Vector<double> x = this.Nodes.X.GetElements(this.Elements.Idnode.Row(e));
                Vector<double> hnewtemp = this.Nodes.Hnew.GetElements(this.Elements.Idnode.Row(e));
                Vector<double> ztemp = this.Nodes.Z.GetElements(this.Elements.Idnode.Row(e));

                this.Elements.Results_qent[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_qent_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Results_incvoldt[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_incvoldt_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Results_dqhordx[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dqhordx_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Results_dqhordx_from_incvoldt[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dqhordx_from_incvoldt_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Results_dqhordx_all[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dqhordx_all_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Results_dqhordx_from_incvoldt_all[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dqhordx_from_incvoldt_all_chi(xchi, e), x, QUADRATURE_ORDER) / elength;

                this.Elements.Hnew[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_h_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Hold[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_hold_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Z[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_z_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Hz[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_hz_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Hzold[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_hzold_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Dhdx[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dhdx_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Dhzdx[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_dhdx_chi(xchi, e), x, QUADRATURE_ORDER) / elength;

                this.Elements.X0[e] = this.Nodes.X[this.Elements.Idnode[e, 0]];
                this.Elements.X1[e] = this.Nodes.X[this.Elements.Idnode[e, 1]];
                this.Elements.H0[e] = this.Nodes.Hnew[this.Elements.Idnode[e, 0]];
                this.Elements.H1[e] = this.Nodes.Hnew[this.Elements.Idnode[e, 1]];
                this.Elements.Z0[e] = this.Nodes.Z[this.Elements.Idnode[e, 0]];
                this.Elements.Z1[e] = this.Nodes.Z[this.Elements.Idnode[e, 1]];

                this.Elements.Dhdx0[e] = Com_fem_shapefunctions.Dphi1d(-1.0, x).DotProduct(hnewtemp);
                this.Elements.Dhdx1[e] = Com_fem_shapefunctions.Dphi1d(1.0, x).DotProduct(hnewtemp);
                this.Elements.Dhzdx0[e] = Com_fem_shapefunctions.Dphi1d(-1.0, x).DotProduct(hnewtemp+ztemp);
                this.Elements.Dhzdx1[e] = Com_fem_shapefunctions.Dphi1d(1.0, x).DotProduct(hnewtemp+ztemp);

                this.Elements.Q[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_q_chi(xchi, e), x, QUADRATURE_ORDER) / elength;
                this.Elements.Q0[e] = f_q_chi(Vector<double>.Build.Dense(1,-1.0),e).Sum();
                this.Elements.Q1[e] = f_q_chi(Vector<double>.Build.Dense(1, 1.0), e).Sum();
                this.Elements.K[e] = Com_fem_intelement.Intelement_rel_1don(xchi => f_k_chi(xchi, e), x, QUADRATURE_ORDER) / elength;

            }

        }
        /// <summary>
        /// Subroutine to update the property class Nodes with the results of the calculations.
        /// </summary>
        public void Get_results_nodes()
        {
            //Permeability on each layer
            Vector<double> ksatlayers1 = Vector<double>.Build.Dense(this.Layers.Count + 1, 0.0);
            Vector<double> ksatlayers = Vector<double>.Build.Dense(this.Layers.Count + 1, 1.0);
            ksatlayers.SetSubVector(0, this.Layers.Count, Vector<double>.Build.DenseOfEnumerable(this.Layers.Layers.Select(x => x.Material.Ksat)));
            ksatlayers1[0] = this.Layers.Layers[0].Material.Ksat;

            this.Nodes.Results_qent = this.Nodes.Qent;
            this.Nodes.Results_incvoldt = this.Nrel * this.Layers.Get_water_inc_med(this.Nodes.Hold, this.Nodes.Hnew) * (this.Nodes.Hnew - this.Nodes.Hold) / this.Time.Dt;

            this.Nodes.Results_qhor_all = -this.Layers.Get_inc_h_from0(this.Nodes.Hnew).Multiply(ksatlayers).PointwiseMultiply(Com_others_custom_functions.f_get_derivatives(this.Nodes.X, this.Nodes.Hnew + this.Nodes.Z));
            this.Nodes.Results_dqhordx_all = Com_others_custom_functions.f_get_derivatives(this.Nodes.X, this.Nodes.Results_qhor_all);

            this.Nodes.Results_qhor = -this.Layers.Get_inc_h_from0(this.Nodes.Hnew).Multiply(ksatlayers1).PointwiseMultiply(Com_others_custom_functions.f_get_derivatives(this.Nodes.X, this.Nodes.Hnew + this.Nodes.Z));
            this.Nodes.Results_dqhordx = Com_others_custom_functions.f_get_derivatives(this.Nodes.X, this.Nodes.Results_qhor);

            this.Nodes.Results_dqhordx_from_incvoldt_all = this.Nodes.Results_qent - this.Nodes.Results_incvoldt;


            Parallel.For(0, this.Nodes.Count, i =>
            {
                if (this.Nodes.Hnew[i] == 0) this.Nodes.Results_dqhordx_from_incvoldt = this.Nodes.Results_dqhordx_from_incvoldt_all;
                else
                    this.Nodes.Results_dqhordx_from_incvoldt[i] = this.Layers.Get_inc_h_from0(this.Nodes.Hnew[i]).DotProduct(ksatlayers1) / this.Layers.Get_inc_h_from0(this.Nodes.Hnew[i]).DotProduct(ksatlayers) * this.Nodes.Results_dqhordx_from_incvoldt_all[i];
            });
            //for (int i=0; i < this.Nodes.Count; i++)
            //{
            //    if (this.Nodes.Hnew[i] == 0) this.Nodes.Results_dqhordx_from_incvoldt = this.Nodes.Results_dqhordx_from_incvoldt_all;
            //    else
            //        this.Nodes.Results_dqhordx_from_incvoldt[i] = this.Layers.Get_inc_h_from0(this.Nodes.Hnew[i]).DotProduct(ksatlayers1) / this.Layers.Get_inc_h_from0(this.Nodes.Hnew[i]).DotProduct(ksatlayers) * this.Nodes.Results_dqhordx_from_incvoldt_all[i]; 
            //}

        }
    }
}
