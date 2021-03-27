using GMS2SnippetMaker.Forms.FormSnippetUpdate;
using GMS2SnippetMaker.Logic;
using System;
using System.Windows.Forms;

namespace GMS2SnippetMaker.Forms.FormSnippetDisplay
{
    public partial class FormSnippetUpdate : Form
    {

        FormSnippetUpdateLogic bloc;
        public FormSnippetUpdate(SnippetData snippet)
        {
            InitializeComponent();
            bloc = new FormSnippetUpdateLogic(snippet);
        }

        internal SnippetData GetSnippet()
        {
            return bloc.Snippet;
        }

        private void FormSnippetUpdate_Load(object sender, EventArgs e)
        {
            tbxCode.Text = bloc.Snippet.SourceCode;
            tbxCode.SelectionStart = bloc.Snippet.SelectionStart;
            tbxCode.SelectionLength = bloc.Snippet.SelectionLength;
        }

        private void FormSnippetUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            bloc.Snippet.SelectionStart = tbxCode.SelectionStart;
            bloc.Snippet.SelectionLength = tbxCode.SelectionLength;
        }
    }
}
