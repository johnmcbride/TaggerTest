using Microsoft.VisualStudio.Text.Tagging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaggerTest
{
    class DocTagger : ITagger<DocTag>
    {
        public IEnumerable<ITagSpan<DocTag>> GetTags(Microsoft.VisualStudio.Text.NormalizedSnapshotSpanCollection spans)
        {
            throw new NotImplementedException();
        }

        public event EventHandler<Microsoft.VisualStudio.Text.SnapshotSpanEventArgs> TagsChanged;
    }
}
