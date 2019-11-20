using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BL
{
    public class ResultModel
    {
        public List<string> Reasons { get; set; }
        public List<IDictionary<string, object>> Durations { get; set; }
        public List<TotalResultModel> ReasonTotal { get; set; }
    }
}
