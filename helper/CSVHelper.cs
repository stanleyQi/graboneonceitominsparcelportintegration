using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools.helper
{
    public class CSVHelper
    {
        public static List<T> Read<T>(string path, CsvFileDescription fileDescription) where T : class, new()
        {
            CsvContext _csv = new CsvContext();
            return _csv.Read<T>(path, fileDescription).ToList();
        }
        public static List<T> Read<T>(string path) where T : class, new()
        {
            CsvContext _csv = new CsvContext();
            CsvFileDescription _fileDescription = new CsvFileDescription()
            {
                SeparatorChar = ',',
                //首行数据是否含有列名
                FirstLineHasColumnNames = true,
                //是否启用CsvColumn属性标记
                EnforceCsvColumnAttribute = true,
                //是否忽略未知的行
                IgnoreUnknownColumns = true,
                //是否启用OutputFormat格式转换数据
                UseOutputFormatForParsingCsvValue = true,
                //是否启用属性下标读取数据
                UseFieldIndexForReadingData = true,
                //文本编码格式
                TextEncoding = Encoding.UTF8
            };
            return _csv.Read<T>(path, _fileDescription).ToList();
        }
    }
}
