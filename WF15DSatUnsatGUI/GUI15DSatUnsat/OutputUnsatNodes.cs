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
    public class OutputUnsatNodes
    {
        public BindingList<OutputUnsatNodesField> Items;

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


        public OutputUnsatNodes(string fileName)
        {
            FileName = fileName;
            Items = ReadDataTable(fileName);

            Update_numIU();
            Update_t();

        }

        public OutputUnsatNodes()
        {
            FileName = "";
            Items = new BindingList<OutputUnsatNodesField>();
        }



        private BindingList<OutputUnsatNodesField> ReadDataTable(string fileName)
        {
            //DataTable result = new DataTable("Constraints");
            //DataRow datarowtemp;
            BindingList<OutputUnsatNodesField> result = new BindingList<OutputUnsatNodesField>();
            OutputUnsatNodesField tempfield = new OutputUnsatNodesField();

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

        private OutputUnsatNodesField GetField(string[] fields)
        {
            //t,iu,x,z,h,th
            OutputUnsatNodesField result = new OutputUnsatNodesField();

            //result.ID = Convert.ToUInt32(fields[0], Culture);
            result.T = Convert.ToDouble(fields[0], Culture);
            result.IU = Convert.ToUInt32(fields[1], Culture);
            result.x = Convert.ToDouble(fields[2], Culture);
            result.z = Convert.ToDouble(fields[3], Culture);
            result.h = Convert.ToDouble(fields[4], Culture);
            result.th = Convert.ToDouble(fields[5], Culture);

            return result;

        }

        public void Update()
        {
            OutputUnsatNodesField tempfield = new OutputUnsatNodesField();
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

        private void Update_numIU()
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
