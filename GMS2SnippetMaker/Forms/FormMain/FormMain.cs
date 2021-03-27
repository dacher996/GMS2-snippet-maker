using GMS2SnippetMaker.Forms.FormMain;
using GMS2SnippetMaker.Forms.FormSnippetDisplay;
using System.Linq;
using System.Windows.Forms;

namespace GMS2SnippetMaker
{
    public partial class FormMain : Form
    {

        #region Fields

        private FormMainLogic bloc; // Business logic

        private string pickedFile
        {
            get => ofdOpenFile.FileName;
            set => ofdOpenFile.FileName = value;
        }
        private string exportDirectory
        {
            get => fbdDestinationPicker.SelectedPath;
            set => fbdDestinationPicker.SelectedPath = value;
        }

        #endregion

        public FormMain()
        {
            InitializeComponent();
            bloc = new FormMainLogic();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            refreshComponents();
            btnAddSnippet.Enabled = false;
        }

        #region Private methods

        private void showMessage(string message)
        {
            var dr = MessageBox.Show(message, "", MessageBoxButtons.OK);
        }

        private bool isValidString(string str)
        {
            return str != null && !string.IsNullOrWhiteSpace(str.Trim());
        }

        private void refreshComponents()
        {
            btnExport.Enabled = bloc.exportEnabled;
            btnRemoveSnippet.Enabled = bloc.exportEnabled;
            lbxData.DataSource = bloc.snippetList.Select((snippet) => snippet.Key + " - " + snippet.SnippetName).ToList();
        }

        private void updateSnippetAddingStates()
        {
            if (!isValidString(tbxKey.Text) || !isValidString(tbxName.Text) || !isValidString(pickedFile))
            {
                btnAddSnippet.Enabled = false;
                return;
            }

            btnAddSnippet.Enabled = true;
        }

        #endregion

        #region UI element events

        private void btnAddSnippet_Click(object sender, System.EventArgs e)
        {
            bool success = bloc.AddSnippet(tbxKey.Text, tbxName.Text, pickedFile);

            if (!success)
            {
                showMessage("Key already mapped!");
                return;
            }

            pickedFile = "";
            tbxKey.Text = "";
            tbxName.Text = "";
            btnAddSnippet.Enabled = false;
            refreshComponents();
        }

        private void tbxKey_TextChanged(object sender, System.EventArgs e)
        {
            updateSnippetAddingStates();
        }

        private void tbxName_TextChanged(object sender, System.EventArgs e)
        {
            updateSnippetAddingStates();
        }

        private void btnPickFile_Click(object sender, System.EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() != DialogResult.OK)
            {
                pickedFile = "";
                updateSnippetAddingStates();
                return;
            }
            if (!isValidString(pickedFile)) return;
            updateSnippetAddingStates();
        }

        private void btnRemoveSnippet_Click(object sender, System.EventArgs e)
        {
            int index = lbxData.SelectedIndex;
            if (index < 0 || index >= bloc.snippetList.Count) return;

            var snippet = bloc.snippetList[index];
            bloc.RemoveSnippet(snippet.Key);
            refreshComponents();
        }

        private void lbxData_DoubleClick(object sender, System.EventArgs e)
        {
            int index = lbxData.SelectedIndex;
            if (index < 0 || index >= bloc.snippetList.Count) return;

            var snippet = bloc.snippetList[index];
            FormSnippetUpdate frm = new FormSnippetUpdate(snippet);
            frm.ShowDialog();
            bloc.UpdateSnippet(snippet.Key,frm.GetSnippet());
            refreshComponents();
        }

        private void btnExport_Click(object sender, System.EventArgs e)
        {
            if (fbdDestinationPicker.ShowDialog() != DialogResult.OK)
            {
                exportDirectory = "";
                return;
            }
            if (!isValidString(exportDirectory)) return;
            bool result = bloc.ExportSnippets(exportDirectory);

            if (!result)
            {
                showMessage("There was an error trying to export the snippets.");
                return;
            }

            showMessage("Snippets successfully exported!");
        }
        
        #endregion

    }
}
