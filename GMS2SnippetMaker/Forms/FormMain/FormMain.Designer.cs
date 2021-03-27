namespace GMS2SnippetMaker
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddSnippet = new System.Windows.Forms.Button();
            this.gbxAddSnippet = new System.Windows.Forms.GroupBox();
            this.lblSnippetName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.gbxList = new System.Windows.Forms.GroupBox();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRemoveSnippet = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.fbdDestinationPicker = new System.Windows.Forms.FolderBrowserDialog();
            this.gbxAddSnippet.SuspendLayout();
            this.gbxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddSnippet
            // 
            this.btnAddSnippet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSnippet.Location = new System.Drawing.Point(15, 22);
            this.btnAddSnippet.Name = "btnAddSnippet";
            this.btnAddSnippet.Size = new System.Drawing.Size(111, 39);
            this.btnAddSnippet.TabIndex = 4;
            this.btnAddSnippet.Text = "Add snippet";
            this.btnAddSnippet.UseVisualStyleBackColor = true;
            this.btnAddSnippet.Click += new System.EventHandler(this.btnAddSnippet_Click);
            // 
            // gbxAddSnippet
            // 
            this.gbxAddSnippet.Controls.Add(this.lblSnippetName);
            this.gbxAddSnippet.Controls.Add(this.tbxName);
            this.gbxAddSnippet.Controls.Add(this.btnPickFile);
            this.gbxAddSnippet.Controls.Add(this.btnAddSnippet);
            this.gbxAddSnippet.Controls.Add(this.lblKey);
            this.gbxAddSnippet.Controls.Add(this.tbxKey);
            this.gbxAddSnippet.Location = new System.Drawing.Point(13, 5);
            this.gbxAddSnippet.Name = "gbxAddSnippet";
            this.gbxAddSnippet.Size = new System.Drawing.Size(702, 78);
            this.gbxAddSnippet.TabIndex = 1;
            this.gbxAddSnippet.TabStop = false;
            // 
            // lblSnippetName
            // 
            this.lblSnippetName.AutoSize = true;
            this.lblSnippetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSnippetName.Location = new System.Drawing.Point(293, 27);
            this.lblSnippetName.Name = "lblSnippetName";
            this.lblSnippetName.Size = new System.Drawing.Size(61, 24);
            this.lblSnippetName.TabIndex = 6;
            this.lblSnippetName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(360, 25);
            this.tbxName.MaxLength = 64;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(152, 29);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxName.TextChanged += new System.EventHandler(this.tbxName_TextChanged);
            // 
            // btnPickFile
            // 
            this.btnPickFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickFile.Location = new System.Drawing.Point(567, 20);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(111, 39);
            this.btnPickFile.TabIndex = 3;
            this.btnPickFile.Text = "Pick file";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(174, 26);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(42, 24);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key";
            // 
            // tbxKey
            // 
            this.tbxKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxKey.Location = new System.Drawing.Point(222, 25);
            this.tbxKey.MaxLength = 1;
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(53, 29);
            this.tbxKey.TabIndex = 1;
            this.tbxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxKey.TextChanged += new System.EventHandler(this.tbxKey_TextChanged);
            // 
            // gbxList
            // 
            this.gbxList.Controls.Add(this.lbxData);
            this.gbxList.Location = new System.Drawing.Point(13, 90);
            this.gbxList.Name = "gbxList";
            this.gbxList.Size = new System.Drawing.Size(701, 348);
            this.gbxList.TabIndex = 2;
            this.gbxList.TabStop = false;
            // 
            // lbxData
            // 
            this.lbxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxData.FormattingEnabled = true;
            this.lbxData.Location = new System.Drawing.Point(3, 16);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(695, 329);
            this.lbxData.TabIndex = 5;
            this.lbxData.DoubleClick += new System.EventHandler(this.lbxData_DoubleClick);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(580, 452);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(131, 36);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export to file";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRemoveSnippet
            // 
            this.btnRemoveSnippet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSnippet.Location = new System.Drawing.Point(13, 451);
            this.btnRemoveSnippet.Name = "btnRemoveSnippet";
            this.btnRemoveSnippet.Size = new System.Drawing.Size(137, 39);
            this.btnRemoveSnippet.TabIndex = 6;
            this.btnRemoveSnippet.Text = "Remove snippet";
            this.btnRemoveSnippet.UseVisualStyleBackColor = true;
            this.btnRemoveSnippet.Click += new System.EventHandler(this.btnRemoveSnippet_Click);
            // 
            // fbdDestinationPicker
            // 
            this.fbdDestinationPicker.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 502);
            this.Controls.Add(this.btnRemoveSnippet);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbxList);
            this.Controls.Add(this.gbxAddSnippet);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 541);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(742, 541);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMaker:Studio 2 snippet maker";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbxAddSnippet.ResumeLayout(false);
            this.gbxAddSnippet.PerformLayout();
            this.gbxList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddSnippet;
        private System.Windows.Forms.GroupBox gbxAddSnippet;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Button btnPickFile;
        private System.Windows.Forms.GroupBox gbxList;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRemoveSnippet;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Label lblSnippetName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.FolderBrowserDialog fbdDestinationPicker;
    }
}

