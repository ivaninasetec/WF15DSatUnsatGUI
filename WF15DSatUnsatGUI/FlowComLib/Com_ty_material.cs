using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowComLib
{
    public class Com_ty_material : INotifyPropertyChanged
    {
        /// <summary>
        /// ID of the material. Automatically assigned
        /// </summary>
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Kind of material:
        /// <list type="number|description">
        /// <listheader> <number>Number</number> <description>Description</description></listheader>
        /// <item>  <number>1</number> <description>Mualem-Van Genuchten</description> </item>
        /// <item>  <number>2</number> <description>Exponential functions for WRC and K from Hayek, 2016 (for validation purposes)</description> </item>
        /// <item>  <number>3</number> <description>Brooks and Corey,1967</description> </item>
        /// <item>  <number>4</number> <description>Clean ballast (as Brooks and Corey with kr=(2+l) (From Thesis, Ivan Campos-Guereta</description> </item>
        /// </list>
        /// </summary>
        private int kindmat;
        public int Kindmat
        {
            get { return kindmat; }
            set { kindmat = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Saturated volumetric water content [L3·L-3]
        /// </summary>
        private double thsat;
        public double Thsat
        {
            get { return thsat; }
            set { thsat = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Residual volumetric water content [L3·L-3]
        /// </summary>
        private double thres;
        public double Thres
        {
            get { return thres; }
            set { thres = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Saturated permeability [L·T-1]
        /// </summary>
        private double ksat;
        public double Ksat
        {
            get { return ksat; }
            set { ksat = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Alpha parameter on Van-Genuchten, psi on Brooks-Corey and Exponential
        /// </summary>
        private double a;
        public double A
        {
            get { return a; }
            set { a = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// n exponent of Van-Genucten, exponent in other hydraulic funcions
        /// </summary>
        private double n;
        public double N
        {
            get { return n; }
            set { n = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// m parameter in Van-Genuchten, not used in other hydraulic functions
        /// </summary>
        private double m;
        public double M
        {
            get { return m; }
            set { m = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// l exponne on permeability (from Mualem). Not used in Exponential.
        /// </summary>
        private double l;
        public double L
        {
            get { return l; }
            set { l = value; OnPropertyChanged(); }
        }

        //public double Get_s_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_s_vec()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double Get_th_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_th_vec()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double Get_kr_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_kr_vec()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double Get_k_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_k_vec()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double Get_dk_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_dk_vec()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double Get_cap_sca()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public double[] Get_cap_vec()
        //{
        //    throw new System.NotImplementedException();
        //}
        #region Constructor
        public Com_ty_material()
        {
            this.Initialize();
        }
        #endregion



        #region Methods
        public void Initialize()
        {
            this.Id = 0;
            this.thres = 0.05;
            this.thsat= 0.4;
            this.a = 3.0;
            this.n = 1.5;
            this.m = 1 - 1 / n;
            this.l = 0.5;
        }
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
