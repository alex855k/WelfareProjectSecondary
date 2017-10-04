using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace LogConversionService
{
    public class LogFile
    {
        private List<Dictionary<string, string[]>> FileLines;
        private List<FileReader> FileReaders = new List<FileReader>();
        private LogFile(object file)
        {
            ConvertFile(file);
        }

        private void ConvertFile(object o)
        {
            string s = (string)o;


        }
    }
}