using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using SEOAnalyzer.Models;
using SEOAnalyzer.Models.Generals;
using SEOAnalyzer.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOAnalyzer.BusinessLogic.Processor
{
    public class UrlProcessor : IProcessor
    {
        ILinkExtractor _linkExtractor;
        public string InputText { get; set; }

        public UrlProcessor(ILinkExtractor linkExtractor)
        {
            _linkExtractor = linkExtractor;
        }

        public IResultModel ProcessInput(ISEOViewModel model)
        {
            IResultModel returnModel = new ResultModel();

            // 1. Extract Url link information from URL input
            List<LinkModel> links = _linkExtractor.GetLinkFromUrl(model.UserInputModel.UrlContent);
            returnModel.Links = links;

            // 2. TODO

            return returnModel;
        }
    }
}
