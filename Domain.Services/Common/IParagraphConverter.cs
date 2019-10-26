using System.Collections.Generic;
using Domain.Model;

namespace Domain.Services.Common
{
    internal interface IParagraphConverter
    {
        IList<Paragraph> ConvertToParagraphs(string text);

        string ConvertToString(IList<Paragraph> paragraphs);
    }
}
