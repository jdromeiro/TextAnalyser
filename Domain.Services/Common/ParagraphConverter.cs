using System.Collections.Generic;
using System.Linq;
using Domain.Model;

namespace Domain.Services.Common
{
    internal class ParagraphConverter : IParagraphConverter
    {
        private readonly string paragraphCharacter = "\n";

        public IEnumerable<Paragraph> ConvertToParagraphs(string text)
        {
            var textLines = text.Split(new string[] { paragraphCharacter }, System.StringSplitOptions.None);

            return textLines.Select(dl => new Paragraph() { Text = dl });
        }

        public string ConvertToString(IEnumerable<Paragraph> paragraphs)
        {
            return paragraphs.Select(p => p.Text)
                .Aggregate((current, next) => current + paragraphCharacter + next);
        }
    }
}
