using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace CADIfox_MVVM.ExcelControl
{
    public static class ExcelToData
    {
        public static List<DataTable> ReadExcelDataTbales(string path, bool isFirstRowHeader = true)
        {
            var dataTables = new List<DataTable>();
            var wk = GetWorkBook(path);

            var sheetCount = wk.NumberOfSheets;

            for (int i = 0; i < sheetCount; i++)
            {
                var dataTable = ReadExcel2DataTable(wk, i, isFirstRowHeader);
                dataTables.Add(dataTable);
            }

            return dataTables;
        }

        public static IWorkbook GetWorkBook(string path)
        {
            IWorkbook wk = null;
            var fs = File.OpenRead(path);

            if (path.Contains("xls"))
            {
                wk = new HSSFWorkbook(fs);
                //MessageBox.Show("若程序出错，请将EXCEL保存为2007版本以上");
                return wk;
            }
            else if (path.Contains("xlsx"))
            {
                wk = new XSSFWorkbook(fs);
                //MessageBox.Show("若程序出错，请将EXCEL保存为2007版本以下");
                return wk;
            }
            else
            {
                MessageBox.Show("请选择Excel文件");
                return null;
            }
        }

        public static DataTable ReadExcel2DataTable(IWorkbook wk, int sheetIndex, bool isFirstRowHeader)
        {
            DataTable dt = new DataTable();

            ISheet sheet = wk.GetSheetAt(sheetIndex);  //读取索引的表数据

            dt = new DataTable(sheet.SheetName);   //dt.tableName

            //获取sheet的首行
            IRow headerRow = sheet.GetRow(0);
            int columnCount = headerRow.LastCellNum;
            int rowCount = sheet.LastRowNum;
            //dt新建列
            int startRowNum = 0; //当首行是标题时，数据从第1行开始读取。否则，从第0行读取。
            if (isFirstRowHeader)
            {
                for (int i = 0; i < columnCount; i++)
                {
                    dt.Columns.Add(headerRow.GetCell(i).ToString(), typeof(String));
                }
                startRowNum = 1;
            }
            else
            {
                for (int i = 0; i < columnCount; i++)
                {
                    dt.Columns.Add("列" + i, typeof(String));
                }
                startRowNum = 0;
            }

            //遍历

            for (int i = 0; i < rowCount; i++)  //
            {
                //每次开始遍历表时刷新列表
                DataRow dataRow = dt.NewRow();
                //dt.Rows.Add();
                IRow row = sheet.GetRow(i + startRowNum);  //从开始行
                if (row != null)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        ICell cell = row.GetCell(j);
                        if (cell != null)
                        {
                            //dt.Rows[i][j] = cell.ToString();
                            dataRow[j] = cell.ToString();
                        }
                    }

                    dt.Rows.Add(dataRow);
                }
            }

            return dt;
        }
    }
}
