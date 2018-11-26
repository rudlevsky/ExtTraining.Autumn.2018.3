using No5.Solution.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution.Elements
{
    public abstract class Elements
    {
        public abstract string Accept(DocumentPart visitor);
    }
}
