using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaggerTest
{
    [Export(typeof(ITaggerProvider))]
    [ContentType("text")]
    [TagType(typeof(DocTag))]
    internal sealed class DocTaggerProvider : ITaggerProvider
    {
        public ITagger<T> CreateTagger<T>(Microsoft.VisualStudio.Text.ITextBuffer buffer) where T : ITag
        {
            throw new NotImplementedException();
        }
    }
}
