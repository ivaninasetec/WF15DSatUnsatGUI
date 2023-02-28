using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FlowComLib
{
    public class Com_ty_layers : INotifyPropertyChanged
    {

        /// <summary>
        /// Number of layers
        /// </summary>
        public int Count
        {
            get { return layers.Count; }
        }

        /// <summary>
        /// Width of the layers [L]
        /// </summary>

        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Depht of phreatic layer [L]
        /// </summary>
        private double zphr;
        public double Zphr
        {
            get { return zphr; }
            set { zphr = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Slope at the bottom of all layers [L]
        /// </summary>
        private double slopebottom;
        public double Slopebottom
        {
            get { return slopebottom; }
            set { slopebottom = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// If true: Top boundary is defined by pressure head.
        /// </summary>
        private bool topboundbyh;
        public bool Topboundbyh
        {
            get { return topboundbyh; }
            set { topboundbyh = value; OnPropertyChanged(); }
        }
        /// <summary>
        /// If true: Top boundary is defined by the inflow on top
        /// </summary>
        public bool Topboundbyq
        {
            get { return !topboundbyh; }
            set { topboundbyh = !value; OnPropertyChanged(); }
        }
        /// <summary>
        /// If false: The bottom boundary is closed (impermeable), if true: Is fixed to the phreatic level
        /// </summary>
        private bool bottombyphl;
        public bool Bottombyphl
        {
            get { return bottombyphl; }
            set { bottombyphl = value; OnPropertyChanged(); }
        }

        private BindingList<Com_ty_layer> layers;
        public BindingList<Com_ty_layer> Layers
        {
            get { return layers; }
            set { layers = value; OnPropertyChanged(); }
        }


        #region Not implemented
        //private Vector<double> height;
        //public Vector<double> Height
        //{
        //    get { return height; }
        //    set { height = value; }
        //}

        //private Com_ty_material[] material;
        //public Com_ty_material[] Material
        //{
        //    get { return material; }
        //    set { material = value; }
        //}

        //private Vector<double> htop;
        //public Vector<double> Htop
        //{
        //    get { return htop; }
        //    set { htop = value; }
        //}

        //private Vector<double> hbottom;
        //public Vector<double> Hbottom
        //{
        //    get { return hbottom; }
        //    set { hbottom = value; }
        //}

        //private List<int> id_elem_top;
        //public List<int> Id_elem_top
        //{
        //    get { return id_elem_top; }
        //    set { id_elem_top = value; }
        //}

        //private List<int> id_elem_bottom;
        //public List<int> Id_elem_bottom
        //{
        //    get { return id_elem_bottom; }
        //    set { id_elem_bottom = value; }
        //}

        //private Vector<double> slope;
        //public Vector<double> Slope
        //{
        //    get { return slope; }
        //    set { slope = value; }
        //}
        #endregion 


        #region Constructors

        public Com_ty_layers()
        {
            this.layers = new BindingList<Com_ty_layer>();
            this.Initialize();
        }

        public Com_ty_layers(int nlayers)
        {
            this.layers = new BindingList<Com_ty_layer>();
            Initialize();
            this.layers = new BindingList<Com_ty_layer>();
            for (int i = 0; i < nlayers; i++)
            {
                Com_ty_layer templayer = new Com_ty_layer();
                templayer.IDLayer = i;
                templayer.Slope = 0.0;
                templayer.Height = 0.3;
                templayer.IDMaterial = 0;
                templayer.Meshelements = 10;
                this.layers.Add(templayer);
            }
        }

        #endregion

        #region Methods
        public void Initialize()
        {
            this.Width = 1.0;
            this.Zphr = -0.5;
            this.Slopebottom = 0.0;
            this.Topboundbyh = false;
            this.Bottombyphl = true;

            this.layers.Clear();
            Com_ty_layer templayer = new Com_ty_layer();
            templayer.IDLayer = 0;
            templayer.Slope = 0.0;
            templayer.Height = 0.3;
            templayer.IDMaterial = 0;
            templayer.Meshelements = 10;
            this.layers.Add(templayer);
        }

        #endregion



        #region Not implemented
        //public void Deallocateall()
        //{
        //    throw new System.NotImplementedException();
        //}

        /// <summary>
        /// Returns the id of the layer given the height h.
        /// </summary>
        /// <param name="h">Height from the bottom</param>
        /// <returns></returns>

        //public List<int> Get_id_from_h(in Vector<double> h)
        //{

        //    Vector<double> htemp = h;
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    List<int> output = new List<int>(h.Count);
        //    for (int i = 0; i < h.Count; i++) output.Add(0);

        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());


        //    double valuetemp;
        //    object outputtemp;

        //    for (int i=0; i < h.Count; i++)
        //    {
        //        (outputtemp, valuetemp) = htop.Find(x => { return x > htemp[i]; });
        //        if (outputtemp == null) output[i] = this.Count; else output[i] = (int)outputtemp; //If no match then the watertable surpass all layers.
        //    }
        //    return output;
        //}

        ////public void Deallocateall()
        ////{
        ////    throw new System.NotImplementedException();
        ////}

        ///// <summary>
        ///// Returns the id of the layer given the height h.
        ///// </summary>
        ///// <param name="h">Height from the bottom</param>
        ///// <returns></returns>
        //public int Get_id_from_h(in double h)
        //{

        //    double htemp = h;
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    int output; 
        //    double valuetemp;
        //    object outputtemp;

        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());

        //    (outputtemp, valuetemp) = htop.Find(x => { return x > htemp; });
        //        if (outputtemp == null) output = this.Count; else output = (int)outputtemp; //If no match then the watertable surpass all layers.
        //    return output;
        //}
        ///// <summary>
        ///// Get a vector with heghts until a given h, begining from h=0 to given h
        ///// </summary>
        ///// <param name="h">Watertable height</param>
        ///// <returns></returns>
        //public Vector<double> Get_h_from0_sca(in double h)
        //{
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    Vector<double> hbottom = Vector<double>.Build.Dense(this.Layers.Count);
        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());
        //    hbottom = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Hbottom).ToArray());

        //    return (htop.PointwiseMinimum(h) - hbottom[0]).PointwiseMaximum(0.0);
        //}
        ///// <summary>
        ///// Get a matrix [h.Count,Nlayers+1] with heights until a given h, begining from h=0 to given h
        ///// </summary>
        ///// <param name="h">Watertable height</param>
        ///// <returns></returns>
        //public Matrix<double> Get_h_from0_vec(in Vector<double> h)
        //{
        //    Matrix<double> output = Matrix<double>.Build.Dense(h.Count, this.Count + 1);
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    Vector<double> hbottom = Vector<double>.Build.Dense(this.Layers.Count);
        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());
        //    hbottom = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Hbottom).ToArray());


        //    for (int i=0;i< this.Count + 1; i++)
        //    {
        //        output.SetColumn(i, (htop.PointwiseMinimum(h[i]) - hbottom[0]).PointwiseMaximum(0.0));
        //    }

        //    return output;
        //}
        ///// <summary>
        ///// Returns height in each layer from h0, to h1. So in the second layer is added the height from 0, from the first layer.
        ///// </summary>
        ///// <param name="h0">Height of first  point from the bottom of first layer</param>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns>Vector [Nlayers+1] With heigh in each layer from h0 to h1</returns>
        //public Vector<double> Get_h_from_h_to_h(in double h0, in double h1)
        //{
        //    Vector<double> output1 = Vector<double>.Build.Dense(this.Count + 1);
        //    double output2;
        //    Vector<double> outputtemp = Vector<double>.Build.Dense(this.Count + 1);
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    Vector<double> hbottom = Vector<double>.Build.Dense(this.Layers.Count);
        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());
        //    hbottom = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Hbottom).ToArray());


        //    if (h1 > h0)
        //    {
        //        output1 = (htop.PointwiseMinimum(h1) - hbottom.PointwiseMaximum(h0)).PointwiseMaximum(0.0);
        //        output2 = Math.Max(0.0, h1 - Math.Max(htop[this.Count], h0));
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    else
        //    {
        //        output1 = (htop.PointwiseMinimum(h0) - hbottom.PointwiseMaximum(h1)).PointwiseMaximum(0.0);
        //        output2 = Math.Max(0.0, h0 - Math.Max(htop[this.Count], h1));
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    return outputtemp;
        //}
        ///// <summary>
        ///// Returns height in each layer from h0, to h1. So in the second layer is added the height from 0, from the first layer. Returns a Matrix in each row the results for each pair h0[i] and h1[i].
        ///// </summary>
        ///// <param name="h0">Height of first  point from the bottom of first layer</param>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns>Matrix [h0.Count,Nlayers+1] With heigh in each layer from h0 to h1</returns>
        //public Matrix<double> Get_h_from_h_to_h(in Vector<double> h0, in Vector<double> h1)
        //{
        //    Matrix<double> output = Matrix<double>.Build.Dense(h0.Count, this.Count + 1);

        //    for (int i = 0; i < h0.Count; i++)
        //    {
        //        output.SetRow(i,Get_h_from_h_to_h(h0[i], h1[i]));
        //    }
        //    return output;
        //}

        ///// <summary>
        ///// This function returns the increment of height from the layer h0 to the top of the layer or to h1
        ///// (the minimum of both) in each of the layers of the collection. The output is a double matrix
        ///// with dimension nlayers+1 to account for water on top of upper layer.
        ///// </summary>
        ///// <param name="h0">Height of first  point from the bottom of first layer</param>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns></returns>

        //public Vector<double> Get_inc_h(in double h0, in double h1)
        //{
        //    Vector<double> output1 = Vector<double>.Build.Dense(this.Count + 1);
        //    double output2;
        //    Vector<double> outputtemp = Vector<double>.Build.Dense(this.Count + 1);
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    Vector<double> hbottom = Vector<double>.Build.Dense(this.Layers.Count);
        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());
        //    hbottom = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Hbottom).ToArray());

        //    if (h1 > h0)
        //    {
        //        output1 = (htop.PointwiseMinimum(h1) - hbottom.PointwiseMaximum(h0)).PointwiseMaximum(0.0);
        //        output2 = Math.Max(0.0, h1 - Math.Max(htop[this.Count], h0));
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    else
        //    {
        //        output1 = (htop.PointwiseMinimum(h0) - hbottom.PointwiseMaximum(h1)).PointwiseMaximum(0.0);
        //        output2 = Math.Max(0.0, h0 - Math.Max(htop[this.Count], h1));
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    return outputtemp;
        //}
        ///// <summary>
        ///// This function returns the increment of height from the layer h0 to the top of the layer or to h1
        ///// (the minimum of both) in each of the layers of the collection. The output is a double matrix
        ///// with dimension nlayers+1 to account for water on top of upper layer.
        ///// </summary>
        ///// <param name="h0">Height of first  point from the bottom of first layer</param>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns></returns>
        //public Matrix<double> Get_inc_h(in Vector<double> h0, in Vector<double> h1)
        //{
        //    Matrix<double> output = Matrix<double>.Build.Dense(h0.Count, this.Count + 1);

        //    for (int i = 0; i < h0.Count; i++)
        //    {
        //        output.SetRow(i, Get_inc_h(h0[i], h1[i]));
        //    }
        //    return output;
        //}
        ///// <summary>
        ///// This function returns the increment of height from the layer h0 to the top of the layer or to h1
        ///// (the minimum of both) in each of the layers of the collection. The output is a double matrix
        ///// with dimension nlayers+1 to account for water on top of upper layer.
        ///// </summary>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns></returns>
        //public Vector<double> Get_inc_h_from0(in double h1)
        //{
        //    Vector<double> output1 = Vector<double>.Build.Dense(this.Count + 1,0.0);
        //    double output2;
        //    Vector<double> outputtemp = Vector<double>.Build.Dense(this.Count + 1);
        //    Vector<double> htop = Vector<double>.Build.Dense(this.Layers.Count);
        //    Vector<double> hbottom = Vector<double>.Build.Dense(this.Layers.Count);
        //    htop = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Htop).ToArray());
        //    hbottom = Vector<double>.Build.DenseOfArray(this.Layers.Select(x => x.Hbottom).ToArray());

        //    if (h1 > 0.0)
        //    {
        //        output1 = (htop.PointwiseMinimum(h1) - hbottom.PointwiseMaximum(0.0)).PointwiseMaximum(0.0);
        //        output2 = Math.Max(0.0, h1 - Math.Max(htop[this.Count], 0.0));
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    else
        //    {
        //        //output1.SetValues(0.0); not necesary, already initialized to 0.0
        //        output2 =h1;
        //        outputtemp.SetSubVector(0, this.Count, output1);
        //        outputtemp[this.Count + 1] = output2;
        //    }
        //    return outputtemp;
        //}
        ///// <summary>
        ///// This function returns the increment of height from the layer h0 to the top of the layer or to h1
        ///// (the minimum of both) in each of the layers of the collection. The output is a double matrix
        ///// with dimension nlayers+1 to account for water on top of upper layer.
        ///// </summary>
        ///// <param name="h1">Height of second point from the bottom of first layer</param>
        ///// <returns></returns>
        //public Matrix<double> Get_inc_h_from0(in Vector<double> h1)
        //{
        //    Matrix<double> output = Matrix<double>.Build.Dense(h1.Count, this.Count + 1);

        //    for (int i = 0; i < h1.Count; i++)
        //    {
        //        output.SetRow(i, Get_inc_h_from0(h1[i]));
        //    }
        //    return output;
        //}

        //public Vector<double> Get_nrel_from_hsat_to_h(in Vector<double> h0, in Vector<double> h1)
        //{
        //    const double MINVALUE_INCH = 1E-10;
        //    double hypi1, hypi0, zhypi1, zhypi0, inc0temp, inc1temp;
        //    int nlayers;

        //    Matrix<double> inch             = Matrix<double>.Build.Dense(h0.Count, this.Count + 1);
        //    Vector<double> inchnewtohold    = Vector<double>.Build.Dense(h0.Count);
        //    Vector<double> incwat           = Vector<double>.Build.Dense(h0.Count,0.0);
        //    Vector<double> satwat           = Vector<double>.Build.Dense(h0.Count,0.0);

        //    Vector<double> output = Vector<double>.Build.Dense(h0.Count, 0.0);

        //    nlayers = this.Count;

        //    //this is h1-h0 but with h1 always>0.0 and h1 always >0 and also with a min value in (h1-h0) of 1E-10.
        //    inch = this.Get_h_from_h_to_h(h0.PointwiseMaximum(0.0), h1.PointwiseMaximum(0.0));
        //    inchnewtohold = ((h1.PointwiseMaximum(0.0) - h0.PointwiseMaximum(0.0)).PointwiseSign()).PointwiseMultiply((h1.PointwiseMaximum(0.0) - h0.PointwiseMaximum(0.0)).PointwiseAbs().PointwiseMaximum(MINVALUE_INCH));

        //    inc0temp = 0.0;
        //    inc1temp = 0.0;

        //    for (int k=0;k<h0.Count; k++)
        //    {
        //        for (int i = 0; i < nlayers; k++)
        //        {
        //            inc0temp = inc1temp; //this is h0
        //            inc1temp = inc0temp + inch[k, i]; //this is h1
        //            if (inc1temp > 0)
        //            {
        //                zhypi1 = -(Math.Pow(inc1temp + this.Layers[i].Material.A, this.Layers[i].Material.N)); //-(a·Dh1)^n
        //                hypi1 = 0.0; // =hyp(zhypi1,m,n,1+1/n)     2F1(m,1/n,1+1/n,zhypi1)

        //                zhypi0 = -(Math.Pow(inc0temp + this.Layers[i].Material.A, this.Layers[i].Material.N)); //-(a·Dh0)^n
        //                hypi0 = 0.0; // =hyp(zhypi0,m,n,1+1/n)     2F1(m,1/n,1+1/n,zhypi1)

        //                output[k]= output[k]+(inc1temp/inchnewtohold[k]*(1.0-hypi1)-inc0temp/inchnewtohold[k]*(1.0-hypi0));
        //            }
        //        }

        //        if (inch[k, nlayers + 1] > 0.0)
        //        {
        //            inc0temp = inc1temp;
        //            inc1temp = inc0temp + inch[k, nlayers + 1];
        //            output[k] = output[k] + 1.0 * (inc1temp - inc0temp) / inchnewtohold[k];
        //        }

        //    }

        //    return output.PointwiseAbs();
        //}
        ///// <summary>
        ///// This function returns the ammount of water needed to fill from h0 (or h1) to h1 (or h0) in the
        ///// unsaturated multilayered system considering van-genuchten unsaturated materials
        ///// In this case we consider the unsaturated material over water table completely dry (not real) and return the mean
        ///// thsat-thres between h0 and h1.
        ///// </summary>
        ///// <param name="h0">h0</param>
        ///// <param name="h1">h1</param>
        ///// <returns>ammount of water needed to fill from h0 (or h1) to h1 (or h0)</returns>
        //public Vector<double> Get_water_inc_med(in Vector<double> h0, in Vector<double> h1)
        //{
        //    const double MIN_H0_TO_H1 = 1E-5;
        //    Vector<double> output = Vector<double>.Build.Dense(h0.Count);
        //    Vector<double> thsatrestemp = Vector<double>.Build.Dense(this.Count + 1);
        //    for (int i = 0; i < this.Count; i++){
        //        thsatrestemp[i] = this.Layers[i].Material.Thsat - this.Layers[i].Material.Thres;
        //    }
        //    thsatrestemp[this.Count + 1] = 1.0;

        //    for (int i = 0; i < h0.Count; i++)
        //    {
        //        if (h0[i] - h1[i] < MIN_H0_TO_H1)
        //            output[i] = this.Layers[this.Get_id_from_h(h1[i])].Material.Thsat - this.Layers[this.Get_id_from_h(h1[i])].Material.Thres;
        //        else
        //            output[i] = Get_inc_h(h0[i], h1[i]).DotProduct(thsatrestemp) / (h1[i] - h0[i]);
        //    }

        //    return output;
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
