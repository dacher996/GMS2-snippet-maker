namespace GMS2SnippetMaker.Logic
{
    public class SnippetData
    {
        public string SnippetName { get; set; } = "SnippetName";
        public string Key { get; set; } = "0";
        public string SourceCode { get; set; } = "";
        public string FilePath { get; set; } = "";

        public int SelectionStart { get; set; } = 0;
        public int SelectionLength { get; set; } = 0;

        public string FileName
        {
            get
            {
                int shortenedLength = 10;
                int fpLength = FilePath.Length;
                if (fpLength > shortenedLength) return FilePath.Substring(fpLength - 1 - shortenedLength);
                return FilePath;
            }
        }

        public string FormattedCode { get => CodeConvertor.ConvertCode(SourceCode,SelectionStart,SelectionLength); }

        public override string ToString()
        {
            return Key + " - " + SnippetName + ":" + FormattedCode;
        }

    }
}
