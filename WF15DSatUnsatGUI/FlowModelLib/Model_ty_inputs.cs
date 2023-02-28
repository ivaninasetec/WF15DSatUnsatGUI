using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowComLib;
//using MathNet.Numerics.LinearAlgebra;
using System.ComponentModel;
using FlowModelLib;
using System.IO;
using System.Windows.Forms;

namespace FlowModelLib
{
    public static class Model_ty_inputs
    {
        //public static void s_model_inputs_parameters(ref Com_ty_parameters parameters, string FileINPUT)
        public static void s_model_inputs_header(TextBox txtbox, string FileINPUT)
        {
            txtbox.Text = "";
            // creating object of CultureInfo
            CultureInfo cultureUS = new CultureInfo("en-US");

            string[] separatingStrings = { " ", "\t" };
            int iRecordEnd = 0;

            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileINPUT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            //Delete all spaces at start of each line:
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimStart();
            }

            //Search the string Block A
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("BLOCK A"))
                {
                    iRecordEnd = i;
                    break;
                }
            }

            //Write Title into Textbox
            for (int i = 0; i < iRecordEnd; i++)
            {
                txtbox.AppendText(lines[i].Remove(0, 1) + "\r\n");
            }

        }

         public static void s_model_inputs_parameters(ref Model_ty_model WF15DSatUnsatModel, string FileINPUT)
        {
            // creating object of CultureInfo
            CultureInfo cultureUS = new CultureInfo("en-US");

            string[] datatemp;
            string[] separatingStrings = { " ", "\t" };
            int iRecordStart = 0,iRecord;

            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileINPUT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            //string[] lines = System.IO.File.ReadAllLines(FileINPUT);
            //Delete all spaces at start of each line:
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimStart();
            }

            //Search the string Block A
            for (int i = 0; i < lines.Count;i++)
            { if (lines[i].Contains("BLOCK A"))
                {
                    iRecordStart = i;
                    break;
                }
            }
            iRecord = iRecordStart;

            //(epsh_tol)Tolerancia en h | (epsth_tol)Tolerancia en th | (epshsat_tol)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces

            WF15DSatUnsatModel.Com_Ty_Parameters.Epsh_tol = Convert.ToDouble(datatemp[0], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Epsth_tol = Convert.ToDouble(datatemp[1], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Epshsat_tol = Convert.ToDouble(datatemp[2], cultureUS);

            //Minimum iterations | (itinc_dt)Iteration to increase dt | (itdec_dt)Iterations to decrease dt | (maxit)Max iterations
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces

            WF15DSatUnsatModel.Com_Ty_Parameters.It_min = Convert.ToInt32(datatemp[0],cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.It_inc_dt = Convert.ToInt32(datatemp[1], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.It_dec_dt = Convert.ToInt32(datatemp[2], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.It_max = Convert.ToInt32(datatemp[3], cultureUS);

            //(crelax)Relaxation coefficient(updates of values in each iterations equal to: (1 - crelax)·hn + (crelax)·hn + 1
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Parameters.Crelax = Convert.ToDouble(datatemp[0], cultureUS);

            //(IsMassLump) ¿Use mass lumping in mass matrix? | (erroronnod) ¿Use error on node or error in element?
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Masslump = bool.Parse(datatemp[0].Trim(new char[] { '.' }));
            WF15DSatUnsatModel.Com_Ty_Parameters.Erroronnode = bool.Parse(datatemp[1].Trim(new char[] { '.' }));

            //(quadratureorder) Order of quadrature for integration in element
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Quadratureorder = Convert.ToInt32(datatemp[0], cultureUS);

            //(typesolution) Type of solution used in calcs: 
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Typesolution = Convert.ToInt32(datatemp[0], cultureUS);

            //(courant) Coefficient of courant: 2.0 (Use a very high value to avoid limiting stepsize by courant condition)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Ccourant = Convert.ToDouble(datatemp[0], cultureUS);

            //(multksal) Multiplication factor for the permeability at the seepage surface
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Multksal = Convert.ToDouble(datatemp[0], cultureUS);

            //(max hsatinc) Max Hsat Increment
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Maxhsatinc = Convert.ToDouble(datatemp[0], cultureUS);

            //(tinit) Initial time | (dtinit) dt at first step | (tmax) t at end of simulation | (dtmin) Min value for dt | (dtmax) Max value for dt 
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Tinit = Convert.ToDouble(datatemp[0],cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Dtinit = Convert.ToDouble(datatemp[1],cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Tmax = Convert.ToDouble(datatemp[2], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Dtmin = Convert.ToDouble(datatemp[3], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Dtmax = Convert.ToDouble(datatemp[4], cultureUS);

            //(Cdtinc) Factor to increase time | (Cdtdec) Factor to decrease time
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Dtinc = Convert.ToDouble(datatemp[0], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Dtdec = Convert.ToDouble(datatemp[1], cultureUS);

            //(dtprintinc) time increment to print results
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Tprintinc = Convert.ToDouble(datatemp[0], cultureUS);

            //Restart at time t?
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Isrestarttime = bool.Parse(datatemp[0].Trim(new char[] { '.' }));

            //Time to restart:
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Trestart = Convert.ToDouble(datatemp[0], cultureUS);

            //nrel min | nrel max
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            WF15DSatUnsatModel.Com_Ty_Parameters.Nrelmin = Convert.ToDouble(datatemp[0], cultureUS);
            WF15DSatUnsatModel.Com_Ty_Parameters.Nrelmax = Convert.ToDouble(datatemp[1], cultureUS);

            ////Relaxation factor for nrel
            //iRecord++;
            //while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            //datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            //parameters.Crelax_nrel = double.Parse(datatemp[0]);

            ////Repetitions on sat-unsat cycles
            //iRecord++;
            //while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            //datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            //parameters.N_repetitions_satunsat = int.Parse(datatemp[0]);

            ////Relaxation factor for qver and dqhordx update
            //iRecord++;
            //while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            //datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            //parameters.Crelax_q = int.Parse(datatemp[0]);
        }

        //public static void s_model_inputs_materials(ref BindingList<Com_ty_material> material, string FileINPUT)
        public static void s_model_inputs_materials(ref Model_ty_model WF15DSatUnsatModel, string FileINPUT)
        {
            WF15DSatUnsatModel.Materials.Initialize();
            // creating object of CultureInfo
            CultureInfo cultureUS = new CultureInfo("en-US");
            string[] datatemp;
            string[] separatingStrings = { " ", "\t" };
            int iRecordStart = 0, iRecord;
            int nmaterials;

            //Read all file
            //string[] lines = System.IO.File.ReadAllLines(FileINPUT);
            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileINPUT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }


            //Delete all spaces at start of each line:
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimStart();
            }

            //Search the string Block A
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("BLOCK B"))
                {
                    iRecordStart = i;
                    break;
                }
            }
            iRecord = iRecordStart;

            //(count) Number of different of materials (Ud)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); 

            nmaterials = int.Parse(datatemp[0]);

            //WF15DSatUnsatModel.Materials = new BindingList<Com_ty_material>();
            WF15DSatUnsatModel.Materials.Materials.Clear();
            for (int i = 0; i<nmaterials; i++)
            {
                WF15DSatUnsatModel.Materials.Materials.Add(new Com_ty_material());
                //material[i]= new Com_ty_material();
            }

            //(kindmat and ID) Kind of material (1= Mualem-Van Genuchten, 2= Exponential Hydraulic Function)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); 

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].Id = j;
                WF15DSatUnsatModel.Materials.Materials[j].Kindmat = Convert.ToInt32(datatemp[j],cultureUS);
            }

            //(thsat) Saturated volumetric water content (m3/m3)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].Thsat = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(thres) Residual volumetric water content (m3/m3)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].Thres = Convert.ToDouble(datatemp[j], cultureUS);
            }

            //(ksat)	Saturated permeability (m/s)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].Ksat = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(a)		a parameter of Van Genuchten (m-1) or a parameter of other hydraulic function
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].A = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(n)		n parameter of Van Genuchten (-) or n parameter of other hydraulic function
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].N = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(m)		m parameter of Van Genuchten (-) or m parameter of other hydraulic function
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].M = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(l)		l parameter of Mualem-Van Genuchten or m parameter of other hydraulic function
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nmaterials; j++)
            {
                WF15DSatUnsatModel.Materials.Materials[j].L = Convert.ToDouble(datatemp[j],cultureUS);
            }


        }

        //public static void s_model_inputs_layers(ref Com_ty_layers layers, string FileINPUT,ref BindingList<Com_ty_material> material)
        public static void s_model_inputs_layers(ref Model_ty_model WF15DSatUnsatModel, string FileINPUT)
        {
            // creating object of CultureInfo
            CultureInfo cultureUS = new CultureInfo("en-US");
            string[] datatemp;
            string[] separatingStrings = { " ", "\t" };
            int iRecordStart = 0, iRecord;
            int nlayers;

            //Read all file
            //string[] lines = System.IO.File.ReadAllLines(FileINPUT);
            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileINPUT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }


            //Delete all spaces at start of each line:
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimStart();
            }

            //Search the string Block A
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("BLOCK C"))
                {
                    iRecordStart = i;
                    break;
                }
            }
            iRecord = iRecordStart;

            //(count) Number of layers
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            nlayers = Convert.ToInt32(datatemp[0],cultureUS);

            //Create a new instance of Com_ty_layers
            if (WF15DSatUnsatModel.Com_Ty_Layers is null)
                WF15DSatUnsatModel.Com_Ty_Layers = new Com_ty_layers(nlayers);
            else
            {
                WF15DSatUnsatModel.Com_Ty_Layers.Layers.Clear();
                for (int i = 0; i < nlayers; i++) WF15DSatUnsatModel.Com_Ty_Layers.Layers.Add(new Com_ty_layer());
            }

            //layers.Count = nlayers;

            //layers.Height = Vector<double>.Build.Dense(nlayers);
            //layers.Material = new Com_ty_material[nlayers];
            //layers.Hbottom = Vector<double>.Build.Dense(nlayers);
            //layers.Htop = Vector<double>.Build.Dense(nlayers);
            //layers.Slope = Vector<double>.Build.Dense(nlayers);

            //(width) Witdh of layers
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Layers.Width = Convert.ToDouble(datatemp[0],cultureUS);


            //(height): Height of each layer (at left side) (m)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nlayers; j++)
            {
                WF15DSatUnsatModel.Com_Ty_Layers.Layers[j].Height = Convert.ToDouble(datatemp[j],cultureUS);
            }

            //(slope): Slope of the bottom of each layer and the last for the top (m/m) (number=nlayers+1, first one must be 0.0)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
            
            WF15DSatUnsatModel.Com_Ty_Layers.Slopebottom = Convert.ToDouble(datatemp[0], cultureUS); //First one slope at bottom

            for (int j = 0; j < nlayers; j++)
            {
                WF15DSatUnsatModel.Com_Ty_Layers.Layers[j].Slope = Convert.ToDouble(datatemp[j+1],cultureUS);
            }

            //(material) Material number on the layer as defined in block B
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nlayers; j++)
            {
                WF15DSatUnsatModel.Com_Ty_Layers.Layers[j].IDMaterial = Convert.ToInt32(datatemp[j], cultureUS) - 1;
                //WF15DSatUnsatModel.Com_Ty_Layers.Layers[j].Material = WF15DSatUnsatModel.Com_Ty_Material[Convert.ToInt32(datatemp[j],cultureUS)-1];
            }

            //ZPHR: Phreatic level (z coordinate) from the top left (m)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Layers.Zphr = Convert.ToDouble(datatemp[0],cultureUS);

            //TOPBOUNDBYH: Is top boundary defined by FLOW1D_BOUND_H.txt?
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyh = bool.Parse(datatemp[0].Trim(new char[] { '.' }));

            //TOPBOUNDBYQ: Is top boundary defined by specific flow with: FLOW1D_BOUND_Q.txt?
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyq = bool.Parse(datatemp[0].Trim(new char[] { '.' }));

            //BOTTOMBYPHL: (Is the bottom layer at defined phreatic level, otherwise q=0)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            WF15DSatUnsatModel.Com_Ty_Layers.Bottombyphl = bool.Parse(datatemp[0].Trim(new char[] { '.' }));
        }

        //public static void s_model_inputs_mesh(ref Model_ty_mesh mesh, string FileINPUT, ref Com_ty_layers layers)
        public static void s_model_inputs_mesh(ref Model_ty_model WF15DSatUnsatModel, string FileINPUT)
        {
            int nvertmodules;
            // creating object of CultureInfo
            CultureInfo cultureUS = new CultureInfo("en-US");

            string[] datatemp;
            string[] separatingStrings = { " ", "\t" };
            int iRecordStart = 0, iRecord;

            //Read all file
            //string[] lines = System.IO.File.ReadAllLines(FileINPUT);
            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileINPUT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            //Delete all spaces at start of each line:
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = lines[i].TrimStart();
            }

            //Search the string Block D
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].Contains("BLOCK D"))
                {
                    iRecordStart = i;
                    break;
                }
            }
            iRecord = iRecordStart;

            //(nn)Nodes per element | (nc)Class of nodes
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            //WF15DSatUnsatModel.Model_Ty_Mesh.Nn = Convert.ToInt32(datatemp[0], cultureUS);
            //WF15DSatUnsatModel.Model_Ty_Mesh.Nc = Convert.ToInt32(datatemp[1], cultureUS);

            //(vmod_count) Number of vertical modules
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            nvertmodules = Convert.ToInt32(datatemp[0], cultureUS);
            //WF15DSatUnsatModel.Model_Ty_Mesh.Vmod_count = Convert.ToInt32(datatemp[0], cultureUS);

            //WF15DSatUnsatModel.Model_Ty_Mesh.Nelemh = new int[WF15DSatUnsatModel.Model_Ty_Mesh.Vmod_count];
            //WF15DSatUnsatModel.Model_Ty_Mesh.Vmod_x = new double[WF15DSatUnsatModel.Model_Ty_Mesh.Vmod_count];
            //WF15DSatUnsatModel.Model_Ty_Mesh.Nelemv = new int[WF15DSatUnsatModel.Com_Ty_Layers.Count];

            //Add a number of "nvertmodules" of empty vertical modules
            WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules.Clear();
            for (int j = 0; j < nvertmodules; j++)
            { WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules.Add(new Model_ty_verticalmodule()); WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules[j].ID = j;  }

           //(nelemh) Number of elements between vertical modules (number=vmod)
           iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nvertmodules; j++)
            {
                //WF15DSatUnsatModel.Model_Ty_Mesh.Nelemh[j] = Convert.ToInt32(datatemp[j], cultureUS);
                WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules[j].Nelemh = Convert.ToInt32(datatemp[j], cultureUS);

            }

            //(vmod_x) Coord x of each vertical module(first always cero)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < nvertmodules; j++)
            {
                //WF15DSatUnsatModel.Model_Ty_Mesh.Vmod_x[j] = Convert.ToDouble(datatemp[j],cultureUS);
                WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules[j].Vmod_x = Convert.ToDouble(datatemp[j], cultureUS);
            }

            //(nelemv) Number of elements per layer (number=number of layers)
            iRecord++;
            while (lines[iRecord].Substring(0, 1) == "!") { iRecord++; }
            datatemp = lines[iRecord].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < WF15DSatUnsatModel.Com_Ty_Layers.Count; j++)
            {
                WF15DSatUnsatModel.Com_Ty_Layers.Layers[j].Meshelements = Convert.ToInt32(datatemp[j], cultureUS);
                //WF15DSatUnsatModel.Model_Ty_Mesh.Nelemv[j] = Convert.ToInt32(datatemp[j], cultureUS);
            }
        }

        //public static void s_model_inputs_boundary(string FileBOUNDARY, Com_ty_boundary boundary, Com_ty_layers layers)
        public static void s_model_inputs_boundary(ref Model_ty_model WF15DSatUnsatModel, string FileBOUNDARY)
        {
            WF15DSatUnsatModel.Boundaries.Initialize();
            CultureInfo cultureUS = new CultureInfo("en-US");
            string[] datatemp;
            string[] separatingStrings = { " ", "\t","," };

            //Read all file
            //List<string> lines = System.IO.File.ReadAllLines(FileBOUNDARY).ToList();
            //Read all file
            List<string> lines = new List<string>();
            using (var fs = new FileStream(FileBOUNDARY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }


            lines.RemoveAll(string.IsNullOrWhiteSpace);
            //boundary.Timebound = Vector<double>.Build.Dense(lines.Length);

            //generate new list of boundary items
            WF15DSatUnsatModel.Boundaries.Boundaries.Clear();
            for (int i = 1; i < lines.Count; i++)
            {
                WF15DSatUnsatModel.Boundaries.Boundaries.Add(new Com_ty_boundary());
            }

            //Fill if topbound by inflow (qbound) os by fixed head (hbound)
            if (WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyq)
            {
                //WF15DSatUnsatModel.Boundaries.Boundaries.Qbound = Vector<double>.Build.Dense(lines.Length);


                    for (int i = 1; i < lines.Count; i++)
                {
                    datatemp = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                    WF15DSatUnsatModel.Boundaries.Boundaries[i-1].Timebound = Convert.ToDouble(datatemp[0], cultureUS);
                    WF15DSatUnsatModel.Boundaries.Boundaries[i-1].Qbound = Convert.ToDouble(datatemp[1], cultureUS);
                }
            }
            else
            {
                //boundary.Hbound = Vector<double>.Build.Dense(lines.Length);

                for (int i = 1; i < lines.Count; i++)
                {
                    datatemp = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                    WF15DSatUnsatModel.Boundaries.Boundaries[i - 1].Timebound = Convert.ToDouble(datatemp[0], cultureUS);
                    WF15DSatUnsatModel.Boundaries.Boundaries[i-1].Hbound = Convert.ToDouble(datatemp[1], cultureUS);
                }
            }


        }


    }
}
