using SEOAnalyzer.Models;
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
        public string InputText { get; set; }

        public IResultModel ProcessInput(ISEOViewModel model)
        {
            IResultModel returnModel = new ResultModel();

            //returnModel.LinkResults

            return returnModel;
        }
    }
}
