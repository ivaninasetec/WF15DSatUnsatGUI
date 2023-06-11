using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI15DSATUNSAT
{
    public class OutputConstraintField
    {
        public UInt32 IDconstraint {get; set;}
        public double T { get; set; }
        public UInt64 Iteration { get; set; }
        public UInt32 IU { get; set; }
        public UInt32 IS { get; set; }
        public double v_idelem_hsat { get; set; }
        public double v_hnew { get; set; }
        public double v_thnew { get; set; }
        public double v_hsat { get; set; }
        public double v_qvtb { get; set; }
        public double v_qvt { get; set; }
        public double v_qvb { get; set; }
        public double v_incvoldt { get; set; }
        public double v_Qs_layer { get; set; }
        public double v_Qs_all { get; set; }
        public double nrel { get; set; }
        public double h_width { get; set; }
        public double h_hsat_mean { get; set; }
        public double h_qent_mean { get; set; }
        public double h_incvoldt_mean { get; set; }
        public double h_dqhordx_mean { get; set; }
        public double h_dqhordx_all_mean { get; set; }
        public double inchnew_mean { get; set; }
    }
}
