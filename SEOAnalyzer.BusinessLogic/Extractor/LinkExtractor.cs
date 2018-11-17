using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAnalyzer.BusinessLogic.Extractor
{
    public class LinkExtractor : ILinkExtractor
    {
        public string UrlPath { get; set; }

        public List<string> GetLinkFromContent(string content)
        {

            return new List<string>();
        }
    }
}
