using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tools.extension;
using tools.objects;

namespace tools.helper
{
    class ExcelHelper
    {
        protected string _sheetName;
        protected string _filePath;
        protected List<string> _headers;
        protected List<string> _type;
        protected IWorkbook _workbook;
        protected ISheet _sheet;
        private const string DefaultSheetName = "temp";

        public bool Export<T>
              (List<T> exportData, string filePath, string sheetName = DefaultSheetName)
        {
            _filePath = filePath;
            _sheetName = sheetName;

            _workbook = new XSSFWorkbook(); //Creating New Excel object
            _sheet = _workbook.CreateSheet(_sheetName); //Creating New Excel Sheet object

            //var headerStyle = _workbook.CreateCellStyle(); //Formatting
            //var headerFont = _workbook.CreateFont();
            //headerFont.IsBold = true;
            //headerStyle.SetFont(headerFont);

            try
            {
                _headers = new List<string>();
                _type = new List<string>();

                WriteData(exportData); //list object to NPOI excel conversion happens here

                //Header
                var header = _sheet.CreateRow(0);
                for (var i = 0; i < _headers.Count; i++)
                {
                    var cell = header.CreateCell(i);
                    cell.SetCellValue(_headers[i]);
                    //cell.CellStyle = headerStyle;
                    // It's heavy, it slows down your Excel if you have large data                
                    _sheet.AutoSizeColumn(i);
                }

                using (var fs = File.OpenWrite(_filePath))
                {
                    _workbook.Write(fs);   //向打开的这个xls文件中写入并保存。
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            
            //// Declare one MemoryStream variable for write file in stream  
            //var stream = new MemoryStream();
            //_workbook.Write(stream);
            //string FilePath = $"E:\\Study\\gmart\\{_fileName}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.xlsx";
            //FileStream file = new FileStream(FilePath, FileMode.CreateNew, FileAccess.Write);
            //stream.WriteTo(file);
            //file.Close();
            //stream.Close();

            void WriteData(List<T> exportDatas)
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));

                DataTable table = new DataTable();

                foreach (PropertyDescriptor prop in properties)
                {
                    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    _type.Add(type.Name);
                    table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ??
                                      prop.PropertyType);
                    string name = Regex.Replace(prop.Name, "([A-Z])", " $1").Trim();
                    //name by caps for header
                    _headers.Add(name);
                }

                foreach (T item in exportDatas)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }

                IRow sheetRow = null;

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    sheetRow = _sheet.CreateRow(i + 1);

                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        ICell Row1 = sheetRow.CreateCell(j);
                        string cellvalue = Convert.ToString(table.Rows[i][j]);

                        // TODO: move it to switch case
                        if (string.IsNullOrWhiteSpace(cellvalue))
                        {
                            Row1.SetCellValue(string.Empty);
                        }
                        else if (_type[j].ToLower() == "string")
                        {
                            Row1.SetCellValue(cellvalue);
                        }
                        else if (_type[j].ToLower() == "int32")
                        {
                            Row1.SetCellValue(Convert.ToInt32(table.Rows[i][j]));
                        }
                        else if (_type[j].ToLower() == "double")
                        {
                            Row1.SetCellValue(Convert.ToDouble(table.Rows[i][j]));
                        }
                        else if (_type[j].ToLower() == "datetime")
                        {
                            Row1.SetCellValue(Convert.ToDateTime
                                 (table.Rows[i][j]).ToString("dd/MM/yyyy hh:mm:ss"));
                        }
                        else if (_type[j].ToLower() == "parcelspec[]")
                        {
                            Row1.SetCellValue((table.Rows[i][j] as Parcel[]).ParcelSpecArrToStringEx());//TODO:extend row including list field
                        }
                        else 
                        {
                            Row1.SetCellValue(table.Rows[i][j].ToString());
                        }
                    }
                }
            }
        }
    }
}
