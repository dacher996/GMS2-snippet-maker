using System.Linq;
using System.Text;

namespace GMS2SnippetMaker.Logic
{
    internal class CodeConvertor
    {

        private static readonly StringBuilder builder = new StringBuilder();

        public static string ConvertCode(string codeToConvert, int selectionStart = 0, int selectionLength = 0)
        {
            builder.Clear();

            if (selectionLength > 0 && (selectionStart >= 0 && selectionStart < codeToConvert.Length))
            {
                string c2c = codeToConvert;
                codeToConvert = c2c.Substring(0, selectionStart) + "|"
                    + c2c.Substring(selectionStart, selectionLength) + "|"
                    + c2c.Substring(selectionStart + selectionLength);
            }

            var strs = codeToConvert.Split('\n').Where((item) => item != null).Select((item) =>
            {
                if (item.EndsWith("\r")) return item.Substring(0, item.Length - 1);
                return item;
            }).ToArray();
            int lastIndex = strs.Length - 1;
            string str, endChar;

            for (int i = 0; i <= lastIndex; i++)
            {
                str = strs[i];
                if (str == null) continue;
                endChar = i == lastIndex ? "" : "$";
                builder.Append(str + endChar);
            }

            return builder.ToString();
        }
        
    }
}
