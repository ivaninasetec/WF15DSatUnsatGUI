using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI15DSATUNSAT
{
    public class OutputSatElementsField
    {
        //t,is,ie,x0,x1,z0,z1,h0,h1,h,dhdx,dhzdx,qent,incvoldt,dqhordx,dqhordx_all,dqhordx_from_incvoldt,dqhordx_from_incvoldt_all,q,q_all
        public UInt32 ID {get; set;}
        public double T { get; set; }
        public UInt32 IS { get; set; }
        public UInt32 IE { get; set; }
        public double x0 { get; set; }
        public double x1 { get; set; }
        public double z0 { get; set; }
        public double z1 { get; set; }
        public double h0 { get; set; }
        public double h1 { get; set; }
        public double h { get; set; }
        public double dhdx { get; set; }
        public double dhzdx { get; set; }
        public double qent { get; set; }
        public double incvoldt { get; set; }
        public double dqhordx { get; set; }
        public double dqhordx_all { get; set; }
        public double dqhordx_from_incvoldt { get; set; }
        public double dqhordx_from_incvoldt_all { get; set; }
        public double q { get; set; }
        public double q_all { get; set; }
    }
}
