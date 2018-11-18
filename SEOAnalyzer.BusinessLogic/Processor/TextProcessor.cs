﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOAnalyzer.BusinessLogic.Extractor.Interfaces;
using SEOAnalyzer.Models;
using SEOAnalyzer.Models.Generals;
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

        public async Task<IResultModel> ProcessInput(ISEOViewModel model)
        {
            IResultModel returnModel = new ResultModel();

            //returnModel
            List<LinkModel> links = await Task.Run(() => _linkExtractor.GetLinkFromContent(model.UserInputModel.TextContent));

            return returnModel;
        }
    }
}
