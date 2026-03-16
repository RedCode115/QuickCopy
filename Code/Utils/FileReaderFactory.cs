using DL_db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class FileReaderFactory
    {
        public static ICodeReader GeefBedrijvenBestandsLezer(string fileType)
        {
            switch (fileType)
            {
                case "TXT": return new CodeFileReader();
                //case "JSON":return new BedrijfsBestandsLezerJson();
                default: return null;
            }
        }
    }
}
