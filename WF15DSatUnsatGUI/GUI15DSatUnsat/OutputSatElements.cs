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
    public class OutputSatElements
    {
        public BindingList<OutputSatElementsField> Items;

        public int nfields = 0;
        public string FileName;
        private System.Type[] fieldtype;

        public CultureInfo Culture = new CultureInfo("en-US");
        public string[] separatingStrings = { "," };
        public string TimeNumberFormat = "0.000";

        private List<uint> numIS;
        public List<uint> NumIS { get { return numIS; } set { numIS = value; } }

        private List<string> t;
        public List<string> T { get { return t; } set { t = value; } }

        public OutputSatElements(string fileName)
        {
            //FileName = fileName;
            //Items = ReadDataTable(fileName);
            //numIS = new List<uint>();
            //List<uint> tempint = new List<uint>();
            //tempint = Items.Select(x => x.IS).ToList();
            //numIS = tempint.GroupBy(x => x).Select(y => y.First()).ToList();
            FileName = fileName;
            Items = ReadDataTable(fileName);

            Update_numIS();
            Update_t();

        }

        public OutputSatElements()
        {
            FileName = "";
            Items = new BindingList<OutputSatElementsField>();
        }



        private BindingList<OutputSatElementsField> ReadDataTable(string fileName)
        {
            //DataTable result = new DataTable("Constraints");
            //DataRow datarowtemp;
            BindingList<OutputSatElementsField> result = new BindingList<OutputSatElementsField>();
            OutputSatElementsField tempfield = new OutputSatElementsField();

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

        private OutputSatElementsField GetField(string[] fields)
        {
            //t,is,ie,x0,x1,z0,z1,h0,h1,h,dhdx,dhzdx,qent,incvoldt,dqhordx,dqhordx_all,dqhordx_from_incvoldt,dqhordx_from_incvoldt_all,q,q_all
            OutputSatElementsField result = new OutputSatElementsField();

            //result.ID = Convert.ToUInt32(fields[0], Culture);
            result.T = Convert.ToDouble(fields[0], Culture);
            result.IS = Convert.ToUInt32(fields[1], Culture);
            result.IE = Convert.ToUInt32(fields[2], Culture);
            result.x0 = Convert.ToDouble(fields[3], Culture);
            result.x1 = Convert.ToDouble(fields[4], Culture);
            result.z0 = Convert.ToDouble(fields[5], Culture);
            result.z1 = Convert.ToDouble(fields[6], Culture);
            result.h0 = Convert.ToDouble(fields[7], Culture);
            result.h1 = Convert.ToDouble(fields[8], Culture);
            result.h = Convert.ToDouble(fields[9], Culture);
            result.dhdx = Convert.ToDouble(fields[10], Culture);
            result.dhzdx = Convert.ToDouble(fields[11], Culture);
            result.qent = Convert.ToDouble(fields[12], Culture);
            result.incvoldt = Convert.ToDouble(fields[13], Culture);
            result.dqhordx = Convert.ToDouble(fields[14], Culture);
            result.dqhordx_all = Convert.ToDouble(fields[15], Culture);
            result.dqhordx_from_incvoldt = Convert.ToDouble(fields[16], Culture);
            result.dqhordx_from_incvoldt_all = Convert.ToDouble(fields[17], Culture);
            result.q = Convert.ToDouble(fields[18], Culture);
            result.q_all = Convert.ToDouble(fields[19], Culture);

            return result;

        }

        public void Update()
        {
            OutputSatElementsField tempfield = new OutputSatElementsField();
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
            numIS = new List<uint>();
            List<uint> tempint = new List<uint>();
            tempint = Items.Select(x => x.IS).ToList();
            numIS = tempint.GroupBy(x => x).Select(y => y.First()).ToList();
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
