using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vid2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                return;
            }

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                return;
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private Point startPoint;
        private bool drag;
        private int m_opacity = 100;

        private int alpha;

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            {
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void nouveauToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void couperToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copierToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void collerToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void annulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void rétablirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void sélectionnertoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void personnaliserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void sommaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void ToolStripButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
