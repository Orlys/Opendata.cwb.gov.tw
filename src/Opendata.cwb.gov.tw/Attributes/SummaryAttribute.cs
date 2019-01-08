
namespace Opendata.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [AttributeUsage(AttributeTargets.All)]
    public sealed class SummaryAttribute : Attribute
    {
        public SummaryAttribute(string summary)
        {
            this.Summary = summary;
        }

        public string Summary { get; }
    }
}
