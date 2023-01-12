using ExcelDataReader;
using OpenQA.Selenium.DevTools.V106.Runtime;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelFramework.TestDataAccess
{
    public class ExcelOperations
    {

        //set the properties to Excel File
        public static DataTable ExcelToDataTable(string FilPath)
        {
            //Opeing a File
            FileStream stream = File.Open(FilPath, FileMode.Open, FileAccess.Read);

            //Encoding Data
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            //Configuring poperties to read Excel File
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);


            //Make Header row false or not readable
            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                }
            });

            //Get all the tables
            DataTableCollection table = result.Tables;

            //Store in DataTable

            DataTable resultTable = table["DataSet"];
            return resultTable;

        }



        //Perform navigation in table with row and col
        static List<DataCollection> datacol = new List<DataCollection>();

        public static void PopulateInColletion(String Filepath)
        {
            DataTable table = ExcelToDataTable(Filepath);

            for (int row = 1; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    DataCollection dtTable = new DataCollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };

                    datacol.Add(dtTable);
                }
            }
        }


        //Read the data from Excel datatable
        public static string ReadData(int rowNumber, string columName)
        {
            try
               {
                    string data = (from colData in datacol
                                   where colData.colName == columName
                                   && colData.rowNumber == rowNumber
                                   select colData.colValue).SingleOrDefault();
                    return data.ToString(); 
                }
            catch(Exception E)
                {
                    return null;                
                }

        }

    }
}
