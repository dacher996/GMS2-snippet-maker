namespace GMS2SnippetMaker.Forms.FormSnippetDisplay
{
    partial class FormSnippetUpdate
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
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxCode
            // 
            this.tbxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCode.Location = new System.Drawing.Point(0, 0);
            this.tbxCode.MaxLength = 999999;
            this.tbxCode.Multiline = true;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.ReadOnly = true;
            this.tbxCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxCode.Size = new System.Drawing.Size(663, 473);
            this.tbxCode.TabIndex = 0;
            // 
            // FormSnippetUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.tbxCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 277);
            this.Name = "FormSnippetUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select code when snipped applied";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSnippetUpdate_FormClosing);
            this.Load += new System.EventHandler(this.FormSnippetUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCode;
    }
}