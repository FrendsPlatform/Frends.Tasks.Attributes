using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Frends.Tasks.Attributes
{
    public class DefaultDisplayTypeAttribute : Attribute
    {
        public DefaultDisplayTypeAttribute(DisplayType type)
        {
            Type = type;
        }

        public DisplayType Type { get; set; }
    }

    public enum DisplayType
    {
        Text,
        MultilineText,
        Json,
        Xml,
        Sql,
        Expression
    }
}
