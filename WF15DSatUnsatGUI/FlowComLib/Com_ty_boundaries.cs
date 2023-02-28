using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowComLib
{
    public class Com_ty_boundaries : INotifyPropertyChanged
    {
        private BindingList<Com_ty_boundary> boundaries;
        public BindingList<Com_ty_boundary> Boundaries
        {
            get { return boundaries; }
            set { boundaries = value; OnPropertyChanged(); }
        }
        #region Constructor
        public Com_ty_boundaries()
        {
            this.Boundaries = new BindingList<Com_ty_boundary>();
            this.Initialize();
        }
        #endregion

        public void Initialize()
        {
            this.Boundaries.Clear();
            Com_ty_boundary tempboundary = new Com_ty_boundary();
            tempboundary.Initialize();
            this.Boundaries.Add(tempboundary);
        }

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
