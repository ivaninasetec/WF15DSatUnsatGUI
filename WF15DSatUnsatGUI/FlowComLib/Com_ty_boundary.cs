using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace FlowComLib
{
    public class Com_ty_boundary : INotifyPropertyChanged
    {
        private double timebound;
        public double Timebound
        {
            get { return timebound; }
            set { timebound = value; OnPropertyChanged(); }
        }

        private double qbound;
        public double Qbound
        {
            get { return qbound; }
            set { qbound = value; OnPropertyChanged(); }
        }
        //private double hbound;
        public double Hbound
        {
            get { return qbound; }
            set { qbound = value; OnPropertyChanged(); }
        }

        //private bool topboundbyh=false;
        //public bool Topboundbyh
        //{
        //    get { return topboundbyh; }
        //    set { topboundbyh = value; }
        //}

        //private bool topboundbyq=false;
        //public bool Topboundbyq
        //{
        //    get { return topboundbyq; }
        //    set { topboundbyq = value; }
        //}

        //private int timestepcount;
        //public int Timestepcount
        //{
        //    get { return timestepcount; }
        //    set { timestepcount = value; }
        //}

        //private int index=1;
        //public int Index
        //{
        //    get { return index; }
        //    set { index = value; }
        //}

        //private Vector<double> timebound;
        //public Vector<double> Timebound
        //{
        //    get { return timebound; }
        //    set { timebound = value; }
        //}

        //private Vector<double> hbound;
        //public Vector<double> Hbound
        //{
        //    get { return hbound; }
        //    set { hbound = value; }
        //}

        //private Vector<double> qbound;
        //public Vector<double> Qbound
        //{
        //    get { return qbound; }
        //    set { qbound = value; }
        //}

        //public double Get_hbound_file(double t)
        //{
        //    if (this.Index > 1)
        //    {
        //        while (t<this.Timebound[this.Index] || this.Index==1)
        //            { this.Index = Math.Max(1, this.Index - 1); }
        //    }

        //    if (this.Index < this.Timestepcount)
        //    {
        //        while (t>this.Timebound[Math.Min(this.Index+1,this.Timestepcount)] && this.Index!=this.Timestepcount)
        //        {
        //            this.Index = Math.Min(this.Index + 1, this.Timestepcount);
        //        }
        //    }

        //    return this.Hbound[this.Index];
        //}

        //public double Get_qbound_file(double t)
        //{
        //    if(this.Index < this.Timestepcount)
        //    {
        //        while(t>this.Timebound[Math.Min(this.Index,this.Timestepcount)] && this.Index != this.Timestepcount)
        //            { this.Index = Math.Min(this.Index + 1, this.Timestepcount); }
        //    }
        //    return this.Qbound[this.Index];

        //    throw new System.NotImplementedException();
        //}

        #region Constructor
        public Com_ty_boundary()
        {
            Initialize();
        }
        #endregion

        #region Methods
        public void Initialize()
        {
            this.Timebound= 0.0;
            this.Qbound = 0.0;
            this.Hbound = 0.0;
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
