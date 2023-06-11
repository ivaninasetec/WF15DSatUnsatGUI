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
    public class OutputConstraints
    {
        public BindingList<OutputConstraintField> Items;

        public int nfields = 0;
        public string FileName;
        private System.Type[] fieldtype;

        public CultureInfo Culture = new CultureInfo("en-US");
        public string[] separatingStrings = { "," };

        private List<uint> numIS;
        public List<uint> NumIS { get { return numIS; } set { numIS = value; } }

        private List<uint> numIU;
        public List<uint> NumIU { get { return numIU; } set { numIU = value; } }


        public OutputConstraints(string fileName)
        {
            FileName = fileName;
            Items = ReadDataTable(fileName);
            numIS = new List<uint>();
            numIU = new List<uint>();
            List<uint> tempint = new List<uint>();
            tempint = Items.Select(x => x.IS).ToList();
            numIS = tempint.GroupBy(x => x).Select(y => y.First()).ToList();
            tempint = Items.Select(x => x.IU).ToList();
            numIU = tempint.GroupBy(x => x).Select(y => y.First()).ToList();
        }

        public OutputConstraints()
        {
            FileName = "";
            Items = new BindingList<OutputConstraintField>();
        }



        private BindingList<OutputConstraintField> ReadDataTable(string fileName)
        {
            //DataTable result = new DataTable("Constraints");
            //DataRow datarowtemp;
            BindingList<OutputConstraintField> result = new BindingList<OutputConstraintField>();
            OutputConstraintField tempfield = new OutputConstraintField();

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

                result.Add(tempfield);
            }
            return result;
        }

        private OutputConstraintField GetField(string[] fields)
        {
            OutputConstraintField result = new OutputConstraintField();

            result.IDconstraint = Convert.ToUInt32(fields[0], Culture);
            result.T = Convert.ToDouble(fields[1], Culture);
            result.Iteration = Convert.ToUInt64(fields[2], Culture);
            result.IU = Convert.ToUInt32(fields[3], Culture);
            result.IS = Convert.ToUInt32(fields[4], Culture);
            result.v_idelem_hsat = Convert.ToDouble(fields[5], Culture);
            result.v_hnew = Convert.ToDouble(fields[6], Culture);
            result.v_thnew = Convert.ToDouble(fields[7], Culture);
            result.v_hsat = Convert.ToDouble(fields[8], Culture);
            result.v_qvtb = Convert.ToDouble(fields[9], Culture);
            result.v_qvt = Convert.ToDouble(fields[10], Culture);
            result.v_qvb = Convert.ToDouble(fields[11], Culture);
            result.v_incvoldt = Convert.ToDouble(fields[12], Culture);
            result.v_Qs_layer = Convert.ToDouble(fields[13], Culture);
            result.v_Qs_all = Convert.ToDouble(fields[14], Culture);
            result.nrel = Convert.ToDouble(fields[15], Culture);
            result.h_width = Convert.ToDouble(fields[16], Culture);
            result.h_hsat_mean = Convert.ToDouble(fields[17], Culture);
            result.h_qent_mean = Convert.ToDouble(fields[18], Culture);
            result.h_incvoldt_mean = Convert.ToDouble(fields[19], Culture);
            result.h_dqhordx_mean = Convert.ToDouble(fields[20], Culture);
            result.h_dqhordx_all_mean = Convert.ToDouble(fields[21], Culture);
            result.inchnew_mean = Convert.ToDouble(fields[22], Culture);

            return result;

        }

        public void Update()
        {
            OutputConstraintField tempfield = new OutputConstraintField();
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

                Items.Add(tempfield);
            }
        }


    }
}
