using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No5.Solution.Parts;

namespace No5.Solution.Elements
{
    public class ElementToPlainText : Elements
    {
        public override string Accept(DocumentPart visitor)
        {
            return visitor.ToPlainText();
        }
    }
}
