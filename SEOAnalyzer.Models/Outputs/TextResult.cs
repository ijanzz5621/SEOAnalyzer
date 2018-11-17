﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOAnalyzer.Models.Generals;

namespace SEOAnalyzer.Models.Outputs
{
    public class TextResult : IResultModel
    {
        public string Content { get; set; }
        public List<MetaModel> Metas { get; set; }
        public List<KeywordModel> Keywords { get; set; }
        public List<string> Links { get; set; }
    }
}
