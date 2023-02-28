using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI15DSATUNSAT
{
    public class OutputUnsatElementsField
    {
        //t,iu,nelem,x0,x1,hnew,hold,thnew,thold,qent,qsal,qmed,incvoldt,kmed,h0,h1,th0,th1,k0,k1,dhdx0,dhdx1,dhxdx0,dhxdx1,dhdxmed,dhxdxmed
        public UInt32 ID {get; set;}
        public double T { get; set; }
        public UInt32 IU { get; set; }
        public UInt32 nelem { get; set; }
        public double x0 { get; set; }
        public double x1 { get; set; }
        public double hnew { get; set; }
        public double hold { get; set; }
        public double thnew { get; set; }
        public double thold { get; set; }
        public double qent { get; set; }
        public double qsal { get; set; }
        public double qmed { get; set; }
        public double incvoldt { get; set; }
        public double kmed { get; set; }
        public double h0 { get; set; }
        public double h1 { get; set; }
        public double th0 { get; set; }
        public double th1 { get; set; }
        public double k0 { get; set; }
        public double k1 { get; set; }
        public double dhdx0 { get; set; }
        public double dhdx1 { get; set; }
        public double dhxdx0 { get; set; }
        public double dhxdx1 { get; set; }
        public double dhdxmed { get; set; }
        public double dhxdxmed { get; set; }

    }
}
