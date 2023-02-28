using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowComLib
{
    public class Com_ty_layer : INotifyPropertyChanged
    {
        #region Properties
        /// <summary>
        /// ID of the current layer. Automatically assigned
        /// </summary>
        private int iDLayer;
        public int IDLayer
        {
            get { return iDLayer; }
            set { iDLayer = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Slope on top
        /// </summary>
        private double slope;
        public double Slope
        {
            get { return slope; }
            set { slope = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// Height of layer
        /// </summary>
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// ID of the material
        /// </summary>
        private int iDmaterial;
        public int IDMaterial
        {
            get { return iDmaterial; }
            set { iDmaterial = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Number of elements in which the layer is divided
        /// </summary>
        private int meshelements;
        public int Meshelements
        {
            get { return meshelements; }
            set { meshelements = value; OnPropertyChanged(); }
        }
        #endregion

        #region Not implemented
        ///// <summary>
        ///// Material with the ID selected
        ///// </summary>
        //private Com_ty_material material;
        //public Com_ty_material Material
        //{
        //    get { return material; }
        //    set { material = value; OnPropertyChanged(); }
        //}

        //private double htop;
        //public double Htop
        //{
        //    get { return htop; }
        //    set { htop = value; }
        //}

        //private double hbottom;
        //public double Hbottom
        //{
        //    get { return hbottom; }
        //    set { hbottom = value; }
        //}

        //private int id_elem_top;
        //public int Id_elem_top
        //{
        //    get { return id_elem_top; }
        //    set { id_elem_top = value; }
        //}

        //private int id_elem_bottom;
        //public int Id_elem_bottom
        //{
        //    get { return id_elem_bottom; }
        //    set { id_elem_bottom = value; }
        //}
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
