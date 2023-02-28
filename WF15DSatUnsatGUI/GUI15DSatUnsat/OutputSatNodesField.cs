using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI15DSATUNSAT
{
    public class OutputSatNodesField
    {
        //t,is,x,z,head,qent,qincvol,qhor,dqhordx,dqhordx_from_incvol,qhor_all,dqhordx_all,dqhordx_from_incvol_all
        public UInt32 ID {get; set;}
        public double T { get; set; }
        public UInt32 IS { get; set; }
        public double x { get; set; }
        public double z { get; set; }
        public double head { get; set; }
        public double qent { get; set; }
        public double qincvol { get; set; }
        public double qhor { get; set; }
        public double dqhordx { get; set; }
        public double dqhordx_from_incvol { get; set; }
        public double qhor_all { get; set; }
        public double dqhordx_all { get; set; }
        public double dqhordx_from_incvol_all { get; set; }
    }
}
