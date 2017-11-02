using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frends.Tasks.Attributes
{
    public class ConditionalDisplay : Attribute
    {


        public ConditionalDisplay(string conditionalDisplayProperty, object allowedValue1) : this(conditionalDisplayProperty, new[] { allowedValue1 })
        {
        }

        public ConditionalDisplay(string conditionalDisplayProperty, object allowedValue1, object allowedValue2) : this(conditionalDisplayProperty, new[] { allowedValue1, allowedValue2})
        {
        }

        public ConditionalDisplay(string conditionalDisplayProperty, object allowedValue1, object allowedValue2,
            object allowedValue3) : this(conditionalDisplayProperty, new[] {allowedValue1, allowedValue2, allowedValue3})
        {
        }


        public ConditionalDisplay(string conditionalDisplayProperty, object allowedValue1, object allowedValue2,
        object allowedValue3, object allowedValue4) : this(conditionalDisplayProperty, new[] { allowedValue1, allowedValue2, allowedValue3, allowedValue4})
        {
        }



        private ConditionalDisplay(string conditionalDisplayProperty, object[] allowedValues)
        {
            ConditionalDisplayProperty = conditionalDisplayProperty;
            AllowedValues = allowedValues.Select(v=> v.ToString()).ToArray();
        }



        public string ConditionalDisplayProperty { get;  private set; }

        public string[] AllowedValues { get; private set; }

    }
}
