namespace GUI15DSATUNSAT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Parameters");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Materials");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Layers");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mesh");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("INPUT ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("CALCULATE ");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Constraints");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sat nodes");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sat elements");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Unsat nodes");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Unsat elements");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("OUTPUT ", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_FileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_CalculationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar_Calculating = new System.Windows.Forms.ToolStripProgressBar();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Main_New = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Main_Openfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Main_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Main_Saveas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Main_Calc = new System.Windows.Forms.ToolStripButton();
            this.treeView_Main = new System.Windows.Forms.TreeView();
            this.tab_Inputs = new System.Windows.Forms.TabControl();
            this.tab_Header = new System.Windows.Forms.TabPage();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.textBox_Header = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tab_Parameters = new System.Windows.Forms.TabPage();
            this.panel_Parameters = new System.Windows.Forms.Panel();
            this.groupBox_Parameters_Tolerances = new System.Windows.Forms.GroupBox();
            this.label_Parameters_Epsh_tol = new System.Windows.Forms.Label();
            this.textbox_Parameters_Epsh_tol = new System.Windows.Forms.TextBox();
            this.label_Parameters_Epsth_tol = new System.Windows.Forms.Label();
            this.textbox_Parameters_Epsth_tol = new System.Windows.Forms.TextBox();
            this.label_Parameters_Maxhsatinc = new System.Windows.Forms.Label();
            this.textbox_Parameters_Maxhsatinc = new System.Windows.Forms.TextBox();
            this.label_Parameters_Epshsat_tol = new System.Windows.Forms.Label();
            this.textbox_Parameters_Epshsat_tol = new System.Windows.Forms.TextBox();
            this.checkBox_Parameters_Erroronnode = new System.Windows.Forms.CheckBox();
            this.groupBox_Parameters_Timestepping = new System.Windows.Forms.GroupBox();
            this.label_Paramters_It_max = new System.Windows.Forms.Label();
            this.textbox_Parameters_It_max = new System.Windows.Forms.TextBox();
            this.label_Parameters_Dtmax = new System.Windows.Forms.Label();
            this.textbox_Parameters_Dtmax = new System.Windows.Forms.TextBox();
            this.label_Parameters_Dtmin = new System.Windows.Forms.Label();
            this.textbox_Parameters_Dtmin = new System.Windows.Forms.TextBox();
            this.label_Parameters_Tmax = new System.Windows.Forms.Label();
            this.textbox_Parameters_Tmax = new System.Windows.Forms.TextBox();
            this.label_Parameters_Dtinit = new System.Windows.Forms.Label();
            this.textbox_Parameters_Dtinit = new System.Windows.Forms.TextBox();
            this.label_Parameters_Tinit = new System.Windows.Forms.Label();
            this.textbox_Parameters_Tinit = new System.Windows.Forms.TextBox();
            this.label_Parameters_Dtdec = new System.Windows.Forms.Label();
            this.textbox_Parameters_Dtdec = new System.Windows.Forms.TextBox();
            this.label_Parameters_PrintInc = new System.Windows.Forms.Label();
            this.label_Parameters_Dtinc = new System.Windows.Forms.Label();
            this.textBox_Parameters_Tprintinc = new System.Windows.Forms.TextBox();
            this.textbox_Parameters_Dtinc = new System.Windows.Forms.TextBox();
            this.label_iterations = new System.Windows.Forms.Label();
            this.label_Parameters_It_dec_dt = new System.Windows.Forms.Label();
            this.textbox_Parameters_It_dec_dt = new System.Windows.Forms.TextBox();
            this.label_Parameters_It_inc_dt = new System.Windows.Forms.Label();
            this.textbox_Parameters_It_inc_dt = new System.Windows.Forms.TextBox();
            this.label_Parameters_It_min = new System.Windows.Forms.Label();
            this.textbox_Parameters_It_min = new System.Windows.Forms.TextBox();
            this.groupBox_Paramaters_MatrixSparsity = new System.Windows.Forms.GroupBox();
            this.radiobutton_Parameters_Typematrixstorage_Banded = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Typematrixstorage_CSR = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Typematrixstorage_Dense = new System.Windows.Forms.RadioButton();
            this.groupBox_Parameters_Solvers = new System.Windows.Forms.GroupBox();
            this.radiobutton_Parameters_Solver_FMGRES = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Solver_Paradiso = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Solver_IntelDSS = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Solver_Direct = new System.Windows.Forms.RadioButton();
            this.groupBox_Parameters_MatrixPreconditioners = new System.Windows.Forms.GroupBox();
            this.radiobutton_Parameters_Preconditioner_ILUT = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Preconditioner_ILU0 = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Preconditioner_Jacobi = new System.Windows.Forms.RadioButton();
            this.radiobutton_Parameters_Preconditioner_None = new System.Windows.Forms.RadioButton();
            this.checkBox_Parameters_Masslump = new System.Windows.Forms.CheckBox();
            this.label_Patameters_Multksat = new System.Windows.Forms.Label();
            this.textbox_Parameters_Multksal = new System.Windows.Forms.TextBox();
            this.label_Parameters_Crelax = new System.Windows.Forms.Label();
            this.textbox_Parameters_Crelax = new System.Windows.Forms.TextBox();
            this.label_Parameters_Quadratureorder = new System.Windows.Forms.Label();
            this.numericUpDown_Parameters_Quadratureorder = new System.Windows.Forms.NumericUpDown();
            this.trackbar_Parameters_Quadratureorder = new System.Windows.Forms.TrackBar();
            this.tab_Materials = new System.Windows.Forms.TabPage();
            this.datagridview_materials = new System.Windows.Forms.DataGridView();
            this.material_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_Kindmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_Thsat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_Thres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_Alfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maerial_Ksat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_L = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Layers = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label_Layers_Width = new System.Windows.Forms.Label();
            this.textBox_Layers_Width = new System.Windows.Forms.TextBox();
            this.label_Layers_Zphr = new System.Windows.Forms.Label();
            this.textBox_Layers_Zphr = new System.Windows.Forms.TextBox();
            this.label_Layers_Slopebottom = new System.Windows.Forms.Label();
            this.textBox_Layers_Slopebottom = new System.Windows.Forms.TextBox();
            this.groupBox_TopBoundary = new System.Windows.Forms.GroupBox();
            this.radioButton_Layers_Topboundbyh = new System.Windows.Forms.RadioButton();
            this.radioButton_Layers_Topboundbyq = new System.Windows.Forms.RadioButton();
            this.groupBox_BottomBoundary = new System.Windows.Forms.GroupBox();
            this.radioButton_Layers_Bottombyphl = new System.Windows.Forms.RadioButton();
            this.radioButton_Layers_BottomImpermeable = new System.Windows.Forms.RadioButton();
            this.dataGridView_Layers = new System.Windows.Forms.DataGridView();
            this.layers_IDlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_Slope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_IDMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.layers_Meshelements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_IDMaterialHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_MaterialHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_HtopHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_HbottomHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_Id_elem_topHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layers_Id_elem_bottomHidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Mesh = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label_ne = new System.Windows.Forms.Label();
            this.textBox_Ne = new System.Windows.Forms.TextBox();
            this.textBox_Nc = new System.Windows.Forms.TextBox();
            this.label_Nc = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox_LayerMesh = new System.Windows.Forms.GroupBox();
            this.dataGridView_LayerMesh = new System.Windows.Forms.DataGridView();
            this.layerMesh_IDlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Meshelements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Slope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_IDMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Htop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Hbottom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Id_elem_top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.layerMesh_Id_elem_bottom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_VerElem = new System.Windows.Forms.GroupBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label_Nvmod = new System.Windows.Forms.Label();
            this.textBox_Nvmod = new System.Windows.Forms.TextBox();
            this.dataGridView_VerticalModules = new System.Windows.Forms.DataGridView();
            this.verticalModules_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalModules_Nelemh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verticalModules_Vmod_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Boundaries = new System.Windows.Forms.TabPage();
            this.groupBox_Boundary = new System.Windows.Forms.GroupBox();
            this.dataGridView_Boundary = new System.Windows.Forms.DataGridView();
            this.boundary_Timebound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boundary_Hbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boundary_Qbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog_FileInput = new System.Windows.Forms.OpenFileDialog();
            this.webBrowser_Right = new System.Windows.Forms.WebBrowser();
            this.panel_Input = new System.Windows.Forms.Panel();
            this.saveFileDialog_Output = new System.Windows.Forms.SaveFileDialog();
            this.panel_Calculate = new System.Windows.Forms.Panel();
            this.splitContainer_Calculate = new System.Windows.Forms.SplitContainer();
            this.scatterXYControl_Calculate_Timestep = new GraphControls.ScatterXYControl();
            this.richTextBoxCalculation = new System.Windows.Forms.RichTextBox();
            this.panel_OutputConstraints = new System.Windows.Forms.Panel();
            this.tabControl_OutputConstraints = new System.Windows.Forms.TabControl();
            this.tab_OutputConstraints_Graph = new System.Windows.Forms.TabPage();
            this.panel_OutputConstraints_Graph = new System.Windows.Forms.Panel();
            this.scatterXYControl_Constraints = new GraphControls.ScatterXYControl();
            this.panel_OutputConstraints_GraphOptions = new System.Windows.Forms.Panel();
            this.button_Constraints_Update = new System.Windows.Forms.Button();
            this.button_Constraints_Clear = new System.Windows.Forms.Button();
            this.button_Constraints_Add_Variable = new System.Windows.Forms.Button();
            this.comboBox_Constraints_numIU = new System.Windows.Forms.ComboBox();
            this.comboBox_Constraints_numIS = new System.Windows.Forms.ComboBox();
            this.label_Constraints_Variable = new System.Windows.Forms.Label();
            this.comboBox_Constraints_Variable = new System.Windows.Forms.ComboBox();
            this.label_Constraints_IU = new System.Windows.Forms.Label();
            this.label_Constraints_IS = new System.Windows.Forms.Label();
            this.tab_OutputContraints_Table = new System.Windows.Forms.TabPage();
            this.datagridview_OutputConstraints = new System.Windows.Forms.DataGridView();
            this.Column_Constraints_IDconstraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator_OutputConstraints = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.timer_CalculationTimestep = new System.Windows.Forms.Timer(this.components);
            this.panel_OutputSatNodes = new System.Windows.Forms.Panel();
            this.tabControl_OutputSatNodes = new System.Windows.Forms.TabControl();
            this.tabPage_SatNodes_Graph = new System.Windows.Forms.TabPage();
            this.panel_OutputSatNodes_Graph = new System.Windows.Forms.Panel();
            this.splitContainer_SatNodes = new System.Windows.Forms.SplitContainer();
            this.scatterXYControl_SatNodes_Layers = new GraphControls.ScatterXYControl();
            this.scatterXYControl_SatNodes_Others = new GraphControls.ScatterXYControl();
            this.panel_OutputSatNodes_GraphOptions = new System.Windows.Forms.Panel();
            this.comboBox_SatNodes_T = new System.Windows.Forms.ComboBox();
            this.label_SatNodes_T = new System.Windows.Forms.Label();
            this.button_SatNodes_Update = new System.Windows.Forms.Button();
            this.button_SatNodes_Clear = new System.Windows.Forms.Button();
            this.button_SatNodes_AddVariable = new System.Windows.Forms.Button();
            this.comboBox_SatNodes_numIS = new System.Windows.Forms.ComboBox();
            this.label_SatNodes_Variable = new System.Windows.Forms.Label();
            this.comboBox_SatNodes_Variable = new System.Windows.Forms.ComboBox();
            this.label_SatNodes_IS = new System.Windows.Forms.Label();
            this.tabPage_SatNodes_Table = new System.Windows.Forms.TabPage();
            this.dataGridView_OutputSatNodes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn_SatNodes_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator_OutputSatNodes = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator_SatNodes_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator_SatNodes_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_SatNodes_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigator_SatNOdes_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_SatNodes_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatNodes_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_OutputSatElements = new System.Windows.Forms.Panel();
            this.tabControl_OutputSatElements = new System.Windows.Forms.TabControl();
            this.tabPage_SatElements_Graph = new System.Windows.Forms.TabPage();
            this.panel_OutputSatElements_Graph = new System.Windows.Forms.Panel();
            this.splitContainer_SatElements = new System.Windows.Forms.SplitContainer();
            this.scatterXYControl_SatElements_Layers = new GraphControls.ScatterXYControl();
            this.scatterXYControl_SatElements_Others = new GraphControls.ScatterXYControl();
            this.panel_OutputSatElements_GraphOptions = new System.Windows.Forms.Panel();
            this.comboBox_SatElements_T = new System.Windows.Forms.ComboBox();
            this.label_SatElements_T = new System.Windows.Forms.Label();
            this.button_SatElements_Update = new System.Windows.Forms.Button();
            this.button_SatElements_Clear = new System.Windows.Forms.Button();
            this.button_SatElements_AddVariable = new System.Windows.Forms.Button();
            this.comboBox_SatElements_numIS = new System.Windows.Forms.ComboBox();
            this.label_SatElements_Variable = new System.Windows.Forms.Label();
            this.comboBox_SatElements_Variable = new System.Windows.Forms.ComboBox();
            this.label_SatElements_IS = new System.Windows.Forms.Label();
            this.tabPage_SatElements_Table = new System.Windows.Forms.TabPage();
            this.dataGridView_OutputSatElements = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn_SatElements_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator_OutputSatElements = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigator_SatElements_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigator_SatElements_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_SatElements_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigator_SatElements_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigator_SatElements_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator_SatElements_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_OutputUnsatNodes = new System.Windows.Forms.Panel();
            this.tabControl_OutputUnsatNodes = new System.Windows.Forms.TabControl();
            this.tabPage_UnsatNodes_Graph = new System.Windows.Forms.TabPage();
            this.panel_OutputUnsatNodes_Graph = new System.Windows.Forms.Panel();
            this.scatterXYControl_UnsatNodes = new GraphControls.ScatterXYControl();
            this.panel_OutputUnsatNodes_GraphOptions = new System.Windows.Forms.Panel();
            this.comboBox_UnsatNodes_T = new System.Windows.Forms.ComboBox();
            this.label_UnsatNodes_T = new System.Windows.Forms.Label();
            this.button_UnsatNodes_Update = new System.Windows.Forms.Button();
            this.button_UnsatNodes_Clear = new System.Windows.Forms.Button();
            this.button_UnsatNodes_AddVariable = new System.Windows.Forms.Button();
            this.comboBox_UnsatNodes_numIU = new System.Windows.Forms.ComboBox();
            this.label_UnsatNodes_Variable = new System.Windows.Forms.Label();
            this.comboBox_UnsatNodes_Variable = new System.Windows.Forms.ComboBox();
            this.label_UnsatNodes_IU = new System.Windows.Forms.Label();
            this.tabPage_UnsatNodes_Table = new System.Windows.Forms.TabPage();
            this.dataGridView_OutputUnsatNodes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn_UnsatNodes_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator_OutputUnsatNodes = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton_UnsatNodes_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_UnsatNodes_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_UnsatNodes_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatNodes_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatNodes_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_UnsatNodes_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_UnsatNodes_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator_UnsatNodes_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_UnsatNodes_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatNodes_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_UnstaNodes_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel_OutputUnsatElements = new System.Windows.Forms.Panel();
            this.tabControl_OutputUnsatElements = new System.Windows.Forms.TabControl();
            this.tabPage_UnsatElements_Graph = new System.Windows.Forms.TabPage();
            this.panel_OutputUnsatElements_Graph = new System.Windows.Forms.Panel();
            this.scatterXYControl_UnsatElements = new GraphControls.ScatterXYControl();
            this.panel_OutputUnsatElements_GraphOptions = new System.Windows.Forms.Panel();
            this.comboBox_UnsatElements_T = new System.Windows.Forms.ComboBox();
            this.label_UnsatElements_T = new System.Windows.Forms.Label();
            this.button_UnsatElements_Update = new System.Windows.Forms.Button();
            this.button_UnsatElements_Clear = new System.Windows.Forms.Button();
            this.button_UnsatElements_AddVariable = new System.Windows.Forms.Button();
            this.comboBox_UnsatElements_numIU = new System.Windows.Forms.ComboBox();
            this.label_UnsatElements_Variable = new System.Windows.Forms.Label();
            this.comboBox_UnsatElements_Variable = new System.Windows.Forms.ComboBox();
            this.label_UnsatElements_IU = new System.Windows.Forms.Label();
            this.tabPage_UnsatElements_Table = new System.Windows.Forms.TabPage();
            this.dataGridView_OutputUnsatElements = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn_OutputUnsatElements_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator_OutputUnsatElements = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton_UnsatElements_AddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel_UnsatElements_CountItem = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_UnsatElements_DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatElements_MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatElements_MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_UnsatElements_Separator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_UnsatElements_PositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator__UnsatElements_Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_UnsatElements_MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_UnsatElements_MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_UnsatElements_Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip_Main.SuspendLayout();
            this.tab_Inputs.SuspendLayout();
            this.tab_Header.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.tab_Parameters.SuspendLayout();
            this.panel_Parameters.SuspendLayout();
            this.groupBox_Parameters_Tolerances.SuspendLayout();
            this.groupBox_Parameters_Timestepping.SuspendLayout();
            this.groupBox_Paramaters_MatrixSparsity.SuspendLayout();
            this.groupBox_Parameters_Solvers.SuspendLayout();
            this.groupBox_Parameters_MatrixPreconditioners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Parameters_Quadratureorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_Parameters_Quadratureorder)).BeginInit();
            this.tab_Materials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_materials)).BeginInit();
            this.tab_Layers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox_TopBoundary.SuspendLayout();
            this.groupBox_BottomBoundary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Layers)).BeginInit();
            this.tab_Mesh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox_LayerMesh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LayerMesh)).BeginInit();
            this.groupBox_VerElem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VerticalModules)).BeginInit();
            this.tab_Boundaries.SuspendLayout();
            this.groupBox_Boundary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Boundary)).BeginInit();
            this.panel_Input.SuspendLayout();
            this.panel_Calculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Calculate)).BeginInit();
            this.splitContainer_Calculate.Panel1.SuspendLayout();
            this.splitContainer_Calculate.Panel2.SuspendLayout();
            this.splitContainer_Calculate.SuspendLayout();
            this.panel_OutputConstraints.SuspendLayout();
            this.tabControl_OutputConstraints.SuspendLayout();
            this.tab_OutputConstraints_Graph.SuspendLayout();
            this.panel_OutputConstraints_Graph.SuspendLayout();
            this.panel_OutputConstraints_GraphOptions.SuspendLayout();
            this.tab_OutputContraints_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_OutputConstraints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputConstraints)).BeginInit();
            this.bindingNavigator_OutputConstraints.SuspendLayout();
            this.panel_OutputSatNodes.SuspendLayout();
            this.tabControl_OutputSatNodes.SuspendLayout();
            this.tabPage_SatNodes_Graph.SuspendLayout();
            this.panel_OutputSatNodes_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SatNodes)).BeginInit();
            this.splitContainer_SatNodes.Panel1.SuspendLayout();
            this.splitContainer_SatNodes.Panel2.SuspendLayout();
            this.splitContainer_SatNodes.SuspendLayout();
            this.panel_OutputSatNodes_GraphOptions.SuspendLayout();
            this.tabPage_SatNodes_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputSatNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputSatNodes)).BeginInit();
            this.bindingNavigator_OutputSatNodes.SuspendLayout();
            this.panel_OutputSatElements.SuspendLayout();
            this.tabControl_OutputSatElements.SuspendLayout();
            this.tabPage_SatElements_Graph.SuspendLayout();
            this.panel_OutputSatElements_Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SatElements)).BeginInit();
            this.splitContainer_SatElements.Panel1.SuspendLayout();
            this.splitContainer_SatElements.Panel2.SuspendLayout();
            this.splitContainer_SatElements.SuspendLayout();
            this.panel_OutputSatElements_GraphOptions.SuspendLayout();
            this.tabPage_SatElements_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputSatElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputSatElements)).BeginInit();
            this.bindingNavigator_OutputSatElements.SuspendLayout();
            this.panel_OutputUnsatNodes.SuspendLayout();
            this.tabControl_OutputUnsatNodes.SuspendLayout();
            this.tabPage_UnsatNodes_Graph.SuspendLayout();
            this.panel_OutputUnsatNodes_Graph.SuspendLayout();
            this.panel_OutputUnsatNodes_GraphOptions.SuspendLayout();
            this.tabPage_UnsatNodes_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputUnsatNodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputUnsatNodes)).BeginInit();
            this.bindingNavigator_OutputUnsatNodes.SuspendLayout();
            this.panel_OutputUnsatElements.SuspendLayout();
            this.tabControl_OutputUnsatElements.SuspendLayout();
            this.tabPage_UnsatElements_Graph.SuspendLayout();
            this.panel_OutputUnsatElements_Graph.SuspendLayout();
            this.panel_OutputUnsatElements_GraphOptions.SuspendLayout();
            this.tabPage_UnsatElements_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputUnsatElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputUnsatElements)).BeginInit();
            this.bindingNavigator_OutputUnsatElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1054, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_FileName,
            this.toolStripStatusLabel_CalculationStatus,
            this.toolStripProgressBar_Calculating});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1054, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_FileName
            // 
            this.toolStripStatusLabel_FileName.Name = "toolStripStatusLabel_FileName";
            this.toolStripStatusLabel_FileName.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_CalculationStatus
            // 
            this.toolStripStatusLabel_CalculationStatus.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel_CalculationStatus.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel_CalculationStatus.Name = "toolStripStatusLabel_CalculationStatus";
            this.toolStripStatusLabel_CalculationStatus.Size = new System.Drawing.Size(127, 17);
            this.toolStripStatusLabel_CalculationStatus.Text = "Calculation not started";
            // 
            // toolStripProgressBar_Calculating
            // 
            this.toolStripProgressBar_Calculating.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar_Calculating.Name = "toolStripProgressBar_Calculating";
            this.toolStripProgressBar_Calculating.Size = new System.Drawing.Size(100, 16);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // toolStrip_Main
            // 
            this.toolStrip_Main.AllowMerge = false;
            this.toolStrip_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStrip_Main.CanOverflow = false;
            this.toolStrip_Main.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Main_New,
            this.toolStripButton_Main_Openfile,
            this.toolStripButton_Main_Save,
            this.toolStripButton_Main_Saveas,
            this.toolStripSeparator1,
            this.toolStripButton_Main_Calc});
            this.toolStrip_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip_Main.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_Main.Name = "toolStrip_Main";
            this.toolStrip_Main.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStrip_Main.Size = new System.Drawing.Size(1054, 47);
            this.toolStrip_Main.TabIndex = 4;
            this.toolStrip_Main.Text = "toolStrip1";
            // 
            // toolStripButton_Main_New
            // 
            this.toolStripButton_Main_New.AutoSize = false;
            this.toolStripButton_Main_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Main_New.Image = global::GUI15DSATUNSAT.Properties.Resources.NewFile_256x;
            this.toolStripButton_Main_New.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Main_New.Name = "toolStripButton_Main_New";
            this.toolStripButton_Main_New.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Main_New.Text = "New calculation";
            this.toolStripButton_Main_New.Click += new System.EventHandler(this.toolStripButton_Main_New_Click);
            // 
            // toolStripButton_Main_Openfile
            // 
            this.toolStripButton_Main_Openfile.AutoSize = false;
            this.toolStripButton_Main_Openfile.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton_Main_Openfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Main_Openfile.ForeColor = System.Drawing.Color.White;
            this.toolStripButton_Main_Openfile.Image = global::GUI15DSATUNSAT.Properties.Resources.OpenFolder_256x;
            this.toolStripButton_Main_Openfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Main_Openfile.Name = "toolStripButton_Main_Openfile";
            this.toolStripButton_Main_Openfile.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Main_Openfile.Text = "Open a new file and set working folder";
            this.toolStripButton_Main_Openfile.Click += new System.EventHandler(this.ToolStripButton_openfile_Click);
            // 
            // toolStripButton_Main_Save
            // 
            this.toolStripButton_Main_Save.AutoSize = false;
            this.toolStripButton_Main_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Main_Save.Image = global::GUI15DSATUNSAT.Properties.Resources.Save_256x;
            this.toolStripButton_Main_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Main_Save.Name = "toolStripButton_Main_Save";
            this.toolStripButton_Main_Save.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Main_Save.Text = "Save current project";
            this.toolStripButton_Main_Save.Click += new System.EventHandler(this.toolStripButton_Main_Save_Click);
            // 
            // toolStripButton_Main_Saveas
            // 
            this.toolStripButton_Main_Saveas.AutoSize = false;
            this.toolStripButton_Main_Saveas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Main_Saveas.Image = global::GUI15DSATUNSAT.Properties.Resources.SaveAs_256x;
            this.toolStripButton_Main_Saveas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Main_Saveas.Name = "toolStripButton_Main_Saveas";
            this.toolStripButton_Main_Saveas.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Main_Saveas.Text = "Save current project with different name";
            this.toolStripButton_Main_Saveas.Click += new System.EventHandler(this.toolStripButton_Main_Saveas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripSeparator1.Size = new System.Drawing.Size(15, 40);
            // 
            // toolStripButton_Main_Calc
            // 
            this.toolStripButton_Main_Calc.AutoSize = false;
            this.toolStripButton_Main_Calc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Main_Calc.Image = global::GUI15DSATUNSAT.Properties.Resources.Calculator_256x;
            this.toolStripButton_Main_Calc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Main_Calc.Name = "toolStripButton_Main_Calc";
            this.toolStripButton_Main_Calc.Size = new System.Drawing.Size(40, 40);
            this.toolStripButton_Main_Calc.Text = "Calculate";
            this.toolStripButton_Main_Calc.Click += new System.EventHandler(this.toolStripButton_Main_Calc_Click);
            // 
            // treeView_Main
            // 
            this.treeView_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.treeView_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_Main.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView_Main.Location = new System.Drawing.Point(0, 71);
            this.treeView_Main.Margin = new System.Windows.Forms.Padding(6);
            this.treeView_Main.Name = "treeView_Main";
            treeNode1.Name = "node_Parameters";
            treeNode1.Text = "Parameters";
            treeNode2.Name = "node_Materials";
            treeNode2.Text = "Materials";
            treeNode3.Name = "node_Layers";
            treeNode3.Text = "Layers";
            treeNode4.Name = "node_Mesh";
            treeNode4.Text = "Mesh";
            treeNode5.Name = "node_Input";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "INPUT ";
            treeNode6.Name = "node_Calculate";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "CALCULATE ";
            treeNode7.Name = "node_Constraints";
            treeNode7.Text = "Constraints";
            treeNode8.Name = "node_SatNodes";
            treeNode8.Text = "Sat nodes";
            treeNode9.Name = "node_SatElements";
            treeNode9.Text = "Sat elements";
            treeNode10.Name = "node_UnsatNodes";
            treeNode10.Text = "Unsat nodes";
            treeNode11.Name = "node_UnsatElements";
            treeNode11.Text = "Unsat elements";
            treeNode12.Name = "node_Output";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode12.Text = "OUTPUT ";
            this.treeView_Main.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode12});
            this.treeView_Main.Size = new System.Drawing.Size(200, 588);
            this.treeView_Main.TabIndex = 0;
            this.treeView_Main.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_Main_NodeMouseClick);
            // 
            // tab_Inputs
            // 
            this.tab_Inputs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tab_Inputs.Controls.Add(this.tab_Header);
            this.tab_Inputs.Controls.Add(this.tab_Parameters);
            this.tab_Inputs.Controls.Add(this.tab_Materials);
            this.tab_Inputs.Controls.Add(this.tab_Layers);
            this.tab_Inputs.Controls.Add(this.tab_Mesh);
            this.tab_Inputs.Controls.Add(this.tab_Boundaries);
            this.tab_Inputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Inputs.HotTrack = true;
            this.tab_Inputs.Location = new System.Drawing.Point(0, 0);
            this.tab_Inputs.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Inputs.MinimumSize = new System.Drawing.Size(610, 580);
            this.tab_Inputs.Name = "tab_Inputs";
            this.tab_Inputs.SelectedIndex = 0;
            this.tab_Inputs.Size = new System.Drawing.Size(610, 588);
            this.tab_Inputs.TabIndex = 2;
            // 
            // tab_Header
            // 
            this.tab_Header.Controls.Add(this.panel_Header);
            this.tab_Header.Location = new System.Drawing.Point(4, 28);
            this.tab_Header.Name = "tab_Header";
            this.tab_Header.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Header.Size = new System.Drawing.Size(602, 556);
            this.tab_Header.TabIndex = 5;
            this.tab_Header.Text = "Title";
            this.tab_Header.UseVisualStyleBackColor = true;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Header.Controls.Add(this.textBox_Header);
            this.panel_Header.Controls.Add(this.label_Title);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Header.Location = new System.Drawing.Point(3, 3);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(596, 550);
            this.panel_Header.TabIndex = 0;
            // 
            // textBox_Header
            // 
            this.textBox_Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Header.Location = new System.Drawing.Point(0, 16);
            this.textBox_Header.Multiline = true;
            this.textBox_Header.Name = "textBox_Header";
            this.textBox_Header.Size = new System.Drawing.Size(596, 534);
            this.textBox_Header.TabIndex = 1;
            this.textBox_Header.Text = "*********************************************\r\nCALCULATION EXAMPLE\r\n*************" +
    "********************************";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(250, 16);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "--- HEADER AND DESCRIPTION ---";
            // 
            // tab_Parameters
            // 
            this.tab_Parameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Parameters.Controls.Add(this.panel_Parameters);
            this.tab_Parameters.Location = new System.Drawing.Point(4, 25);
            this.tab_Parameters.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Parameters.Name = "tab_Parameters";
            this.tab_Parameters.Padding = new System.Windows.Forms.Padding(6);
            this.tab_Parameters.Size = new System.Drawing.Size(602, 555);
            this.tab_Parameters.TabIndex = 0;
            this.tab_Parameters.Text = "Parameters";
            // 
            // panel_Parameters
            // 
            this.panel_Parameters.AutoScroll = true;
            this.panel_Parameters.Controls.Add(this.groupBox_Parameters_Tolerances);
            this.panel_Parameters.Controls.Add(this.checkBox_Parameters_Erroronnode);
            this.panel_Parameters.Controls.Add(this.groupBox_Parameters_Timestepping);
            this.panel_Parameters.Controls.Add(this.groupBox_Paramaters_MatrixSparsity);
            this.panel_Parameters.Controls.Add(this.groupBox_Parameters_Solvers);
            this.panel_Parameters.Controls.Add(this.groupBox_Parameters_MatrixPreconditioners);
            this.panel_Parameters.Controls.Add(this.checkBox_Parameters_Masslump);
            this.panel_Parameters.Controls.Add(this.label_Patameters_Multksat);
            this.panel_Parameters.Controls.Add(this.textbox_Parameters_Multksal);
            this.panel_Parameters.Controls.Add(this.label_Parameters_Crelax);
            this.panel_Parameters.Controls.Add(this.textbox_Parameters_Crelax);
            this.panel_Parameters.Controls.Add(this.label_Parameters_Quadratureorder);
            this.panel_Parameters.Controls.Add(this.numericUpDown_Parameters_Quadratureorder);
            this.panel_Parameters.Controls.Add(this.trackbar_Parameters_Quadratureorder);
            this.panel_Parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Parameters.Location = new System.Drawing.Point(6, 6);
            this.panel_Parameters.Margin = new System.Windows.Forms.Padding(6);
            this.panel_Parameters.Name = "panel_Parameters";
            this.panel_Parameters.Size = new System.Drawing.Size(590, 543);
            this.panel_Parameters.TabIndex = 0;
            // 
            // groupBox_Parameters_Tolerances
            // 
            this.groupBox_Parameters_Tolerances.Controls.Add(this.label_Parameters_Epsh_tol);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.textbox_Parameters_Epsh_tol);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.label_Parameters_Epsth_tol);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.textbox_Parameters_Epsth_tol);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.label_Parameters_Maxhsatinc);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.textbox_Parameters_Maxhsatinc);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.label_Parameters_Epshsat_tol);
            this.groupBox_Parameters_Tolerances.Controls.Add(this.textbox_Parameters_Epshsat_tol);
            this.groupBox_Parameters_Tolerances.ForeColor = System.Drawing.Color.White;
            this.groupBox_Parameters_Tolerances.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Parameters_Tolerances.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Tolerances.Name = "groupBox_Parameters_Tolerances";
            this.groupBox_Parameters_Tolerances.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Tolerances.Size = new System.Drawing.Size(577, 74);
            this.groupBox_Parameters_Tolerances.TabIndex = 48;
            this.groupBox_Parameters_Tolerances.TabStop = false;
            this.groupBox_Parameters_Tolerances.Text = "Tolerances";
            // 
            // label_Parameters_Epsh_tol
            // 
            this.label_Parameters_Epsh_tol.AutoSize = true;
            this.label_Parameters_Epsh_tol.Location = new System.Drawing.Point(10, 20);
            this.label_Parameters_Epsh_tol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Epsh_tol.Name = "label_Parameters_Epsh_tol";
            this.label_Parameters_Epsh_tol.Size = new System.Drawing.Size(95, 16);
            this.label_Parameters_Epsh_tol.TabIndex = 1;
            this.label_Parameters_Epsh_tol.Text = "Pressure head";
            // 
            // textbox_Parameters_Epsh_tol
            // 
            this.textbox_Parameters_Epsh_tol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_Parameters_Epsh_tol.Location = new System.Drawing.Point(20, 40);
            this.textbox_Parameters_Epsh_tol.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Epsh_tol.Name = "textbox_Parameters_Epsh_tol";
            this.textbox_Parameters_Epsh_tol.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Epsh_tol.TabIndex = 0;
            this.textbox_Parameters_Epsh_tol.Text = "1.0E-3";
            this.textbox_Parameters_Epsh_tol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Epsh_tol.WordWrap = false;
            this.textbox_Parameters_Epsh_tol.Enter += new System.EventHandler(this.textbox_SetHelp);
            // 
            // label_Parameters_Epsth_tol
            // 
            this.label_Parameters_Epsth_tol.AutoSize = true;
            this.label_Parameters_Epsth_tol.Location = new System.Drawing.Point(115, 20);
            this.label_Parameters_Epsth_tol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Epsth_tol.Name = "label_Parameters_Epsth_tol";
            this.label_Parameters_Epsth_tol.Size = new System.Drawing.Size(151, 16);
            this.label_Parameters_Epsth_tol.TabIndex = 3;
            this.label_Parameters_Epsth_tol.Text = "Volumetric water content";
            // 
            // textbox_Parameters_Epsth_tol
            // 
            this.textbox_Parameters_Epsth_tol.Location = new System.Drawing.Point(152, 40);
            this.textbox_Parameters_Epsth_tol.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Epsth_tol.Name = "textbox_Parameters_Epsth_tol";
            this.textbox_Parameters_Epsth_tol.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Epsth_tol.TabIndex = 2;
            this.textbox_Parameters_Epsth_tol.Text = "1.0E-3";
            this.textbox_Parameters_Epsth_tol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Epsth_tol.WordWrap = false;
            this.textbox_Parameters_Epsth_tol.Enter += new System.EventHandler(this.textbox_SetHelp);
            // 
            // label_Parameters_Maxhsatinc
            // 
            this.label_Parameters_Maxhsatinc.AutoSize = true;
            this.label_Parameters_Maxhsatinc.Location = new System.Drawing.Point(404, 20);
            this.label_Parameters_Maxhsatinc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Maxhsatinc.Name = "label_Parameters_Maxhsatinc";
            this.label_Parameters_Maxhsatinc.Size = new System.Drawing.Size(171, 16);
            this.label_Parameters_Maxhsatinc.TabIndex = 7;
            this.label_Parameters_Maxhsatinc.Text = "Max increment in watertable";
            // 
            // textbox_Parameters_Maxhsatinc
            // 
            this.textbox_Parameters_Maxhsatinc.Location = new System.Drawing.Point(452, 40);
            this.textbox_Parameters_Maxhsatinc.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Maxhsatinc.Name = "textbox_Parameters_Maxhsatinc";
            this.textbox_Parameters_Maxhsatinc.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Maxhsatinc.TabIndex = 6;
            this.textbox_Parameters_Maxhsatinc.Text = "0.01";
            this.textbox_Parameters_Maxhsatinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Maxhsatinc.WordWrap = false;
            // 
            // label_Parameters_Epshsat_tol
            // 
            this.label_Parameters_Epshsat_tol.AutoSize = true;
            this.label_Parameters_Epshsat_tol.Location = new System.Drawing.Point(275, 20);
            this.label_Parameters_Epshsat_tol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Epshsat_tol.Name = "label_Parameters_Epshsat_tol";
            this.label_Parameters_Epshsat_tol.Size = new System.Drawing.Size(122, 16);
            this.label_Parameters_Epshsat_tol.TabIndex = 5;
            this.label_Parameters_Epshsat_tol.Text = "Water table in layer";
            // 
            // textbox_Parameters_Epshsat_tol
            // 
            this.textbox_Parameters_Epshsat_tol.Location = new System.Drawing.Point(297, 40);
            this.textbox_Parameters_Epshsat_tol.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Epshsat_tol.Name = "textbox_Parameters_Epshsat_tol";
            this.textbox_Parameters_Epshsat_tol.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Epshsat_tol.TabIndex = 4;
            this.textbox_Parameters_Epshsat_tol.Text = "1.0E-5";
            this.textbox_Parameters_Epshsat_tol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Epshsat_tol.WordWrap = false;
            // 
            // checkBox_Parameters_Erroronnode
            // 
            this.checkBox_Parameters_Erroronnode.AutoSize = true;
            this.checkBox_Parameters_Erroronnode.Location = new System.Drawing.Point(6, 81);
            this.checkBox_Parameters_Erroronnode.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_Parameters_Erroronnode.Name = "checkBox_Parameters_Erroronnode";
            this.checkBox_Parameters_Erroronnode.Size = new System.Drawing.Size(326, 20);
            this.checkBox_Parameters_Erroronnode.TabIndex = 57;
            this.checkBox_Parameters_Erroronnode.Text = "Error check on node (otherwise error over element)";
            this.checkBox_Parameters_Erroronnode.UseVisualStyleBackColor = true;
            // 
            // groupBox_Parameters_Timestepping
            // 
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Paramters_It_max);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_It_max);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Dtmax);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Dtmax);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Dtmin);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Dtmin);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Tmax);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Tmax);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Dtinit);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Dtinit);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Tinit);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Tinit);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Dtdec);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Dtdec);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_PrintInc);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_Dtinc);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textBox_Parameters_Tprintinc);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_Dtinc);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_iterations);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_It_dec_dt);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_It_dec_dt);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_It_inc_dt);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_It_inc_dt);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.label_Parameters_It_min);
            this.groupBox_Parameters_Timestepping.Controls.Add(this.textbox_Parameters_It_min);
            this.groupBox_Parameters_Timestepping.ForeColor = System.Drawing.Color.White;
            this.groupBox_Parameters_Timestepping.Location = new System.Drawing.Point(6, 98);
            this.groupBox_Parameters_Timestepping.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Timestepping.Name = "groupBox_Parameters_Timestepping";
            this.groupBox_Parameters_Timestepping.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Timestepping.Size = new System.Drawing.Size(577, 269);
            this.groupBox_Parameters_Timestepping.TabIndex = 50;
            this.groupBox_Parameters_Timestepping.TabStop = false;
            this.groupBox_Parameters_Timestepping.Text = "Timestepping";
            // 
            // label_Paramters_It_max
            // 
            this.label_Paramters_It_max.AutoSize = true;
            this.label_Paramters_It_max.Location = new System.Drawing.Point(6, 136);
            this.label_Paramters_It_max.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Paramters_It_max.Name = "label_Paramters_It_max";
            this.label_Paramters_It_max.Size = new System.Drawing.Size(305, 16);
            this.label_Paramters_It_max.TabIndex = 29;
            this.label_Paramters_It_max.Text = "Timestep restarted when iterations are higher than:";
            // 
            // textbox_Parameters_It_max
            // 
            this.textbox_Parameters_It_max.Location = new System.Drawing.Point(328, 130);
            this.textbox_Parameters_It_max.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_It_max.Name = "textbox_Parameters_It_max";
            this.textbox_Parameters_It_max.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_It_max.TabIndex = 28;
            this.textbox_Parameters_It_max.Text = "50";
            this.textbox_Parameters_It_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_It_max.WordWrap = false;
            // 
            // label_Parameters_Dtmax
            // 
            this.label_Parameters_Dtmax.AutoSize = true;
            this.label_Parameters_Dtmax.Location = new System.Drawing.Point(349, 209);
            this.label_Parameters_Dtmax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Dtmax.Name = "label_Parameters_Dtmax";
            this.label_Parameters_Dtmax.Size = new System.Drawing.Size(89, 16);
            this.label_Parameters_Dtmax.TabIndex = 27;
            this.label_Parameters_Dtmax.Text = "Max timestep:";
            // 
            // textbox_Parameters_Dtmax
            // 
            this.textbox_Parameters_Dtmax.Location = new System.Drawing.Point(444, 206);
            this.textbox_Parameters_Dtmax.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Dtmax.Name = "textbox_Parameters_Dtmax";
            this.textbox_Parameters_Dtmax.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Dtmax.TabIndex = 26;
            this.textbox_Parameters_Dtmax.Text = "100";
            this.textbox_Parameters_Dtmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Dtmax.WordWrap = false;
            // 
            // label_Parameters_Dtmin
            // 
            this.label_Parameters_Dtmin.AutoSize = true;
            this.label_Parameters_Dtmin.Location = new System.Drawing.Point(349, 180);
            this.label_Parameters_Dtmin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Dtmin.Name = "label_Parameters_Dtmin";
            this.label_Parameters_Dtmin.Size = new System.Drawing.Size(85, 16);
            this.label_Parameters_Dtmin.TabIndex = 25;
            this.label_Parameters_Dtmin.Text = "Min timestep:";
            // 
            // textbox_Parameters_Dtmin
            // 
            this.textbox_Parameters_Dtmin.Location = new System.Drawing.Point(444, 177);
            this.textbox_Parameters_Dtmin.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Dtmin.Name = "textbox_Parameters_Dtmin";
            this.textbox_Parameters_Dtmin.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Dtmin.TabIndex = 24;
            this.textbox_Parameters_Dtmin.Text = "1E-10";
            this.textbox_Parameters_Dtmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Dtmin.WordWrap = false;
            // 
            // label_Parameters_Tmax
            // 
            this.label_Parameters_Tmax.AutoSize = true;
            this.label_Parameters_Tmax.Location = new System.Drawing.Point(9, 209);
            this.label_Parameters_Tmax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Tmax.Name = "label_Parameters_Tmax";
            this.label_Parameters_Tmax.Size = new System.Drawing.Size(62, 16);
            this.label_Parameters_Tmax.TabIndex = 23;
            this.label_Parameters_Tmax.Text = "End time:";
            // 
            // textbox_Parameters_Tmax
            // 
            this.textbox_Parameters_Tmax.Location = new System.Drawing.Point(83, 206);
            this.textbox_Parameters_Tmax.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Tmax.Name = "textbox_Parameters_Tmax";
            this.textbox_Parameters_Tmax.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Tmax.TabIndex = 22;
            this.textbox_Parameters_Tmax.Text = "21600";
            this.textbox_Parameters_Tmax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Tmax.WordWrap = false;
            // 
            // label_Parameters_Dtinit
            // 
            this.label_Parameters_Dtinit.AutoSize = true;
            this.label_Parameters_Dtinit.Location = new System.Drawing.Point(170, 180);
            this.label_Parameters_Dtinit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Dtinit.Name = "label_Parameters_Dtinit";
            this.label_Parameters_Dtinit.Size = new System.Drawing.Size(94, 16);
            this.label_Parameters_Dtinit.TabIndex = 21;
            this.label_Parameters_Dtinit.Text = "Initial timestep:";
            // 
            // textbox_Parameters_Dtinit
            // 
            this.textbox_Parameters_Dtinit.Location = new System.Drawing.Point(262, 177);
            this.textbox_Parameters_Dtinit.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Dtinit.Name = "textbox_Parameters_Dtinit";
            this.textbox_Parameters_Dtinit.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Dtinit.TabIndex = 20;
            this.textbox_Parameters_Dtinit.Text = "1E-3";
            this.textbox_Parameters_Dtinit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Dtinit.WordWrap = false;
            // 
            // label_Parameters_Tinit
            // 
            this.label_Parameters_Tinit.AutoSize = true;
            this.label_Parameters_Tinit.Location = new System.Drawing.Point(9, 180);
            this.label_Parameters_Tinit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Tinit.Name = "label_Parameters_Tinit";
            this.label_Parameters_Tinit.Size = new System.Drawing.Size(68, 16);
            this.label_Parameters_Tinit.TabIndex = 19;
            this.label_Parameters_Tinit.Text = "Initial time:";
            // 
            // textbox_Parameters_Tinit
            // 
            this.textbox_Parameters_Tinit.Location = new System.Drawing.Point(83, 177);
            this.textbox_Parameters_Tinit.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Tinit.Name = "textbox_Parameters_Tinit";
            this.textbox_Parameters_Tinit.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Tinit.TabIndex = 18;
            this.textbox_Parameters_Tinit.Text = "0.0";
            this.textbox_Parameters_Tinit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Tinit.WordWrap = false;
            // 
            // label_Parameters_Dtdec
            // 
            this.label_Parameters_Dtdec.AutoSize = true;
            this.label_Parameters_Dtdec.Location = new System.Drawing.Point(388, 106);
            this.label_Parameters_Dtdec.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Dtdec.Name = "label_Parameters_Dtdec";
            this.label_Parameters_Dtdec.Size = new System.Drawing.Size(107, 16);
            this.label_Parameters_Dtdec.TabIndex = 17;
            this.label_Parameters_Dtdec.Text = "Time change by:";
            // 
            // textbox_Parameters_Dtdec
            // 
            this.textbox_Parameters_Dtdec.Location = new System.Drawing.Point(507, 100);
            this.textbox_Parameters_Dtdec.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Dtdec.Name = "textbox_Parameters_Dtdec";
            this.textbox_Parameters_Dtdec.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_Dtdec.TabIndex = 16;
            this.textbox_Parameters_Dtdec.Text = "0.8";
            this.textbox_Parameters_Dtdec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Dtdec.WordWrap = false;
            // 
            // label_Parameters_PrintInc
            // 
            this.label_Parameters_PrintInc.AutoSize = true;
            this.label_Parameters_PrintInc.Location = new System.Drawing.Point(9, 238);
            this.label_Parameters_PrintInc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_PrintInc.Name = "label_Parameters_PrintInc";
            this.label_Parameters_PrintInc.Size = new System.Drawing.Size(230, 16);
            this.label_Parameters_PrintInc.TabIndex = 64;
            this.label_Parameters_PrintInc.Text = "Save results at given time increments:";
            // 
            // label_Parameters_Dtinc
            // 
            this.label_Parameters_Dtinc.AutoSize = true;
            this.label_Parameters_Dtinc.Location = new System.Drawing.Point(388, 75);
            this.label_Parameters_Dtinc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Dtinc.Name = "label_Parameters_Dtinc";
            this.label_Parameters_Dtinc.Size = new System.Drawing.Size(107, 16);
            this.label_Parameters_Dtinc.TabIndex = 15;
            this.label_Parameters_Dtinc.Text = "Time change by:";
            // 
            // textBox_Parameters_Tprintinc
            // 
            this.textBox_Parameters_Tprintinc.Location = new System.Drawing.Point(262, 235);
            this.textBox_Parameters_Tprintinc.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Parameters_Tprintinc.Name = "textBox_Parameters_Tprintinc";
            this.textBox_Parameters_Tprintinc.Size = new System.Drawing.Size(75, 22);
            this.textBox_Parameters_Tprintinc.TabIndex = 63;
            this.textBox_Parameters_Tprintinc.Text = "1.0";
            this.textBox_Parameters_Tprintinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Parameters_Tprintinc.WordWrap = false;
            // 
            // textbox_Parameters_Dtinc
            // 
            this.textbox_Parameters_Dtinc.Location = new System.Drawing.Point(507, 69);
            this.textbox_Parameters_Dtinc.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Dtinc.Name = "textbox_Parameters_Dtinc";
            this.textbox_Parameters_Dtinc.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_Dtinc.TabIndex = 14;
            this.textbox_Parameters_Dtinc.Text = "1.2";
            this.textbox_Parameters_Dtinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Dtinc.WordWrap = false;
            // 
            // label_iterations
            // 
            this.label_iterations.AutoSize = true;
            this.label_iterations.Location = new System.Drawing.Point(325, 16);
            this.label_iterations.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_iterations.Name = "label_iterations";
            this.label_iterations.Size = new System.Drawing.Size(61, 16);
            this.label_iterations.TabIndex = 13;
            this.label_iterations.Text = "iterations";
            // 
            // label_Parameters_It_dec_dt
            // 
            this.label_Parameters_It_dec_dt.AutoSize = true;
            this.label_Parameters_It_dec_dt.Location = new System.Drawing.Point(4, 106);
            this.label_Parameters_It_dec_dt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_It_dec_dt.Name = "label_Parameters_It_dec_dt";
            this.label_Parameters_It_dec_dt.Size = new System.Drawing.Size(318, 16);
            this.label_Parameters_It_dec_dt.TabIndex = 12;
            this.label_Parameters_It_dec_dt.Text = "Timestep decreased when iterations are higher than:";
            // 
            // textbox_Parameters_It_dec_dt
            // 
            this.textbox_Parameters_It_dec_dt.Location = new System.Drawing.Point(328, 100);
            this.textbox_Parameters_It_dec_dt.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_It_dec_dt.Name = "textbox_Parameters_It_dec_dt";
            this.textbox_Parameters_It_dec_dt.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_It_dec_dt.TabIndex = 11;
            this.textbox_Parameters_It_dec_dt.Text = "7";
            this.textbox_Parameters_It_dec_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_It_dec_dt.WordWrap = false;
            // 
            // label_Parameters_It_inc_dt
            // 
            this.label_Parameters_It_inc_dt.AutoSize = true;
            this.label_Parameters_It_inc_dt.Location = new System.Drawing.Point(4, 75);
            this.label_Parameters_It_inc_dt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_It_inc_dt.Name = "label_Parameters_It_inc_dt";
            this.label_Parameters_It_inc_dt.Size = new System.Drawing.Size(307, 16);
            this.label_Parameters_It_inc_dt.TabIndex = 9;
            this.label_Parameters_It_inc_dt.Text = "Timestep increased when iterations are lower than:";
            // 
            // textbox_Parameters_It_inc_dt
            // 
            this.textbox_Parameters_It_inc_dt.Location = new System.Drawing.Point(328, 69);
            this.textbox_Parameters_It_inc_dt.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_It_inc_dt.Name = "textbox_Parameters_It_inc_dt";
            this.textbox_Parameters_It_inc_dt.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_It_inc_dt.TabIndex = 10;
            this.textbox_Parameters_It_inc_dt.Text = "3";
            this.textbox_Parameters_It_inc_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_It_inc_dt.WordWrap = false;
            // 
            // label_Parameters_It_min
            // 
            this.label_Parameters_It_min.AutoSize = true;
            this.label_Parameters_It_min.Location = new System.Drawing.Point(4, 44);
            this.label_Parameters_It_min.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_It_min.Name = "label_Parameters_It_min";
            this.label_Parameters_It_min.Size = new System.Drawing.Size(259, 16);
            this.label_Parameters_It_min.TabIndex = 7;
            this.label_Parameters_It_min.Text = "Minimum number of iterations per timestep:";
            // 
            // textbox_Parameters_It_min
            // 
            this.textbox_Parameters_It_min.Location = new System.Drawing.Point(328, 38);
            this.textbox_Parameters_It_min.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_It_min.Name = "textbox_Parameters_It_min";
            this.textbox_Parameters_It_min.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_It_min.TabIndex = 8;
            this.textbox_Parameters_It_min.Text = "1";
            this.textbox_Parameters_It_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_It_min.WordWrap = false;
            // 
            // groupBox_Paramaters_MatrixSparsity
            // 
            this.groupBox_Paramaters_MatrixSparsity.Controls.Add(this.radiobutton_Parameters_Typematrixstorage_Banded);
            this.groupBox_Paramaters_MatrixSparsity.Controls.Add(this.radiobutton_Parameters_Typematrixstorage_CSR);
            this.groupBox_Paramaters_MatrixSparsity.Controls.Add(this.radiobutton_Parameters_Typematrixstorage_Dense);
            this.groupBox_Paramaters_MatrixSparsity.ForeColor = System.Drawing.Color.White;
            this.groupBox_Paramaters_MatrixSparsity.Location = new System.Drawing.Point(6, 365);
            this.groupBox_Paramaters_MatrixSparsity.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Paramaters_MatrixSparsity.Name = "groupBox_Paramaters_MatrixSparsity";
            this.groupBox_Paramaters_MatrixSparsity.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Paramaters_MatrixSparsity.Size = new System.Drawing.Size(137, 95);
            this.groupBox_Paramaters_MatrixSparsity.TabIndex = 51;
            this.groupBox_Paramaters_MatrixSparsity.TabStop = false;
            this.groupBox_Paramaters_MatrixSparsity.Text = "Matrix sparsity";
            // 
            // radiobutton_Parameters_Typematrixstorage_Banded
            // 
            this.radiobutton_Parameters_Typematrixstorage_Banded.AutoSize = true;
            this.radiobutton_Parameters_Typematrixstorage_Banded.Location = new System.Drawing.Point(10, 64);
            this.radiobutton_Parameters_Typematrixstorage_Banded.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Typematrixstorage_Banded.Name = "radiobutton_Parameters_Typematrixstorage_Banded";
            this.radiobutton_Parameters_Typematrixstorage_Banded.Size = new System.Drawing.Size(119, 20);
            this.radiobutton_Parameters_Typematrixstorage_Banded.TabIndex = 17;
            this.radiobutton_Parameters_Typematrixstorage_Banded.TabStop = true;
            this.radiobutton_Parameters_Typematrixstorage_Banded.Text = "Sparse banded";
            this.radiobutton_Parameters_Typematrixstorage_Banded.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Typematrixstorage_Banded.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Typematrixstorage);
            // 
            // radiobutton_Parameters_Typematrixstorage_CSR
            // 
            this.radiobutton_Parameters_Typematrixstorage_CSR.AutoSize = true;
            this.radiobutton_Parameters_Typematrixstorage_CSR.Location = new System.Drawing.Point(10, 41);
            this.radiobutton_Parameters_Typematrixstorage_CSR.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Typematrixstorage_CSR.Name = "radiobutton_Parameters_Typematrixstorage_CSR";
            this.radiobutton_Parameters_Typematrixstorage_CSR.Size = new System.Drawing.Size(100, 20);
            this.radiobutton_Parameters_Typematrixstorage_CSR.TabIndex = 16;
            this.radiobutton_Parameters_Typematrixstorage_CSR.TabStop = true;
            this.radiobutton_Parameters_Typematrixstorage_CSR.Text = "Sparse CSR";
            this.radiobutton_Parameters_Typematrixstorage_CSR.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Typematrixstorage_CSR.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Typematrixstorage);
            // 
            // radiobutton_Parameters_Typematrixstorage_Dense
            // 
            this.radiobutton_Parameters_Typematrixstorage_Dense.AutoSize = true;
            this.radiobutton_Parameters_Typematrixstorage_Dense.Checked = true;
            this.radiobutton_Parameters_Typematrixstorage_Dense.Location = new System.Drawing.Point(10, 19);
            this.radiobutton_Parameters_Typematrixstorage_Dense.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Typematrixstorage_Dense.Name = "radiobutton_Parameters_Typematrixstorage_Dense";
            this.radiobutton_Parameters_Typematrixstorage_Dense.Size = new System.Drawing.Size(65, 20);
            this.radiobutton_Parameters_Typematrixstorage_Dense.TabIndex = 15;
            this.radiobutton_Parameters_Typematrixstorage_Dense.TabStop = true;
            this.radiobutton_Parameters_Typematrixstorage_Dense.Text = "Dense";
            this.radiobutton_Parameters_Typematrixstorage_Dense.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Typematrixstorage_Dense.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Typematrixstorage);
            // 
            // groupBox_Parameters_Solvers
            // 
            this.groupBox_Parameters_Solvers.Controls.Add(this.radiobutton_Parameters_Solver_FMGRES);
            this.groupBox_Parameters_Solvers.Controls.Add(this.radiobutton_Parameters_Solver_Paradiso);
            this.groupBox_Parameters_Solvers.Controls.Add(this.radiobutton_Parameters_Solver_IntelDSS);
            this.groupBox_Parameters_Solvers.Controls.Add(this.radiobutton_Parameters_Solver_Direct);
            this.groupBox_Parameters_Solvers.ForeColor = System.Drawing.Color.White;
            this.groupBox_Parameters_Solvers.Location = new System.Drawing.Point(160, 365);
            this.groupBox_Parameters_Solvers.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Solvers.Name = "groupBox_Parameters_Solvers";
            this.groupBox_Parameters_Solvers.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_Solvers.Size = new System.Drawing.Size(282, 117);
            this.groupBox_Parameters_Solvers.TabIndex = 52;
            this.groupBox_Parameters_Solvers.TabStop = false;
            this.groupBox_Parameters_Solvers.Text = "Solvers";
            // 
            // radiobutton_Parameters_Solver_FMGRES
            // 
            this.radiobutton_Parameters_Solver_FMGRES.AutoSize = true;
            this.radiobutton_Parameters_Solver_FMGRES.Enabled = false;
            this.radiobutton_Parameters_Solver_FMGRES.Location = new System.Drawing.Point(12, 87);
            this.radiobutton_Parameters_Solver_FMGRES.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Solver_FMGRES.Name = "radiobutton_Parameters_Solver_FMGRES";
            this.radiobutton_Parameters_Solver_FMGRES.Size = new System.Drawing.Size(182, 20);
            this.radiobutton_Parameters_Solver_FMGRES.TabIndex = 18;
            this.radiobutton_Parameters_Solver_FMGRES.Text = "Iterative Solver (FMGRES)";
            this.radiobutton_Parameters_Solver_FMGRES.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Solver_FMGRES.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Solver);
            // 
            // radiobutton_Parameters_Solver_Paradiso
            // 
            this.radiobutton_Parameters_Solver_Paradiso.AutoSize = true;
            this.radiobutton_Parameters_Solver_Paradiso.Enabled = false;
            this.radiobutton_Parameters_Solver_Paradiso.Location = new System.Drawing.Point(12, 64);
            this.radiobutton_Parameters_Solver_Paradiso.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Solver_Paradiso.Name = "radiobutton_Parameters_Solver_Paradiso";
            this.radiobutton_Parameters_Solver_Paradiso.Size = new System.Drawing.Size(242, 20);
            this.radiobutton_Parameters_Solver_Paradiso.TabIndex = 17;
            this.radiobutton_Parameters_Solver_Paradiso.Text = "Direct Sparse Solver (Intel Paradiso)";
            this.radiobutton_Parameters_Solver_Paradiso.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Solver_Paradiso.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Solver);
            // 
            // radiobutton_Parameters_Solver_IntelDSS
            // 
            this.radiobutton_Parameters_Solver_IntelDSS.AutoSize = true;
            this.radiobutton_Parameters_Solver_IntelDSS.Enabled = false;
            this.radiobutton_Parameters_Solver_IntelDSS.Location = new System.Drawing.Point(12, 41);
            this.radiobutton_Parameters_Solver_IntelDSS.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Solver_IntelDSS.Name = "radiobutton_Parameters_Solver_IntelDSS";
            this.radiobutton_Parameters_Solver_IntelDSS.Size = new System.Drawing.Size(215, 20);
            this.radiobutton_Parameters_Solver_IntelDSS.TabIndex = 16;
            this.radiobutton_Parameters_Solver_IntelDSS.Text = "Direct Sparse Solver (Intel DSS)";
            this.radiobutton_Parameters_Solver_IntelDSS.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Solver_IntelDSS.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Solver);
            // 
            // radiobutton_Parameters_Solver_Direct
            // 
            this.radiobutton_Parameters_Solver_Direct.AutoSize = true;
            this.radiobutton_Parameters_Solver_Direct.Checked = true;
            this.radiobutton_Parameters_Solver_Direct.Location = new System.Drawing.Point(12, 19);
            this.radiobutton_Parameters_Solver_Direct.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Solver_Direct.Name = "radiobutton_Parameters_Solver_Direct";
            this.radiobutton_Parameters_Solver_Direct.Size = new System.Drawing.Size(267, 20);
            this.radiobutton_Parameters_Solver_Direct.TabIndex = 15;
            this.radiobutton_Parameters_Solver_Direct.TabStop = true;
            this.radiobutton_Parameters_Solver_Direct.Text = "Direct Dense Solver (LU Decomposition)";
            this.radiobutton_Parameters_Solver_Direct.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Solver_Direct.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Solver);
            // 
            // groupBox_Parameters_MatrixPreconditioners
            // 
            this.groupBox_Parameters_MatrixPreconditioners.Controls.Add(this.radiobutton_Parameters_Preconditioner_ILUT);
            this.groupBox_Parameters_MatrixPreconditioners.Controls.Add(this.radiobutton_Parameters_Preconditioner_ILU0);
            this.groupBox_Parameters_MatrixPreconditioners.Controls.Add(this.radiobutton_Parameters_Preconditioner_Jacobi);
            this.groupBox_Parameters_MatrixPreconditioners.Controls.Add(this.radiobutton_Parameters_Preconditioner_None);
            this.groupBox_Parameters_MatrixPreconditioners.ForeColor = System.Drawing.Color.White;
            this.groupBox_Parameters_MatrixPreconditioners.Location = new System.Drawing.Point(460, 365);
            this.groupBox_Parameters_MatrixPreconditioners.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_MatrixPreconditioners.Name = "groupBox_Parameters_MatrixPreconditioners";
            this.groupBox_Parameters_MatrixPreconditioners.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_Parameters_MatrixPreconditioners.Size = new System.Drawing.Size(123, 117);
            this.groupBox_Parameters_MatrixPreconditioners.TabIndex = 53;
            this.groupBox_Parameters_MatrixPreconditioners.TabStop = false;
            this.groupBox_Parameters_MatrixPreconditioners.Text = "Preconditioners";
            // 
            // radiobutton_Parameters_Preconditioner_ILUT
            // 
            this.radiobutton_Parameters_Preconditioner_ILUT.AutoSize = true;
            this.radiobutton_Parameters_Preconditioner_ILUT.Enabled = false;
            this.radiobutton_Parameters_Preconditioner_ILUT.Location = new System.Drawing.Point(14, 87);
            this.radiobutton_Parameters_Preconditioner_ILUT.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Preconditioner_ILUT.Name = "radiobutton_Parameters_Preconditioner_ILUT";
            this.radiobutton_Parameters_Preconditioner_ILUT.Size = new System.Drawing.Size(54, 20);
            this.radiobutton_Parameters_Preconditioner_ILUT.TabIndex = 18;
            this.radiobutton_Parameters_Preconditioner_ILUT.Text = "ILUT";
            this.radiobutton_Parameters_Preconditioner_ILUT.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Preconditioner_ILUT.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Preconditioner);
            // 
            // radiobutton_Parameters_Preconditioner_ILU0
            // 
            this.radiobutton_Parameters_Preconditioner_ILU0.AutoSize = true;
            this.radiobutton_Parameters_Preconditioner_ILU0.Enabled = false;
            this.radiobutton_Parameters_Preconditioner_ILU0.Location = new System.Drawing.Point(14, 64);
            this.radiobutton_Parameters_Preconditioner_ILU0.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Preconditioner_ILU0.Name = "radiobutton_Parameters_Preconditioner_ILU0";
            this.radiobutton_Parameters_Preconditioner_ILU0.Size = new System.Drawing.Size(52, 20);
            this.radiobutton_Parameters_Preconditioner_ILU0.TabIndex = 17;
            this.radiobutton_Parameters_Preconditioner_ILU0.Text = "ILU0";
            this.radiobutton_Parameters_Preconditioner_ILU0.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Preconditioner_ILU0.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Preconditioner);
            // 
            // radiobutton_Parameters_Preconditioner_Jacobi
            // 
            this.radiobutton_Parameters_Preconditioner_Jacobi.AutoSize = true;
            this.radiobutton_Parameters_Preconditioner_Jacobi.Location = new System.Drawing.Point(14, 41);
            this.radiobutton_Parameters_Preconditioner_Jacobi.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Preconditioner_Jacobi.Name = "radiobutton_Parameters_Preconditioner_Jacobi";
            this.radiobutton_Parameters_Preconditioner_Jacobi.Size = new System.Drawing.Size(66, 20);
            this.radiobutton_Parameters_Preconditioner_Jacobi.TabIndex = 16;
            this.radiobutton_Parameters_Preconditioner_Jacobi.TabStop = true;
            this.radiobutton_Parameters_Preconditioner_Jacobi.Text = "Jacobi";
            this.radiobutton_Parameters_Preconditioner_Jacobi.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Preconditioner_Jacobi.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Preconditioner);
            // 
            // radiobutton_Parameters_Preconditioner_None
            // 
            this.radiobutton_Parameters_Preconditioner_None.AutoSize = true;
            this.radiobutton_Parameters_Preconditioner_None.Checked = true;
            this.radiobutton_Parameters_Preconditioner_None.Location = new System.Drawing.Point(14, 19);
            this.radiobutton_Parameters_Preconditioner_None.Margin = new System.Windows.Forms.Padding(6);
            this.radiobutton_Parameters_Preconditioner_None.Name = "radiobutton_Parameters_Preconditioner_None";
            this.radiobutton_Parameters_Preconditioner_None.Size = new System.Drawing.Size(58, 20);
            this.radiobutton_Parameters_Preconditioner_None.TabIndex = 15;
            this.radiobutton_Parameters_Preconditioner_None.TabStop = true;
            this.radiobutton_Parameters_Preconditioner_None.Text = "None";
            this.radiobutton_Parameters_Preconditioner_None.UseVisualStyleBackColor = true;
            this.radiobutton_Parameters_Preconditioner_None.CheckedChanged += new System.EventHandler(this.SetTypeSolution_Preconditioner);
            // 
            // checkBox_Parameters_Masslump
            // 
            this.checkBox_Parameters_Masslump.AutoSize = true;
            this.checkBox_Parameters_Masslump.Checked = true;
            this.checkBox_Parameters_Masslump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Parameters_Masslump.Location = new System.Drawing.Point(6, 462);
            this.checkBox_Parameters_Masslump.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_Parameters_Masslump.Name = "checkBox_Parameters_Masslump";
            this.checkBox_Parameters_Masslump.Size = new System.Drawing.Size(137, 20);
            this.checkBox_Parameters_Masslump.TabIndex = 56;
            this.checkBox_Parameters_Masslump.Text = "Use mass lumping";
            this.checkBox_Parameters_Masslump.UseVisualStyleBackColor = true;
            // 
            // label_Patameters_Multksat
            // 
            this.label_Patameters_Multksat.AutoSize = true;
            this.label_Patameters_Multksat.Location = new System.Drawing.Point(6, 515);
            this.label_Patameters_Multksat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Patameters_Multksat.Name = "label_Patameters_Multksat";
            this.label_Patameters_Multksat.Size = new System.Drawing.Size(230, 16);
            this.label_Patameters_Multksat.TabIndex = 55;
            this.label_Patameters_Multksat.Text = "Seepage surface multiplication factor:";
            // 
            // textbox_Parameters_Multksal
            // 
            this.textbox_Parameters_Multksal.Location = new System.Drawing.Point(256, 512);
            this.textbox_Parameters_Multksal.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Multksal.Name = "textbox_Parameters_Multksal";
            this.textbox_Parameters_Multksal.Size = new System.Drawing.Size(75, 22);
            this.textbox_Parameters_Multksal.TabIndex = 54;
            this.textbox_Parameters_Multksal.Text = "1.074";
            this.textbox_Parameters_Multksal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Multksal.WordWrap = false;
            // 
            // label_Parameters_Crelax
            // 
            this.label_Parameters_Crelax.AutoSize = true;
            this.label_Parameters_Crelax.Location = new System.Drawing.Point(349, 515);
            this.label_Parameters_Crelax.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Crelax.Name = "label_Parameters_Crelax";
            this.label_Parameters_Crelax.Size = new System.Drawing.Size(147, 16);
            this.label_Parameters_Crelax.TabIndex = 59;
            this.label_Parameters_Crelax.Text = "Coefficient of relaxation:";
            // 
            // textbox_Parameters_Crelax
            // 
            this.textbox_Parameters_Crelax.Location = new System.Drawing.Point(529, 512);
            this.textbox_Parameters_Crelax.Margin = new System.Windows.Forms.Padding(6);
            this.textbox_Parameters_Crelax.Name = "textbox_Parameters_Crelax";
            this.textbox_Parameters_Crelax.Size = new System.Drawing.Size(50, 22);
            this.textbox_Parameters_Crelax.TabIndex = 58;
            this.textbox_Parameters_Crelax.Text = "1.0";
            this.textbox_Parameters_Crelax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbox_Parameters_Crelax.WordWrap = false;
            // 
            // label_Parameters_Quadratureorder
            // 
            this.label_Parameters_Quadratureorder.AutoSize = true;
            this.label_Parameters_Quadratureorder.Location = new System.Drawing.Point(6, 488);
            this.label_Parameters_Quadratureorder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Parameters_Quadratureorder.Name = "label_Parameters_Quadratureorder";
            this.label_Parameters_Quadratureorder.Size = new System.Drawing.Size(246, 16);
            this.label_Parameters_Quadratureorder.TabIndex = 61;
            this.label_Parameters_Quadratureorder.Text = "Quadrature order for element integration:";
            // 
            // numericUpDown_Parameters_Quadratureorder
            // 
            this.numericUpDown_Parameters_Quadratureorder.Location = new System.Drawing.Point(256, 486);
            this.numericUpDown_Parameters_Quadratureorder.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown_Parameters_Quadratureorder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Parameters_Quadratureorder.Name = "numericUpDown_Parameters_Quadratureorder";
            this.numericUpDown_Parameters_Quadratureorder.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown_Parameters_Quadratureorder.TabIndex = 62;
            this.numericUpDown_Parameters_Quadratureorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Parameters_Quadratureorder.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // trackbar_Parameters_Quadratureorder
            // 
            this.trackbar_Parameters_Quadratureorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trackbar_Parameters_Quadratureorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackbar_Parameters_Quadratureorder.Location = new System.Drawing.Point(343, 486);
            this.trackbar_Parameters_Quadratureorder.Margin = new System.Windows.Forms.Padding(6);
            this.trackbar_Parameters_Quadratureorder.Maximum = 60;
            this.trackbar_Parameters_Quadratureorder.Minimum = 1;
            this.trackbar_Parameters_Quadratureorder.Name = "trackbar_Parameters_Quadratureorder";
            this.trackbar_Parameters_Quadratureorder.Size = new System.Drawing.Size(244, 45);
            this.trackbar_Parameters_Quadratureorder.TabIndex = 49;
            this.trackbar_Parameters_Quadratureorder.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackbar_Parameters_Quadratureorder.Value = 10;
            // 
            // tab_Materials
            // 
            this.tab_Materials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Materials.Controls.Add(this.datagridview_materials);
            this.tab_Materials.ForeColor = System.Drawing.Color.White;
            this.tab_Materials.Location = new System.Drawing.Point(4, 25);
            this.tab_Materials.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Materials.Name = "tab_Materials";
            this.tab_Materials.Padding = new System.Windows.Forms.Padding(6);
            this.tab_Materials.Size = new System.Drawing.Size(602, 555);
            this.tab_Materials.TabIndex = 1;
            this.tab_Materials.Text = "Materials";
            // 
            // datagridview_materials
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.datagridview_materials.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview_materials.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_materials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview_materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_materials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material_ID,
            this.material_Kindmat,
            this.material_Thsat,
            this.material_Thres,
            this.material_Alfa,
            this.material_N,
            this.material_M,
            this.maerial_Ksat,
            this.material_L});
            this.datagridview_materials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_materials.EnableHeadersVisualStyles = false;
            this.datagridview_materials.Location = new System.Drawing.Point(6, 6);
            this.datagridview_materials.Margin = new System.Windows.Forms.Padding(6);
            this.datagridview_materials.Name = "datagridview_materials";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_materials.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview_materials.RowHeadersWidth = 82;
            this.datagridview_materials.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datagridview_materials.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridview_materials.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridview_materials.Size = new System.Drawing.Size(590, 543);
            this.datagridview_materials.TabIndex = 1;
            // 
            // material_ID
            // 
            this.material_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_ID.DataPropertyName = "Id";
            this.material_ID.HeaderText = "ID";
            this.material_ID.MinimumWidth = 20;
            this.material_ID.Name = "material_ID";
            this.material_ID.ToolTipText = "Code number of material";
            this.material_ID.Width = 44;
            // 
            // material_Kindmat
            // 
            this.material_Kindmat.DataPropertyName = "kindmat";
            this.material_Kindmat.HeaderText = "Kindmat";
            this.material_Kindmat.Name = "material_Kindmat";
            this.material_Kindmat.Width = 60;
            // 
            // material_Thsat
            // 
            this.material_Thsat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_Thsat.DataPropertyName = "thsat";
            this.material_Thsat.HeaderText = "thsat";
            this.material_Thsat.MinimumWidth = 20;
            this.material_Thsat.Name = "material_Thsat";
            this.material_Thsat.ToolTipText = "Volumetric water content at saturation";
            this.material_Thsat.Width = 59;
            // 
            // material_Thres
            // 
            this.material_Thres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_Thres.DataPropertyName = "thres";
            this.material_Thres.HeaderText = "thres";
            this.material_Thres.MinimumWidth = 20;
            this.material_Thres.Name = "material_Thres";
            this.material_Thres.ToolTipText = "Irreducible volumetric water content";
            this.material_Thres.Width = 60;
            // 
            // material_Alfa
            // 
            this.material_Alfa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_Alfa.DataPropertyName = "a";
            this.material_Alfa.HeaderText = "alfa";
            this.material_Alfa.MinimumWidth = 20;
            this.material_Alfa.Name = "material_Alfa";
            this.material_Alfa.ToolTipText = "Van-Genuchten alfa parameter [L-1]";
            this.material_Alfa.Width = 53;
            // 
            // material_N
            // 
            this.material_N.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_N.DataPropertyName = "n";
            this.material_N.HeaderText = "n";
            this.material_N.MinimumWidth = 20;
            this.material_N.Name = "material_N";
            this.material_N.ToolTipText = "Van Genuchten n parameter";
            this.material_N.Width = 38;
            // 
            // material_M
            // 
            this.material_M.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_M.DataPropertyName = "m";
            this.material_M.HeaderText = "m";
            this.material_M.MinimumWidth = 20;
            this.material_M.Name = "material_M";
            this.material_M.ToolTipText = "Van Genuchten m parameter (1-1/n by default)";
            this.material_M.Width = 42;
            // 
            // maerial_Ksat
            // 
            this.maerial_Ksat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maerial_Ksat.DataPropertyName = "ksat";
            this.maerial_Ksat.HeaderText = "ksat";
            this.maerial_Ksat.MinimumWidth = 20;
            this.maerial_Ksat.Name = "maerial_Ksat";
            this.maerial_Ksat.ToolTipText = "Permeability coefficient [LT-1]";
            this.maerial_Ksat.Width = 56;
            // 
            // material_L
            // 
            this.material_L.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.material_L.DataPropertyName = "l";
            this.material_L.HeaderText = "l";
            this.material_L.MinimumWidth = 20;
            this.material_L.Name = "material_L";
            this.material_L.ToolTipText = "l exponential parameter of Mualem";
            this.material_L.Width = 34;
            // 
            // tab_Layers
            // 
            this.tab_Layers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Layers.Controls.Add(this.splitContainer2);
            this.tab_Layers.Location = new System.Drawing.Point(4, 25);
            this.tab_Layers.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Layers.Name = "tab_Layers";
            this.tab_Layers.Padding = new System.Windows.Forms.Padding(6);
            this.tab_Layers.Size = new System.Drawing.Size(602, 555);
            this.tab_Layers.TabIndex = 2;
            this.tab_Layers.Text = "Layers";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(6, 6);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.AutoScrollMinSize = new System.Drawing.Size(0, 60);
            this.splitContainer2.Panel1.Controls.Add(this.label_Layers_Width);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_Layers_Width);
            this.splitContainer2.Panel1.Controls.Add(this.label_Layers_Zphr);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_Layers_Zphr);
            this.splitContainer2.Panel1.Controls.Add(this.label_Layers_Slopebottom);
            this.splitContainer2.Panel1.Controls.Add(this.textBox_Layers_Slopebottom);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_TopBoundary);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox_BottomBoundary);
            this.splitContainer2.Panel1MinSize = 110;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView_Layers);
            this.splitContainer2.Size = new System.Drawing.Size(590, 543);
            this.splitContainer2.SplitterDistance = 110;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 1;
            // 
            // label_Layers_Width
            // 
            this.label_Layers_Width.AutoSize = true;
            this.label_Layers_Width.Location = new System.Drawing.Point(6, 14);
            this.label_Layers_Width.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Layers_Width.Name = "label_Layers_Width";
            this.label_Layers_Width.Size = new System.Drawing.Size(98, 16);
            this.label_Layers_Width.TabIndex = 1;
            this.label_Layers_Width.Text = "Width of layers:";
            // 
            // textBox_Layers_Width
            // 
            this.textBox_Layers_Width.Location = new System.Drawing.Point(151, 11);
            this.textBox_Layers_Width.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Layers_Width.Name = "textBox_Layers_Width";
            this.textBox_Layers_Width.Size = new System.Drawing.Size(75, 22);
            this.textBox_Layers_Width.TabIndex = 0;
            this.textBox_Layers_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Layers_Zphr
            // 
            this.label_Layers_Zphr.AutoSize = true;
            this.label_Layers_Zphr.Location = new System.Drawing.Point(6, 42);
            this.label_Layers_Zphr.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Layers_Zphr.Name = "label_Layers_Zphr";
            this.label_Layers_Zphr.Size = new System.Drawing.Size(143, 16);
            this.label_Layers_Zphr.TabIndex = 3;
            this.label_Layers_Zphr.Text = "Depht of phreatic level:";
            // 
            // textBox_Layers_Zphr
            // 
            this.textBox_Layers_Zphr.Location = new System.Drawing.Point(151, 39);
            this.textBox_Layers_Zphr.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Layers_Zphr.Name = "textBox_Layers_Zphr";
            this.textBox_Layers_Zphr.Size = new System.Drawing.Size(75, 22);
            this.textBox_Layers_Zphr.TabIndex = 1;
            this.textBox_Layers_Zphr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Layers_Slopebottom
            // 
            this.label_Layers_Slopebottom.AutoSize = true;
            this.label_Layers_Slopebottom.Location = new System.Drawing.Point(6, 72);
            this.label_Layers_Slopebottom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Layers_Slopebottom.Name = "label_Layers_Slopebottom";
            this.label_Layers_Slopebottom.Size = new System.Drawing.Size(104, 16);
            this.label_Layers_Slopebottom.TabIndex = 7;
            this.label_Layers_Slopebottom.Text = "Slope at bottom:";
            // 
            // textBox_Layers_Slopebottom
            // 
            this.textBox_Layers_Slopebottom.Enabled = false;
            this.textBox_Layers_Slopebottom.Location = new System.Drawing.Point(151, 69);
            this.textBox_Layers_Slopebottom.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Layers_Slopebottom.Name = "textBox_Layers_Slopebottom";
            this.textBox_Layers_Slopebottom.Size = new System.Drawing.Size(75, 22);
            this.textBox_Layers_Slopebottom.TabIndex = 2;
            this.textBox_Layers_Slopebottom.Text = "0";
            this.textBox_Layers_Slopebottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_TopBoundary
            // 
            this.groupBox_TopBoundary.Controls.Add(this.radioButton_Layers_Topboundbyh);
            this.groupBox_TopBoundary.Controls.Add(this.radioButton_Layers_Topboundbyq);
            this.groupBox_TopBoundary.ForeColor = System.Drawing.Color.White;
            this.groupBox_TopBoundary.Location = new System.Drawing.Point(238, 6);
            this.groupBox_TopBoundary.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_TopBoundary.Name = "groupBox_TopBoundary";
            this.groupBox_TopBoundary.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_TopBoundary.Size = new System.Drawing.Size(167, 92);
            this.groupBox_TopBoundary.TabIndex = 4;
            this.groupBox_TopBoundary.TabStop = false;
            this.groupBox_TopBoundary.Text = "Top Boundary";
            // 
            // radioButton_Layers_Topboundbyh
            // 
            this.radioButton_Layers_Topboundbyh.AutoSize = true;
            this.radioButton_Layers_Topboundbyh.Checked = true;
            this.radioButton_Layers_Topboundbyh.Location = new System.Drawing.Point(12, 27);
            this.radioButton_Layers_Topboundbyh.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Layers_Topboundbyh.Name = "radioButton_Layers_Topboundbyh";
            this.radioButton_Layers_Topboundbyh.Size = new System.Drawing.Size(149, 20);
            this.radioButton_Layers_Topboundbyh.TabIndex = 3;
            this.radioButton_Layers_Topboundbyh.TabStop = true;
            this.radioButton_Layers_Topboundbyh.Text = "By pressure head (h)";
            this.radioButton_Layers_Topboundbyh.UseVisualStyleBackColor = true;
            this.radioButton_Layers_Topboundbyh.CheckedChanged += new System.EventHandler(this.radioButton_Layers_Topboundbyh_CheckedChanged);
            // 
            // radioButton_Layers_Topboundbyq
            // 
            this.radioButton_Layers_Topboundbyq.AutoSize = true;
            this.radioButton_Layers_Topboundbyq.Location = new System.Drawing.Point(12, 59);
            this.radioButton_Layers_Topboundbyq.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Layers_Topboundbyq.Name = "radioButton_Layers_Topboundbyq";
            this.radioButton_Layers_Topboundbyq.Size = new System.Drawing.Size(96, 20);
            this.radioButton_Layers_Topboundbyq.TabIndex = 4;
            this.radioButton_Layers_Topboundbyq.Text = "By Inflow (q)";
            this.radioButton_Layers_Topboundbyq.UseVisualStyleBackColor = true;
            // 
            // groupBox_BottomBoundary
            // 
            this.groupBox_BottomBoundary.Controls.Add(this.radioButton_Layers_Bottombyphl);
            this.groupBox_BottomBoundary.Controls.Add(this.radioButton_Layers_BottomImpermeable);
            this.groupBox_BottomBoundary.ForeColor = System.Drawing.Color.White;
            this.groupBox_BottomBoundary.Location = new System.Drawing.Point(417, 6);
            this.groupBox_BottomBoundary.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_BottomBoundary.Name = "groupBox_BottomBoundary";
            this.groupBox_BottomBoundary.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_BottomBoundary.Size = new System.Drawing.Size(143, 92);
            this.groupBox_BottomBoundary.TabIndex = 5;
            this.groupBox_BottomBoundary.TabStop = false;
            this.groupBox_BottomBoundary.Text = "Bottom Boundary";
            // 
            // radioButton_Layers_Bottombyphl
            // 
            this.radioButton_Layers_Bottombyphl.AutoSize = true;
            this.radioButton_Layers_Bottombyphl.Checked = true;
            this.radioButton_Layers_Bottombyphl.Location = new System.Drawing.Point(12, 27);
            this.radioButton_Layers_Bottombyphl.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Layers_Bottombyphl.Name = "radioButton_Layers_Bottombyphl";
            this.radioButton_Layers_Bottombyphl.Size = new System.Drawing.Size(124, 20);
            this.radioButton_Layers_Bottombyphl.TabIndex = 5;
            this.radioButton_Layers_Bottombyphl.TabStop = true;
            this.radioButton_Layers_Bottombyphl.Text = "By phreatic level";
            this.radioButton_Layers_Bottombyphl.UseVisualStyleBackColor = true;
            this.radioButton_Layers_Bottombyphl.Click += new System.EventHandler(this.radioButton_Layers_Bottombyphl_Click);
            // 
            // radioButton_Layers_BottomImpermeable
            // 
            this.radioButton_Layers_BottomImpermeable.AutoSize = true;
            this.radioButton_Layers_BottomImpermeable.Location = new System.Drawing.Point(12, 59);
            this.radioButton_Layers_BottomImpermeable.Margin = new System.Windows.Forms.Padding(6);
            this.radioButton_Layers_BottomImpermeable.Name = "radioButton_Layers_BottomImpermeable";
            this.radioButton_Layers_BottomImpermeable.Size = new System.Drawing.Size(105, 20);
            this.radioButton_Layers_BottomImpermeable.TabIndex = 6;
            this.radioButton_Layers_BottomImpermeable.Text = "Impermeable";
            this.radioButton_Layers_BottomImpermeable.UseVisualStyleBackColor = true;
            this.radioButton_Layers_BottomImpermeable.Click += new System.EventHandler(this.radioButton_Layers_BottomImpermeable_Click);
            // 
            // dataGridView_Layers
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Layers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Layers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Layers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Layers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layers_IDlayer,
            this.layers_Slope,
            this.layers_Height,
            this.layers_IDMaterial,
            this.layers_Meshelements,
            this.layers_IDMaterialHidden,
            this.layers_MaterialHidden,
            this.layers_HtopHidden,
            this.layers_HbottomHidden,
            this.layers_Id_elem_topHidden,
            this.layers_Id_elem_bottomHidden});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Layers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Layers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Layers.EnableHeadersVisualStyles = false;
            this.dataGridView_Layers.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Layers.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_Layers.Name = "dataGridView_Layers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Layers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Layers.RowHeadersWidth = 82;
            this.dataGridView_Layers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Layers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Layers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Layers.Size = new System.Drawing.Size(590, 425);
            this.dataGridView_Layers.TabIndex = 7;
            this.dataGridView_Layers.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Layers_CellValueChanged);
            this.dataGridView_Layers.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_Layers_CurrentCellDirtyStateChanged);
            this.dataGridView_Layers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Layers_DataBindingComplete);
            this.dataGridView_Layers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_Layers_DataError);
            // 
            // layers_IDlayer
            // 
            this.layers_IDlayer.DataPropertyName = "IDlayer";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.layers_IDlayer.DefaultCellStyle = dataGridViewCellStyle6;
            this.layers_IDlayer.Frozen = true;
            this.layers_IDlayer.HeaderText = "ID";
            this.layers_IDlayer.Name = "layers_IDlayer";
            this.layers_IDlayer.ReadOnly = true;
            this.layers_IDlayer.Width = 50;
            // 
            // layers_Slope
            // 
            this.layers_Slope.DataPropertyName = "Slope";
            this.layers_Slope.Frozen = true;
            this.layers_Slope.HeaderText = "Slope on top";
            this.layers_Slope.MinimumWidth = 10;
            this.layers_Slope.Name = "layers_Slope";
            this.layers_Slope.Width = 120;
            // 
            // layers_Height
            // 
            this.layers_Height.DataPropertyName = "Height";
            this.layers_Height.Frozen = true;
            this.layers_Height.HeaderText = "Height";
            this.layers_Height.MinimumWidth = 10;
            this.layers_Height.Name = "layers_Height";
            this.layers_Height.Width = 80;
            // 
            // layers_IDMaterial
            // 
            this.layers_IDMaterial.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.layers_IDMaterial.DisplayStyleForCurrentCellOnly = true;
            this.layers_IDMaterial.Frozen = true;
            this.layers_IDMaterial.HeaderText = "IDMaterial";
            this.layers_IDMaterial.Name = "layers_IDMaterial";
            this.layers_IDMaterial.ToolTipText = "Select the material ID from Materials table";
            this.layers_IDMaterial.Width = 80;
            // 
            // layers_Meshelements
            // 
            this.layers_Meshelements.DataPropertyName = "Meshelements";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.layers_Meshelements.DefaultCellStyle = dataGridViewCellStyle7;
            this.layers_Meshelements.Frozen = true;
            this.layers_Meshelements.HeaderText = "MeshElements";
            this.layers_Meshelements.Name = "layers_Meshelements";
            this.layers_Meshelements.ReadOnly = true;
            // 
            // layers_IDMaterialHidden
            // 
            this.layers_IDMaterialHidden.DataPropertyName = "IDMaterial";
            this.layers_IDMaterialHidden.HeaderText = "IDMaterialHidden";
            this.layers_IDMaterialHidden.Name = "layers_IDMaterialHidden";
            this.layers_IDMaterialHidden.Visible = false;
            // 
            // layers_MaterialHidden
            // 
            this.layers_MaterialHidden.DataPropertyName = "Material";
            this.layers_MaterialHidden.HeaderText = "MaterialHidden";
            this.layers_MaterialHidden.Name = "layers_MaterialHidden";
            this.layers_MaterialHidden.Visible = false;
            // 
            // layers_HtopHidden
            // 
            this.layers_HtopHidden.DataPropertyName = "Htop";
            this.layers_HtopHidden.HeaderText = "HtopHidden";
            this.layers_HtopHidden.Name = "layers_HtopHidden";
            this.layers_HtopHidden.Visible = false;
            // 
            // layers_HbottomHidden
            // 
            this.layers_HbottomHidden.DataPropertyName = "Hbottom";
            this.layers_HbottomHidden.HeaderText = "HbottomHidden";
            this.layers_HbottomHidden.Name = "layers_HbottomHidden";
            this.layers_HbottomHidden.Visible = false;
            // 
            // layers_Id_elem_topHidden
            // 
            this.layers_Id_elem_topHidden.DataPropertyName = "Id_elem_top";
            this.layers_Id_elem_topHidden.HeaderText = "Id_elem_topHidden";
            this.layers_Id_elem_topHidden.Name = "layers_Id_elem_topHidden";
            this.layers_Id_elem_topHidden.Visible = false;
            // 
            // layers_Id_elem_bottomHidden
            // 
            this.layers_Id_elem_bottomHidden.DataPropertyName = "Id_elem_bottom";
            this.layers_Id_elem_bottomHidden.HeaderText = "Id_elem_bottomHidden";
            this.layers_Id_elem_bottomHidden.Name = "layers_Id_elem_bottomHidden";
            this.layers_Id_elem_bottomHidden.Visible = false;
            // 
            // tab_Mesh
            // 
            this.tab_Mesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_Mesh.Controls.Add(this.splitContainer3);
            this.tab_Mesh.Location = new System.Drawing.Point(4, 25);
            this.tab_Mesh.Margin = new System.Windows.Forms.Padding(6);
            this.tab_Mesh.Name = "tab_Mesh";
            this.tab_Mesh.Padding = new System.Windows.Forms.Padding(6);
            this.tab_Mesh.Size = new System.Drawing.Size(602, 555);
            this.tab_Mesh.TabIndex = 3;
            this.tab_Mesh.Text = "Mesh";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(6, 6);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label_ne);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_Ne);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_Nc);
            this.splitContainer3.Panel1.Controls.Add(this.label_Nc);
            this.splitContainer3.Panel1MinSize = 40;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel2MinSize = 50;
            this.splitContainer3.Size = new System.Drawing.Size(590, 543);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.SplitterWidth = 8;
            this.splitContainer3.TabIndex = 7;
            // 
            // label_ne
            // 
            this.label_ne.AutoSize = true;
            this.label_ne.Location = new System.Drawing.Point(6, 13);
            this.label_ne.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ne.Name = "label_ne";
            this.label_ne.Size = new System.Drawing.Size(122, 16);
            this.label_ne.TabIndex = 1;
            this.label_ne.Text = "Nodes per element";
            // 
            // textBox_Ne
            // 
            this.textBox_Ne.Location = new System.Drawing.Point(140, 10);
            this.textBox_Ne.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Ne.Name = "textBox_Ne";
            this.textBox_Ne.ReadOnly = true;
            this.textBox_Ne.Size = new System.Drawing.Size(50, 22);
            this.textBox_Ne.TabIndex = 0;
            this.textBox_Ne.Text = "2";
            this.textBox_Ne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Nc
            // 
            this.textBox_Nc.Location = new System.Drawing.Point(372, 10);
            this.textBox_Nc.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Nc.Name = "textBox_Nc";
            this.textBox_Nc.ReadOnly = true;
            this.textBox_Nc.Size = new System.Drawing.Size(50, 22);
            this.textBox_Nc.TabIndex = 2;
            this.textBox_Nc.Text = "0";
            this.textBox_Nc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Nc
            // 
            this.label_Nc.AutoSize = true;
            this.label_Nc.Location = new System.Drawing.Point(202, 13);
            this.label_Nc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Nc.Name = "label_Nc";
            this.label_Nc.Size = new System.Drawing.Size(158, 16);
            this.label_Nc.TabIndex = 3;
            this.label_Nc.Text = "Derivative class of nodes";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox_LayerMesh);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.groupBox_VerElem);
            this.splitContainer4.Size = new System.Drawing.Size(590, 495);
            this.splitContainer4.SplitterDistance = 180;
            this.splitContainer4.SplitterWidth = 8;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox_LayerMesh
            // 
            this.groupBox_LayerMesh.Controls.Add(this.dataGridView_LayerMesh);
            this.groupBox_LayerMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_LayerMesh.ForeColor = System.Drawing.Color.White;
            this.groupBox_LayerMesh.Location = new System.Drawing.Point(0, 0);
            this.groupBox_LayerMesh.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_LayerMesh.Name = "groupBox_LayerMesh";
            this.groupBox_LayerMesh.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_LayerMesh.Size = new System.Drawing.Size(180, 495);
            this.groupBox_LayerMesh.TabIndex = 0;
            this.groupBox_LayerMesh.TabStop = false;
            this.groupBox_LayerMesh.Text = "Layers mesh elements";
            // 
            // dataGridView_LayerMesh
            // 
            this.dataGridView_LayerMesh.AllowUserToAddRows = false;
            this.dataGridView_LayerMesh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_LayerMesh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_LayerMesh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_LayerMesh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LayerMesh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.layerMesh_IDlayer,
            this.layerMesh_Meshelements,
            this.layerMesh_Slope,
            this.layerMesh_Height,
            this.layerMesh_IDMaterial,
            this.layerMesh_Material,
            this.layerMesh_Htop,
            this.layerMesh_Hbottom,
            this.layerMesh_Id_elem_top,
            this.layerMesh_Id_elem_bottom});
            this.dataGridView_LayerMesh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_LayerMesh.EnableHeadersVisualStyles = false;
            this.dataGridView_LayerMesh.Location = new System.Drawing.Point(6, 21);
            this.dataGridView_LayerMesh.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_LayerMesh.Name = "dataGridView_LayerMesh";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_LayerMesh.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_LayerMesh.RowHeadersVisible = false;
            this.dataGridView_LayerMesh.RowHeadersWidth = 30;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_LayerMesh.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_LayerMesh.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_LayerMesh.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_LayerMesh.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_LayerMesh.Size = new System.Drawing.Size(168, 468);
            this.dataGridView_LayerMesh.TabIndex = 0;
            // 
            // layerMesh_IDlayer
            // 
            this.layerMesh_IDlayer.DataPropertyName = "IDlayer";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.layerMesh_IDlayer.DefaultCellStyle = dataGridViewCellStyle12;
            this.layerMesh_IDlayer.Frozen = true;
            this.layerMesh_IDlayer.HeaderText = "ID";
            this.layerMesh_IDlayer.MinimumWidth = 40;
            this.layerMesh_IDlayer.Name = "layerMesh_IDlayer";
            this.layerMesh_IDlayer.ReadOnly = true;
            this.layerMesh_IDlayer.Width = 60;
            // 
            // layerMesh_Meshelements
            // 
            this.layerMesh_Meshelements.DataPropertyName = "Meshelements";
            this.layerMesh_Meshelements.HeaderText = "Number of elements";
            this.layerMesh_Meshelements.MinimumWidth = 20;
            this.layerMesh_Meshelements.Name = "layerMesh_Meshelements";
            // 
            // layerMesh_Slope
            // 
            this.layerMesh_Slope.DataPropertyName = "Slope";
            this.layerMesh_Slope.HeaderText = "layerMesh_Slope";
            this.layerMesh_Slope.Name = "layerMesh_Slope";
            this.layerMesh_Slope.ReadOnly = true;
            this.layerMesh_Slope.Visible = false;
            // 
            // layerMesh_Height
            // 
            this.layerMesh_Height.DataPropertyName = "Height";
            this.layerMesh_Height.HeaderText = "layerMesh_Height";
            this.layerMesh_Height.Name = "layerMesh_Height";
            this.layerMesh_Height.ReadOnly = true;
            this.layerMesh_Height.Visible = false;
            // 
            // layerMesh_IDMaterial
            // 
            this.layerMesh_IDMaterial.DataPropertyName = "IDMaterial";
            this.layerMesh_IDMaterial.HeaderText = "IDMaterial";
            this.layerMesh_IDMaterial.Name = "layerMesh_IDMaterial";
            this.layerMesh_IDMaterial.ReadOnly = true;
            this.layerMesh_IDMaterial.Visible = false;
            // 
            // layerMesh_Material
            // 
            this.layerMesh_Material.DataPropertyName = "Material";
            this.layerMesh_Material.HeaderText = "Material";
            this.layerMesh_Material.Name = "layerMesh_Material";
            this.layerMesh_Material.ReadOnly = true;
            this.layerMesh_Material.Visible = false;
            // 
            // layerMesh_Htop
            // 
            this.layerMesh_Htop.DataPropertyName = "Htop";
            this.layerMesh_Htop.HeaderText = "Htop";
            this.layerMesh_Htop.Name = "layerMesh_Htop";
            this.layerMesh_Htop.ReadOnly = true;
            this.layerMesh_Htop.Visible = false;
            // 
            // layerMesh_Hbottom
            // 
            this.layerMesh_Hbottom.DataPropertyName = "Hbottom";
            this.layerMesh_Hbottom.HeaderText = "Hbottom";
            this.layerMesh_Hbottom.Name = "layerMesh_Hbottom";
            this.layerMesh_Hbottom.ReadOnly = true;
            this.layerMesh_Hbottom.Visible = false;
            // 
            // layerMesh_Id_elem_top
            // 
            this.layerMesh_Id_elem_top.DataPropertyName = "Id_elem_top";
            this.layerMesh_Id_elem_top.HeaderText = "Id_elem_top";
            this.layerMesh_Id_elem_top.Name = "layerMesh_Id_elem_top";
            this.layerMesh_Id_elem_top.ReadOnly = true;
            this.layerMesh_Id_elem_top.Visible = false;
            // 
            // layerMesh_Id_elem_bottom
            // 
            this.layerMesh_Id_elem_bottom.DataPropertyName = "Id_elem_bottom";
            this.layerMesh_Id_elem_bottom.HeaderText = "Id_elem_bottom";
            this.layerMesh_Id_elem_bottom.Name = "layerMesh_Id_elem_bottom";
            this.layerMesh_Id_elem_bottom.ReadOnly = true;
            this.layerMesh_Id_elem_bottom.Visible = false;
            // 
            // groupBox_VerElem
            // 
            this.groupBox_VerElem.Controls.Add(this.splitContainer5);
            this.groupBox_VerElem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_VerElem.ForeColor = System.Drawing.Color.White;
            this.groupBox_VerElem.Location = new System.Drawing.Point(0, 0);
            this.groupBox_VerElem.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox_VerElem.Name = "groupBox_VerElem";
            this.groupBox_VerElem.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox_VerElem.Size = new System.Drawing.Size(402, 495);
            this.groupBox_VerElem.TabIndex = 7;
            this.groupBox_VerElem.TabStop = false;
            this.groupBox_VerElem.Text = "Vertical 1DUNSAT submodels";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(6, 21);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.label_Nvmod);
            this.splitContainer5.Panel1.Controls.Add(this.textBox_Nvmod);
            this.splitContainer5.Panel1MinSize = 30;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dataGridView_VerticalModules);
            this.splitContainer5.Size = new System.Drawing.Size(390, 468);
            this.splitContainer5.SplitterDistance = 30;
            this.splitContainer5.SplitterWidth = 8;
            this.splitContainer5.TabIndex = 6;
            // 
            // label_Nvmod
            // 
            this.label_Nvmod.AutoSize = true;
            this.label_Nvmod.Location = new System.Drawing.Point(25, 13);
            this.label_Nvmod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Nvmod.Name = "label_Nvmod";
            this.label_Nvmod.Size = new System.Drawing.Size(240, 16);
            this.label_Nvmod.TabIndex = 5;
            this.label_Nvmod.Text = "Number of vertical 1DUNSAT modules:";
            // 
            // textBox_Nvmod
            // 
            this.textBox_Nvmod.Location = new System.Drawing.Point(312, 10);
            this.textBox_Nvmod.Margin = new System.Windows.Forms.Padding(6);
            this.textBox_Nvmod.Name = "textBox_Nvmod";
            this.textBox_Nvmod.ReadOnly = true;
            this.textBox_Nvmod.Size = new System.Drawing.Size(114, 22);
            this.textBox_Nvmod.TabIndex = 4;
            this.textBox_Nvmod.Text = "1";
            this.textBox_Nvmod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView_VerticalModules
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_VerticalModules.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_VerticalModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_VerticalModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_VerticalModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verticalModules_ID,
            this.verticalModules_Nelemh,
            this.verticalModules_Vmod_x});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_VerticalModules.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView_VerticalModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_VerticalModules.EnableHeadersVisualStyles = false;
            this.dataGridView_VerticalModules.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_VerticalModules.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_VerticalModules.Name = "dataGridView_VerticalModules";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_VerticalModules.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView_VerticalModules.RowHeadersWidth = 30;
            this.dataGridView_VerticalModules.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_VerticalModules.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_VerticalModules.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_VerticalModules.Size = new System.Drawing.Size(390, 430);
            this.dataGridView_VerticalModules.TabIndex = 0;
            this.dataGridView_VerticalModules.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_VerticalModules_CellValueChanged);
            // 
            // verticalModules_ID
            // 
            this.verticalModules_ID.DataPropertyName = "ID";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.verticalModules_ID.DefaultCellStyle = dataGridViewCellStyle17;
            this.verticalModules_ID.Frozen = true;
            this.verticalModules_ID.HeaderText = "ID Vertical Module";
            this.verticalModules_ID.MinimumWidth = 45;
            this.verticalModules_ID.Name = "verticalModules_ID";
            this.verticalModules_ID.ReadOnly = true;
            this.verticalModules_ID.Width = 60;
            // 
            // verticalModules_Nelemh
            // 
            this.verticalModules_Nelemh.DataPropertyName = "Nelemh";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.verticalModules_Nelemh.DefaultCellStyle = dataGridViewCellStyle18;
            this.verticalModules_Nelemh.HeaderText = "Number of elements between vertical modules";
            this.verticalModules_Nelemh.MinimumWidth = 50;
            this.verticalModules_Nelemh.Name = "verticalModules_Nelemh";
            this.verticalModules_Nelemh.Width = 140;
            // 
            // verticalModules_Vmod_x
            // 
            this.verticalModules_Vmod_x.DataPropertyName = "Vmod_x";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "E3";
            dataGridViewCellStyle19.NullValue = null;
            this.verticalModules_Vmod_x.DefaultCellStyle = dataGridViewCellStyle19;
            this.verticalModules_Vmod_x.HeaderText = "X Coord of vertical module";
            this.verticalModules_Vmod_x.MinimumWidth = 10;
            this.verticalModules_Vmod_x.Name = "verticalModules_Vmod_x";
            this.verticalModules_Vmod_x.Width = 120;
            // 
            // tab_Boundaries
            // 
            this.tab_Boundaries.Controls.Add(this.groupBox_Boundary);
            this.tab_Boundaries.Location = new System.Drawing.Point(4, 25);
            this.tab_Boundaries.Name = "tab_Boundaries";
            this.tab_Boundaries.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Boundaries.Size = new System.Drawing.Size(602, 555);
            this.tab_Boundaries.TabIndex = 4;
            this.tab_Boundaries.Text = "TopBoundary";
            this.tab_Boundaries.UseVisualStyleBackColor = true;
            // 
            // groupBox_Boundary
            // 
            this.groupBox_Boundary.Controls.Add(this.dataGridView_Boundary);
            this.groupBox_Boundary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Boundary.Location = new System.Drawing.Point(3, 3);
            this.groupBox_Boundary.Name = "groupBox_Boundary";
            this.groupBox_Boundary.Size = new System.Drawing.Size(596, 549);
            this.groupBox_Boundary.TabIndex = 0;
            this.groupBox_Boundary.TabStop = false;
            this.groupBox_Boundary.Text = "Boundaries at top";
            // 
            // dataGridView_Boundary
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Boundary.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Boundary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView_Boundary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Boundary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boundary_Timebound,
            this.boundary_Hbound,
            this.boundary_Qbound});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Boundary.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView_Boundary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Boundary.EnableHeadersVisualStyles = false;
            this.dataGridView_Boundary.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_Boundary.Name = "dataGridView_Boundary";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Boundary.RowHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView_Boundary.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_Boundary.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_Boundary.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_Boundary.Size = new System.Drawing.Size(590, 528);
            this.dataGridView_Boundary.TabIndex = 0;
            // 
            // boundary_Timebound
            // 
            this.boundary_Timebound.DataPropertyName = "Timebound";
            this.boundary_Timebound.HeaderText = "Time\n[T]";
            this.boundary_Timebound.Name = "boundary_Timebound";
            // 
            // boundary_Hbound
            // 
            this.boundary_Hbound.DataPropertyName = "Hbound";
            this.boundary_Hbound.HeaderText = "Head\n[L]";
            this.boundary_Hbound.Name = "boundary_Hbound";
            // 
            // boundary_Qbound
            // 
            this.boundary_Qbound.DataPropertyName = "Qbound";
            this.boundary_Qbound.HeaderText = "Inflow\n[L3·T-1·L-2]";
            this.boundary_Qbound.Name = "boundary_Qbound";
            this.boundary_Qbound.Visible = false;
            // 
            // openFileDialog_FileInput
            // 
            this.openFileDialog_FileInput.FileName = "*.wfsuinp";
            this.openFileDialog_FileInput.Filter = "\"WF15DSatUnsat file|*.wfsuinp\"";
            this.openFileDialog_FileInput.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileInput_FileOk);
            // 
            // webBrowser_Right
            // 
            this.webBrowser_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.webBrowser_Right.Location = new System.Drawing.Point(604, 0);
            this.webBrowser_Right.MinimumSize = new System.Drawing.Size(250, 20);
            this.webBrowser_Right.Name = "webBrowser_Right";
            this.webBrowser_Right.ScrollBarsEnabled = false;
            this.webBrowser_Right.Size = new System.Drawing.Size(250, 588);
            this.webBrowser_Right.TabIndex = 6;
            // 
            // panel_Input
            // 
            this.panel_Input.AutoScroll = true;
            this.panel_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Input.Controls.Add(this.tab_Inputs);
            this.panel_Input.Controls.Add(this.webBrowser_Right);
            this.panel_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Input.Location = new System.Drawing.Point(200, 71);
            this.panel_Input.MinimumSize = new System.Drawing.Size(850, 580);
            this.panel_Input.Name = "panel_Input";
            this.panel_Input.Size = new System.Drawing.Size(854, 588);
            this.panel_Input.TabIndex = 7;
            // 
            // saveFileDialog_Output
            // 
            this.saveFileDialog_Output.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_Output_FileOk);
            // 
            // panel_Calculate
            // 
            this.panel_Calculate.Controls.Add(this.splitContainer_Calculate);
            this.panel_Calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Calculate.Location = new System.Drawing.Point(200, 71);
            this.panel_Calculate.Name = "panel_Calculate";
            this.panel_Calculate.Size = new System.Drawing.Size(854, 588);
            this.panel_Calculate.TabIndex = 8;
            // 
            // splitContainer_Calculate
            // 
            this.splitContainer_Calculate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Calculate.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Calculate.Name = "splitContainer_Calculate";
            this.splitContainer_Calculate.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Calculate.Panel1
            // 
            this.splitContainer_Calculate.Panel1.Controls.Add(this.scatterXYControl_Calculate_Timestep);
            // 
            // splitContainer_Calculate.Panel2
            // 
            this.splitContainer_Calculate.Panel2.Controls.Add(this.richTextBoxCalculation);
            this.splitContainer_Calculate.Size = new System.Drawing.Size(854, 588);
            this.splitContainer_Calculate.SplitterDistance = 283;
            this.splitContainer_Calculate.TabIndex = 1;
            // 
            // scatterXYControl_Calculate_Timestep
            // 
            this.scatterXYControl_Calculate_Timestep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.scatterXYControl_Calculate_Timestep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_Calculate_Timestep.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_Calculate_Timestep.LockHorizontalAxis = false;
            this.scatterXYControl_Calculate_Timestep.LockVerticalAxis = false;
            this.scatterXYControl_Calculate_Timestep.Name = "scatterXYControl_Calculate_Timestep";
            this.scatterXYControl_Calculate_Timestep.Size = new System.Drawing.Size(854, 283);
            this.scatterXYControl_Calculate_Timestep.TabIndex = 0;
            this.scatterXYControl_Calculate_Timestep.Title = "Timestep during calculation over time";
            this.scatterXYControl_Calculate_Timestep.XAxisMax = -9.5D;
            this.scatterXYControl_Calculate_Timestep.XAxisMin = -10D;
            this.scatterXYControl_Calculate_Timestep.Xlabel = "time [T]";
            this.scatterXYControl_Calculate_Timestep.YAxisMax = 10D;
            this.scatterXYControl_Calculate_Timestep.YAxisMin = -10.5D;
            this.scatterXYControl_Calculate_Timestep.Ylabel = "timestep [T]";
            // 
            // richTextBoxCalculation
            // 
            this.richTextBoxCalculation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCalculation.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCalculation.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCalculation.Name = "richTextBoxCalculation";
            this.richTextBoxCalculation.Size = new System.Drawing.Size(854, 301);
            this.richTextBoxCalculation.TabIndex = 0;
            this.richTextBoxCalculation.Text = "";
            // 
            // panel_OutputConstraints
            // 
            this.panel_OutputConstraints.Controls.Add(this.tabControl_OutputConstraints);
            this.panel_OutputConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputConstraints.Location = new System.Drawing.Point(200, 71);
            this.panel_OutputConstraints.Name = "panel_OutputConstraints";
            this.panel_OutputConstraints.Size = new System.Drawing.Size(854, 588);
            this.panel_OutputConstraints.TabIndex = 9;
            // 
            // tabControl_OutputConstraints
            // 
            this.tabControl_OutputConstraints.Controls.Add(this.tab_OutputConstraints_Graph);
            this.tabControl_OutputConstraints.Controls.Add(this.tab_OutputContraints_Table);
            this.tabControl_OutputConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_OutputConstraints.Location = new System.Drawing.Point(0, 0);
            this.tabControl_OutputConstraints.Name = "tabControl_OutputConstraints";
            this.tabControl_OutputConstraints.SelectedIndex = 0;
            this.tabControl_OutputConstraints.Size = new System.Drawing.Size(854, 588);
            this.tabControl_OutputConstraints.TabIndex = 0;
            // 
            // tab_OutputConstraints_Graph
            // 
            this.tab_OutputConstraints_Graph.Controls.Add(this.panel_OutputConstraints_Graph);
            this.tab_OutputConstraints_Graph.Controls.Add(this.panel_OutputConstraints_GraphOptions);
            this.tab_OutputConstraints_Graph.Location = new System.Drawing.Point(4, 25);
            this.tab_OutputConstraints_Graph.Name = "tab_OutputConstraints_Graph";
            this.tab_OutputConstraints_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.tab_OutputConstraints_Graph.Size = new System.Drawing.Size(846, 559);
            this.tab_OutputConstraints_Graph.TabIndex = 1;
            this.tab_OutputConstraints_Graph.Text = "Graphic";
            this.tab_OutputConstraints_Graph.UseVisualStyleBackColor = true;
            // 
            // panel_OutputConstraints_Graph
            // 
            this.panel_OutputConstraints_Graph.Controls.Add(this.scatterXYControl_Constraints);
            this.panel_OutputConstraints_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputConstraints_Graph.Location = new System.Drawing.Point(3, 3);
            this.panel_OutputConstraints_Graph.Name = "panel_OutputConstraints_Graph";
            this.panel_OutputConstraints_Graph.Size = new System.Drawing.Size(640, 553);
            this.panel_OutputConstraints_Graph.TabIndex = 0;
            // 
            // scatterXYControl_Constraints
            // 
            this.scatterXYControl_Constraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_Constraints.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_Constraints.LockHorizontalAxis = false;
            this.scatterXYControl_Constraints.LockVerticalAxis = false;
            this.scatterXYControl_Constraints.Name = "scatterXYControl_Constraints";
            this.scatterXYControl_Constraints.Size = new System.Drawing.Size(640, 553);
            this.scatterXYControl_Constraints.TabIndex = 0;
            this.scatterXYControl_Constraints.Title = "Output at the constraints over time";
            this.scatterXYControl_Constraints.XAxisMax = -9.5D;
            this.scatterXYControl_Constraints.XAxisMin = -10D;
            this.scatterXYControl_Constraints.Xlabel = "Time [T]";
            this.scatterXYControl_Constraints.YAxisMax = 10D;
            this.scatterXYControl_Constraints.YAxisMin = -10.5D;
            this.scatterXYControl_Constraints.Ylabel = "Output";
            // 
            // panel_OutputConstraints_GraphOptions
            // 
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.button_Constraints_Update);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.button_Constraints_Clear);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.button_Constraints_Add_Variable);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.comboBox_Constraints_numIU);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.comboBox_Constraints_numIS);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.label_Constraints_Variable);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.comboBox_Constraints_Variable);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.label_Constraints_IU);
            this.panel_OutputConstraints_GraphOptions.Controls.Add(this.label_Constraints_IS);
            this.panel_OutputConstraints_GraphOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutputConstraints_GraphOptions.Location = new System.Drawing.Point(643, 3);
            this.panel_OutputConstraints_GraphOptions.Name = "panel_OutputConstraints_GraphOptions";
            this.panel_OutputConstraints_GraphOptions.Size = new System.Drawing.Size(200, 553);
            this.panel_OutputConstraints_GraphOptions.TabIndex = 1;
            // 
            // button_Constraints_Update
            // 
            this.button_Constraints_Update.BackColor = System.Drawing.Color.Black;
            this.button_Constraints_Update.Location = new System.Drawing.Point(6, 3);
            this.button_Constraints_Update.Name = "button_Constraints_Update";
            this.button_Constraints_Update.Size = new System.Drawing.Size(191, 23);
            this.button_Constraints_Update.TabIndex = 10;
            this.button_Constraints_Update.Text = "Update Output";
            this.button_Constraints_Update.UseVisualStyleBackColor = false;
            this.button_Constraints_Update.Click += new System.EventHandler(this.button_Constraint_Update_Click);
            // 
            // button_Constraints_Clear
            // 
            this.button_Constraints_Clear.BackColor = System.Drawing.Color.Black;
            this.button_Constraints_Clear.Location = new System.Drawing.Point(3, 189);
            this.button_Constraints_Clear.Name = "button_Constraints_Clear";
            this.button_Constraints_Clear.Size = new System.Drawing.Size(192, 23);
            this.button_Constraints_Clear.TabIndex = 9;
            this.button_Constraints_Clear.Text = "Clear Graph";
            this.button_Constraints_Clear.UseVisualStyleBackColor = false;
            this.button_Constraints_Clear.Click += new System.EventHandler(this.button_Constraints_Clear_Click);
            // 
            // button_Constraints_Add_Variable
            // 
            this.button_Constraints_Add_Variable.BackColor = System.Drawing.Color.Black;
            this.button_Constraints_Add_Variable.Location = new System.Drawing.Point(3, 158);
            this.button_Constraints_Add_Variable.Name = "button_Constraints_Add_Variable";
            this.button_Constraints_Add_Variable.Size = new System.Drawing.Size(192, 23);
            this.button_Constraints_Add_Variable.TabIndex = 8;
            this.button_Constraints_Add_Variable.Text = "Plot Variable";
            this.button_Constraints_Add_Variable.UseVisualStyleBackColor = false;
            this.button_Constraints_Add_Variable.Click += new System.EventHandler(this.button_Constraints_Add_Variable_Click);
            // 
            // comboBox_Constraints_numIU
            // 
            this.comboBox_Constraints_numIU.FormattingEnabled = true;
            this.comboBox_Constraints_numIU.Location = new System.Drawing.Point(136, 77);
            this.comboBox_Constraints_numIU.Name = "comboBox_Constraints_numIU";
            this.comboBox_Constraints_numIU.Size = new System.Drawing.Size(57, 24);
            this.comboBox_Constraints_numIU.TabIndex = 7;
            // 
            // comboBox_Constraints_numIS
            // 
            this.comboBox_Constraints_numIS.FormattingEnabled = true;
            this.comboBox_Constraints_numIS.Location = new System.Drawing.Point(136, 39);
            this.comboBox_Constraints_numIS.Name = "comboBox_Constraints_numIS";
            this.comboBox_Constraints_numIS.Size = new System.Drawing.Size(57, 24);
            this.comboBox_Constraints_numIS.TabIndex = 6;
            // 
            // label_Constraints_Variable
            // 
            this.label_Constraints_Variable.AutoSize = true;
            this.label_Constraints_Variable.ForeColor = System.Drawing.Color.Black;
            this.label_Constraints_Variable.Location = new System.Drawing.Point(4, 130);
            this.label_Constraints_Variable.Name = "label_Constraints_Variable";
            this.label_Constraints_Variable.Size = new System.Drawing.Size(109, 16);
            this.label_Constraints_Variable.TabIndex = 5;
            this.label_Constraints_Variable.Text = "Variable to show:";
            // 
            // comboBox_Constraints_Variable
            // 
            this.comboBox_Constraints_Variable.FormattingEnabled = true;
            this.comboBox_Constraints_Variable.Items.AddRange(new object[] {
            "v_hnew",
            "v_thnew",
            "v_hsat",
            "v_qvtb",
            "v_qvt",
            "v_qvb",
            "v_incvoldt",
            "v_Qs_layer",
            "v_Qs_all",
            "nrel",
            "h_width",
            "h_hsat_mean",
            "h_qent_mean",
            "h_incvoldt_mean",
            "h_dqhordx_mean",
            "h_dqhordx_all_mean"});
            this.comboBox_Constraints_Variable.Location = new System.Drawing.Point(136, 127);
            this.comboBox_Constraints_Variable.Name = "comboBox_Constraints_Variable";
            this.comboBox_Constraints_Variable.Size = new System.Drawing.Size(57, 24);
            this.comboBox_Constraints_Variable.TabIndex = 4;
            // 
            // label_Constraints_IU
            // 
            this.label_Constraints_IU.AutoSize = true;
            this.label_Constraints_IU.ForeColor = System.Drawing.Color.Black;
            this.label_Constraints_IU.Location = new System.Drawing.Point(3, 80);
            this.label_Constraints_IU.Name = "label_Constraints_IU";
            this.label_Constraints_IU.Size = new System.Drawing.Size(127, 16);
            this.label_Constraints_IU.TabIndex = 3;
            this.label_Constraints_IU.Text = "Vertical Module (IU):";
            // 
            // label_Constraints_IS
            // 
            this.label_Constraints_IS.AutoSize = true;
            this.label_Constraints_IS.ForeColor = System.Drawing.Color.Black;
            this.label_Constraints_IS.Location = new System.Drawing.Point(3, 42);
            this.label_Constraints_IS.Name = "label_Constraints_IS";
            this.label_Constraints_IS.Size = new System.Drawing.Size(115, 16);
            this.label_Constraints_IS.TabIndex = 1;
            this.label_Constraints_IS.Text = "Layer number (IS):";
            // 
            // tab_OutputContraints_Table
            // 
            this.tab_OutputContraints_Table.Controls.Add(this.datagridview_OutputConstraints);
            this.tab_OutputContraints_Table.Controls.Add(this.bindingNavigator_OutputConstraints);
            this.tab_OutputContraints_Table.Location = new System.Drawing.Point(4, 22);
            this.tab_OutputContraints_Table.Name = "tab_OutputContraints_Table";
            this.tab_OutputContraints_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_OutputContraints_Table.Size = new System.Drawing.Size(846, 558);
            this.tab_OutputContraints_Table.TabIndex = 0;
            this.tab_OutputContraints_Table.Text = "Table";
            this.tab_OutputContraints_Table.UseVisualStyleBackColor = true;
            // 
            // datagridview_OutputConstraints
            // 
            this.datagridview_OutputConstraints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview_OutputConstraints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Constraints_IDconstraint});
            this.datagridview_OutputConstraints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_OutputConstraints.Location = new System.Drawing.Point(3, 28);
            this.datagridview_OutputConstraints.Name = "datagridview_OutputConstraints";
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridview_OutputConstraints.RowsDefaultCellStyle = dataGridViewCellStyle26;
            this.datagridview_OutputConstraints.Size = new System.Drawing.Size(840, 527);
            this.datagridview_OutputConstraints.TabIndex = 1;
            // 
            // Column_Constraints_IDconstraint
            // 
            this.Column_Constraints_IDconstraint.DataPropertyName = "IDconstraint";
            this.Column_Constraints_IDconstraint.HeaderText = "IDconstraint";
            this.Column_Constraints_IDconstraint.Name = "Column_Constraints_IDconstraint";
            // 
            // bindingNavigator_OutputConstraints
            // 
            this.bindingNavigator_OutputConstraints.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator_OutputConstraints.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_OutputConstraints.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator_OutputConstraints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator_OutputConstraints.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator_OutputConstraints.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_OutputConstraints.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_OutputConstraints.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_OutputConstraints.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_OutputConstraints.Name = "bindingNavigator_OutputConstraints";
            this.bindingNavigator_OutputConstraints.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_OutputConstraints.Size = new System.Drawing.Size(840, 25);
            this.bindingNavigator_OutputConstraints.TabIndex = 2;
            this.bindingNavigator_OutputConstraints.Text = "bindingNavigator_OutputConstraints";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // timer_CalculationTimestep
            // 
            this.timer_CalculationTimestep.Interval = 500;
            this.timer_CalculationTimestep.Tick += new System.EventHandler(this.timer_CalculationTimestep_Tick);
            // 
            // panel_OutputSatNodes
            // 
            this.panel_OutputSatNodes.Controls.Add(this.tabControl_OutputSatNodes);
            this.panel_OutputSatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputSatNodes.Location = new System.Drawing.Point(200, 71);
            this.panel_OutputSatNodes.Name = "panel_OutputSatNodes";
            this.panel_OutputSatNodes.Size = new System.Drawing.Size(854, 588);
            this.panel_OutputSatNodes.TabIndex = 10;
            // 
            // tabControl_OutputSatNodes
            // 
            this.tabControl_OutputSatNodes.Controls.Add(this.tabPage_SatNodes_Graph);
            this.tabControl_OutputSatNodes.Controls.Add(this.tabPage_SatNodes_Table);
            this.tabControl_OutputSatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_OutputSatNodes.Location = new System.Drawing.Point(0, 0);
            this.tabControl_OutputSatNodes.Name = "tabControl_OutputSatNodes";
            this.tabControl_OutputSatNodes.SelectedIndex = 0;
            this.tabControl_OutputSatNodes.Size = new System.Drawing.Size(854, 588);
            this.tabControl_OutputSatNodes.TabIndex = 0;
            // 
            // tabPage_SatNodes_Graph
            // 
            this.tabPage_SatNodes_Graph.Controls.Add(this.panel_OutputSatNodes_Graph);
            this.tabPage_SatNodes_Graph.Controls.Add(this.panel_OutputSatNodes_GraphOptions);
            this.tabPage_SatNodes_Graph.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SatNodes_Graph.Name = "tabPage_SatNodes_Graph";
            this.tabPage_SatNodes_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SatNodes_Graph.Size = new System.Drawing.Size(846, 559);
            this.tabPage_SatNodes_Graph.TabIndex = 1;
            this.tabPage_SatNodes_Graph.Text = "Graphic";
            this.tabPage_SatNodes_Graph.UseVisualStyleBackColor = true;
            // 
            // panel_OutputSatNodes_Graph
            // 
            this.panel_OutputSatNodes_Graph.Controls.Add(this.splitContainer_SatNodes);
            this.panel_OutputSatNodes_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputSatNodes_Graph.Location = new System.Drawing.Point(3, 3);
            this.panel_OutputSatNodes_Graph.Name = "panel_OutputSatNodes_Graph";
            this.panel_OutputSatNodes_Graph.Size = new System.Drawing.Size(640, 553);
            this.panel_OutputSatNodes_Graph.TabIndex = 0;
            // 
            // splitContainer_SatNodes
            // 
            this.splitContainer_SatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_SatNodes.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_SatNodes.Name = "splitContainer_SatNodes";
            this.splitContainer_SatNodes.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_SatNodes.Panel1
            // 
            this.splitContainer_SatNodes.Panel1.Controls.Add(this.scatterXYControl_SatNodes_Layers);
            // 
            // splitContainer_SatNodes.Panel2
            // 
            this.splitContainer_SatNodes.Panel2.Controls.Add(this.scatterXYControl_SatNodes_Others);
            this.splitContainer_SatNodes.Size = new System.Drawing.Size(640, 553);
            this.splitContainer_SatNodes.SplitterDistance = 261;
            this.splitContainer_SatNodes.TabIndex = 1;
            // 
            // scatterXYControl_SatNodes_Layers
            // 
            this.scatterXYControl_SatNodes_Layers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_SatNodes_Layers.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_SatNodes_Layers.LockHorizontalAxis = false;
            this.scatterXYControl_SatNodes_Layers.LockVerticalAxis = false;
            this.scatterXYControl_SatNodes_Layers.Name = "scatterXYControl_SatNodes_Layers";
            this.scatterXYControl_SatNodes_Layers.Size = new System.Drawing.Size(640, 261);
            this.scatterXYControl_SatNodes_Layers.TabIndex = 0;
            this.scatterXYControl_SatNodes_Layers.Title = "Output: Values at nodes on the 1DSat layer";
            this.scatterXYControl_SatNodes_Layers.XAxisMax = -9.5D;
            this.scatterXYControl_SatNodes_Layers.XAxisMin = -10D;
            this.scatterXYControl_SatNodes_Layers.Xlabel = "X [L]";
            this.scatterXYControl_SatNodes_Layers.YAxisMax = 10D;
            this.scatterXYControl_SatNodes_Layers.YAxisMin = -10.5D;
            this.scatterXYControl_SatNodes_Layers.Ylabel = "Head [L]";
            // 
            // scatterXYControl_SatNodes_Others
            // 
            this.scatterXYControl_SatNodes_Others.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_SatNodes_Others.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_SatNodes_Others.LockHorizontalAxis = false;
            this.scatterXYControl_SatNodes_Others.LockVerticalAxis = false;
            this.scatterXYControl_SatNodes_Others.Name = "scatterXYControl_SatNodes_Others";
            this.scatterXYControl_SatNodes_Others.Size = new System.Drawing.Size(640, 288);
            this.scatterXYControl_SatNodes_Others.TabIndex = 1;
            this.scatterXYControl_SatNodes_Others.Title = "Output: Values at nodes on the 1DSat layer";
            this.scatterXYControl_SatNodes_Others.XAxisMax = -9.5D;
            this.scatterXYControl_SatNodes_Others.XAxisMin = -10D;
            this.scatterXYControl_SatNodes_Others.Xlabel = "X [L]";
            this.scatterXYControl_SatNodes_Others.YAxisMax = 10D;
            this.scatterXYControl_SatNodes_Others.YAxisMin = -10.5D;
            this.scatterXYControl_SatNodes_Others.Ylabel = "Output";
            // 
            // panel_OutputSatNodes_GraphOptions
            // 
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.comboBox_SatNodes_T);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.label_SatNodes_T);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.button_SatNodes_Update);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.button_SatNodes_Clear);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.button_SatNodes_AddVariable);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.comboBox_SatNodes_numIS);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.label_SatNodes_Variable);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.comboBox_SatNodes_Variable);
            this.panel_OutputSatNodes_GraphOptions.Controls.Add(this.label_SatNodes_IS);
            this.panel_OutputSatNodes_GraphOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutputSatNodes_GraphOptions.Location = new System.Drawing.Point(643, 3);
            this.panel_OutputSatNodes_GraphOptions.Name = "panel_OutputSatNodes_GraphOptions";
            this.panel_OutputSatNodes_GraphOptions.Size = new System.Drawing.Size(200, 553);
            this.panel_OutputSatNodes_GraphOptions.TabIndex = 1;
            // 
            // comboBox_SatNodes_T
            // 
            this.comboBox_SatNodes_T.FormattingEnabled = true;
            this.comboBox_SatNodes_T.Location = new System.Drawing.Point(136, 74);
            this.comboBox_SatNodes_T.Name = "comboBox_SatNodes_T";
            this.comboBox_SatNodes_T.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatNodes_T.TabIndex = 12;
            // 
            // label_SatNodes_T
            // 
            this.label_SatNodes_T.AutoSize = true;
            this.label_SatNodes_T.ForeColor = System.Drawing.Color.Black;
            this.label_SatNodes_T.Location = new System.Drawing.Point(3, 77);
            this.label_SatNodes_T.Name = "label_SatNodes_T";
            this.label_SatNodes_T.Size = new System.Drawing.Size(61, 16);
            this.label_SatNodes_T.TabIndex = 11;
            this.label_SatNodes_T.Text = "Time (T):";
            // 
            // button_SatNodes_Update
            // 
            this.button_SatNodes_Update.BackColor = System.Drawing.Color.Black;
            this.button_SatNodes_Update.Location = new System.Drawing.Point(6, 3);
            this.button_SatNodes_Update.Name = "button_SatNodes_Update";
            this.button_SatNodes_Update.Size = new System.Drawing.Size(191, 23);
            this.button_SatNodes_Update.TabIndex = 10;
            this.button_SatNodes_Update.Text = "Update Output";
            this.button_SatNodes_Update.UseVisualStyleBackColor = false;
            this.button_SatNodes_Update.Click += new System.EventHandler(this.button_SatNodes_Update_Click);
            // 
            // button_SatNodes_Clear
            // 
            this.button_SatNodes_Clear.BackColor = System.Drawing.Color.Black;
            this.button_SatNodes_Clear.Location = new System.Drawing.Point(3, 189);
            this.button_SatNodes_Clear.Name = "button_SatNodes_Clear";
            this.button_SatNodes_Clear.Size = new System.Drawing.Size(192, 23);
            this.button_SatNodes_Clear.TabIndex = 9;
            this.button_SatNodes_Clear.Text = "Clear Graph";
            this.button_SatNodes_Clear.UseVisualStyleBackColor = false;
            this.button_SatNodes_Clear.Click += new System.EventHandler(this.button_SatNodes_Clear_Click);
            // 
            // button_SatNodes_AddVariable
            // 
            this.button_SatNodes_AddVariable.BackColor = System.Drawing.Color.Black;
            this.button_SatNodes_AddVariable.Location = new System.Drawing.Point(3, 158);
            this.button_SatNodes_AddVariable.Name = "button_SatNodes_AddVariable";
            this.button_SatNodes_AddVariable.Size = new System.Drawing.Size(192, 23);
            this.button_SatNodes_AddVariable.TabIndex = 8;
            this.button_SatNodes_AddVariable.Text = "Plot Variable";
            this.button_SatNodes_AddVariable.UseVisualStyleBackColor = false;
            this.button_SatNodes_AddVariable.Click += new System.EventHandler(this.button_SatNodes_Add_Variable_Click);
            // 
            // comboBox_SatNodes_numIS
            // 
            this.comboBox_SatNodes_numIS.FormattingEnabled = true;
            this.comboBox_SatNodes_numIS.Location = new System.Drawing.Point(136, 39);
            this.comboBox_SatNodes_numIS.Name = "comboBox_SatNodes_numIS";
            this.comboBox_SatNodes_numIS.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatNodes_numIS.TabIndex = 6;
            // 
            // label_SatNodes_Variable
            // 
            this.label_SatNodes_Variable.AutoSize = true;
            this.label_SatNodes_Variable.ForeColor = System.Drawing.Color.Black;
            this.label_SatNodes_Variable.Location = new System.Drawing.Point(4, 130);
            this.label_SatNodes_Variable.Name = "label_SatNodes_Variable";
            this.label_SatNodes_Variable.Size = new System.Drawing.Size(109, 16);
            this.label_SatNodes_Variable.TabIndex = 5;
            this.label_SatNodes_Variable.Text = "Variable to show:";
            // 
            // comboBox_SatNodes_Variable
            // 
            this.comboBox_SatNodes_Variable.FormattingEnabled = true;
            this.comboBox_SatNodes_Variable.Items.AddRange(new object[] {
            "head",
            "qent",
            "qincvol",
            "qhor",
            "dqhordx",
            "dqhordx_from_incvol",
            "qhor_all",
            "dqhordx_all",
            "dqhordx_from_incvol_all"});
            this.comboBox_SatNodes_Variable.Location = new System.Drawing.Point(136, 127);
            this.comboBox_SatNodes_Variable.Name = "comboBox_SatNodes_Variable";
            this.comboBox_SatNodes_Variable.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatNodes_Variable.TabIndex = 4;
            // 
            // label_SatNodes_IS
            // 
            this.label_SatNodes_IS.AutoSize = true;
            this.label_SatNodes_IS.ForeColor = System.Drawing.Color.Black;
            this.label_SatNodes_IS.Location = new System.Drawing.Point(3, 42);
            this.label_SatNodes_IS.Name = "label_SatNodes_IS";
            this.label_SatNodes_IS.Size = new System.Drawing.Size(115, 16);
            this.label_SatNodes_IS.TabIndex = 1;
            this.label_SatNodes_IS.Text = "Layer number (IS):";
            // 
            // tabPage_SatNodes_Table
            // 
            this.tabPage_SatNodes_Table.Controls.Add(this.dataGridView_OutputSatNodes);
            this.tabPage_SatNodes_Table.Controls.Add(this.bindingNavigator_OutputSatNodes);
            this.tabPage_SatNodes_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SatNodes_Table.Name = "tabPage_SatNodes_Table";
            this.tabPage_SatNodes_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SatNodes_Table.Size = new System.Drawing.Size(846, 558);
            this.tabPage_SatNodes_Table.TabIndex = 0;
            this.tabPage_SatNodes_Table.Text = "Table";
            this.tabPage_SatNodes_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_OutputSatNodes
            // 
            this.dataGridView_OutputSatNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OutputSatNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_SatNodes_ID});
            this.dataGridView_OutputSatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OutputSatNodes.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_OutputSatNodes.Name = "dataGridView_OutputSatNodes";
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_OutputSatNodes.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView_OutputSatNodes.Size = new System.Drawing.Size(840, 527);
            this.dataGridView_OutputSatNodes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn_SatNodes_ID
            // 
            this.dataGridViewTextBoxColumn_SatNodes_ID.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn_SatNodes_ID.HeaderText = "IDconstraint";
            this.dataGridViewTextBoxColumn_SatNodes_ID.Name = "dataGridViewTextBoxColumn_SatNodes_ID";
            // 
            // bindingNavigator_OutputSatNodes
            // 
            this.bindingNavigator_OutputSatNodes.AddNewItem = this.bindingNavigator_SatNodes_AddNewItem;
            this.bindingNavigator_OutputSatNodes.CountItem = this.bindingNavigator_SatNodes_CountItem;
            this.bindingNavigator_OutputSatNodes.DeleteItem = this.bindingNavigator_SatNodes_DeleteItem;
            this.bindingNavigator_OutputSatNodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigator_SatNodes_MoveFirstItem,
            this.bindingNavigator_SatNodes_MovePreviousItem,
            this.bindingNavigator_SatNodes_Separator,
            this.bindingNavigator_SatNodes_PositionItem,
            this.bindingNavigator_SatNodes_CountItem,
            this.bindingNavigator_SatNOdes_Separator1,
            this.bindingNavigator_SatNodes_MoveNextItem,
            this.bindingNavigator_SatNodes_MoveLastItem,
            this.bindingNavigator_SatNodes_Separator2,
            this.bindingNavigator_SatNodes_AddNewItem,
            this.bindingNavigator_SatNodes_DeleteItem});
            this.bindingNavigator_OutputSatNodes.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator_OutputSatNodes.MoveFirstItem = this.bindingNavigator_SatNodes_MoveFirstItem;
            this.bindingNavigator_OutputSatNodes.MoveLastItem = this.bindingNavigator_SatNodes_MoveLastItem;
            this.bindingNavigator_OutputSatNodes.MoveNextItem = this.bindingNavigator_SatNodes_MoveNextItem;
            this.bindingNavigator_OutputSatNodes.MovePreviousItem = this.bindingNavigator_SatNodes_MovePreviousItem;
            this.bindingNavigator_OutputSatNodes.Name = "bindingNavigator_OutputSatNodes";
            this.bindingNavigator_OutputSatNodes.PositionItem = this.bindingNavigator_SatNodes_PositionItem;
            this.bindingNavigator_OutputSatNodes.Size = new System.Drawing.Size(840, 25);
            this.bindingNavigator_OutputSatNodes.TabIndex = 2;
            this.bindingNavigator_OutputSatNodes.Text = "bindingNavigator1";
            // 
            // bindingNavigator_SatNodes_AddNewItem
            // 
            this.bindingNavigator_SatNodes_AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_AddNewItem.Image")));
            this.bindingNavigator_SatNodes_AddNewItem.Name = "bindingNavigator_SatNodes_AddNewItem";
            this.bindingNavigator_SatNodes_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_AddNewItem.Text = "Add new";
            // 
            // bindingNavigator_SatNodes_CountItem
            // 
            this.bindingNavigator_SatNodes_CountItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigator_SatNodes_CountItem.Name = "bindingNavigator_SatNodes_CountItem";
            this.bindingNavigator_SatNodes_CountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigator_SatNodes_CountItem.Text = "of {0}";
            this.bindingNavigator_SatNodes_CountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigator_SatNodes_DeleteItem
            // 
            this.bindingNavigator_SatNodes_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_DeleteItem.Image")));
            this.bindingNavigator_SatNodes_DeleteItem.Name = "bindingNavigator_SatNodes_DeleteItem";
            this.bindingNavigator_SatNodes_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_DeleteItem.Text = "Delete";
            // 
            // bindingNavigator_SatNodes_MoveFirstItem
            // 
            this.bindingNavigator_SatNodes_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_MoveFirstItem.Image")));
            this.bindingNavigator_SatNodes_MoveFirstItem.Name = "bindingNavigator_SatNodes_MoveFirstItem";
            this.bindingNavigator_SatNodes_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_MoveFirstItem.Text = "Move first";
            // 
            // bindingNavigator_SatNodes_MovePreviousItem
            // 
            this.bindingNavigator_SatNodes_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_MovePreviousItem.Image")));
            this.bindingNavigator_SatNodes_MovePreviousItem.Name = "bindingNavigator_SatNodes_MovePreviousItem";
            this.bindingNavigator_SatNodes_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_MovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigator_SatNodes_Separator
            // 
            this.bindingNavigator_SatNodes_Separator.Name = "bindingNavigator_SatNodes_Separator";
            this.bindingNavigator_SatNodes_Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_SatNodes_PositionItem
            // 
            this.bindingNavigator_SatNodes_PositionItem.AccessibleName = "Position";
            this.bindingNavigator_SatNodes_PositionItem.AutoSize = false;
            this.bindingNavigator_SatNodes_PositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigator_SatNodes_PositionItem.Name = "bindingNavigator_SatNodes_PositionItem";
            this.bindingNavigator_SatNodes_PositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigator_SatNodes_PositionItem.Text = "0";
            this.bindingNavigator_SatNodes_PositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigator_SatNOdes_Separator1
            // 
            this.bindingNavigator_SatNOdes_Separator1.Name = "bindingNavigator_SatNOdes_Separator1";
            this.bindingNavigator_SatNOdes_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_SatNodes_MoveNextItem
            // 
            this.bindingNavigator_SatNodes_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_MoveNextItem.Image")));
            this.bindingNavigator_SatNodes_MoveNextItem.Name = "bindingNavigator_SatNodes_MoveNextItem";
            this.bindingNavigator_SatNodes_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_MoveNextItem.Text = "Move next";
            // 
            // bindingNavigator_SatNodes_MoveLastItem
            // 
            this.bindingNavigator_SatNodes_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatNodes_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatNodes_MoveLastItem.Image")));
            this.bindingNavigator_SatNodes_MoveLastItem.Name = "bindingNavigator_SatNodes_MoveLastItem";
            this.bindingNavigator_SatNodes_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatNodes_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatNodes_MoveLastItem.Text = "Move last";
            // 
            // bindingNavigator_SatNodes_Separator2
            // 
            this.bindingNavigator_SatNodes_Separator2.Name = "bindingNavigator_SatNodes_Separator2";
            this.bindingNavigator_SatNodes_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel_OutputSatElements
            // 
            this.panel_OutputSatElements.Controls.Add(this.tabControl_OutputSatElements);
            this.panel_OutputSatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputSatElements.Location = new System.Drawing.Point(200, 71);
            this.panel_OutputSatElements.Name = "panel_OutputSatElements";
            this.panel_OutputSatElements.Size = new System.Drawing.Size(854, 588);
            this.panel_OutputSatElements.TabIndex = 11;
            // 
            // tabControl_OutputSatElements
            // 
            this.tabControl_OutputSatElements.Controls.Add(this.tabPage_SatElements_Graph);
            this.tabControl_OutputSatElements.Controls.Add(this.tabPage_SatElements_Table);
            this.tabControl_OutputSatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_OutputSatElements.Location = new System.Drawing.Point(0, 0);
            this.tabControl_OutputSatElements.Name = "tabControl_OutputSatElements";
            this.tabControl_OutputSatElements.SelectedIndex = 0;
            this.tabControl_OutputSatElements.Size = new System.Drawing.Size(854, 588);
            this.tabControl_OutputSatElements.TabIndex = 0;
            // 
            // tabPage_SatElements_Graph
            // 
            this.tabPage_SatElements_Graph.Controls.Add(this.panel_OutputSatElements_Graph);
            this.tabPage_SatElements_Graph.Controls.Add(this.panel_OutputSatElements_GraphOptions);
            this.tabPage_SatElements_Graph.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SatElements_Graph.Name = "tabPage_SatElements_Graph";
            this.tabPage_SatElements_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SatElements_Graph.Size = new System.Drawing.Size(846, 559);
            this.tabPage_SatElements_Graph.TabIndex = 1;
            this.tabPage_SatElements_Graph.Text = "Graphic";
            this.tabPage_SatElements_Graph.UseVisualStyleBackColor = true;
            // 
            // panel_OutputSatElements_Graph
            // 
            this.panel_OutputSatElements_Graph.Controls.Add(this.splitContainer_SatElements);
            this.panel_OutputSatElements_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputSatElements_Graph.Location = new System.Drawing.Point(3, 3);
            this.panel_OutputSatElements_Graph.Name = "panel_OutputSatElements_Graph";
            this.panel_OutputSatElements_Graph.Size = new System.Drawing.Size(640, 553);
            this.panel_OutputSatElements_Graph.TabIndex = 0;
            // 
            // splitContainer_SatElements
            // 
            this.splitContainer_SatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_SatElements.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_SatElements.Name = "splitContainer_SatElements";
            this.splitContainer_SatElements.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_SatElements.Panel1
            // 
            this.splitContainer_SatElements.Panel1.Controls.Add(this.scatterXYControl_SatElements_Layers);
            // 
            // splitContainer_SatElements.Panel2
            // 
            this.splitContainer_SatElements.Panel2.Controls.Add(this.scatterXYControl_SatElements_Others);
            this.splitContainer_SatElements.Size = new System.Drawing.Size(640, 553);
            this.splitContainer_SatElements.SplitterDistance = 261;
            this.splitContainer_SatElements.TabIndex = 1;
            // 
            // scatterXYControl_SatElements_Layers
            // 
            this.scatterXYControl_SatElements_Layers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_SatElements_Layers.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_SatElements_Layers.LockHorizontalAxis = false;
            this.scatterXYControl_SatElements_Layers.LockVerticalAxis = false;
            this.scatterXYControl_SatElements_Layers.Name = "scatterXYControl_SatElements_Layers";
            this.scatterXYControl_SatElements_Layers.Size = new System.Drawing.Size(640, 261);
            this.scatterXYControl_SatElements_Layers.TabIndex = 0;
            this.scatterXYControl_SatElements_Layers.Title = "Output: Values in Elements on the 1DSat layer";
            this.scatterXYControl_SatElements_Layers.XAxisMax = 2D;
            this.scatterXYControl_SatElements_Layers.XAxisMin = 0D;
            this.scatterXYControl_SatElements_Layers.Xlabel = "X [L]";
            this.scatterXYControl_SatElements_Layers.YAxisMax = 2D;
            this.scatterXYControl_SatElements_Layers.YAxisMin = 0D;
            this.scatterXYControl_SatElements_Layers.Ylabel = "Output";
            // 
            // scatterXYControl_SatElements_Others
            // 
            this.scatterXYControl_SatElements_Others.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_SatElements_Others.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_SatElements_Others.LockHorizontalAxis = false;
            this.scatterXYControl_SatElements_Others.LockVerticalAxis = false;
            this.scatterXYControl_SatElements_Others.Name = "scatterXYControl_SatElements_Others";
            this.scatterXYControl_SatElements_Others.Size = new System.Drawing.Size(640, 288);
            this.scatterXYControl_SatElements_Others.TabIndex = 1;
            this.scatterXYControl_SatElements_Others.Title = "Output: Values in Elements on the 1DSat layer";
            this.scatterXYControl_SatElements_Others.XAxisMax = 2D;
            this.scatterXYControl_SatElements_Others.XAxisMin = 0D;
            this.scatterXYControl_SatElements_Others.Xlabel = "X [L]";
            this.scatterXYControl_SatElements_Others.YAxisMax = 2D;
            this.scatterXYControl_SatElements_Others.YAxisMin = 0D;
            this.scatterXYControl_SatElements_Others.Ylabel = "Output";
            // 
            // panel_OutputSatElements_GraphOptions
            // 
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.comboBox_SatElements_T);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.label_SatElements_T);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.button_SatElements_Update);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.button_SatElements_Clear);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.button_SatElements_AddVariable);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.comboBox_SatElements_numIS);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.label_SatElements_Variable);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.comboBox_SatElements_Variable);
            this.panel_OutputSatElements_GraphOptions.Controls.Add(this.label_SatElements_IS);
            this.panel_OutputSatElements_GraphOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutputSatElements_GraphOptions.Location = new System.Drawing.Point(643, 3);
            this.panel_OutputSatElements_GraphOptions.Name = "panel_OutputSatElements_GraphOptions";
            this.panel_OutputSatElements_GraphOptions.Size = new System.Drawing.Size(200, 553);
            this.panel_OutputSatElements_GraphOptions.TabIndex = 1;
            // 
            // comboBox_SatElements_T
            // 
            this.comboBox_SatElements_T.FormattingEnabled = true;
            this.comboBox_SatElements_T.Location = new System.Drawing.Point(136, 74);
            this.comboBox_SatElements_T.Name = "comboBox_SatElements_T";
            this.comboBox_SatElements_T.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatElements_T.TabIndex = 12;
            // 
            // label_SatElements_T
            // 
            this.label_SatElements_T.AutoSize = true;
            this.label_SatElements_T.ForeColor = System.Drawing.Color.Black;
            this.label_SatElements_T.Location = new System.Drawing.Point(3, 77);
            this.label_SatElements_T.Name = "label_SatElements_T";
            this.label_SatElements_T.Size = new System.Drawing.Size(61, 16);
            this.label_SatElements_T.TabIndex = 11;
            this.label_SatElements_T.Text = "Time (T):";
            // 
            // button_SatElements_Update
            // 
            this.button_SatElements_Update.BackColor = System.Drawing.Color.Black;
            this.button_SatElements_Update.Location = new System.Drawing.Point(6, 3);
            this.button_SatElements_Update.Name = "button_SatElements_Update";
            this.button_SatElements_Update.Size = new System.Drawing.Size(191, 23);
            this.button_SatElements_Update.TabIndex = 10;
            this.button_SatElements_Update.Text = "Update Output";
            this.button_SatElements_Update.UseVisualStyleBackColor = false;
            this.button_SatElements_Update.Click += new System.EventHandler(this.button_SatElements_Update_Click);
            // 
            // button_SatElements_Clear
            // 
            this.button_SatElements_Clear.BackColor = System.Drawing.Color.Black;
            this.button_SatElements_Clear.Location = new System.Drawing.Point(3, 189);
            this.button_SatElements_Clear.Name = "button_SatElements_Clear";
            this.button_SatElements_Clear.Size = new System.Drawing.Size(192, 23);
            this.button_SatElements_Clear.TabIndex = 9;
            this.button_SatElements_Clear.Text = "Clear Graph";
            this.button_SatElements_Clear.UseVisualStyleBackColor = false;
            this.button_SatElements_Clear.Click += new System.EventHandler(this.button_SatElements_Clear_Click);
            // 
            // button_SatElements_AddVariable
            // 
            this.button_SatElements_AddVariable.BackColor = System.Drawing.Color.Black;
            this.button_SatElements_AddVariable.Location = new System.Drawing.Point(3, 158);
            this.button_SatElements_AddVariable.Name = "button_SatElements_AddVariable";
            this.button_SatElements_AddVariable.Size = new System.Drawing.Size(192, 23);
            this.button_SatElements_AddVariable.TabIndex = 8;
            this.button_SatElements_AddVariable.Text = "Plot Variable";
            this.button_SatElements_AddVariable.UseVisualStyleBackColor = false;
            this.button_SatElements_AddVariable.Click += new System.EventHandler(this.button_SatElements_Add_Variable_Click);
            // 
            // comboBox_SatElements_numIS
            // 
            this.comboBox_SatElements_numIS.FormattingEnabled = true;
            this.comboBox_SatElements_numIS.Location = new System.Drawing.Point(136, 39);
            this.comboBox_SatElements_numIS.Name = "comboBox_SatElements_numIS";
            this.comboBox_SatElements_numIS.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatElements_numIS.TabIndex = 6;
            // 
            // label_SatElements_Variable
            // 
            this.label_SatElements_Variable.AutoSize = true;
            this.label_SatElements_Variable.ForeColor = System.Drawing.Color.Black;
            this.label_SatElements_Variable.Location = new System.Drawing.Point(4, 130);
            this.label_SatElements_Variable.Name = "label_SatElements_Variable";
            this.label_SatElements_Variable.Size = new System.Drawing.Size(109, 16);
            this.label_SatElements_Variable.TabIndex = 5;
            this.label_SatElements_Variable.Text = "Variable to show:";
            // 
            // comboBox_SatElements_Variable
            // 
            this.comboBox_SatElements_Variable.FormattingEnabled = true;
            this.comboBox_SatElements_Variable.Items.AddRange(new object[] {
            "head",
            "dhdx",
            "dhzdx",
            "qent",
            "incvoldt",
            "dqhordx",
            "dqhordx_all",
            "dqhordx_from_incvoldt",
            "dqhordx_from_incvoldt_all",
            "q",
            "q_all"});
            this.comboBox_SatElements_Variable.Location = new System.Drawing.Point(136, 127);
            this.comboBox_SatElements_Variable.Name = "comboBox_SatElements_Variable";
            this.comboBox_SatElements_Variable.Size = new System.Drawing.Size(57, 24);
            this.comboBox_SatElements_Variable.TabIndex = 4;
            // 
            // label_SatElements_IS
            // 
            this.label_SatElements_IS.AutoSize = true;
            this.label_SatElements_IS.ForeColor = System.Drawing.Color.Black;
            this.label_SatElements_IS.Location = new System.Drawing.Point(3, 42);
            this.label_SatElements_IS.Name = "label_SatElements_IS";
            this.label_SatElements_IS.Size = new System.Drawing.Size(115, 16);
            this.label_SatElements_IS.TabIndex = 1;
            this.label_SatElements_IS.Text = "Layer number (IS):";
            // 
            // tabPage_SatElements_Table
            // 
            this.tabPage_SatElements_Table.Controls.Add(this.dataGridView_OutputSatElements);
            this.tabPage_SatElements_Table.Controls.Add(this.bindingNavigator_OutputSatElements);
            this.tabPage_SatElements_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SatElements_Table.Name = "tabPage_SatElements_Table";
            this.tabPage_SatElements_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SatElements_Table.Size = new System.Drawing.Size(846, 558);
            this.tabPage_SatElements_Table.TabIndex = 0;
            this.tabPage_SatElements_Table.Text = "Table";
            this.tabPage_SatElements_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_OutputSatElements
            // 
            this.dataGridView_OutputSatElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OutputSatElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_SatElements_ID});
            this.dataGridView_OutputSatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OutputSatElements.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_OutputSatElements.Name = "dataGridView_OutputSatElements";
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_OutputSatElements.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_OutputSatElements.Size = new System.Drawing.Size(840, 527);
            this.dataGridView_OutputSatElements.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn_SatElements_ID
            // 
            this.dataGridViewTextBoxColumn_SatElements_ID.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn_SatElements_ID.HeaderText = "IDconstraint";
            this.dataGridViewTextBoxColumn_SatElements_ID.Name = "dataGridViewTextBoxColumn_SatElements_ID";
            // 
            // bindingNavigator_OutputSatElements
            // 
            this.bindingNavigator_OutputSatElements.AddNewItem = this.bindingNavigator_SatElements_AddNewItem;
            this.bindingNavigator_OutputSatElements.CountItem = this.bindingNavigator_SatElements_CountItem;
            this.bindingNavigator_OutputSatElements.DeleteItem = this.bindingNavigator_SatElements_DeleteItem;
            this.bindingNavigator_OutputSatElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigator_SatElements_MoveFirstItem,
            this.bindingNavigator_SatElements_MovePreviousItem,
            this.bindingNavigator_SatElements_Separator,
            this.bindingNavigator_SatElements_PositionItem,
            this.bindingNavigator_SatElements_CountItem,
            this.bindingNavigator_SatElements_Separator1,
            this.bindingNavigator_SatElements_MoveNextItem,
            this.bindingNavigator_SatElements_MoveLastItem,
            this.bindingNavigator_SatElements_Separator2,
            this.bindingNavigator_SatElements_AddNewItem,
            this.bindingNavigator_SatElements_DeleteItem});
            this.bindingNavigator_OutputSatElements.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator_OutputSatElements.MoveFirstItem = this.bindingNavigator_SatElements_MoveFirstItem;
            this.bindingNavigator_OutputSatElements.MoveLastItem = this.bindingNavigator_SatElements_MoveLastItem;
            this.bindingNavigator_OutputSatElements.MoveNextItem = this.bindingNavigator_SatElements_MoveNextItem;
            this.bindingNavigator_OutputSatElements.MovePreviousItem = this.bindingNavigator_SatElements_MovePreviousItem;
            this.bindingNavigator_OutputSatElements.Name = "bindingNavigator_OutputSatElements";
            this.bindingNavigator_OutputSatElements.PositionItem = this.bindingNavigator_SatElements_PositionItem;
            this.bindingNavigator_OutputSatElements.Size = new System.Drawing.Size(840, 25);
            this.bindingNavigator_OutputSatElements.TabIndex = 2;
            this.bindingNavigator_OutputSatElements.Text = "bindingNavigator1";
            // 
            // bindingNavigator_SatElements_AddNewItem
            // 
            this.bindingNavigator_SatElements_AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_AddNewItem.Image")));
            this.bindingNavigator_SatElements_AddNewItem.Name = "bindingNavigator_SatElements_AddNewItem";
            this.bindingNavigator_SatElements_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_AddNewItem.Text = "Add new";
            // 
            // bindingNavigator_SatElements_CountItem
            // 
            this.bindingNavigator_SatElements_CountItem.ForeColor = System.Drawing.Color.Black;
            this.bindingNavigator_SatElements_CountItem.Name = "bindingNavigator_SatElements_CountItem";
            this.bindingNavigator_SatElements_CountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigator_SatElements_CountItem.Text = "of {0}";
            this.bindingNavigator_SatElements_CountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigator_SatElements_DeleteItem
            // 
            this.bindingNavigator_SatElements_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_DeleteItem.Image")));
            this.bindingNavigator_SatElements_DeleteItem.Name = "bindingNavigator_SatElements_DeleteItem";
            this.bindingNavigator_SatElements_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_DeleteItem.Text = "Delete";
            // 
            // bindingNavigator_SatElements_MoveFirstItem
            // 
            this.bindingNavigator_SatElements_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_MoveFirstItem.Image")));
            this.bindingNavigator_SatElements_MoveFirstItem.Name = "bindingNavigator_SatElements_MoveFirstItem";
            this.bindingNavigator_SatElements_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_MoveFirstItem.Text = "Move first";
            // 
            // bindingNavigator_SatElements_MovePreviousItem
            // 
            this.bindingNavigator_SatElements_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_MovePreviousItem.Image")));
            this.bindingNavigator_SatElements_MovePreviousItem.Name = "bindingNavigator_SatElements_MovePreviousItem";
            this.bindingNavigator_SatElements_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_MovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigator_SatElements_Separator
            // 
            this.bindingNavigator_SatElements_Separator.Name = "bindingNavigator_SatElements_Separator";
            this.bindingNavigator_SatElements_Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_SatElements_PositionItem
            // 
            this.bindingNavigator_SatElements_PositionItem.AccessibleName = "Position";
            this.bindingNavigator_SatElements_PositionItem.AutoSize = false;
            this.bindingNavigator_SatElements_PositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigator_SatElements_PositionItem.Name = "bindingNavigator_SatElements_PositionItem";
            this.bindingNavigator_SatElements_PositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigator_SatElements_PositionItem.Text = "0";
            this.bindingNavigator_SatElements_PositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigator_SatElements_Separator1
            // 
            this.bindingNavigator_SatElements_Separator1.Name = "bindingNavigator_SatElements_Separator1";
            this.bindingNavigator_SatElements_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigator_SatElements_MoveNextItem
            // 
            this.bindingNavigator_SatElements_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_MoveNextItem.Image")));
            this.bindingNavigator_SatElements_MoveNextItem.Name = "bindingNavigator_SatElements_MoveNextItem";
            this.bindingNavigator_SatElements_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_MoveNextItem.Text = "Move next";
            // 
            // bindingNavigator_SatElements_MoveLastItem
            // 
            this.bindingNavigator_SatElements_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigator_SatElements_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigator_SatElements_MoveLastItem.Image")));
            this.bindingNavigator_SatElements_MoveLastItem.Name = "bindingNavigator_SatElements_MoveLastItem";
            this.bindingNavigator_SatElements_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigator_SatElements_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigator_SatElements_MoveLastItem.Text = "Move last";
            // 
            // bindingNavigator_SatElements_Separator2
            // 
            this.bindingNavigator_SatElements_Separator2.Name = "bindingNavigator_SatElements_Separator2";
            this.bindingNavigator_SatElements_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel_OutputUnsatNodes
            // 
            this.panel_OutputUnsatNodes.Controls.Add(this.tabControl_OutputUnsatNodes);
            this.panel_OutputUnsatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputUnsatNodes.Location = new System.Drawing.Point(200, 71);
            this.panel_OutputUnsatNodes.Name = "panel_OutputUnsatNodes";
            this.panel_OutputUnsatNodes.Size = new System.Drawing.Size(854, 588);
            this.panel_OutputUnsatNodes.TabIndex = 12;
            // 
            // tabControl_OutputUnsatNodes
            // 
            this.tabControl_OutputUnsatNodes.Controls.Add(this.tabPage_UnsatNodes_Graph);
            this.tabControl_OutputUnsatNodes.Controls.Add(this.tabPage_UnsatNodes_Table);
            this.tabControl_OutputUnsatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_OutputUnsatNodes.Location = new System.Drawing.Point(0, 0);
            this.tabControl_OutputUnsatNodes.Name = "tabControl_OutputUnsatNodes";
            this.tabControl_OutputUnsatNodes.SelectedIndex = 0;
            this.tabControl_OutputUnsatNodes.Size = new System.Drawing.Size(854, 588);
            this.tabControl_OutputUnsatNodes.TabIndex = 0;
            // 
            // tabPage_UnsatNodes_Graph
            // 
            this.tabPage_UnsatNodes_Graph.Controls.Add(this.panel_OutputUnsatNodes_Graph);
            this.tabPage_UnsatNodes_Graph.Controls.Add(this.panel_OutputUnsatNodes_GraphOptions);
            this.tabPage_UnsatNodes_Graph.Location = new System.Drawing.Point(4, 25);
            this.tabPage_UnsatNodes_Graph.Name = "tabPage_UnsatNodes_Graph";
            this.tabPage_UnsatNodes_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UnsatNodes_Graph.Size = new System.Drawing.Size(846, 559);
            this.tabPage_UnsatNodes_Graph.TabIndex = 1;
            this.tabPage_UnsatNodes_Graph.Text = "Graphic";
            this.tabPage_UnsatNodes_Graph.UseVisualStyleBackColor = true;
            // 
            // panel_OutputUnsatNodes_Graph
            // 
            this.panel_OutputUnsatNodes_Graph.Controls.Add(this.scatterXYControl_UnsatNodes);
            this.panel_OutputUnsatNodes_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputUnsatNodes_Graph.Location = new System.Drawing.Point(3, 3);
            this.panel_OutputUnsatNodes_Graph.Name = "panel_OutputUnsatNodes_Graph";
            this.panel_OutputUnsatNodes_Graph.Size = new System.Drawing.Size(640, 553);
            this.panel_OutputUnsatNodes_Graph.TabIndex = 0;
            // 
            // scatterXYControl_UnsatNodes
            // 
            this.scatterXYControl_UnsatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_UnsatNodes.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_UnsatNodes.LockHorizontalAxis = false;
            this.scatterXYControl_UnsatNodes.LockVerticalAxis = false;
            this.scatterXYControl_UnsatNodes.Name = "scatterXYControl_UnsatNodes";
            this.scatterXYControl_UnsatNodes.Size = new System.Drawing.Size(640, 553);
            this.scatterXYControl_UnsatNodes.TabIndex = 0;
            this.scatterXYControl_UnsatNodes.Title = "Output: Values at nodes on the 1DUnsat layer";
            this.scatterXYControl_UnsatNodes.XAxisMax = 1D;
            this.scatterXYControl_UnsatNodes.XAxisMin = -1D;
            this.scatterXYControl_UnsatNodes.Xlabel = "Output";
            this.scatterXYControl_UnsatNodes.YAxisMax = 2D;
            this.scatterXYControl_UnsatNodes.YAxisMin = 0D;
            this.scatterXYControl_UnsatNodes.Ylabel = "Y coord [L]";
            // 
            // panel_OutputUnsatNodes_GraphOptions
            // 
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.comboBox_UnsatNodes_T);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.label_UnsatNodes_T);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.button_UnsatNodes_Update);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.button_UnsatNodes_Clear);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.button_UnsatNodes_AddVariable);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.comboBox_UnsatNodes_numIU);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.label_UnsatNodes_Variable);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.comboBox_UnsatNodes_Variable);
            this.panel_OutputUnsatNodes_GraphOptions.Controls.Add(this.label_UnsatNodes_IU);
            this.panel_OutputUnsatNodes_GraphOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutputUnsatNodes_GraphOptions.Location = new System.Drawing.Point(643, 3);
            this.panel_OutputUnsatNodes_GraphOptions.Name = "panel_OutputUnsatNodes_GraphOptions";
            this.panel_OutputUnsatNodes_GraphOptions.Size = new System.Drawing.Size(200, 553);
            this.panel_OutputUnsatNodes_GraphOptions.TabIndex = 1;
            // 
            // comboBox_UnsatNodes_T
            // 
            this.comboBox_UnsatNodes_T.FormattingEnabled = true;
            this.comboBox_UnsatNodes_T.Location = new System.Drawing.Point(136, 74);
            this.comboBox_UnsatNodes_T.Name = "comboBox_UnsatNodes_T";
            this.comboBox_UnsatNodes_T.Size = new System.Drawing.Size(57, 24);
            this.comboBox_UnsatNodes_T.TabIndex = 12;
            // 
            // label_UnsatNodes_T
            // 
            this.label_UnsatNodes_T.AutoSize = true;
            this.label_UnsatNodes_T.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatNodes_T.Location = new System.Drawing.Point(3, 77);
            this.label_UnsatNodes_T.Name = "label_UnsatNodes_T";
            this.label_UnsatNodes_T.Size = new System.Drawing.Size(61, 16);
            this.label_UnsatNodes_T.TabIndex = 11;
            this.label_UnsatNodes_T.Text = "Time (T):";
            // 
            // button_UnsatNodes_Update
            // 
            this.button_UnsatNodes_Update.BackColor = System.Drawing.Color.Black;
            this.button_UnsatNodes_Update.Location = new System.Drawing.Point(6, 3);
            this.button_UnsatNodes_Update.Name = "button_UnsatNodes_Update";
            this.button_UnsatNodes_Update.Size = new System.Drawing.Size(191, 23);
            this.button_UnsatNodes_Update.TabIndex = 10;
            this.button_UnsatNodes_Update.Text = "Update Output";
            this.button_UnsatNodes_Update.UseVisualStyleBackColor = false;
            this.button_UnsatNodes_Update.Click += new System.EventHandler(this.button_UnsatNodes_Update_Click);
            // 
            // button_UnsatNodes_Clear
            // 
            this.button_UnsatNodes_Clear.BackColor = System.Drawing.Color.Black;
            this.button_UnsatNodes_Clear.Location = new System.Drawing.Point(3, 189);
            this.button_UnsatNodes_Clear.Name = "button_UnsatNodes_Clear";
            this.button_UnsatNodes_Clear.Size = new System.Drawing.Size(192, 23);
            this.button_UnsatNodes_Clear.TabIndex = 9;
            this.button_UnsatNodes_Clear.Text = "Clear Graph";
            this.button_UnsatNodes_Clear.UseVisualStyleBackColor = false;
            this.button_UnsatNodes_Clear.Click += new System.EventHandler(this.button_UnsatNodes_Clear_Click);
            // 
            // button_UnsatNodes_AddVariable
            // 
            this.button_UnsatNodes_AddVariable.BackColor = System.Drawing.Color.Black;
            this.button_UnsatNodes_AddVariable.Location = new System.Drawing.Point(3, 158);
            this.button_UnsatNodes_AddVariable.Name = "button_UnsatNodes_AddVariable";
            this.button_UnsatNodes_AddVariable.Size = new System.Drawing.Size(192, 23);
            this.button_UnsatNodes_AddVariable.TabIndex = 8;
            this.button_UnsatNodes_AddVariable.Text = "Plot Variable";
            this.button_UnsatNodes_AddVariable.UseVisualStyleBackColor = false;
            this.button_UnsatNodes_AddVariable.Click += new System.EventHandler(this.button_UnsatNodes_Add_Variable_Click);
            // 
            // comboBox_UnsatNodes_numIU
            // 
            this.comboBox_UnsatNodes_numIU.FormattingEnabled = true;
            this.comboBox_UnsatNodes_numIU.Location = new System.Drawing.Point(136, 39);
            this.comboBox_UnsatNodes_numIU.Name = "comboBox_UnsatNodes_numIU";
            this.comboBox_UnsatNodes_numIU.Size = new System.Drawing.Size(57, 24);
            this.comboBox_UnsatNodes_numIU.TabIndex = 6;
            this.comboBox_UnsatNodes_numIU.SelectedIndexChanged += new System.EventHandler(this.comboBox_UnsatNodes_numIU_SelectedIndexChanged);
            // 
            // label_UnsatNodes_Variable
            // 
            this.label_UnsatNodes_Variable.AutoSize = true;
            this.label_UnsatNodes_Variable.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatNodes_Variable.Location = new System.Drawing.Point(4, 130);
            this.label_UnsatNodes_Variable.Name = "label_UnsatNodes_Variable";
            this.label_UnsatNodes_Variable.Size = new System.Drawing.Size(109, 16);
            this.label_UnsatNodes_Variable.TabIndex = 5;
            this.label_UnsatNodes_Variable.Text = "Variable to show:";
            // 
            // comboBox_UnsatNodes_Variable
            // 
            this.comboBox_UnsatNodes_Variable.FormattingEnabled = true;
            this.comboBox_UnsatNodes_Variable.Items.AddRange(new object[] {
            "Head",
            "Volumentric Water Content"});
            this.comboBox_UnsatNodes_Variable.Location = new System.Drawing.Point(119, 127);
            this.comboBox_UnsatNodes_Variable.Name = "comboBox_UnsatNodes_Variable";
            this.comboBox_UnsatNodes_Variable.Size = new System.Drawing.Size(74, 24);
            this.comboBox_UnsatNodes_Variable.TabIndex = 4;
            // 
            // label_UnsatNodes_IU
            // 
            this.label_UnsatNodes_IU.AutoSize = true;
            this.label_UnsatNodes_IU.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatNodes_IU.Location = new System.Drawing.Point(3, 42);
            this.label_UnsatNodes_IU.Name = "label_UnsatNodes_IU";
            this.label_UnsatNodes_IU.Size = new System.Drawing.Size(127, 16);
            this.label_UnsatNodes_IU.TabIndex = 1;
            this.label_UnsatNodes_IU.Text = "Vertical Module (IU):";
            // 
            // tabPage_UnsatNodes_Table
            // 
            this.tabPage_UnsatNodes_Table.Controls.Add(this.dataGridView_OutputUnsatNodes);
            this.tabPage_UnsatNodes_Table.Controls.Add(this.bindingNavigator_OutputUnsatNodes);
            this.tabPage_UnsatNodes_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_UnsatNodes_Table.Name = "tabPage_UnsatNodes_Table";
            this.tabPage_UnsatNodes_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UnsatNodes_Table.Size = new System.Drawing.Size(846, 558);
            this.tabPage_UnsatNodes_Table.TabIndex = 0;
            this.tabPage_UnsatNodes_Table.Text = "Table";
            this.tabPage_UnsatNodes_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_OutputUnsatNodes
            // 
            this.dataGridView_OutputUnsatNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OutputUnsatNodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_UnsatNodes_ID});
            this.dataGridView_OutputUnsatNodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OutputUnsatNodes.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_OutputUnsatNodes.Name = "dataGridView_OutputUnsatNodes";
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_OutputUnsatNodes.RowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView_OutputUnsatNodes.Size = new System.Drawing.Size(840, 527);
            this.dataGridView_OutputUnsatNodes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn_UnsatNodes_ID
            // 
            this.dataGridViewTextBoxColumn_UnsatNodes_ID.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn_UnsatNodes_ID.HeaderText = "IDconstraint";
            this.dataGridViewTextBoxColumn_UnsatNodes_ID.Name = "dataGridViewTextBoxColumn_UnsatNodes_ID";
            // 
            // bindingNavigator_OutputUnsatNodes
            // 
            this.bindingNavigator_OutputUnsatNodes.AddNewItem = this.toolStripButton_UnsatNodes_AddNewItem;
            this.bindingNavigator_OutputUnsatNodes.CountItem = this.toolStripLabel_UnsatNodes_CountItem;
            this.bindingNavigator_OutputUnsatNodes.DeleteItem = this.toolStripButton_UnsatNodes_DeleteItem;
            this.bindingNavigator_OutputUnsatNodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_UnsatNodes_MoveFirstItem,
            this.toolStripButton_UnsatNodes_MovePreviousItem,
            this.toolStripSeparator_UnsatNodes_Separator,
            this.toolStripTextBox_UnsatNodes_PositionItem,
            this.toolStripLabel_UnsatNodes_CountItem,
            this.toolStripSeparator_UnsatNodes_Separator1,
            this.toolStripButton_UnsatNodes_MoveNextItem,
            this.toolStripButton_UnsatNodes_MoveLastItem,
            this.toolStripSeparator_UnstaNodes_Separator2,
            this.toolStripButton_UnsatNodes_AddNewItem,
            this.toolStripButton_UnsatNodes_DeleteItem});
            this.bindingNavigator_OutputUnsatNodes.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator_OutputUnsatNodes.MoveFirstItem = this.toolStripButton_UnsatNodes_MoveFirstItem;
            this.bindingNavigator_OutputUnsatNodes.MoveLastItem = this.toolStripButton_UnsatNodes_MoveLastItem;
            this.bindingNavigator_OutputUnsatNodes.MoveNextItem = this.toolStripButton_UnsatNodes_MoveNextItem;
            this.bindingNavigator_OutputUnsatNodes.MovePreviousItem = this.toolStripButton_UnsatNodes_MovePreviousItem;
            this.bindingNavigator_OutputUnsatNodes.Name = "bindingNavigator_OutputUnsatNodes";
            this.bindingNavigator_OutputUnsatNodes.PositionItem = this.toolStripTextBox_UnsatNodes_PositionItem;
            this.bindingNavigator_OutputUnsatNodes.Size = new System.Drawing.Size(840, 25);
            this.bindingNavigator_OutputUnsatNodes.TabIndex = 2;
            this.bindingNavigator_OutputUnsatNodes.Text = "bindingNavigator1";
            // 
            // toolStripButton_UnsatNodes_AddNewItem
            // 
            this.toolStripButton_UnsatNodes_AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_AddNewItem.Image")));
            this.toolStripButton_UnsatNodes_AddNewItem.Name = "toolStripButton_UnsatNodes_AddNewItem";
            this.toolStripButton_UnsatNodes_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_AddNewItem.Text = "Add new";
            // 
            // toolStripLabel_UnsatNodes_CountItem
            // 
            this.toolStripLabel_UnsatNodes_CountItem.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel_UnsatNodes_CountItem.Name = "toolStripLabel_UnsatNodes_CountItem";
            this.toolStripLabel_UnsatNodes_CountItem.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel_UnsatNodes_CountItem.Text = "of {0}";
            this.toolStripLabel_UnsatNodes_CountItem.ToolTipText = "Total number of items";
            // 
            // toolStripButton_UnsatNodes_DeleteItem
            // 
            this.toolStripButton_UnsatNodes_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_DeleteItem.Image")));
            this.toolStripButton_UnsatNodes_DeleteItem.Name = "toolStripButton_UnsatNodes_DeleteItem";
            this.toolStripButton_UnsatNodes_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_DeleteItem.Text = "Delete";
            // 
            // toolStripButton_UnsatNodes_MoveFirstItem
            // 
            this.toolStripButton_UnsatNodes_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_MoveFirstItem.Image")));
            this.toolStripButton_UnsatNodes_MoveFirstItem.Name = "toolStripButton_UnsatNodes_MoveFirstItem";
            this.toolStripButton_UnsatNodes_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_MoveFirstItem.Text = "Move first";
            // 
            // toolStripButton_UnsatNodes_MovePreviousItem
            // 
            this.toolStripButton_UnsatNodes_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_MovePreviousItem.Image")));
            this.toolStripButton_UnsatNodes_MovePreviousItem.Name = "toolStripButton_UnsatNodes_MovePreviousItem";
            this.toolStripButton_UnsatNodes_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_MovePreviousItem.Text = "Move previous";
            // 
            // toolStripSeparator_UnsatNodes_Separator
            // 
            this.toolStripSeparator_UnsatNodes_Separator.Name = "toolStripSeparator_UnsatNodes_Separator";
            this.toolStripSeparator_UnsatNodes_Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox_UnsatNodes_PositionItem
            // 
            this.toolStripTextBox_UnsatNodes_PositionItem.AccessibleName = "Position";
            this.toolStripTextBox_UnsatNodes_PositionItem.AutoSize = false;
            this.toolStripTextBox_UnsatNodes_PositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_UnsatNodes_PositionItem.Name = "toolStripTextBox_UnsatNodes_PositionItem";
            this.toolStripTextBox_UnsatNodes_PositionItem.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox_UnsatNodes_PositionItem.Text = "0";
            this.toolStripTextBox_UnsatNodes_PositionItem.ToolTipText = "Current position";
            // 
            // toolStripSeparator_UnsatNodes_Separator1
            // 
            this.toolStripSeparator_UnsatNodes_Separator1.Name = "toolStripSeparator_UnsatNodes_Separator1";
            this.toolStripSeparator_UnsatNodes_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_UnsatNodes_MoveNextItem
            // 
            this.toolStripButton_UnsatNodes_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_MoveNextItem.Image")));
            this.toolStripButton_UnsatNodes_MoveNextItem.Name = "toolStripButton_UnsatNodes_MoveNextItem";
            this.toolStripButton_UnsatNodes_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_MoveNextItem.Text = "Move next";
            // 
            // toolStripButton_UnsatNodes_MoveLastItem
            // 
            this.toolStripButton_UnsatNodes_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatNodes_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatNodes_MoveLastItem.Image")));
            this.toolStripButton_UnsatNodes_MoveLastItem.Name = "toolStripButton_UnsatNodes_MoveLastItem";
            this.toolStripButton_UnsatNodes_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatNodes_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatNodes_MoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator_UnstaNodes_Separator2
            // 
            this.toolStripSeparator_UnstaNodes_Separator2.Name = "toolStripSeparator_UnstaNodes_Separator2";
            this.toolStripSeparator_UnstaNodes_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel_OutputUnsatElements
            // 
            this.panel_OutputUnsatElements.Controls.Add(this.tabControl_OutputUnsatElements);
            this.panel_OutputUnsatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputUnsatElements.Location = new System.Drawing.Point(200, 71);
            this.panel_OutputUnsatElements.Name = "panel_OutputUnsatElements";
            this.panel_OutputUnsatElements.Size = new System.Drawing.Size(854, 588);
            this.panel_OutputUnsatElements.TabIndex = 13;
            // 
            // tabControl_OutputUnsatElements
            // 
            this.tabControl_OutputUnsatElements.Controls.Add(this.tabPage_UnsatElements_Graph);
            this.tabControl_OutputUnsatElements.Controls.Add(this.tabPage_UnsatElements_Table);
            this.tabControl_OutputUnsatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_OutputUnsatElements.Location = new System.Drawing.Point(0, 0);
            this.tabControl_OutputUnsatElements.Name = "tabControl_OutputUnsatElements";
            this.tabControl_OutputUnsatElements.SelectedIndex = 0;
            this.tabControl_OutputUnsatElements.Size = new System.Drawing.Size(854, 588);
            this.tabControl_OutputUnsatElements.TabIndex = 0;
            // 
            // tabPage_UnsatElements_Graph
            // 
            this.tabPage_UnsatElements_Graph.Controls.Add(this.panel_OutputUnsatElements_Graph);
            this.tabPage_UnsatElements_Graph.Controls.Add(this.panel_OutputUnsatElements_GraphOptions);
            this.tabPage_UnsatElements_Graph.Location = new System.Drawing.Point(4, 25);
            this.tabPage_UnsatElements_Graph.Name = "tabPage_UnsatElements_Graph";
            this.tabPage_UnsatElements_Graph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UnsatElements_Graph.Size = new System.Drawing.Size(846, 559);
            this.tabPage_UnsatElements_Graph.TabIndex = 1;
            this.tabPage_UnsatElements_Graph.Text = "Graphic";
            this.tabPage_UnsatElements_Graph.UseVisualStyleBackColor = true;
            // 
            // panel_OutputUnsatElements_Graph
            // 
            this.panel_OutputUnsatElements_Graph.Controls.Add(this.scatterXYControl_UnsatElements);
            this.panel_OutputUnsatElements_Graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_OutputUnsatElements_Graph.Location = new System.Drawing.Point(3, 3);
            this.panel_OutputUnsatElements_Graph.Name = "panel_OutputUnsatElements_Graph";
            this.panel_OutputUnsatElements_Graph.Size = new System.Drawing.Size(640, 553);
            this.panel_OutputUnsatElements_Graph.TabIndex = 0;
            // 
            // scatterXYControl_UnsatElements
            // 
            this.scatterXYControl_UnsatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterXYControl_UnsatElements.Location = new System.Drawing.Point(0, 0);
            this.scatterXYControl_UnsatElements.LockHorizontalAxis = false;
            this.scatterXYControl_UnsatElements.LockVerticalAxis = false;
            this.scatterXYControl_UnsatElements.Name = "scatterXYControl_UnsatElements";
            this.scatterXYControl_UnsatElements.Size = new System.Drawing.Size(640, 553);
            this.scatterXYControl_UnsatElements.TabIndex = 0;
            this.scatterXYControl_UnsatElements.Title = "Output: Values at nodes on the 1DUnsat layer";
            this.scatterXYControl_UnsatElements.XAxisMax = 1D;
            this.scatterXYControl_UnsatElements.XAxisMin = -1D;
            this.scatterXYControl_UnsatElements.Xlabel = "Output";
            this.scatterXYControl_UnsatElements.YAxisMax = 2D;
            this.scatterXYControl_UnsatElements.YAxisMin = 0D;
            this.scatterXYControl_UnsatElements.Ylabel = "Y coord [L]";
            // 
            // panel_OutputUnsatElements_GraphOptions
            // 
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.comboBox_UnsatElements_T);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.label_UnsatElements_T);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.button_UnsatElements_Update);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.button_UnsatElements_Clear);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.button_UnsatElements_AddVariable);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.comboBox_UnsatElements_numIU);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.label_UnsatElements_Variable);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.comboBox_UnsatElements_Variable);
            this.panel_OutputUnsatElements_GraphOptions.Controls.Add(this.label_UnsatElements_IU);
            this.panel_OutputUnsatElements_GraphOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutputUnsatElements_GraphOptions.Location = new System.Drawing.Point(643, 3);
            this.panel_OutputUnsatElements_GraphOptions.Name = "panel_OutputUnsatElements_GraphOptions";
            this.panel_OutputUnsatElements_GraphOptions.Size = new System.Drawing.Size(200, 553);
            this.panel_OutputUnsatElements_GraphOptions.TabIndex = 1;
            // 
            // comboBox_UnsatElements_T
            // 
            this.comboBox_UnsatElements_T.FormattingEnabled = true;
            this.comboBox_UnsatElements_T.Location = new System.Drawing.Point(136, 74);
            this.comboBox_UnsatElements_T.Name = "comboBox_UnsatElements_T";
            this.comboBox_UnsatElements_T.Size = new System.Drawing.Size(57, 24);
            this.comboBox_UnsatElements_T.TabIndex = 12;
            // 
            // label_UnsatElements_T
            // 
            this.label_UnsatElements_T.AutoSize = true;
            this.label_UnsatElements_T.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatElements_T.Location = new System.Drawing.Point(3, 77);
            this.label_UnsatElements_T.Name = "label_UnsatElements_T";
            this.label_UnsatElements_T.Size = new System.Drawing.Size(61, 16);
            this.label_UnsatElements_T.TabIndex = 11;
            this.label_UnsatElements_T.Text = "Time (T):";
            // 
            // button_UnsatElements_Update
            // 
            this.button_UnsatElements_Update.BackColor = System.Drawing.Color.Black;
            this.button_UnsatElements_Update.Location = new System.Drawing.Point(6, 3);
            this.button_UnsatElements_Update.Name = "button_UnsatElements_Update";
            this.button_UnsatElements_Update.Size = new System.Drawing.Size(191, 23);
            this.button_UnsatElements_Update.TabIndex = 10;
            this.button_UnsatElements_Update.Text = "Update Output";
            this.button_UnsatElements_Update.UseVisualStyleBackColor = false;
            this.button_UnsatElements_Update.Click += new System.EventHandler(this.button_UnsatElements_Update_Click);
            // 
            // button_UnsatElements_Clear
            // 
            this.button_UnsatElements_Clear.BackColor = System.Drawing.Color.Black;
            this.button_UnsatElements_Clear.Location = new System.Drawing.Point(3, 189);
            this.button_UnsatElements_Clear.Name = "button_UnsatElements_Clear";
            this.button_UnsatElements_Clear.Size = new System.Drawing.Size(192, 23);
            this.button_UnsatElements_Clear.TabIndex = 9;
            this.button_UnsatElements_Clear.Text = "Clear Graph";
            this.button_UnsatElements_Clear.UseVisualStyleBackColor = false;
            this.button_UnsatElements_Clear.Click += new System.EventHandler(this.button_UnsatElements_Clear_Click);
            // 
            // button_UnsatElements_AddVariable
            // 
            this.button_UnsatElements_AddVariable.BackColor = System.Drawing.Color.Black;
            this.button_UnsatElements_AddVariable.Location = new System.Drawing.Point(3, 158);
            this.button_UnsatElements_AddVariable.Name = "button_UnsatElements_AddVariable";
            this.button_UnsatElements_AddVariable.Size = new System.Drawing.Size(192, 23);
            this.button_UnsatElements_AddVariable.TabIndex = 8;
            this.button_UnsatElements_AddVariable.Text = "Plot Variable";
            this.button_UnsatElements_AddVariable.UseVisualStyleBackColor = false;
            this.button_UnsatElements_AddVariable.Click += new System.EventHandler(this.button_UnsatElements_Add_Variable_Click);
            // 
            // comboBox_UnsatElements_numIU
            // 
            this.comboBox_UnsatElements_numIU.FormattingEnabled = true;
            this.comboBox_UnsatElements_numIU.Location = new System.Drawing.Point(136, 39);
            this.comboBox_UnsatElements_numIU.Name = "comboBox_UnsatElements_numIU";
            this.comboBox_UnsatElements_numIU.Size = new System.Drawing.Size(57, 24);
            this.comboBox_UnsatElements_numIU.TabIndex = 6;
            this.comboBox_UnsatElements_numIU.SelectedIndexChanged += new System.EventHandler(this.comboBox_UnsatElements_numIU_SelectedIndexChanged);
            // 
            // label_UnsatElements_Variable
            // 
            this.label_UnsatElements_Variable.AutoSize = true;
            this.label_UnsatElements_Variable.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatElements_Variable.Location = new System.Drawing.Point(4, 130);
            this.label_UnsatElements_Variable.Name = "label_UnsatElements_Variable";
            this.label_UnsatElements_Variable.Size = new System.Drawing.Size(109, 16);
            this.label_UnsatElements_Variable.TabIndex = 5;
            this.label_UnsatElements_Variable.Text = "Variable to show:";
            // 
            // comboBox_UnsatElements_Variable
            // 
            this.comboBox_UnsatElements_Variable.FormattingEnabled = true;
            this.comboBox_UnsatElements_Variable.Items.AddRange(new object[] {
            "Head",
            "Volumetric Water Content",
            "qent",
            "qsal",
            "qmed",
            "incvoldt",
            "k",
            "dhdx",
            "dhxdx"});
            this.comboBox_UnsatElements_Variable.Location = new System.Drawing.Point(119, 127);
            this.comboBox_UnsatElements_Variable.Name = "comboBox_UnsatElements_Variable";
            this.comboBox_UnsatElements_Variable.Size = new System.Drawing.Size(74, 24);
            this.comboBox_UnsatElements_Variable.TabIndex = 4;
            // 
            // label_UnsatElements_IU
            // 
            this.label_UnsatElements_IU.AutoSize = true;
            this.label_UnsatElements_IU.ForeColor = System.Drawing.Color.Black;
            this.label_UnsatElements_IU.Location = new System.Drawing.Point(3, 42);
            this.label_UnsatElements_IU.Name = "label_UnsatElements_IU";
            this.label_UnsatElements_IU.Size = new System.Drawing.Size(127, 16);
            this.label_UnsatElements_IU.TabIndex = 1;
            this.label_UnsatElements_IU.Text = "Vertical Module (IU):";
            // 
            // tabPage_UnsatElements_Table
            // 
            this.tabPage_UnsatElements_Table.Controls.Add(this.dataGridView_OutputUnsatElements);
            this.tabPage_UnsatElements_Table.Controls.Add(this.bindingNavigator_OutputUnsatElements);
            this.tabPage_UnsatElements_Table.Location = new System.Drawing.Point(4, 22);
            this.tabPage_UnsatElements_Table.Name = "tabPage_UnsatElements_Table";
            this.tabPage_UnsatElements_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_UnsatElements_Table.Size = new System.Drawing.Size(846, 558);
            this.tabPage_UnsatElements_Table.TabIndex = 0;
            this.tabPage_UnsatElements_Table.Text = "Table";
            this.tabPage_UnsatElements_Table.UseVisualStyleBackColor = true;
            // 
            // dataGridView_OutputUnsatElements
            // 
            this.dataGridView_OutputUnsatElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OutputUnsatElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_OutputUnsatElements_ID});
            this.dataGridView_OutputUnsatElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_OutputUnsatElements.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_OutputUnsatElements.Name = "dataGridView_OutputUnsatElements";
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_OutputUnsatElements.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView_OutputUnsatElements.Size = new System.Drawing.Size(840, 527);
            this.dataGridView_OutputUnsatElements.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn_OutputUnsatElements_ID
            // 
            this.dataGridViewTextBoxColumn_OutputUnsatElements_ID.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn_OutputUnsatElements_ID.HeaderText = "IDconstraint";
            this.dataGridViewTextBoxColumn_OutputUnsatElements_ID.Name = "dataGridViewTextBoxColumn_OutputUnsatElements_ID";
            // 
            // bindingNavigator_OutputUnsatElements
            // 
            this.bindingNavigator_OutputUnsatElements.AddNewItem = this.toolStripButton_UnsatElements_AddNewItem;
            this.bindingNavigator_OutputUnsatElements.CountItem = this.toolStripLabel_UnsatElements_CountItem;
            this.bindingNavigator_OutputUnsatElements.DeleteItem = this.toolStripButton_UnsatElements_DeleteItem;
            this.bindingNavigator_OutputUnsatElements.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_UnsatElements_MoveFirstItem,
            this.toolStripButton_UnsatElements_MovePreviousItem,
            this.toolStripSeparator_UnsatElements_Separator,
            this.toolStripTextBox_UnsatElements_PositionItem,
            this.toolStripLabel_UnsatElements_CountItem,
            this.toolStripSeparator__UnsatElements_Separator1,
            this.toolStripButton_UnsatElements_MoveNextItem,
            this.toolStripButton_UnsatElements_MoveLastItem,
            this.toolStripSeparator_UnsatElements_Separator2,
            this.toolStripButton_UnsatElements_AddNewItem,
            this.toolStripButton_UnsatElements_DeleteItem});
            this.bindingNavigator_OutputUnsatElements.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator_OutputUnsatElements.MoveFirstItem = this.toolStripButton_UnsatElements_MoveFirstItem;
            this.bindingNavigator_OutputUnsatElements.MoveLastItem = this.toolStripButton_UnsatElements_MoveLastItem;
            this.bindingNavigator_OutputUnsatElements.MoveNextItem = this.toolStripButton_UnsatElements_MoveNextItem;
            this.bindingNavigator_OutputUnsatElements.MovePreviousItem = this.toolStripButton_UnsatElements_MovePreviousItem;
            this.bindingNavigator_OutputUnsatElements.Name = "bindingNavigator_OutputUnsatElements";
            this.bindingNavigator_OutputUnsatElements.PositionItem = this.toolStripTextBox_UnsatElements_PositionItem;
            this.bindingNavigator_OutputUnsatElements.Size = new System.Drawing.Size(840, 25);
            this.bindingNavigator_OutputUnsatElements.TabIndex = 2;
            this.bindingNavigator_OutputUnsatElements.Text = "bindingNavigator1";
            // 
            // toolStripButton_UnsatElements_AddNewItem
            // 
            this.toolStripButton_UnsatElements_AddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_AddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_AddNewItem.Image")));
            this.toolStripButton_UnsatElements_AddNewItem.Name = "toolStripButton_UnsatElements_AddNewItem";
            this.toolStripButton_UnsatElements_AddNewItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_AddNewItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_AddNewItem.Text = "Add new";
            // 
            // toolStripLabel_UnsatElements_CountItem
            // 
            this.toolStripLabel_UnsatElements_CountItem.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel_UnsatElements_CountItem.Name = "toolStripLabel_UnsatElements_CountItem";
            this.toolStripLabel_UnsatElements_CountItem.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel_UnsatElements_CountItem.Text = "of {0}";
            this.toolStripLabel_UnsatElements_CountItem.ToolTipText = "Total number of items";
            // 
            // toolStripButton_UnsatElements_DeleteItem
            // 
            this.toolStripButton_UnsatElements_DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_DeleteItem.Image")));
            this.toolStripButton_UnsatElements_DeleteItem.Name = "toolStripButton_UnsatElements_DeleteItem";
            this.toolStripButton_UnsatElements_DeleteItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_DeleteItem.Text = "Delete";
            // 
            // toolStripButton_UnsatElements_MoveFirstItem
            // 
            this.toolStripButton_UnsatElements_MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_MoveFirstItem.Image")));
            this.toolStripButton_UnsatElements_MoveFirstItem.Name = "toolStripButton_UnsatElements_MoveFirstItem";
            this.toolStripButton_UnsatElements_MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_MoveFirstItem.Text = "Move first";
            // 
            // toolStripButton_UnsatElements_MovePreviousItem
            // 
            this.toolStripButton_UnsatElements_MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_MovePreviousItem.Image")));
            this.toolStripButton_UnsatElements_MovePreviousItem.Name = "toolStripButton_UnsatElements_MovePreviousItem";
            this.toolStripButton_UnsatElements_MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_MovePreviousItem.Text = "Move previous";
            // 
            // toolStripSeparator_UnsatElements_Separator
            // 
            this.toolStripSeparator_UnsatElements_Separator.Name = "toolStripSeparator_UnsatElements_Separator";
            this.toolStripSeparator_UnsatElements_Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox_UnsatElements_PositionItem
            // 
            this.toolStripTextBox_UnsatElements_PositionItem.AccessibleName = "Position";
            this.toolStripTextBox_UnsatElements_PositionItem.AutoSize = false;
            this.toolStripTextBox_UnsatElements_PositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox_UnsatElements_PositionItem.Name = "toolStripTextBox_UnsatElements_PositionItem";
            this.toolStripTextBox_UnsatElements_PositionItem.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox_UnsatElements_PositionItem.Text = "0";
            this.toolStripTextBox_UnsatElements_PositionItem.ToolTipText = "Current position";
            // 
            // toolStripSeparator__UnsatElements_Separator1
            // 
            this.toolStripSeparator__UnsatElements_Separator1.Name = "toolStripSeparator__UnsatElements_Separator1";
            this.toolStripSeparator__UnsatElements_Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_UnsatElements_MoveNextItem
            // 
            this.toolStripButton_UnsatElements_MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_MoveNextItem.Image")));
            this.toolStripButton_UnsatElements_MoveNextItem.Name = "toolStripButton_UnsatElements_MoveNextItem";
            this.toolStripButton_UnsatElements_MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_MoveNextItem.Text = "Move next";
            // 
            // toolStripButton_UnsatElements_MoveLastItem
            // 
            this.toolStripButton_UnsatElements_MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_UnsatElements_MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_UnsatElements_MoveLastItem.Image")));
            this.toolStripButton_UnsatElements_MoveLastItem.Name = "toolStripButton_UnsatElements_MoveLastItem";
            this.toolStripButton_UnsatElements_MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.toolStripButton_UnsatElements_MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_UnsatElements_MoveLastItem.Text = "Move last";
            // 
            // toolStripSeparator_UnsatElements_Separator2
            // 
            this.toolStripSeparator_UnsatElements_Separator2.Name = "toolStripSeparator_UnsatElements_Separator2";
            this.toolStripSeparator_UnsatElements_Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1054, 681);
            this.Controls.Add(this.panel_Input);
            this.Controls.Add(this.panel_Calculate);
            this.Controls.Add(this.panel_OutputConstraints);
            this.Controls.Add(this.panel_OutputSatNodes);
            this.Controls.Add(this.panel_OutputSatElements);
            this.Controls.Add(this.panel_OutputUnsatNodes);
            this.Controls.Add(this.panel_OutputUnsatElements);
            this.Controls.Add(this.treeView_Main);
            this.Controls.Add(this.toolStrip_Main);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "WD15DSATUNSAT (GUI)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip_Main.ResumeLayout(false);
            this.toolStrip_Main.PerformLayout();
            this.tab_Inputs.ResumeLayout(false);
            this.tab_Header.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.tab_Parameters.ResumeLayout(false);
            this.panel_Parameters.ResumeLayout(false);
            this.panel_Parameters.PerformLayout();
            this.groupBox_Parameters_Tolerances.ResumeLayout(false);
            this.groupBox_Parameters_Tolerances.PerformLayout();
            this.groupBox_Parameters_Timestepping.ResumeLayout(false);
            this.groupBox_Parameters_Timestepping.PerformLayout();
            this.groupBox_Paramaters_MatrixSparsity.ResumeLayout(false);
            this.groupBox_Paramaters_MatrixSparsity.PerformLayout();
            this.groupBox_Parameters_Solvers.ResumeLayout(false);
            this.groupBox_Parameters_Solvers.PerformLayout();
            this.groupBox_Parameters_MatrixPreconditioners.ResumeLayout(false);
            this.groupBox_Parameters_MatrixPreconditioners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Parameters_Quadratureorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbar_Parameters_Quadratureorder)).EndInit();
            this.tab_Materials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_materials)).EndInit();
            this.tab_Layers.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox_TopBoundary.ResumeLayout(false);
            this.groupBox_TopBoundary.PerformLayout();
            this.groupBox_BottomBoundary.ResumeLayout(false);
            this.groupBox_BottomBoundary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Layers)).EndInit();
            this.tab_Mesh.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox_LayerMesh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LayerMesh)).EndInit();
            this.groupBox_VerElem.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VerticalModules)).EndInit();
            this.tab_Boundaries.ResumeLayout(false);
            this.groupBox_Boundary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Boundary)).EndInit();
            this.panel_Input.ResumeLayout(false);
            this.panel_Calculate.ResumeLayout(false);
            this.splitContainer_Calculate.Panel1.ResumeLayout(false);
            this.splitContainer_Calculate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Calculate)).EndInit();
            this.splitContainer_Calculate.ResumeLayout(false);
            this.panel_OutputConstraints.ResumeLayout(false);
            this.tabControl_OutputConstraints.ResumeLayout(false);
            this.tab_OutputConstraints_Graph.ResumeLayout(false);
            this.panel_OutputConstraints_Graph.ResumeLayout(false);
            this.panel_OutputConstraints_GraphOptions.ResumeLayout(false);
            this.panel_OutputConstraints_GraphOptions.PerformLayout();
            this.tab_OutputContraints_Table.ResumeLayout(false);
            this.tab_OutputContraints_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_OutputConstraints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputConstraints)).EndInit();
            this.bindingNavigator_OutputConstraints.ResumeLayout(false);
            this.bindingNavigator_OutputConstraints.PerformLayout();
            this.panel_OutputSatNodes.ResumeLayout(false);
            this.tabControl_OutputSatNodes.ResumeLayout(false);
            this.tabPage_SatNodes_Graph.ResumeLayout(false);
            this.panel_OutputSatNodes_Graph.ResumeLayout(false);
            this.splitContainer_SatNodes.Panel1.ResumeLayout(false);
            this.splitContainer_SatNodes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SatNodes)).EndInit();
            this.splitContainer_SatNodes.ResumeLayout(false);
            this.panel_OutputSatNodes_GraphOptions.ResumeLayout(false);
            this.panel_OutputSatNodes_GraphOptions.PerformLayout();
            this.tabPage_SatNodes_Table.ResumeLayout(false);
            this.tabPage_SatNodes_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputSatNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputSatNodes)).EndInit();
            this.bindingNavigator_OutputSatNodes.ResumeLayout(false);
            this.bindingNavigator_OutputSatNodes.PerformLayout();
            this.panel_OutputSatElements.ResumeLayout(false);
            this.tabControl_OutputSatElements.ResumeLayout(false);
            this.tabPage_SatElements_Graph.ResumeLayout(false);
            this.panel_OutputSatElements_Graph.ResumeLayout(false);
            this.splitContainer_SatElements.Panel1.ResumeLayout(false);
            this.splitContainer_SatElements.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_SatElements)).EndInit();
            this.splitContainer_SatElements.ResumeLayout(false);
            this.panel_OutputSatElements_GraphOptions.ResumeLayout(false);
            this.panel_OutputSatElements_GraphOptions.PerformLayout();
            this.tabPage_SatElements_Table.ResumeLayout(false);
            this.tabPage_SatElements_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputSatElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputSatElements)).EndInit();
            this.bindingNavigator_OutputSatElements.ResumeLayout(false);
            this.bindingNavigator_OutputSatElements.PerformLayout();
            this.panel_OutputUnsatNodes.ResumeLayout(false);
            this.tabControl_OutputUnsatNodes.ResumeLayout(false);
            this.tabPage_UnsatNodes_Graph.ResumeLayout(false);
            this.panel_OutputUnsatNodes_Graph.ResumeLayout(false);
            this.panel_OutputUnsatNodes_GraphOptions.ResumeLayout(false);
            this.panel_OutputUnsatNodes_GraphOptions.PerformLayout();
            this.tabPage_UnsatNodes_Table.ResumeLayout(false);
            this.tabPage_UnsatNodes_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputUnsatNodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputUnsatNodes)).EndInit();
            this.bindingNavigator_OutputUnsatNodes.ResumeLayout(false);
            this.bindingNavigator_OutputUnsatNodes.PerformLayout();
            this.panel_OutputUnsatElements.ResumeLayout(false);
            this.tabControl_OutputUnsatElements.ResumeLayout(false);
            this.tabPage_UnsatElements_Graph.ResumeLayout(false);
            this.panel_OutputUnsatElements_Graph.ResumeLayout(false);
            this.panel_OutputUnsatElements_GraphOptions.ResumeLayout(false);
            this.panel_OutputUnsatElements_GraphOptions.PerformLayout();
            this.tabPage_UnsatElements_Table.ResumeLayout(false);
            this.tabPage_UnsatElements_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OutputUnsatElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_OutputUnsatElements)).EndInit();
            this.bindingNavigator_OutputUnsatElements.ResumeLayout(false);
            this.bindingNavigator_OutputUnsatElements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip_Main;
        private System.Windows.Forms.ToolStripButton toolStripButton_Main_New;
        private System.Windows.Forms.ToolStripButton toolStripButton_Main_Openfile;
        private System.Windows.Forms.ToolStripButton toolStripButton_Main_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_Main_Saveas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Main_Calc;
        private System.Windows.Forms.TreeView treeView_Main;
        private System.Windows.Forms.Panel panel_Parameters;
        private System.Windows.Forms.TrackBar trackbar_Parameters_Quadratureorder;
        private System.Windows.Forms.Label label_Parameters_Quadratureorder;
        private System.Windows.Forms.Label label_Parameters_Crelax;
        private System.Windows.Forms.TextBox textbox_Parameters_Crelax;
        private System.Windows.Forms.CheckBox checkBox_Parameters_Erroronnode;
        private System.Windows.Forms.CheckBox checkBox_Parameters_Masslump;
        private System.Windows.Forms.Label label_Patameters_Multksat;
        private System.Windows.Forms.TextBox textbox_Parameters_Multksal;
        private System.Windows.Forms.GroupBox groupBox_Parameters_MatrixPreconditioners;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Preconditioner_ILUT;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Preconditioner_ILU0;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Preconditioner_Jacobi;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Preconditioner_None;
        private System.Windows.Forms.GroupBox groupBox_Parameters_Solvers;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Solver_FMGRES;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Solver_Paradiso;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Solver_IntelDSS;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Solver_Direct;
        private System.Windows.Forms.GroupBox groupBox_Paramaters_MatrixSparsity;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Typematrixstorage_Banded;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Typematrixstorage_CSR;
        private System.Windows.Forms.RadioButton radiobutton_Parameters_Typematrixstorage_Dense;
        private System.Windows.Forms.GroupBox groupBox_Parameters_Timestepping;
        private System.Windows.Forms.Label label_Paramters_It_max;
        private System.Windows.Forms.TextBox textbox_Parameters_It_max;
        private System.Windows.Forms.Label label_Parameters_Dtmax;
        private System.Windows.Forms.TextBox textbox_Parameters_Dtmax;
        private System.Windows.Forms.Label label_Parameters_Dtmin;
        private System.Windows.Forms.TextBox textbox_Parameters_Dtmin;
        private System.Windows.Forms.Label label_Parameters_Tmax;
        private System.Windows.Forms.TextBox textbox_Parameters_Tmax;
        private System.Windows.Forms.Label label_Parameters_Dtinit;
        private System.Windows.Forms.TextBox textbox_Parameters_Dtinit;
        private System.Windows.Forms.Label label_Parameters_Tinit;
        private System.Windows.Forms.TextBox textbox_Parameters_Tinit;
        private System.Windows.Forms.Label label_Parameters_Dtdec;
        private System.Windows.Forms.TextBox textbox_Parameters_Dtdec;
        private System.Windows.Forms.Label label_Parameters_Dtinc;
        private System.Windows.Forms.TextBox textbox_Parameters_Dtinc;
        private System.Windows.Forms.Label label_iterations;
        private System.Windows.Forms.Label label_Parameters_It_dec_dt;
        private System.Windows.Forms.TextBox textbox_Parameters_It_dec_dt;
        private System.Windows.Forms.TextBox textbox_Parameters_It_inc_dt;
        private System.Windows.Forms.Label label_Parameters_It_inc_dt;
        private System.Windows.Forms.TextBox textbox_Parameters_It_min;
        private System.Windows.Forms.Label label_Parameters_It_min;
        private System.Windows.Forms.GroupBox groupBox_Parameters_Tolerances;
        private System.Windows.Forms.Label label_Parameters_Maxhsatinc;
        private System.Windows.Forms.TextBox textbox_Parameters_Maxhsatinc;
        private System.Windows.Forms.Label label_Parameters_Epshsat_tol;
        private System.Windows.Forms.TextBox textbox_Parameters_Epshsat_tol;
        private System.Windows.Forms.Label label_Parameters_Epsth_tol;
        private System.Windows.Forms.TextBox textbox_Parameters_Epsth_tol;
        private System.Windows.Forms.Label label_Parameters_Epsh_tol;
        private System.Windows.Forms.TextBox textbox_Parameters_Epsh_tol;
        private System.Windows.Forms.DataGridView datagridview_materials;
        private System.Windows.Forms.TabControl tab_Inputs;
        private System.Windows.Forms.TabPage tab_Parameters;
        private System.Windows.Forms.TabPage tab_Materials;
        private System.Windows.Forms.TabPage tab_Layers;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label_Layers_Slopebottom;
        private System.Windows.Forms.TextBox textBox_Layers_Slopebottom;
        private System.Windows.Forms.GroupBox groupBox_BottomBoundary;
        private System.Windows.Forms.RadioButton radioButton_Layers_BottomImpermeable;
        private System.Windows.Forms.RadioButton radioButton_Layers_Bottombyphl;
        private System.Windows.Forms.GroupBox groupBox_TopBoundary;
        private System.Windows.Forms.RadioButton radioButton_Layers_Topboundbyq;
        private System.Windows.Forms.RadioButton radioButton_Layers_Topboundbyh;
        private System.Windows.Forms.Label label_Layers_Zphr;
        private System.Windows.Forms.TextBox textBox_Layers_Zphr;
        private System.Windows.Forms.Label label_Layers_Width;
        private System.Windows.Forms.TextBox textBox_Layers_Width;
        private System.Windows.Forms.DataGridView dataGridView_Layers;
        private System.Windows.Forms.TabPage tab_Mesh;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label_ne;
        private System.Windows.Forms.TextBox textBox_Ne;
        private System.Windows.Forms.TextBox textBox_Nc;
        private System.Windows.Forms.Label label_Nc;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.GroupBox groupBox_LayerMesh;
        private System.Windows.Forms.DataGridView dataGridView_LayerMesh;
        private System.Windows.Forms.GroupBox groupBox_VerElem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label_Nvmod;
        private System.Windows.Forms.TextBox textBox_Nvmod;
        private System.Windows.Forms.DataGridView dataGridView_VerticalModules;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalModules_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalModules_Nelemh;
        private System.Windows.Forms.DataGridViewTextBoxColumn verticalModules_Vmod_x;
        private System.Windows.Forms.NumericUpDown numericUpDown_Parameters_Quadratureorder;
        private System.Windows.Forms.OpenFileDialog openFileDialog_FileInput;
        private System.Windows.Forms.Label label_Parameters_PrintInc;
        private System.Windows.Forms.TextBox textBox_Parameters_Tprintinc;
        private System.Windows.Forms.WebBrowser webBrowser_Right;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel_Input;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_FileName;
        private System.Windows.Forms.TabPage tab_Boundaries;
        private System.Windows.Forms.GroupBox groupBox_Boundary;
        private System.Windows.Forms.DataGridView dataGridView_Boundary;
        private System.Windows.Forms.DataGridViewTextBoxColumn boundary_Timebound;
        private System.Windows.Forms.DataGridViewTextBoxColumn boundary_Hbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn boundary_Qbound;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Output;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_Kindmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_Thsat;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_Thres;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_Alfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_M;
        private System.Windows.Forms.DataGridViewTextBoxColumn maerial_Ksat;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_L;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_IDlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_Slope;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_Height;
        private System.Windows.Forms.DataGridViewComboBoxColumn layers_IDMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_Meshelements;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_IDMaterialHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_MaterialHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_HtopHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_HbottomHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_Id_elem_topHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layers_Id_elem_bottomHidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_IDlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Meshelements;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Slope;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_IDMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Htop;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Hbottom;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Id_elem_top;
        private System.Windows.Forms.DataGridViewTextBoxColumn layerMesh_Id_elem_bottom;
        private System.Windows.Forms.Panel panel_Calculate;
        private System.Windows.Forms.Panel panel_OutputConstraints;
        private System.Windows.Forms.TabControl tabControl_OutputConstraints;
        private System.Windows.Forms.TabPage tab_OutputContraints_Table;
        public System.Windows.Forms.DataGridView datagridview_OutputConstraints;
        private System.Windows.Forms.TabPage tab_OutputConstraints_Graph;
        private System.Windows.Forms.Panel panel_OutputConstraints_Graph;

        private System.Windows.Forms.Panel panel_OutputConstraints_GraphOptions;
        private System.Windows.Forms.SplitContainer splitContainer_Calculate;
        private GraphControls.ScatterXYControl scatterXYControl_Calculate_Timestep;
        private System.Windows.Forms.Timer timer_CalculationTimestep;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_CalculationStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar_Calculating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Constraints_IDconstraint;
        private System.Windows.Forms.BindingNavigator bindingNavigator_OutputConstraints;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private GraphControls.ScatterXYControl scatterXYControl_Constraints;
        private System.Windows.Forms.Label label_Constraints_IU;
        private System.Windows.Forms.Label label_Constraints_IS;
        private System.Windows.Forms.Label label_Constraints_Variable;
        private System.Windows.Forms.ComboBox comboBox_Constraints_Variable;
        private System.Windows.Forms.ComboBox comboBox_Constraints_numIU;
        private System.Windows.Forms.ComboBox comboBox_Constraints_numIS;
        private System.Windows.Forms.Button button_Constraints_Clear;
        private System.Windows.Forms.Button button_Constraints_Add_Variable;
        private System.Windows.Forms.Button button_Constraints_Update;
        private System.Windows.Forms.Panel panel_OutputSatNodes;
        private System.Windows.Forms.TabControl tabControl_OutputSatNodes;
        private System.Windows.Forms.TabPage tabPage_SatNodes_Graph;
        private System.Windows.Forms.Panel panel_OutputSatNodes_Graph;
        private GraphControls.ScatterXYControl scatterXYControl_SatNodes_Layers;
        private System.Windows.Forms.Panel panel_OutputSatNodes_GraphOptions;
        private System.Windows.Forms.Button button_SatNodes_Update;
        private System.Windows.Forms.Button button_SatNodes_Clear;
        private System.Windows.Forms.Button button_SatNodes_AddVariable;
        private System.Windows.Forms.ComboBox comboBox_SatNodes_numIS;
        private System.Windows.Forms.Label label_SatNodes_Variable;
        private System.Windows.Forms.ComboBox comboBox_SatNodes_Variable;
        private System.Windows.Forms.Label label_SatNodes_IS;
        private System.Windows.Forms.TabPage tabPage_SatNodes_Table;
        public System.Windows.Forms.DataGridView dataGridView_OutputSatNodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_SatNodes_ID;
        private System.Windows.Forms.BindingNavigator bindingNavigator_OutputSatNodes;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_AddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigator_SatNodes_CountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_DeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatNodes_Separator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigator_SatNodes_PositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatNOdes_Separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_MoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatNodes_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatNodes_Separator2;
        private System.Windows.Forms.RichTextBox richTextBoxCalculation;
        private System.Windows.Forms.ComboBox comboBox_SatNodes_T;
        private System.Windows.Forms.Label label_SatNodes_T;
        private System.Windows.Forms.Panel panel_OutputSatElements;
        private System.Windows.Forms.TabControl tabControl_OutputSatElements;
        private System.Windows.Forms.TabPage tabPage_SatElements_Graph;
        private System.Windows.Forms.Panel panel_OutputSatElements_Graph;
        private GraphControls.ScatterXYControl scatterXYControl_SatElements_Layers;
        private System.Windows.Forms.Panel panel_OutputSatElements_GraphOptions;
        private System.Windows.Forms.ComboBox comboBox_SatElements_T;
        private System.Windows.Forms.Label label_SatElements_T;
        private System.Windows.Forms.Button button_SatElements_Update;
        private System.Windows.Forms.Button button_SatElements_Clear;
        private System.Windows.Forms.Button button_SatElements_AddVariable;
        private System.Windows.Forms.ComboBox comboBox_SatElements_numIS;
        private System.Windows.Forms.Label label_SatElements_Variable;
        private System.Windows.Forms.ComboBox comboBox_SatElements_Variable;
        private System.Windows.Forms.Label label_SatElements_IS;
        private System.Windows.Forms.TabPage tabPage_SatElements_Table;
        public System.Windows.Forms.DataGridView dataGridView_OutputSatElements;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_SatElements_ID;
        private System.Windows.Forms.BindingNavigator bindingNavigator_OutputSatElements;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_AddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigator_SatElements_CountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_DeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatElements_Separator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigator_SatElements_PositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatElements_Separator1;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_MoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigator_SatElements_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigator_SatElements_Separator2;
        private System.Windows.Forms.SplitContainer splitContainer_SatElements;
        private GraphControls.ScatterXYControl scatterXYControl_SatElements_Others;
        private System.Windows.Forms.SplitContainer splitContainer_SatNodes;
        private GraphControls.ScatterXYControl scatterXYControl_SatNodes_Others;
        private System.Windows.Forms.Panel panel_OutputUnsatNodes;
        private System.Windows.Forms.TabControl tabControl_OutputUnsatNodes;
        private System.Windows.Forms.TabPage tabPage_UnsatNodes_Graph;
        private System.Windows.Forms.Panel panel_OutputUnsatNodes_Graph;
        private GraphControls.ScatterXYControl scatterXYControl_UnsatNodes;
        private System.Windows.Forms.Panel panel_OutputUnsatNodes_GraphOptions;
        private System.Windows.Forms.ComboBox comboBox_UnsatNodes_T;
        private System.Windows.Forms.Label label_UnsatNodes_T;
        private System.Windows.Forms.Button button_UnsatNodes_Update;
        private System.Windows.Forms.Button button_UnsatNodes_Clear;
        private System.Windows.Forms.Button button_UnsatNodes_AddVariable;
        private System.Windows.Forms.ComboBox comboBox_UnsatNodes_numIU;
        private System.Windows.Forms.Label label_UnsatNodes_Variable;
        private System.Windows.Forms.ComboBox comboBox_UnsatNodes_Variable;
        private System.Windows.Forms.Label label_UnsatNodes_IU;
        private System.Windows.Forms.TabPage tabPage_UnsatNodes_Table;
        public System.Windows.Forms.DataGridView dataGridView_OutputUnsatNodes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_UnsatNodes_ID;
        private System.Windows.Forms.BindingNavigator bindingNavigator_OutputUnsatNodes;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_AddNewItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_UnsatNodes_CountItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_DeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_UnsatNodes_Separator;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_UnsatNodes_PositionItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_UnsatNodes_Separator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_MoveNextItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatNodes_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_UnstaNodes_Separator2;
        private System.Windows.Forms.Panel panel_OutputUnsatElements;
        private System.Windows.Forms.TabControl tabControl_OutputUnsatElements;
        private System.Windows.Forms.TabPage tabPage_UnsatElements_Graph;
        private System.Windows.Forms.Panel panel_OutputUnsatElements_Graph;
        private GraphControls.ScatterXYControl scatterXYControl_UnsatElements;
        private System.Windows.Forms.Panel panel_OutputUnsatElements_GraphOptions;
        private System.Windows.Forms.ComboBox comboBox_UnsatElements_T;
        private System.Windows.Forms.Label label_UnsatElements_T;
        private System.Windows.Forms.Button button_UnsatElements_Update;
        private System.Windows.Forms.Button button_UnsatElements_Clear;
        private System.Windows.Forms.Button button_UnsatElements_AddVariable;
        private System.Windows.Forms.ComboBox comboBox_UnsatElements_numIU;
        private System.Windows.Forms.Label label_UnsatElements_Variable;
        private System.Windows.Forms.ComboBox comboBox_UnsatElements_Variable;
        private System.Windows.Forms.Label label_UnsatElements_IU;
        private System.Windows.Forms.TabPage tabPage_UnsatElements_Table;
        public System.Windows.Forms.DataGridView dataGridView_OutputUnsatElements;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_OutputUnsatElements_ID;
        private System.Windows.Forms.BindingNavigator bindingNavigator_OutputUnsatElements;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_AddNewItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_UnsatElements_CountItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_DeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_MoveFirstItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_UnsatElements_Separator;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_UnsatElements_PositionItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator__UnsatElements_Separator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_MoveNextItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_UnsatElements_MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_UnsatElements_Separator2;
        private System.Windows.Forms.TabPage tab_Header;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.TextBox textBox_Header;
        private System.Windows.Forms.Label label_Title;
    }
}

