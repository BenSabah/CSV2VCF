using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CSV2VCF
{
    public static class Utils
    {
        private static IEnumerable<string> readFile(string i_CsvFilePath)
        {
            return File.ReadLines(i_CsvFilePath, Encoding.Default);
        }

        public static bool ReadCsvFileAs2dArray(string i_CsvFilePath, out string[][] fileAsArray)
        {
            try
            {
                string[] fileAsLines = readFile(i_CsvFilePath).ToArray();
                fileAsArray = fileAsLines.Select(x => x.Split(',')).ToArray();
                return true;
            }
            catch (Exception)
            {
                fileAsArray = null;
                return false;
            }
        }

        public static bool searchClipboardFor2dArray(out string[][] data)
        {
            try
            {
                var rawClipboardData = Clipboard.GetDataObject();
                var stream = (Stream)rawClipboardData.GetData(DataFormats.CommaSeparatedValue);
                string clipboardParsedData = (new StreamReader(stream, Encoding.Default)).ReadToEnd().Trim().Trim('\0');
                string[] lines = clipboardParsedData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                List<string[]> dataAsList = new List<string[]>();

                for (int i = 0; i < lines.Length; i++)
                {
                    string s = lines[i].Trim().Trim('\0');
                    if (s.Length == 0) { continue; }
                    dataAsList.Add(s.Split(','));
                }

                data = dataAsList.ToArray();
                return true;
            }

            catch (Exception)
            {
                data = null;
                return false;
            }
        }

        public static void writeDataToFile(string path, string FileData)
        {
            File.WriteAllText(path, FileData);
        }

        public static string flattenedException(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            Exception innerException = e;
            do
            {
                sb.Append(innerException);
                innerException = innerException.InnerException;
            }
            while (innerException != null);
            return sb.ToString();
        }

        public static void SwapColumns(object[][] table, int idx1, int idx2)
        {
            int lines = table.GetUpperBound(0);

            for (int i = 0; i < lines; i++)
            {
                object tmp = table[i][idx1];
                table[i][idx1] = table[i][idx2];
                table[i][idx2] = tmp;
            }
        }
    }
}
