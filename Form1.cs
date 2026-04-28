using LibVLCSharp.Shared;



namespace ASHPRO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2Panel1.Dock = DockStyle.None;
            guna2Panel1.Width = 350;
            guna2Panel1.Height = this.Height - 30;
            guna2Panel1.Location = new Point(0, 35); 
            guna2Panel1.FillColor = Color.FromArgb(20, 20, 20);

            //guna2Panel1.BorderRadius. = 20;
            guna2Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;



            // Video Structure
            Core.Initialize();

           LibVLC libVLC = new LibVLC();
           MediaPlayer mediaPlayer = new MediaPlayer(libVLC);

            mediaPlayer.Mute = true;
            videoView1.SendToBack();

            videoView1.MediaPlayer = mediaPlayer;
            videoView1.Dock = DockStyle.Fill;

          

            guna2Panel1.BringToFront();
           



            var media = new Media(libVLC, @"C:\Users\SAM\source\repos\ASHPRO\video.mp4", FromType.FromPath);
            mediaPlayer.Play(media);

            // 🔁 Loop
            mediaPlayer.EndReached += (s, e) =>
            {
                this.Invoke(new Action(() =>
                {
                    mediaPlayer.Stop();
                    mediaPlayer.Play(new Media(libVLC, @"C:\Users\SAM\source\repos\ASHPRO\video.mp4", FromType.FromPath));
                }));
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
