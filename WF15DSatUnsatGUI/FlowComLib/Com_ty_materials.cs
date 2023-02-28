using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowComLib
{
    public class Com_ty_materials : INotifyPropertyChanged
    {
        private BindingList<Com_ty_material> materials;
        public BindingList<Com_ty_material> Materials
        {
            get { return materials; }
            set { materials = value; OnPropertyChanged(); }
        }
        #region Constructor
        public Com_ty_materials()
        {
            this.Materials = new BindingList<Com_ty_material>();
            this.Initialize();
        }
        #endregion

        public void Initialize()
        {
            this.Materials.Clear();
            Com_ty_material tempmaterial = new Com_ty_material();
            tempmaterial.Initialize();
            this.Materials.Add(tempmaterial);
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