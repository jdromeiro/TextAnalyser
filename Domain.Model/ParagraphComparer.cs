using System.Collections.Generic;

namespace Domain.Model
{
    public class ParagraphComparer : IComparer<Paragraph>
    {
        public int Compare(Paragraph x, Paragraph y)
        {
            return string.Compare(x.Text, y.Text);
        }
    }
}
