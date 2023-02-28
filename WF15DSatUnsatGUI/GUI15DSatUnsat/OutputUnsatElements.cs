using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.CodeDom.Compiler;

namespace GUI15DSATUNSAT
{
    public class OutputUnsatElements
    {
        public BindingList<OutputUnsatElementsField> Items;

        public int nfields = 0;
        public string FileName;
        private System.Type[] fieldtype;

        public CultureInfo Culture = new CultureInfo("en-US");
        public string[] separatingStrings = { "," };
        public string TimeNumberFormat = "0.000";

        private List<uint> numIU;
        public List<uint> NumIU { get { return numIU; } set { numIU = value; } }
        private List<string> t;
        public List<string> T { get { return t; } set { t = value; } }

        public OutputUnsatElements(string fileName)
        {
            FileName = fileName;
            Items = ReadDataTable(fileName);

            Update_numIS();
            Update_t();

        }

        public OutputUnsatElements()
        {
            FileName = "";
            Items = new BindingList<OutputUnsatElementsField>();
        }



        private BindingList<OutputUnsatElementsField> ReadDataTable(string fileName)
        {
            //DataTable result = new DataTable("Constraints");
            //DataRow datarowtemp;
            BindingList<OutputUnsatElementsField> result = new BindingList<OutputUnsatElementsField>();
            OutputUnsatElementsField tempfield = new OutputUnsatElementsField();

            string[] firstline;
            string[] fields;
            List<string> lines = new List<string>();

            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            nfields = lines.Count();

            //fieldtypes
            firstline = lines[0].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
            fieldtype = new System.Type[firstline.Length];

            //fill first rows
            for (int i = 1; i < lines.Count(); i++)
            {
                fields = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
                
                tempfield = GetField(fields);
                tempfield.ID = Convert.ToUInt32(i);

                result.Add(tempfield);
            }
            return result;
        }

        private OutputUnsatElementsField GetField(string[] fields)
        {
            //t,iu,nelem,x0,x1,hnew,hold,thnew,thold,qent,qsal,qmed,incvoldt,kmed,h0,h1,th0,th1,k0,k1,dhdx0,dhdx1,dhxdx0,dhxdx1,dhdxmed,dhxdxmed
            OutputUnsatElementsField result = new OutputUnsatElementsField();

            //result.ID = Convert.ToUInt32(fields[0], Culture);
            result.T = Convert.ToDouble(fields[0], Culture);
            result.IU = Convert.ToUInt32(fields[1], Culture);
            result.nelem = Convert.ToUInt32(fields[2], Culture);
            result.x0 = Convert.ToDouble(fields[3], Culture);
            result.x1 = Convert.ToDouble(fields[4], Culture);
            result.hnew = Convert.ToDouble(fields[5], Culture);
            result.hold = Convert.ToDouble(fields[6], Culture);
            result.thnew = Convert.ToDouble(fields[7], Culture);
            result.thold = Convert.ToDouble(fields[8], Culture);
            result.qent = Convert.ToDouble(fields[9], Culture);
            result.qsal = Convert.ToDouble(fields[10], Culture);
            result.qmed = Convert.ToDouble(fields[11], Culture);
            result.incvoldt = Convert.ToDouble(fields[12], Culture);
            result.kmed = Convert.ToDouble(fields[13], Culture);
            result.h0 = Convert.ToDouble(fields[14], Culture);
            result.h1 = Convert.ToDouble(fields[15], Culture);
            result.th0 = Convert.ToDouble(fields[16], Culture);
            result.th1 = Convert.ToDouble(fields[17], Culture);
            result.k0 = Convert.ToDouble(fields[18], Culture);
            result.k1 = Convert.ToDouble(fields[19], Culture);
            result.dhdx0 = Convert.ToDouble(fields[20], Culture);
            result.dhdx1 = Convert.ToDouble(fields[21], Culture);
            result.dhxdx0 = Convert.ToDouble(fields[22], Culture);
            result.dhxdx1 = Convert.ToDouble(fields[23], Culture);
            result.dhdxmed = Convert.ToDouble(fields[24], Culture);
            result.dhxdxmed = Convert.ToDouble(fields[25], Culture);

            return result;

        }

        public void Update()
        {
            OutputUnsatElementsField tempfield = new OutputUnsatElementsField();
            int nfieldsini = nfields;
            List<string> lines = new List<string>();

            using (var fs = new FileStream(FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            nfields = lines.Count();
            string[] fields;


            //fill first rows
            for (int i = nfieldsini; i < nfields; i++)
            {
                fields = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces

                tempfield = GetField(fields);
                tempfield.ID = Convert.ToUInt32(i + 1);
                Items.Add(tempfield);
            }
        }

        private void Update_numIS()
        {
            numIU = new List<uint>();
            List<uint> tempint = new List<uint>();
            tempint = Items.Select(x => x.IU).ToList();
            numIU = tempint.GroupBy(x => x).Select(y => y.First()).ToList();
        }

        private void Update_t()
        {
            t = new List<string>();
            List<string> tempt = new List<string>();
            tempt = Items.Select(x => x.T.ToString(TimeNumberFormat)).ToList();
            t = tempt.GroupBy(x => x).Select(y => y.First()).ToList();
        }

    }
}
