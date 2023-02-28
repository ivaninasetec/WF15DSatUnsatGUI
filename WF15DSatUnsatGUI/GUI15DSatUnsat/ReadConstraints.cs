using Microsoft.VisualBasic.FileIO;
using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI15DSATUNSAT
{
    public class ReadConstraints
    {
        public DataTable OutputTable;
        public int nfields=0;
        public string FileName;
        private System.Type[] fieldtype;

        public CultureInfo Culture = new CultureInfo("en-US");
        public string[] separatingStrings = { "," };

        public ReadConstraints(string fileName)
        {
            FileName=fileName;
            OutputTable = ReadDataTable(fileName);
        }

        public ReadConstraints()
        {
            FileName = "";
            OutputTable = new DataTable();
        }



        private DataTable ReadDataTable(string fileName)
        {
            DataTable result = new DataTable("Constraints");
            DataRow datarowtemp;
            string[] firstline;
            string[] fields;
            List<string> lines=new List<string>();

            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs, Encoding.Default))
            {
                string templine;
                while ((templine = sr.ReadLine()) != null)
                {
                    lines.Add(templine);
                }
            }

            nfields= lines.Count();
            
            //fieldtypes
            firstline = lines[0].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
            fieldtype = new System.Type[firstline.Length];

            //Build array of types
            fieldtype[0] = typeof(Int32); //idconstraint
            fieldtype[1] = typeof(Double); //t
            fieldtype[2] = typeof(Int32); //iteration
            fieldtype[3] = typeof(Int32); //iu
            fieldtype[4] = typeof(Int32); //is
            //fieldtype[5] = typeof(Double); //v_idelem_hsat
            //fieldtype[6] = typeof(Double); //v_hnew
            //fieldtype[7] = typeof(Double); //v_thnew
            //fieldtype[8] = typeof(Double); //v_hsat
            //fieldtype[9] = typeof(Double); //v_qvtb
            //fieldtype[10] = typeof(Double); //v_qvt
            //fieldtype[11] = typeof(Double); //v_qvb
            //fieldtype[12] = typeof(Double); //v_incvoldt
            //fieldtype[13] = typeof(Double); //v_Qs_layer
            //fieldtype[14] = typeof(Double); //v_Qs_all
            //fieldtype[15] = typeof(Double); //nrel
            //fieldtype[16] = typeof(Double); //h_width
            //fieldtype[17] = typeof(Double); //h_hsat_mean
            //fieldtype[18] = typeof(Double); //h_qent_mean
            //fieldtype[19] = typeof(Double); //h_incvoldt_mean
            //fieldtype[20] = typeof(Double); //h_dqhordx_mean
            //fieldtype[21] = typeof(Double); //h_dqhordx_all_mean
            for (int i = 5;i < fieldtype.Length; i++) fieldtype[i] = typeof(Double);

            //Build Columns
            for (int i = 0; i < firstline.Count(); i++)
            {
                result.Columns.Add(new DataColumn(firstline[i], fieldtype[i]));
            }

            //fill first rows
            for (int i = 1; i < lines.Count(); i++)
            {
                datarowtemp = result.NewRow();
                fields = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
                for (int j = 0; j < fields.Count(); j++)
                    switch (fieldtype[j].Name)
                {
                    case "Int32":
                        datarowtemp[j] = Convert.ToInt32(fields[j],Culture);
                        break;
                    case "Double":
                        datarowtemp[j] = Convert.ToDouble(fields[j], Culture);
                        break;
                    default:
                        datarowtemp[j] = fields[j];
                        break;
                }
                result.Rows.Add(datarowtemp);
            }
            return result;
        }

        public void Update()
        {
            DataRow datarowtemp;
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
                datarowtemp = OutputTable.NewRow();
                fields = lines[i].Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries); //Read data separated by spaces
                for (int j = 0; j < fields.Length; j++)
                    switch (fieldtype[j].Name)
                    {
                        case "Int32":
                            datarowtemp[j] = Convert.ToInt32(fields[j], Culture);
                            break;
                        case "Double":
                            datarowtemp[j] = Convert.ToDouble(fields[j], Culture);
                            break;
                        default:
                            datarowtemp[j] = fields[j];
                            break;
                    }
                OutputTable.Rows.Add(datarowtemp);
            }

        }

    }
}
