using GMS2SnippetMaker.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GMS2SnippetMaker.Forms.FormMain
{
    internal class FormMainLogic
    {
        #region Fields

        private Dictionary<string, SnippetData> snippets;

        #endregion

        public FormMainLogic()
        {
            snippets = new Dictionary<string, SnippetData>();
        }

        #region Getters

        public bool exportEnabled { get => snippets.Count > 0; }

        public List<SnippetData> snippetList { get => snippets.Values.ToList(); }

        #endregion

        #region Public methods

        public bool AddSnippet(string key, string snippetName, string filePath)
        {
            key = key.ToUpper();
            if (snippets.ContainsKey(key))
                return false;

            string loadedData = loadFileContents(filePath);
            SnippetData data = new SnippetData()
            {
                SnippetName = capitalizeString(snippetName),
                Key = key.ToUpper(),
                SourceCode = loadedData,
                FilePath = filePath,
            };
            snippets.Add(key.ToUpper(), data);

            return true;
        }

        public void RemoveSnippet(string key)
        {
            if (!snippets.ContainsKey(key.ToUpper())) return;
            snippets.Remove(key);
        }

        public void UpdateSnippet(string key, SnippetData data)
        {
            var upperKey = key.ToUpper();
            if (!snippets.ContainsKey(upperKey.ToUpper())) return;
            snippets.Remove(upperKey);
            snippets.Add(upperKey, data);
        }

        public bool ExportSnippets(string folderPath)
        {
            string filePath = folderPath + "\\snippets.txt";
            try
            {
                using (var sr = File.AppendText(filePath))
                    snippetList.ForEach((item) =>
                    {
                        sr.Write(item.ToString());
                        sr.WriteLine();
                    });
                return true;
            }
            catch (Exception _)
            {
                return false;
            }
        }

        #endregion

        #region Private methods

        private string loadFileContents(string path)
        {
            string readString = "";
            using (var sr = File.OpenText(path))
                readString = sr.ReadToEnd();

            return readString;
        }

        private string capitalizeString(string str)
        {
            if (string.IsNullOrWhiteSpace(str)) return str;
            if (str.Length == 1) return str.ToUpper();
            return str[0].ToString().ToUpper() + str.Substring(1);
        }

        #endregion

    }
}
