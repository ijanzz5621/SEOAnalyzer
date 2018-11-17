using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using SEOAnalyzer.Models;
using SEOAnalyzer.Models.Outputs;

namespace SEOAnalyzer.BusinessLogic.Processor
{
    public class TextProcessor : IProcessor
    {
        ILinkExtractor _linkExtractor;

        public string InputText { get; set; }

        public TextProcessor(ILinkExtractor linkExtractor)
        {
            _linkExtractor = linkExtractor;
        }

        public IResultModel ProcessInput(ISEOViewModel model)
        {
            IResultModel returnModel = new ResultModel();

            //returnModel
            List<string> links = _linkExtractor.GetLinkFromContent(model.UserInputModel.TextContent);

            List<string> test = new List<string>();

            return returnModel;
        }
    }
}
