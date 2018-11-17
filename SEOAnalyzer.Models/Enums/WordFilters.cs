using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAnalyzer.Models.Enums
{
    public static class WordFilters
    {
        public static List<string> StopWords { get; set; } = new List<string>() {

                "AND", "OR", "A", "THE", "."

            };


    }
}
