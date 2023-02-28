using System;
using System.Linq;
using System.Data;
using Microsoft.VisualBasic.FileIO; // This namespace usage is important or else TextFieldParser method will lead to error
using System.IO;

namespace GUI15DSATUNSAT
{
    public class ReadCSV
    {
        public DataTable readCSV;

        public ReadCSV(string fileName, string tablename, bool firstRowContainsFieldNames = true)
        {
            readCSV = GenerateDataTable(fileName, tablename, firstRowContainsFieldNames);
        }

        private static DataTable GenerateDataTable(string fileName, string tablename, bool firstRowContainsFieldNames = true)
        {
            //Create datatable
            DataTable result = new DataTable(tablename);
            //create a Datacolumn
            DataRow datarowtemp;
            string[] fields;
            string[] firstline;

            if (fileName == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(fileName);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiters);

                // Get The Column Names
                fields = tfp.ReadFields();

                // Get first line
                firstline = tfp.ReadFields();

                //fieldtypes
                System.Type[] fieldtype = new System.Type[fields.Count()];

                //Build array of types
                for (int i = 0; i < fields.Count(); i++)
                {
                    if (Int32.TryParse(firstline[i], out Int32 intvalue))
                    {
                        fieldtype[i] = typeof(Int32);
                    }
                    else if (Double.TryParse(firstline[i], out Double doublevalue))
                    {
                        fieldtype[i] = typeof(Double);
                    }
                    else
                    {
                        fieldtype[i] = typeof(String);
                    }
                }

                //Build columns
                for (int i = 0; i < fields.Count(); i++)
                {
                    result.Columns.Add(new DataColumn(fields[i], fieldtype[i]));
                }

                //Fill first rows
                datarowtemp = result.NewRow();
                for (int i = 0; i < fields.Count(); i++)
                {
                    switch (fieldtype[i].Name)
                    {
                        case "Int32":
                            datarowtemp[i] = Int32.Parse(firstline[i]);
                            break;
                        case "Double":
                            datarowtemp[i] = Double.Parse(firstline[i]);
                            break;
                        default:
                            datarowtemp[i] = firstline[i];
                            break;
                    }
                }
                result.Rows.Add(datarowtemp);

                //Fill the rest
                while (!tfp.EndOfData)
                {
                    firstline = tfp.ReadFields();
                    datarowtemp = result.NewRow();
                    for (int i = 0; i < fields.Count(); i++)
                    {
                        switch (fieldtype[i].Name)
                        {
                            case "Int32":
                                datarowtemp[i] = Int32.Parse(firstline[i]);
                                break;
                            case "Double":
                                datarowtemp[i] = Double.Parse(firstline[i]);
                                break;
                            default:
                                datarowtemp[i] = firstline[i];
                                break;
                        }
                    }
                    result.Rows.Add(datarowtemp);
                }

                return result;
            }
        }
    }
}
