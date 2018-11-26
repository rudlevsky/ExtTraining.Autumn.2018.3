using No5.Solution.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No5.Solution
{
    // Использовать паттерн "Visitor"

    public class Document<T>
    {
        private readonly List<T> partselem;
        private readonly List<DocumentPart> parts;

        public Document(List<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);

            /*for (int i = 0; i < parts.Count; i++)
            {
                partselem<T>.Add(parts[i]);
            }*/

        }

        public string ToHtml()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToHtml()}\n";
            }

            return output;
        }

        public string ToPlainText()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToPlainText()}\n";
            }

            return output;
        }

        public string ToLaTeX()
        {
            string output = string.Empty;

            foreach (DocumentPart part in this.parts)
            {
                output += $"{part.ToLaTeX()}\n";
            }

            return output;
        }
    }
}
