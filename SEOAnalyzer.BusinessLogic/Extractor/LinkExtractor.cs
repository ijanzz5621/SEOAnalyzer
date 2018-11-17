using HtmlAgilityPack;
using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using SEOAnalyzer.Models.Generals;
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

        public List<LinkModel> GetLinkFromContent(string content)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(content);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {

            }

            return new List<LinkModel>();
        }

        public List<LinkModel> GetLinkFromUrl(string url)
        {
            List<LinkModel> returnList = new List<LinkModel>();

            HtmlWeb hw = new HtmlWeb();
            HtmlDocument doc = hw.Load(url);
            foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                var newItem = new LinkModel
                {
                    Name = link.Name
                    ,
                    Path = link.XPath
                };
                returnList.Add(newItem);
            }

            return returnList;
        }
    }
}
