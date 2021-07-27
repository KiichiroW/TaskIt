using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskIt
{
    public partial class Form2 : Form
    {
        public Form1 mainForm;

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(ActiveForm.Location.X + 80, ActiveForm.Location.Y + 200);
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            (mainForm).ThemeColor = btnRed.BackColor;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            (mainForm).ThemeColor = btnBlue.BackColor;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            (mainForm).ThemeColor = btnGreen.BackColor;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            (mainForm).ThemeColor = btnYellow.BackColor;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            (mainForm).ThemeColor = btnOrange.BackColor;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btn_customCol_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (mainForm).ThemeColor = colorDialog.Color;
            }
        }


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
    }
}
