
namespace TaskIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.noteList = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_FontBold = new System.Windows.Forms.Button();
            this.btn_FontItalic = new System.Windows.Forms.Button();
            this.btn_FontUnderline = new System.Windows.Forms.Button();
            this.btn_FontStrike = new System.Windows.Forms.Button();
            this.btn_CreateNote = new System.Windows.Forms.Button();
            this.btn_DeleteNote = new System.Windows.Forms.Button();
            this.btn_NoteColor = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.topPanel.Controls.Add(this.btn_Minimize);
            this.topPanel.Controls.Add(this.btn_Close);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(400, 25);
            this.topPanel.TabIndex = 7;
            this.topPanel.BackColorChanged += new System.EventHandler(this.topPanel_BackColorChanged);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragApp);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelMouseUp);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("BIZ UDPMincho Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(350, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(25, 25);
            this.btn_Minimize.TabIndex = 7;
            this.btn_Minimize.Text = "-";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(48)))), ((int)(((byte)(87)))));
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("BIZ UDPMincho Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(375, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 6;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.btn_CreateNote);
            this.panel2.Controls.Add(this.noteList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 375);
            this.panel2.TabIndex = 8;
            // 
            // noteList
            // 
            this.noteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(46)))));
            this.noteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteList.Font = new System.Drawing.Font("BIZ UDPMincho Medium", 12F);
            this.noteList.ForeColor = System.Drawing.Color.White;
            this.noteList.FormattingEnabled = true;
            this.noteList.ItemHeight = 16;
            this.noteList.Location = new System.Drawing.Point(3, 6);
            this.noteList.Name = "noteList";
            this.noteList.Size = new System.Drawing.Size(54, 320);
            this.noteList.TabIndex = 9;
            this.noteList.SelectedIndexChanged += new System.EventHandler(this.noteList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(50, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 2);
            this.label1.TabIndex = 9;
            // 
            // btn_FontBold
            // 
            this.btn_FontBold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_FontBold.FlatAppearance.BorderSize = 0;
            this.btn_FontBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FontBold.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FontBold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_FontBold.Location = new System.Drawing.Point(66, 370);
            this.btn_FontBold.Name = "btn_FontBold";
            this.btn_FontBold.Size = new System.Drawing.Size(30, 30);
            this.btn_FontBold.TabIndex = 0;
            this.btn_FontBold.Text = "B";
            this.btn_FontBold.UseVisualStyleBackColor = true;
            this.btn_FontBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // btn_FontItalic
            // 
            this.btn_FontItalic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_FontItalic.FlatAppearance.BorderSize = 0;
            this.btn_FontItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FontItalic.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_FontItalic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_FontItalic.Location = new System.Drawing.Point(102, 370);
            this.btn_FontItalic.Name = "btn_FontItalic";
            this.btn_FontItalic.Size = new System.Drawing.Size(30, 30);
            this.btn_FontItalic.TabIndex = 1;
            this.btn_FontItalic.Text = "I";
            this.btn_FontItalic.UseVisualStyleBackColor = true;
            this.btn_FontItalic.Click += new System.EventHandler(this.buttonItalics_Click);
            // 
            // btn_FontUnderline
            // 
            this.btn_FontUnderline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_FontUnderline.FlatAppearance.BorderSize = 0;
            this.btn_FontUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FontUnderline.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_FontUnderline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_FontUnderline.Location = new System.Drawing.Point(138, 370);
            this.btn_FontUnderline.Name = "btn_FontUnderline";
            this.btn_FontUnderline.Size = new System.Drawing.Size(30, 30);
            this.btn_FontUnderline.TabIndex = 2;
            this.btn_FontUnderline.Text = "U";
            this.btn_FontUnderline.UseVisualStyleBackColor = true;
            this.btn_FontUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // btn_FontStrike
            // 
            this.btn_FontStrike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_FontStrike.FlatAppearance.BorderSize = 0;
            this.btn_FontStrike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FontStrike.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_FontStrike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_FontStrike.Location = new System.Drawing.Point(174, 370);
            this.btn_FontStrike.Name = "btn_FontStrike";
            this.btn_FontStrike.Size = new System.Drawing.Size(30, 30);
            this.btn_FontStrike.TabIndex = 3;
            this.btn_FontStrike.Text = "S";
            this.btn_FontStrike.UseVisualStyleBackColor = true;
            this.btn_FontStrike.Click += new System.EventHandler(this.buttonStrikeThrough_Click);
            // 
            // btn_CreateNote
            // 
            this.btn_CreateNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.btn_CreateNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_CreateNote.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_CreateNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateNote.Font = new System.Drawing.Font("BIZ UDPMincho Medium", 14F);
            this.btn_CreateNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(226)))), ((int)(((byte)(237)))));
            this.btn_CreateNote.Location = new System.Drawing.Point(0, 345);
            this.btn_CreateNote.Name = "btn_CreateNote";
            this.btn_CreateNote.Size = new System.Drawing.Size(60, 30);
            this.btn_CreateNote.TabIndex = 1;
            this.btn_CreateNote.Text = "Add";
            this.btn_CreateNote.UseVisualStyleBackColor = false;
            this.btn_CreateNote.Click += new System.EventHandler(this.btn_CreateNote_Click);
            // 
            // btn_DeleteNote
            // 
            this.btn_DeleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DeleteNote.BackgroundImage")));
            this.btn_DeleteNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DeleteNote.FlatAppearance.BorderSize = 0;
            this.btn_DeleteNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteNote.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_DeleteNote.Location = new System.Drawing.Point(358, 371);
            this.btn_DeleteNote.Name = "btn_DeleteNote";
            this.btn_DeleteNote.Size = new System.Drawing.Size(30, 30);
            this.btn_DeleteNote.TabIndex = 5;
            this.btn_DeleteNote.UseVisualStyleBackColor = true;
            this.btn_DeleteNote.Click += new System.EventHandler(this.btn_DeleteNote_Click);
            // 
            // btn_NoteColor
            // 
            this.btn_NoteColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NoteColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_NoteColor.BackgroundImage")));
            this.btn_NoteColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_NoteColor.FlatAppearance.BorderSize = 0;
            this.btn_NoteColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NoteColor.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_NoteColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.btn_NoteColor.Location = new System.Drawing.Point(322, 371);
            this.btn_NoteColor.Name = "btn_NoteColor";
            this.btn_NoteColor.Size = new System.Drawing.Size(30, 30);
            this.btn_NoteColor.TabIndex = 6;
            this.btn_NoteColor.UseVisualStyleBackColor = true;
            this.btn_NoteColor.Click += new System.EventHandler(this.btn_NoteColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_DeleteNote);
            this.Controls.Add(this.btn_NoteColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btn_FontStrike);
            this.Controls.Add(this.btn_FontUnderline);
            this.Controls.Add(this.btn_FontBold);
            this.Controls.Add(this.btn_FontItalic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.Text = "TaskIt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.topPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox noteList;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_FontBold;
        private System.Windows.Forms.Button btn_FontItalic;
        private System.Windows.Forms.Button btn_FontUnderline;
        private System.Windows.Forms.Button btn_FontStrike;
        private System.Windows.Forms.Button btn_CreateNote;
        private System.Windows.Forms.Button btn_DeleteNote;
        private System.Windows.Forms.Button btn_NoteColor;
    }
}

