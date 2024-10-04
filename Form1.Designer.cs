namespace Text_Document_Processing
{
    partial class Form1
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
            this.btnchooceapath = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtdocumentname = new System.Windows.Forms.TextBox();
            this.lbldocument = new System.Windows.Forms.Label();
            this.lblpath = new System.Windows.Forms.Label();
            this.txtdocumentpath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnImportthelist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportdata = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnchooceapath
            // 
            this.btnchooceapath.Location = new System.Drawing.Point(561, 12);
            this.btnchooceapath.Name = "btnchooceapath";
            this.btnchooceapath.Size = new System.Drawing.Size(164, 33);
            this.btnchooceapath.TabIndex = 0;
            this.btnchooceapath.Text = "Choose a Path";
            this.btnchooceapath.UseVisualStyleBackColor = true;
            this.btnchooceapath.Click += new System.EventHandler(this.btnchooceapath_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(561, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtdocumentname
            // 
            this.txtdocumentname.Location = new System.Drawing.Point(145, 12);
            this.txtdocumentname.Name = "txtdocumentname";
            this.txtdocumentname.Size = new System.Drawing.Size(359, 20);
            this.txtdocumentname.TabIndex = 2;
            // 
            // lbldocument
            // 
            this.lbldocument.AutoSize = true;
            this.lbldocument.Location = new System.Drawing.Point(13, 12);
            this.lbldocument.Name = "lbldocument";
            this.lbldocument.Size = new System.Drawing.Size(87, 13);
            this.lbldocument.TabIndex = 3;
            this.lbldocument.Text = "Document Name";
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(13, 60);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(81, 13);
            this.lblpath.TabIndex = 5;
            this.lblpath.Text = "Document Path";
            // 
            // txtdocumentpath
            // 
            this.txtdocumentpath.Location = new System.Drawing.Point(145, 60);
            this.txtdocumentpath.Name = "txtdocumentpath";
            this.txtdocumentpath.Size = new System.Drawing.Size(359, 20);
            this.txtdocumentpath.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImportthelist
            // 
            this.btnImportthelist.Location = new System.Drawing.Point(561, 112);
            this.btnImportthelist.Name = "btnImportthelist";
            this.btnImportthelist.Size = new System.Drawing.Size(164, 33);
            this.btnImportthelist.TabIndex = 6;
            this.btnImportthelist.Text = "Import to List";
            this.btnImportthelist.UseVisualStyleBackColor = true;
            this.btnImportthelist.Click += new System.EventHandler(this.btnImportthelist_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 199);
            this.listBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Transferred Information";
            // 
            // btnExportdata
            // 
            this.btnExportdata.Location = new System.Drawing.Point(561, 168);
            this.btnExportdata.Name = "btnExportdata";
            this.btnExportdata.Size = new System.Drawing.Size(164, 33);
            this.btnExportdata.TabIndex = 9;
            this.btnExportdata.Text = "Export Data";
            this.btnExportdata.UseVisualStyleBackColor = true;
            this.btnExportdata.Click += new System.EventHandler(this.btnSavedata_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(297, 221);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(223, 199);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data To Be Saved";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(741, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExportdata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnImportthelist);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.txtdocumentpath);
            this.Controls.Add(this.lbldocument);
            this.Controls.Add(this.txtdocumentname);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnchooceapath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnchooceapath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtdocumentname;
        private System.Windows.Forms.Label lbldocument;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.TextBox txtdocumentpath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnImportthelist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportdata;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

