using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Domain
{
    public class Settings
    {
        public Settings(string language, int fontSize, string theam)
        { 
            Language = language;
            FontSize = fontSize;
            Theam = theam;
        }

        public string Language { get; set; }
        public int FontSize { get; set; }
        public string Theam { get; set; }
    }
}
