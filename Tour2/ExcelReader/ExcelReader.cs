using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour2.ExcelReader
{
   public class ExcelReader
    {
         public static string result;
        public static string ReadData(string FilePath,string Sheet,string TC,string Coloum)
        {
            FileStream stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataTable table = reader.AsDataSet().Tables[Sheet];
           
            for (int row =0; row<table.Rows.Count;row++)
            {
                if ((table.Rows[row][1].ToString() == TC))
                {
                    result = table.Rows[row][Coloum].ToString();
                    break;
                }
                
            }
            return result;
        }
        
    }
}
//Console.WriteLine(ExcelReader.ExcelReader.ReadData(@"D:\PractiveFiles\ExcelReaderFile.xlsx", "Login", "RF_WEB_POU_SetPhy_000001", "UserID"));
