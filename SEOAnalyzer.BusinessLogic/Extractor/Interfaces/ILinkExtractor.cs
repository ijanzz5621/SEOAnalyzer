using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAnalyzer.BusinessLogic.Extractor.Interfaces
{
    public interface ILinkExtractor : IExtractor
    {
        string UrlPath { get; set; }
        List<string> GetLinkFromContent(string content);
    }
}
