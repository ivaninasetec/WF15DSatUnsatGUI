using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowModelLib
{
    public class Model_ty_verticalmodule : INotifyPropertyChanged
    {       
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        private int nelemh;
        public int Nelemh
        {
            get { return nelemh; }
            set { nelemh = value; OnPropertyChanged(); }
        }
        private double vmod_x;
        public double Vmod_x
        {
            get { return vmod_x; }
            set { vmod_x = value; OnPropertyChanged(); }
        }

        public void Initialize()
        {
            this.ID = 0;
            this.nelemh = 10;
            this.Vmod_x = 0;
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
