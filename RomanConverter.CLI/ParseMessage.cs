using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanConverter.CLI
{
    public class ParseMessage
    {
        
        public int ParsedInt { get; set; }

        public bool HasError { get; set; }

        public string ExceptionMessage { get; set; }

    }
}
