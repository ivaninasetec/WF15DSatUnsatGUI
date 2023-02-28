using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowComLib;
using FlowModelLib;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace FlowModelLib
{
    public static class Model_ty_outputs
    {

        //public static void s_model_output_title(string FileOUTPUT, string title)
        //{
        //    //Read all file
        //    List<string> lines = new List<string>();
        //    lines.Append("!*****************************************************************");
        //    lines.Append(title);
        //    lines.Append("!*****************************************************************");

        //    File.WriteAllLines(FileOUTPUT, lines);
        //    //File.WriteAllLines(FileOUTPUT, lines.ToArray());
        //}
        public static void s_model_output_header(TextBox txtbox, string FileOUTPUT)
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < txtbox.Lines.Length; i++)
            {
                lines.Add("!"+txtbox.Lines[i]);
            }

            File.AppendAllLines(FileOUTPUT, lines);

        }

            public static void s_model_output_parameters(Model_ty_model WF15DSatUnsatModel, string FileOUTPUT)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            //List with all the lines of the file
            List<string> lines = new List<string>();

            //System.IO.File.AppendAllLines()
            lines.Add("!****** BLOCK A: PARAMETERS **************************************");
            lines.Add("!GENERAL PARAMETERS");
            lines.Add("!(epsh_tol) Tolerancia en h | (epsth_tol) Tolerancia en th | (epshsat_tol)");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Epsh_tol, cultureUS) + "   " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Epsth_tol, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Epshsat_tol, cultureUS));
            lines.Add("!Minimum iterations | (itinc_dt) Iteration to increase dt  | (itdec_dt) Iterations to decrease dt | (maxit) Max iterations for time step (if surpassed restart timestep and decrease dt)");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.It_min, cultureUS) + "   " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.It_inc_dt, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.It_dec_dt, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.It_max, cultureUS));
            lines.Add("!(crelax) Relaxation coefficient (updates of values in each iterations equal to: (1-crelax)·hn+(crelax)·hn+1");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Crelax, cultureUS));
            lines.Add("!(IsMassLump) ¿Use mass lumping in mass matrix? | (erroronnod) ¿Use error on node or error in element?");
            lines.Add("."+ Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Masslump, cultureUS) + "." + "   " + "." + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Erroronnode, cultureUS) + ".");
            lines.Add("!(quadratureorder) Order of quadrature for integration in element");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Quadratureorder, cultureUS));
            lines.Add("!(typesolution) Type of solution used in calcs: ");
            lines.Add("!Number	| sparsity | solver | preconditioner");
            lines.Add("!	1     dense      gauss    none");
            lines.Add("!	2     dense      gauss    jacobi");
            lines.Add("!	3     csr        DSS      none");
            lines.Add("!	4     csr        DSS      jacobi");
            lines.Add("!	5     csr        DSS      ilu0");
            lines.Add("!	6     csr        DSS      ilut");
            lines.Add("!	7     csr        PARADISO none");
            lines.Add("!	8     csr        PARADISO jacobi");
            lines.Add("!	9     csr        PARADISO ilu0");
            lines.Add("!	10    csr        PARADISO ilut");
            lines.Add("!	11    csr        FGMRES   none");
            lines.Add("!	12    csr        FGMRES   jacobi");
            lines.Add("!	13    csr        FGMRES   ilu0");
            lines.Add("!	14    csr        FGMRES   ilut");
            lines.Add("!	15    banded     gauss	  none");
            lines.Add("!	16    banded     gauss	  jacobi");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Typesolution, cultureUS));
            lines.Add("!(courant) Coefficient of courant: 2.0 (Use a very high value to avoid limiting stepsize by courant condition)");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Ccourant, cultureUS));
            lines.Add("!(multksal) Multiplication factor for the permeability at the seepage surface");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Multksal, cultureUS));
            lines.Add("!(max hsatinc) Max Hsat Increment");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Maxhsatinc, cultureUS));
            lines.Add("!TIME PARAMETERS:");
            lines.Add("!(tinit)Initial time | (dtinit)dt at first step | (tmax)t at end of simulation | (dtmin)Min value for dt | (dtmax)Max value for dt");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Tinit, cultureUS) + "   " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Dtinit, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Tmax, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Dtmin, cultureUS) + "    " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Dtmax, cultureUS));
            lines.Add("!(Cdtinc) Factor to increase time | (Cdtdec) Factor to decrease time");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Dtinc, cultureUS) + "   " + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Dtdec, cultureUS));
            lines.Add("!(dtprintinc) time increment to print results");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Tprintinc, cultureUS));
            lines.Add("!Restart at time t?");
            lines.Add("." + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Isrestarttime, cultureUS) + ".");
            lines.Add("!Time to restart:");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Trestart, cultureUS));
            lines.Add("!nrel min | nrel max");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Nrelmin, cultureUS) + "    "+ Convert.ToString(WF15DSatUnsatModel.Com_Ty_Parameters.Nrelmax, cultureUS));
            //lines.Append("!Relaxation factor for nrel");
            //lines.Append(parameters.Crelax_nrel.ToString());
            //lines.Append("!Repetitions on sat-unsat cycles");
            //lines.Append(parameters.N_repetitions_satunsat.ToString());
            //lines.Append("!Relaxation factor for qver and dqhordx update");
            //lines.Append(parameters.Crelax_q.ToString());

            File.AppendAllLines(FileOUTPUT,lines);
        }

        public static void s_model_output_materials(Model_ty_model WF15DSatUnsatModel, string FileOUTPUT)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            //List with all the lines of the file
            List<string> lines = new List<string>();
            string templine;

            //System.IO.File.AppendAllLines()
            lines.Add("!****** BLOCK B: MATERIALS **************************************");
            lines.Add("!(count) Number of different of materials (Ud)");
            lines.Add(WF15DSatUnsatModel.Materials.Materials.Count().ToString());
            lines.Add("!(kindmat) Kind of material (1= Mualem-Van Genuchten, 2= Exponential Hydraulic Function (Hayek, 2016), 3=Brooks and Corey, 4 Clean ballast (as Brooks and Corey with kr=(2+l))");
            templine = "";
            for (int i = 0;i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].Kindmat, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(thsat) Saturated volumetric water content (m3/m3)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                //templine = templine + WF15DSatUnsatModel.Materials.Materials[i].Thsat.ToString() + " \t";
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].Thsat,cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(thres) Residual volumetric water content (m3/m3)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].Thres, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(ksat)\tSaturated permeability (m/s) (ballast should be 5.08E-2 but it isnt)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].Ksat, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add(@"!(a)        a parameter of Van Genuchten (m-1) or a parameter of other hydraulic function");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].A, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add(@"!(n)		n parameter of Van Genuchten (-) or n parameter of other hydraulic function");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].N, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add(@"!(m)		m parameter of Van Genuchten (-) or m parameter of other hydraulic function");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].M, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add(@"!(l)		l parameter of Mualem-Van Genuchten or m parameter of other hydraulic function");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Materials.Materials.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Materials.Materials[i].L, cultureUS) + " \t";
            }
            lines.Add(templine);

            File.AppendAllLines(FileOUTPUT, lines);
        }

        public static void s_model_output_layers(Model_ty_model WF15DSatUnsatModel, string FileOUTPUT)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            //List with all the lines of the file
            List<string> lines = new List<string>();
            string templine;

            //System.IO.File.AppendAllLines()
            lines.Add("!****** BLOCK C: LAYERS **************************************");
            lines.Add("!(count) Number of layers");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Layers.Count(), cultureUS));
            lines.Add("!(width) Witdh of layers");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Width, cultureUS));

            lines.Add("!(height): Height of each layer (at left side) (m) ");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Com_Ty_Layers.Layers.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Layers[i].Height, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(slope): Slope of the bottom of each layer and the last for the top (m/m)");
            templine = "";
            templine = Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Slopebottom, cultureUS) + " \t";
            for (int i = 0; i < WF15DSatUnsatModel.Com_Ty_Layers.Layers.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Layers[i].Slope, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(material)Material number on the layer as defined in block B");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Com_Ty_Layers.Layers.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Layers[i].IDMaterial+1, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!ZPHR: Phreatic level (z coordinate) from the top left (m)");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Zphr, cultureUS));

            lines.Add("!TOPBOUNDBYH: Is top boundary defined by *.wfbound");
            lines.Add("."+Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyh, cultureUS)+".");

            lines.Add("!TOPBOUNDBYQ: Is top boundary defined by specific flow with: *.wfbound");
            lines.Add("." + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyq, cultureUS) + ".");

            lines.Add("!BOTTOMBYPHL: (Is the bottom layer at defined phreatic level, otherwise q=0)");
            lines.Add("." + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Bottombyphl, cultureUS) + ".");

            File.AppendAllLines(FileOUTPUT, lines);
        }

        public static void s_model_output_mesh(Model_ty_model WF15DSatUnsatModel, string FileOUTPUT)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            //List with all the lines of the file
            List<string> lines = new List<string>();
            string templine;

            //System.IO.File.AppendAllLines()
            lines.Add("!****** BLOCK D: MESH **************************************");
            lines.Add("!(nn) Nodes per element | (nc) Class of nodes");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Model_Ty_Mesh.Nn, cultureUS)+" \t"+ Convert.ToString(WF15DSatUnsatModel.Model_Ty_Mesh.Nc, cultureUS));
            
            lines.Add("!(vmod_count) Number of vertical modules");
            lines.Add(Convert.ToString(WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules.Count, cultureUS));

            lines.Add("!(nelemh) Number of elements between vertical modules (number=vmod)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules[i].Nelemh, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(vmod_x) Coord x of each vertical module(first always cero)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Model_Ty_Mesh.Vertical_Modules[i].Vmod_x, cultureUS) + " \t";
            }
            lines.Add(templine);

            lines.Add("!(nelemv) Number of elements per layer (number=number of layers)");
            templine = "";
            for (int i = 0; i < WF15DSatUnsatModel.Com_Ty_Layers.Layers.Count; i++)
            {
                templine = templine + Convert.ToString(WF15DSatUnsatModel.Com_Ty_Layers.Layers[i].Meshelements, cultureUS) + " \t";
            }
            lines.Add(templine);

            File.AppendAllLines(FileOUTPUT, lines);
        }

        public static void s_model_output_boundary(Model_ty_model WF15DSatUnsatModel, string FileOUTPUT)
        {
            CultureInfo cultureUS = new CultureInfo("en-US");
            //List with all the lines of the file
            List<string> lines = new List<string>();

            if (WF15DSatUnsatModel.Com_Ty_Layers.Topboundbyq)
            {
                lines.Add("Time[T] \t Q[L3·T-1·L-2]");
                for (int i = 0; i < WF15DSatUnsatModel.Boundaries.Boundaries.Count; i++)
                {
                    lines.Add(Convert.ToString(WF15DSatUnsatModel.Boundaries.Boundaries[i].Timebound, cultureUS) + " \t" + Convert.ToString(WF15DSatUnsatModel.Boundaries.Boundaries[i].Qbound, cultureUS));
                }
            }
                
            else
            {
                lines.Add("Time[T] \t H[L]");
                for (int i = 0; i < WF15DSatUnsatModel.Boundaries.Boundaries.Count; i++)
                {
                    lines.Add(Convert.ToString(WF15DSatUnsatModel.Boundaries.Boundaries[i].Timebound, cultureUS) + " \t" + Convert.ToString(WF15DSatUnsatModel.Boundaries.Boundaries[i].Hbound, cultureUS));
                }
            }

            File.AppendAllLines(FileOUTPUT, lines);

        }

    }
}
