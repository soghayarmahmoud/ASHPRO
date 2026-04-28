namespace ASHPRO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            form1ToolStripMenuItem = new ToolStripMenuItem();
            form2ToolStripMenuItem = new ToolStripMenuItem();
            form3ToolStripMenuItem = new ToolStripMenuItem();
            form4ToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fullScreenToolStripMenuItem = new ToolStripMenuItem();
            exitFullScreenToolStripMenuItem = new ToolStripMenuItem();
            closeAppToolStripMenuItem = new ToolStripMenuItem();
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1259, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { form1ToolStripMenuItem, form2ToolStripMenuItem, form3ToolStripMenuItem, form4ToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(62, 29);
            filesToolStripMenuItem.Text = "Files";
            // 
            // form1ToolStripMenuItem
            // 
            form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            form1ToolStripMenuItem.Size = new Size(166, 34);
            form1ToolStripMenuItem.Text = "Form1";
            // 
            // form2ToolStripMenuItem
            // 
            form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            form2ToolStripMenuItem.Size = new Size(166, 34);
            form2ToolStripMenuItem.Text = "Form2";
            // 
            // form3ToolStripMenuItem
            // 
            form3ToolStripMenuItem.Name = "form3ToolStripMenuItem";
            form3ToolStripMenuItem.Size = new Size(166, 34);
            form3ToolStripMenuItem.Text = "Form3";
            // 
            // form4ToolStripMenuItem
            // 
            form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            form4ToolStripMenuItem.Size = new Size(166, 34);
            form4ToolStripMenuItem.Text = "Form4";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fullScreenToolStripMenuItem, exitFullScreenToolStripMenuItem, closeAppToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem
            // 
            fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            fullScreenToolStripMenuItem.Size = new Size(230, 34);
            fullScreenToolStripMenuItem.Text = "Full Screen";
            // 
            // exitFullScreenToolStripMenuItem
            // 
            exitFullScreenToolStripMenuItem.Name = "exitFullScreenToolStripMenuItem";
            exitFullScreenToolStripMenuItem.Size = new Size(230, 34);
            exitFullScreenToolStripMenuItem.Text = "Exit Full Screen";
            // 
            // closeAppToolStripMenuItem
            // 
            closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            closeAppToolStripMenuItem.Size = new Size(230, 34);
            closeAppToolStripMenuItem.Text = "Close App";
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.DeepSkyBlue;
            videoView1.Dock = DockStyle.Fill;
            videoView1.ForeColor = Color.Coral;
            videoView1.Location = new Point(0, 33);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(1259, 601);
            videoView1.TabIndex = 1;
            videoView1.Text = "videoView1";
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(959, 33);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(300, 601);
            guna2Panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 634);
            Controls.Add(guna2Panel1);
            Controls.Add(videoView1);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem form1ToolStripMenuItem;
        private ToolStripMenuItem form2ToolStripMenuItem;
        private ToolStripMenuItem form3ToolStripMenuItem;
        private ToolStripMenuItem form4ToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fullScreenToolStripMenuItem;
        private ToolStripMenuItem exitFullScreenToolStripMenuItem;
        private ToolStripMenuItem closeAppToolStripMenuItem;
        private LibVLCSharp.WinForms.VideoView videoView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
