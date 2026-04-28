using LibVLCSharp.Shared;



namespace ASHPRO
{
    public partial class Form1 : Form
    {



        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;

        private bool isFullScreen = false;
        private FormWindowState previousWindowState;
        private FormBorderStyle previousBorderStyle;
        private Rectangle previousBounds;

        public Form1()
        {
            InitializeComponent();


            // Panel Structure

            guna2Panel1.Dock = DockStyle.None;
            guna2Panel1.Width = 350;
            guna2Panel1.Height = this.Height - 30;
            guna2Panel1.Location = new Point(0, 35); 
            guna2Panel1.FillColor = Color.FromArgb(20, 20, 20);

            //guna2Panel1.BorderRadius. = 20;
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Core.Initialize();
            guna2Panel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2();
            }

            form2.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2();
            }
            form2.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3();
            }
            form3.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (form4 == null || form4.IsDisposed)
            {
                form4 = new Form4();
            }
            form4.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.Show();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3();
            }
            form3.Show();
        }
          
        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form4 == null || form4.IsDisposed)
            {
                form4 = new Form4();
            }
            form4.Show();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form5 == null || form5.IsDisposed)
            {
                form5 = new Form5();
            }
            form5.Show();
        }
           
        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isFullScreen) return;

            previousWindowState = this.WindowState;
            previousBorderStyle = this.FormBorderStyle;
            previousBounds = this.Bounds;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Normal;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            isFullScreen = true;
        }

        private void exitFullScreenToolStripMenuItem_Click(object sender, EventArgs e)
                {
            if (!isFullScreen) return;

            this.FormBorderStyle = previousBorderStyle;
            this.WindowState = previousWindowState;
            this.Bounds = previousBounds;

            isFullScreen = false;
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


