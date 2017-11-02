using System;

namespace Frends.Tasks.Attributes
{
    public class CustomDisplay : Attribute
    {
        public CustomDisplay(DisplayOption option)
        {
            Option = option;
        }
        public DisplayOption Option { get; set; }
    }
}