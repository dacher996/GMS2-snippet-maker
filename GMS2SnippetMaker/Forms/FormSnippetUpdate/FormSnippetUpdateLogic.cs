using GMS2SnippetMaker.Logic;

namespace GMS2SnippetMaker.Forms.FormSnippetUpdate
{
    internal class FormSnippetUpdateLogic
    {
        private SnippetData snippet;

        public FormSnippetUpdateLogic(SnippetData data)
        {
            snippet = data;
        }

        public SnippetData Snippet
        {
            get => snippet;
        }
    }
}
