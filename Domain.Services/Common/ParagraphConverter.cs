using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Common
{
    internal class ParagraphConverter : IParagraphConverter
    {
        private readonly string paragraphCharacter = "\n";

        public IList<Paragraph> ConvertToParagraphs(string text)
        {
            var textLines = text.Split(new string[] { paragraphCharacter }, System.StringSplitOptions.None);

            return textLines.Select(dl => new Paragraph(dl)).ToList();
        }

        public string ConvertToString(IList<Paragraph> paragraphs)
        {
            return paragraphs.Select(p => p.Text)
                .Aggregate((current, next) => current + paragraphCharacter + next);
        }
    }
}
