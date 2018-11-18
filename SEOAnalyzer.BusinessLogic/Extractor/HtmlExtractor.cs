using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SEOAnalyzer.BusinessLogic.Extractor
{
    public class HtmlExtractor : IHtmlExtractor
    {
        //public string UrlPath { get; set; }

        public async Task<string> GetContentFromUrl(string url)
        {
            WebClient client = new WebClient();

            return await client.DownloadStringTaskAsync(url);
        }
    }
}
