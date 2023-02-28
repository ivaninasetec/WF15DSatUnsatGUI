using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace FlowComLib
{
    /// <summary>
    /// Class to define the calculation parameters
    /// </summary>
    public class Com_ty_parameters : INotifyPropertyChanged
    {

        #region Tolerance parameters
        /// <summary>
        /// Pressure head tolerance [L]
        /// </summary>
        private double epsh_tol;
        public double Epsh_tol
        {
            get { return epsh_tol; }
            set { epsh_tol = value;OnPropertyChanged();}
        }

        /// <summary>
        /// Volumetric water content tolerance [L3·L-3]
        /// </summary>
        private double epsth_tol;
        public double Epsth_tol
        {
            get { return epsth_tol; }
            set { epsth_tol = value;OnPropertyChanged();}
        }

        /// <summary>
        /// Watertable height in the layer to consider that FLOW1D sat is activated [L]
        /// </summary>
        private double epshsat_tol;
        public double Epshsat_tol
        {
            get { return epshsat_tol; }
            set { epshsat_tol = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Max allowed watertable height increment on current timestep [L]
        /// </summary>
        private double maxhsatinc;
        public double Maxhsatinc
        {
            get { return maxhsatinc; }
            set { maxhsatinc = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// If true: Error control on nodes, if false: Error control on elements.
        /// </summary>
        private bool erroronnode;
        public bool Erroronnode
        {
            get { return erroronnode; }
            set { erroronnode = value; OnPropertyChanged(); }
        }
        #endregion

        #region Timestepping parameters

        /// <summary>
        /// Minimum number of iterations per timestep
        /// </summary>
        private int it_min=1;
        public int It_min
        {
            get { return it_min; }
            set { it_min = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Timestep increased when iterations are lower than this mumber
        /// </summary>
        private int it_inc_dt;
        public int It_inc_dt
        {
            get { return it_inc_dt; }
            set { it_inc_dt = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Timestep increased by this factor when iterations < it_inc_dt
        /// </summary>
        private double dtinc;
        public double Dtinc
        {
            get { return dtinc; }
            set { dtinc = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Timestep decreaded when iterations are lower than this number
        /// </summary>

        private int it_dec_dt;
        public int It_dec_dt
        {
            get { return it_dec_dt; }
            set { it_dec_dt = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Timestp decreased by this factor when iterations are over it_dc_dt
        /// </summary>
        private double dtdec;
        public double Dtdec
        {
            get { return dtdec; }
            set { dtdec = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Timestep decreased and restarted if iterations are over this number.
        /// </summary>

        private int it_max;
        public int It_max
        {
            get { return it_max; }
            set { it_max = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Initial time (default 0.0)
        /// </summary>
        private double tinit=0.0;
        public double Tinit
        {
            get { return tinit; }
            set { tinit = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Initial timestep
        /// </summary>
        private double dtinit;
        public double Dtinit
        {
            get { return dtinit; }
            set { dtinit = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Min timestep
        /// </summary>
        private double dtmin;
        public double Dtmin
        {
            get { return dtmin; }
            set { dtmin = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Time to end calculations
        /// </summary>
        private double tmax;
        public double Tmax
        {
            get { return tmax; }
            set { tmax = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Max timestep
        /// </summary>
        private double dtmax;
        public double Dtmax
        {
            get { return dtmax; }
            set { dtmax = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Print results at each interval
        /// </summary>

        private double tprintinc;
        public double Tprintinc
        {
            get { return tprintinc; }
            set { tprintinc = value; OnPropertyChanged(); }
        }


        #endregion

        #region Matrix solvers
        /// <summary>
        /// Type solution selected:
        /// <list type="number|sparsity|solver|preconditioner">
        /// <listheader> <number>Number</number> <sparsity>Sparsity</sparsity> <solver>Solver</solver>  <preconditioner>Preconditioner</preconditioner> </listheader>
        /// <item> <number>1</number> <sparsity>Dense</sparsity> <solver>Gauss</solver>  <preconditioner>None</preconditioner> </item>
        /// <item> <number>2</number> <sparsity>Dense</sparsity> <solver>Gauss</solver>  <preconditioner>Jacobi</preconditioner> </item>
        /// <item> <number>3</number> <sparsity>CSR</sparsity> <solver>DSS</solver>  <preconditioner>None</preconditioner> </item>
        /// <item> <number>4</number> <sparsity>CSR</sparsity> <solver>DSS</solver>  <preconditioner>Jacobi</preconditioner> </item>
        /// <item> <number>5</number> <sparsity>CSR</sparsity> <solver>DSS</solver>  <preconditioner>ILU0</preconditioner> </item>
        /// <item> <number>6</number> <sparsity>CSR</sparsity> <solver>DSS</solver>  <preconditioner>ILUT</preconditioner> </item>
        /// <item> <number>7</number> <sparsity>CSR</sparsity> <solver>Paradiso</solver>  <preconditioner>None</preconditioner> </item>
        /// <item> <number>8</number> <sparsity>CSR</sparsity> <solver>Paradiso</solver>  <preconditioner>Jacobi</preconditioner> </item>
        /// <item> <number>9</number> <sparsity>CSR</sparsity> <solver>Paradiso</solver>  <preconditioner>ILU0</preconditioner> </item>
        /// <item> <number>10</number> <sparsity>CSR</sparsity> <solver>Paradiso</solver>  <preconditioner>ILUT</preconditioner> </item>
        /// <item> <number>11</number> <sparsity>CSR</sparsity> <solver>FMGRES</solver>  <preconditioner>None</preconditioner> </item>
        /// <item> <number>12</number> <sparsity>CSR</sparsity> <solver>FMGRES</solver>  <preconditioner>Jacobi</preconditioner> </item>
        /// <item> <number>13</number> <sparsity>CSR</sparsity> <solver>FMGRES</solver>  <preconditioner>ILU0</preconditioner> </item>
        /// <item> <number>14</number> <sparsity>CSR</sparsity> <solver>FMGRES</solver>  <preconditioner>ILUT</preconditioner> </item>
        /// <item> <number>15</number> <sparsity>Banded</sparsity> <solver>Gauss</solver>  <preconditioner>None</preconditioner> </item>
        /// <item> <number>16</number> <sparsity>Banded</sparsity> <solver>Gauss</solver>  <preconditioner>Jacobi</preconditioner> </item>
        /// </list>
        /// </summary>
        public int Typesolution
        {
            get { return typesolution; }
            set { typesolution = value; OnPropertyChanged(); }
        }
        private int typesolution;

        /// <summary>
        /// Type of matrix storage (Dense, Sparse or Banded.
        /// </summary>
        private int typematrixstorage;
        public int Typematrixstorage
        {
            get { return typematrixstorage; }
            set { typematrixstorage = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Type of solver (Direct Gauss,Direct DSS,Direct Paradiso, Iterative FMGRES
        /// </summary>
        private int typesolver;
        public int Typesolver
        {
            get { return typesolver; }
            set { typesolver = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Type of preconditioner: None, Jacobi, ILU0 and ILUT
        /// </summary>
        private int typepreconditioner;
        public int Typepreconditioner
        {
            get { return typepreconditioner; }
            set { typepreconditioner = value; OnPropertyChanged(); }
        }
        #endregion

        #region Other parameters
        /// <summary>
        /// If true: Use mass lumping on the mass matrix
        /// </summary>
        private bool masslump;
        public bool Masslump
        {
            get { return masslump; }
            set { masslump = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Coeficient on the seepage boundary (equivalent to the slope of the watertable on the exit)
        /// </summary>
        private double multksal;
        public double Multksal
        {
            get { return multksal; }
            set { multksal = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Coeficient of relaxation when updating iterative solutions.
        /// </summary>
        private double crelax;
        public double Crelax
        {
            get { return crelax; }
            set { crelax = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Quadrature order for element integration by Gauss-Legendre aproximation
        /// </summary>
        private int quadratureorder;
        public int Quadratureorder
        {
            get { return quadratureorder; }
            set { quadratureorder = value; OnPropertyChanged(); }
        }


        #endregion

        #region Fixed parameters, for trial purposes
        private double ccourant=1.0E10;
        public double Ccourant
        {
            get { return ccourant; }
            set { ccourant = value; OnPropertyChanged(); }
        }

        private double nrelmin = 0.000001;
        public double Nrelmin
        {
            get { return nrelmin; }
            set { nrelmin = value; OnPropertyChanged(); }
        }

        private double nrelmax = 1.0;
        public double Nrelmax
        {
            get { return nrelmax; }
            set { nrelmax = value; OnPropertyChanged(); }
        }

        private bool isrestarttime;
        public bool Isrestarttime
        {
            get { return isrestarttime; }
            set { isrestarttime = value; OnPropertyChanged(); }
        }

        private double trestart;
        public double Trestart
        {
            get { return trestart; }
            set { trestart = value; OnPropertyChanged(); }
        }

        #endregion

        #region Not yet implemented


        //private double crelax_nrel;
        //public double Crelax_nrel
        //{
        //    get { return crelax_nrel; }
        //    set { crelax_nrel = value; OnPropertyChanged(); }
        //}

        //private double crelax_q;
        //public double Crelax_q
        //{
        //    get { return crelax_q; }
        //    set { crelax_q = value; OnPropertyChanged(); }
        //}

        //private int n_repetitions_satunsat;
        //public int N_repetitions_satunsat
        //{
        //    get { return n_repetitions_satunsat; }
        //    set { n_repetitions_satunsat = value; OnPropertyChanged(); }
        //}

        #endregion

        #region Methods

        public void Initilize()
        {
            
            this.Crelax = 1.0;
            this.Dtdec = 0.0;
            this.Dtinc = 0.0;
            this.Dtinit = 0.0;
            this.Dtmax = 0.0;
            this.Dtmin = 0.0;
            this.Epshsat_tol = 0.0;
            this.Epsh_tol = 0.0;
            this.Erroronnode = false;

            this.It_dec_dt = 7;
            this.It_inc_dt = 3;
            this.it_max = 50;
            this.It_min = 1;
            this.Masslump = true;
            this.Maxhsatinc = 0.01;
            this.Multksal = 1.024;
            this.Quadratureorder = 10;
            this.Tinit = 0;
            this.Tmax = 21600;
            this.Tprintinc = 1.0;
            this.Typematrixstorage = 1;
            this.Typepreconditioner = 1;
            this.Typesolution = 1;
            this.Typesolver = 1;

            //Not yet implemented
            this.Ccourant = 0.0;
            this.Nrelmin = 0.000001;
            this.Nrelmax = 1.0;
            this.Isrestarttime = true;
            this.Trestart = 0.0;

            //this.Crelax_nrel = 1.0;
            //this.Crelax_q = 1.0;
            //this.N_repetitions_satunsat = 5;



        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
