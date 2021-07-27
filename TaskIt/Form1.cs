using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace TaskIt
{
    public partial class Form1 : Form
    {
        private List<RichTextBox> notes = new List<RichTextBox>();
        private List<Button> fontButtons = new List<Button>();
        private RichTextBox currentNote;

        public Color ThemeColor
        {
            set { topPanel.BackColor = value; }
            get { return topPanel.BackColor; }
        }

        private string path;

        private Color fontClickedColor = Color.LightGray;
        private Color fontNormalColor = Color.White;

        private RichTextBox notePositions;

        private bool closeWithoutSaving = false;

        public Form1()
        {
            InitializeComponent();
        }


        // If not set asks for path + adds font buttons to fontButtons list
        private void Form1_Load(object sender, EventArgs e)
        {
            // Gets path
            if (Properties.Settings.Default.Path == "")
            {
                MessageBox.Show("Set Path");

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.Path = folderBrowserDialog.SelectedPath;
                    path = Properties.Settings.Default.Path;

                    Properties.Settings.Default.Save();
                }
                else
                {
                    closeWithoutSaving = true;
                    Application.Exit();
                }
            }
            else
            {
                path = Properties.Settings.Default.Path;
            }


            // Adds font buttons
            fontButtons.Add(btn_FontBold);
            fontButtons.Add(btn_FontItalic);
            fontButtons.Add(btn_FontUnderline);
            fontButtons.Add(btn_FontStrike);
        }


        // Sets form location to last remembered location + opens and loads all notes
        private void Form1_Shown(object sender, EventArgs e)
        {
            // Sets form location
            ActiveForm.Location = Properties.Settings.Default.StartPos;


            //Sets form size
            ActiveForm.Size = Properties.Settings.Default.FormSize;


            // Opens and loads notes
            string noteName;
            if (Directory.Exists(path))
            {
                foreach (string note in Directory.GetFiles(path))
                {
                    int startingPos = note.IndexOf("_") + 1;

                    if (note.Contains("note"))
                    {
                        noteName = note.Substring(startingPos, note.Length - startingPos);
                        OpenNote(noteName);
                    }
                }
            }
            else
            {
                MessageBox.Show("Path does not exist");
            }


            // Sets note's location
            if (File.Exists($"{path}\\positions"))
            {
                StreamReader file = new StreamReader($"{path}\\positions");

                if (file.ReadLine() == null)
                {
                    return;
                }

                file.ReadLine();
                file.ReadLine();

                for (int i = 0; i < noteList.Items.Count; i++)
                {
                    string line = file.ReadLine();
                    line = line.Substring(0, line.IndexOf("\\"));

                    if (line.Length > 4)
                    {
                        noteList.Items[i] = line.Substring(0, 4);
                    }
                    else
                    {
                        noteList.Items[i] = line;
                    }
                }

                file.Close();

                File.Delete($"{path}\\positions");
            }

            
            // Sets Note theme color
            topPanel.BackColor = Properties.Settings.Default.ThemeColor;


            // Checks if textbox was the last used one, if so keeps it open
            if (Properties.Settings.Default.CurrentNote != "")
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].Name == Properties.Settings.Default.CurrentNote)
                    {
                        notes[i].Visible = true;
                        currentNote = notes[i];
                        noteList.SelectedItem = notes[i].Tag.ToString();
                    }
                    else
                    {
                        notes[i].Visible = false;
                    }
                }
            }
        }


        // Remebers last used note and position, as well as saves Notes
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (closeWithoutSaving == false)
            {
                // Saves last used Note
                if (currentNote != null)
                {
                    Properties.Settings.Default.CurrentNote = currentNote.Name;
                }


                // Saves form size
                Properties.Settings.Default.FormSize = ActiveForm.Size;


                // Saves theme color
                Properties.Settings.Default.ThemeColor = topPanel.BackColor;


                // Tries to save position
                try
                {
                    Properties.Settings.Default.StartPos = ActiveForm.Location;
                }
                catch
                {

                }


                // Saves note positions
                notePositions = new RichTextBox();
                ActiveForm.Controls.Add(notePositions);

                for (int i = 0; i < noteList.Items.Count; i++)
                {
                    if (i == noteList.Items.Count - 1)
                    {
                        notePositions.Text += noteList.Items[i].ToString();
                    }
                    else if (i == 0)
                    {
                        notePositions.Text += "\n" + noteList.Items[i].ToString() + "\n";
                    }
                    else
                    {
                        notePositions.Text += noteList.Items[i].ToString() + "\n";
                    }
                }

                notePositions.SaveFile($"{path}\\positions");


                // Saves
                Properties.Settings.Default.Save();

                foreach (RichTextBox note in notes)
                {
                    note.SaveFile($"{path}\\{note.Name}");
                }
            }
        }


        // Button to create new note
        private void btn_CreateNote_Click(object sender, EventArgs e)
        {
            string noteName = Interaction.InputBox("Enter name for new Note");
            if (noteName != "")
            {
                CreateNote(noteName);
            }
        }


        // Creates a note
        private void CreateNote(string newName)
        {
            // Create TextBox
            RichTextBox newTextBox = new RichTextBox();
            newTextBox.Name = $"note_{newName}";
            newTextBox.Font = new Font("BIZ UDPMincho Medium", 12);
            newTextBox.BorderStyle = BorderStyle.None;
            newTextBox.Location = new Point(76, 41);
            newTextBox.Size = new Size(ActiveForm.Size.Width - 80, ActiveForm.Size.Height - 82);
            newTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            newTextBox.Click += new EventHandler(fontCheck_Click);
            newTextBox.KeyDown += new KeyEventHandler(bulletPoint_KeyDown);

            // Sets tag
            if (newName.Length > 4)
            {
                newTextBox.Tag = newName.Substring(0, 4);
            }
            else
            {
                newTextBox.Tag = newName;
            }

            ActiveForm.Controls.Add(newTextBox);
            notes.Add(newTextBox);
            noteList.Items.Add(newTextBox.Tag.ToString());


            // Shows new note by hiding the rest
            noteList.SelectedItem = newTextBox.Tag.ToString();
        }


        // Creates a note and loads in text 
        private void OpenNote(string newName)
        {
            // Create TextBox
            RichTextBox newTextBox = new RichTextBox();
            newTextBox.Name = $"note_{newName}";
            newTextBox.Font = new Font("BIZ UDPMincho Medium", 12);
            newTextBox.BorderStyle = BorderStyle.None;
            newTextBox.Location = new Point(76, 41);
            newTextBox.Size = new Size(ActiveForm.Size.Width - 80, ActiveForm.Size.Height - 82);
            newTextBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left);
            newTextBox.Click += new EventHandler(fontCheck_Click);
            newTextBox.KeyDown += new KeyEventHandler(bulletPoint_KeyDown);

            // Sets Tag
            if (newName.Length > 4)
            {
                newTextBox.Tag = newName.Substring(0, 4);
            }
            else
            {
                newTextBox.Tag = newName;
            }

            ActiveForm.Controls.Add(newTextBox);
            notes.Add(newTextBox);
            noteList.Items.Add(newTextBox.Tag.ToString());


            // Loads Text
            newTextBox.LoadFile($"{path}\\{newTextBox.Name}");
        }


        // Closes application
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Swaps notes
        private void noteList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteList.SelectedItem != null)
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].Tag.ToString() == noteList.SelectedItem.ToString())
                    {
                        notes[i].Visible = true;
                        currentNote = notes[i];
                    }
                    else
                    {
                        notes[i].Visible = false;
                    }
                }
            }
        }


        // Allows for draggable app
        #region Drag
        private bool mouseDown;
        private Point lastPos;

        private void PanelMouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastPos = e.Location;
        }

        private void DragApp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void PanelMouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion


        // Allows for Resizing
        #region Resize
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }

            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        #endregion


        // Checks to see what font is being used
        private void fontCheck_Click(object sender, EventArgs e)
        {
            FontStyle currentFontStyle = currentNote.SelectionFont.Style;

            foreach (Button btn in fontButtons)
            {
                btn.BackColor = fontNormalColor;
            }

            switch (currentFontStyle)
            {
                case FontStyle.Underline:
                    btn_FontUnderline.BackColor = fontClickedColor;
                    break;
                case FontStyle.Bold:
                    btn_FontBold.BackColor = fontClickedColor;
                    break;
                case FontStyle.Italic:
                    btn_FontItalic.BackColor = fontClickedColor;
                    break;
                case FontStyle.Strikeout:
                    btn_FontStrike.BackColor = fontClickedColor;
                    break;
            }

        }

        #region FontButtons
        private void buttonBold_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Bold, btn_FontBold);
        }

        private void buttonItalics_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Italic, btn_FontItalic);
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Underline, btn_FontUnderline);
        }

        private void buttonStrikeThrough_Click(object sender, EventArgs e)
        {
            ChangeFontStyle(FontStyle.Strikeout, btn_FontStrike);
        }
        #endregion


        // Changes font style
        private void ChangeFontStyle(FontStyle fontStyle, Button button)
        {
            foreach (Button btn in fontButtons)
            {
                btn.BackColor = fontNormalColor;
            }

            if (currentNote.SelectionFont != null)
            {
                if (currentNote.SelectionFont.Style != fontStyle)
                {
                    currentNote.SelectionFont = new Font(currentNote.Font, fontStyle);
                    button.BackColor = fontClickedColor;
                }
                else
                {
                    currentNote.SelectionFont = new Font(currentNote.Font, FontStyle.Regular);
                    button.BackColor = fontNormalColor;
                }
            }
        }


        // Keyboard shortcuts for bullets and fonts
        private void bulletPoint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D8 && e.Shift)
            {
                e.SuppressKeyPress = true;
                currentNote.SelectionBullet = true;
            }

            if (e.KeyCode == Keys.U && e.Control)
            {
                btn_FontUnderline.PerformClick();
            }

            if (e.KeyCode == Keys.B && e.Control)
            {
                btn_FontBold.PerformClick();
            }

            if (e.KeyCode == Keys.I && e.Control)
            {
                btn_FontItalic.PerformClick();
            }

            if (e.KeyCode == Keys.Q && e.Control)
            {
                btn_FontStrike.PerformClick();
            }
        }


        // Deletes note
        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            if (Interaction.MsgBox("This will delete the note you are currently on. Are you sure you want to delete it?", MsgBoxStyle.YesNo, "Note Delete") == MsgBoxResult.Yes)
            {
                // Removes Note from Form and NoteList
                noteList.Items.Remove(currentNote.Tag.ToString());
                notes.Remove(currentNote);
                ActiveForm.Controls.Remove(currentNote);


                // Deletes text file
                if (File.Exists($"{path}\\{currentNote.Name}"))
                {
                    File.Delete($"{path}\\{currentNote.Name}");
                }


                // Opens first Note if it exists
                if (notes.Count > 0)
                {
                    noteList.SelectedItem = notes[0].Tag.ToString();
                }
            }
        }


        // Minimizes App
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // Changes Note Theme
        private void btn_NoteColor_Click(object sender, EventArgs e)
        {
            Form2 colorPopup = new Form2();
            colorPopup.mainForm = this;
            colorPopup.Show();

        }


        // Changes top bar color if theme color changed
        private void topPanel_BackColorChanged(object sender, EventArgs e)
        {
            btn_Close.BackColor = topPanel.BackColor;
            btn_Minimize.BackColor = topPanel.BackColor;
        }


        // Key Shortcuts for moving Notes up and down in NoteList
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (msg.HWnd == noteList.Handle)
            {
                if (keyData == (Keys.Up | Keys.Control))
                {
                    string value = noteList.SelectedItem.ToString();

                    if (noteList.SelectedIndex != 0)
                    {
                        noteList.Items[noteList.SelectedIndex] = noteList.Items[noteList.SelectedIndex - 1].ToString();
                        noteList.Items[noteList.SelectedIndex - 1] = value;
                        noteList.SelectedItem = value;
                    }

                    return true;
                }
                else if (keyData == (Keys.Down | Keys.Control))
                {
                    string value = noteList.SelectedItem.ToString();

                    if (noteList.SelectedIndex != noteList.Items.Count - 1)
                    {
                        noteList.Items[noteList.SelectedIndex] = noteList.Items[noteList.SelectedIndex + 1].ToString();
                        noteList.Items[noteList.SelectedIndex + 1] = value;
                        noteList.SelectedItem = value;
                    }

                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
