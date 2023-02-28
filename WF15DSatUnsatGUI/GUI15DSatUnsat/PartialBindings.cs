using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI15DSATUNSAT
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        //BINDINGS
        //BINDINGS PARAMETERS
        private Binding binding_Quadratureorder;
        private Binding binding_Parameter_Epsh_tol;
        private Binding binding_Parameter_Epsth_tol;
        private Binding binding_Parameter_Epshsat_tol;
        private Binding binding_Parameter_It_inc_dt;
        private Binding binding_Parameter_It_dec_dt;
        private Binding binding_Parameter_It_min;
        private Binding binding_Parameter_It_max;
        private Binding binding_Parameter_Crelax;
        private Binding binding_Parameter_Masslump;
        private Binding binding_Parameter_Erroronnode;
        private Binding binding_Parameter_Quadratureorder;
        //private Binding binding_Parameter_Typesolution;
        private Binding binding_Parameter_Multksal;
        private Binding binding_Parameter_Maxhsatinc;
        private Binding binding_Parameter_Tinit;
        private Binding binding_Parameter_Dtinit;
        private Binding binding_Parameter_Tmax;
        private Binding binding_Parameter_Dtinc;
        private Binding binding_Parameter_Dtdec;
        private Binding binding_Parameter_Dtmax;
        private Binding binding_Parameter_Dtmin;
        private Binding binding_Parameter_Tprintinc;
        private Binding binding_Meshelements;


        BindingSource sourceMaterials;
        private BindingSource sourceIDMaterial;
        private Binding binding_Layers_Width;
        private Binding binding_Layers_Zphr;
        private Binding binding_Layers_Slopebottom;
        private BindingSource sourceLayers;
        private BindingSource sourceVerticalModules;
        private BindingSource sourceBoundary;

        private BindingSource sourceOutputConstraints;
        private BindingSource sourceOutputSatNodes;
        private BindingSource sourceOutputSatElements;
        private BindingSource sourceOutputUnsatNodes;
        private BindingSource sourceOutputUnsatElements;

        private void CreateBindings()
        {
            //BINDINGS PARAMETERS TAB
            binding_Quadratureorder = new Binding("Value", trackbar_Parameters_Quadratureorder, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Epsh_tol = new Binding("Text", Model.Com_Ty_Parameters, "Epsh_tol", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Epsth_tol = new Binding("Text", Model.Com_Ty_Parameters, "Epsth_tol", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Epshsat_tol = new Binding("Text", Model.Com_Ty_Parameters, "Epshsat_tol", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_It_inc_dt = new Binding("Text", Model.Com_Ty_Parameters, "It_inc_dt", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_It_dec_dt = new Binding("Text", Model.Com_Ty_Parameters, "It_dec_dt", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_It_min = new Binding("Text", Model.Com_Ty_Parameters, "It_min", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_It_max = new Binding("Text", Model.Com_Ty_Parameters, "It_max", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Crelax = new Binding("Text", Model.Com_Ty_Parameters, "Crelax", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Masslump = new Binding("Checked", Model.Com_Ty_Parameters, "Masslump", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Erroronnode = new Binding("Checked", Model.Com_Ty_Parameters, "Erroronnode", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Quadratureorder = new Binding("Value", Model.Com_Ty_Parameters, "Quadratureorder", true, DataSourceUpdateMode.OnPropertyChanged);
            //binding_Parameter_Typesolution = new Binding("Typesolution", Model.com_Ty_Parameters, "Typesolution", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Multksal = new Binding("Text", Model.Com_Ty_Parameters, "Multksal", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Maxhsatinc = new Binding("Text", Model.Com_Ty_Parameters, "Maxhsatinc", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Tinit = new Binding("Text", Model.Com_Ty_Parameters, "Tinit", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Dtinit = new Binding("Text", Model.Com_Ty_Parameters, "Dtinit", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Tmax = new Binding("Text", Model.Com_Ty_Parameters, "Tmax", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Dtinc = new Binding("Text", Model.Com_Ty_Parameters, "Dtinc", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Dtdec = new Binding("Text", Model.Com_Ty_Parameters, "Dtdec", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Dtmax = new Binding("Text", Model.Com_Ty_Parameters, "Dtmax", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Dtmin = new Binding("Text", Model.Com_Ty_Parameters, "Dtmin", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Parameter_Tprintinc = new Binding("Text", Model.Com_Ty_Parameters, "Tprintinc", true, DataSourceUpdateMode.OnPropertyChanged);

            //BINDING MATERIALS
            sourceMaterials = new BindingSource(Model.Materials.Materials, null);
            binding_Layers_Width = new Binding("Text", Model.Com_Ty_Layers, "Width", true, DataSourceUpdateMode.OnPropertyChanged);

            //BINDING LAYERS
            binding_Layers_Zphr = new Binding("Text", Model.Com_Ty_Layers, "Zphr", true, DataSourceUpdateMode.OnPropertyChanged);
            binding_Layers_Slopebottom = new Binding("Text", Model.Com_Ty_Layers, "Slopebottom", true, DataSourceUpdateMode.OnPropertyChanged);
            //binding_Layers_Topboundbyh = new Binding("Topboundbyh", Model.Com_Ty_Layers, "Topboundbyh", true, DataSourceUpdateMode.OnPropertyChanged);
            //binding_Layers_Topboundbyh = new Binding("Checked", Com_Ty_Layers, "Topboundbyh", true, DataSourceUpdateMode.OnPropertyChanged);
            //binding_Layers_Bottombyphl = new Binding("Bottombyphl", Model.Com_Ty_Layers, "Bottombyphl", true, DataSourceUpdateMode.OnPropertyChanged);
            //binding_Layers_Bottombyphl = new Binding("Checked", Com_Ty_Layers, "Bottombyphl", true, DataSourceUpdateMode.OnPropertyChanged);

            binding_Meshelements = new Binding("Meshelements", Model.Com_Ty_Layers.Layers, "Nelemv", true, DataSourceUpdateMode.OnPropertyChanged);

            //BINDING LAYER GRIDVIEW
            sourceLayers = new BindingSource(Model.Com_Ty_Layers.Layers, null);

            sourceIDMaterial = new BindingSource(Model.Materials.Materials.Select(x => x.Id).ToList(), null);


            //BINDING MESH
            sourceVerticalModules = new BindingSource(Model.Model_Ty_Mesh.Vertical_Modules, null);

            //BINDING BOUNDARIES
            sourceBoundary = new BindingSource(Model.Boundaries.Boundaries, null);

            //BINDING OUTPUTS
            sourceOutputConstraints = new BindingSource(OutputConstraintList.Items, null);
            sourceOutputSatNodes = new BindingSource(OutputSatNodesList.Items, null);
            sourceOutputSatElements = new BindingSource(OutputSatElementsList.Items, null);
            sourceOutputUnsatNodes = new BindingSource(OutputUnsatNodesList.Items, null);
            sourceOutputUnsatElements = new BindingSource(OutputUnsatElementsList.Items, null);

        }

        private void AssignBindings()
        {
            //BINDINGS PARAMETERS
            numericUpDown_Parameters_Quadratureorder.DataBindings.Add(binding_Quadratureorder);
            textbox_Parameters_Epsh_tol.DataBindings.Add(binding_Parameter_Epsh_tol);
            textbox_Parameters_Epsth_tol.DataBindings.Add(binding_Parameter_Epsth_tol);
            textbox_Parameters_Epshsat_tol.DataBindings.Add(binding_Parameter_Epshsat_tol);
            textbox_Parameters_It_inc_dt.DataBindings.Add(binding_Parameter_It_inc_dt);
            textbox_Parameters_It_dec_dt.DataBindings.Add(binding_Parameter_It_dec_dt);
            textbox_Parameters_It_min.DataBindings.Add(binding_Parameter_It_min);
            textbox_Parameters_It_max.DataBindings.Add(binding_Parameter_It_max);
            textbox_Parameters_Crelax.DataBindings.Add(binding_Parameter_Crelax);
            checkBox_Parameters_Masslump.DataBindings.Add(binding_Parameter_Masslump);
            checkBox_Parameters_Erroronnode.DataBindings.Add(binding_Parameter_Erroronnode);
            trackbar_Parameters_Quadratureorder.DataBindings.Add(binding_Parameter_Quadratureorder);
            //this.DataBindings.Add(binding_Parameter_Typesolution);
            textbox_Parameters_Multksal.DataBindings.Add(binding_Parameter_Multksal);
            textbox_Parameters_Maxhsatinc.DataBindings.Add(binding_Parameter_Maxhsatinc);
            textbox_Parameters_Tinit.DataBindings.Add(binding_Parameter_Tinit);
            textbox_Parameters_Dtinit.DataBindings.Add(binding_Parameter_Dtinit);
            textbox_Parameters_Tmax.DataBindings.Add(binding_Parameter_Tmax);
            textbox_Parameters_Dtinc.DataBindings.Add(binding_Parameter_Dtinc);
            textbox_Parameters_Dtdec.DataBindings.Add(binding_Parameter_Dtdec);
            textbox_Parameters_Dtmax.DataBindings.Add(binding_Parameter_Dtmax);
            textbox_Parameters_Dtmin.DataBindings.Add(binding_Parameter_Dtmin);
            textBox_Parameters_Tprintinc.DataBindings.Add(binding_Parameter_Tprintinc);

            //BINDINGS MATERIALS
            datagridview_materials.DataSource = sourceMaterials;

            //BINDINGS LAYERS
            textBox_Layers_Width.DataBindings.Add(binding_Layers_Width);
            textBox_Layers_Zphr.DataBindings.Add(binding_Layers_Zphr);
            textBox_Layers_Slopebottom.DataBindings.Add(binding_Layers_Slopebottom);
            //this.DataBindings.Add(binding_Layers_Topboundbyh);
            //radioButton_Layers_Topboundbyh.DataBindings.Add(binding_Layers_Topboundbyh);
            //this.DataBindings.Add(binding_Layers_Bottombyphl);
            //radioButton_Layers_Bottombyphl.DataBindings.Add(binding_Layers_Bottombyphl);

            //BINDINGS LAYERS DATASOURCE
            dataGridView_Layers.DataSource = sourceLayers;
            dataGridView_LayerMesh.DataSource = sourceLayers;
            //layers_Material.Items.Clear();
            //if (com_Ty_Material.Count == 0) layers_Material.Items.Add(0);
            //for (int i = 0; i < com_Ty_Material.Count; i++)
            //    layers_Material.Items.Add(com_Ty_Material.Select(x => x.Id).ToList()[i]);
            //dataGridView_Layers.DataSource = sourceLayers;

            layers_IDMaterial.DataSource = Model.Materials.Materials;
            layers_IDMaterial.DisplayMember = "Id";
            layers_IDMaterial.ValueMember = "Id";


            //layers_Material.Items.Add(com_Ty_Material.Select(x => x.Id).ToList());
            //List<int> tempID = com_Ty_Material.Select(x => x.Id).ToList();
            //for (int i = 0; i < tempID.Count; i++)
            //   layers_Material.Items.Add(tempID[i]);

            //BINDING MESH
            dataGridView_VerticalModules.DataSource = sourceVerticalModules;

            //BINDING BOUNDARIES
            dataGridView_Boundary.DataSource = sourceBoundary;

            //OUTPUTS
            datagridview_OutputConstraints.DataSource = sourceOutputConstraints;
            dataGridView_OutputSatNodes.DataSource = sourceOutputSatNodes;
            dataGridView_OutputSatElements.DataSource = sourceOutputSatElements;
            dataGridView_OutputUnsatNodes.DataSource = sourceOutputUnsatNodes;
            dataGridView_OutputUnsatElements.DataSource = sourceOutputUnsatElements;
        }



    }
}
