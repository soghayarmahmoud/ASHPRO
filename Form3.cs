using Guna.UI2.WinForms;
using LibVLCSharp.Shared;
using LibVLCSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ASHPRO
{
    public partial class Form3 : Form
    {
        List<string> playlist = new List<string>();
        int currentIndex = -1;
        bool isRepeatAll = false;
        bool isRepeatOne = false;

        LibVLC _libVLC;
        MediaPlayer _mediaPlayer;

        // متغيرات للتحكم في وضع ملء الشاشة
        private bool isFullScreen = false;
        private FormWindowState normalWindowState;
        private FormBorderStyle normalBorderStyle;
        private Rectangle normalBounds;

        public Form3()
        {
            InitializeComponent();

            // ربط أحداث الـ TrackBars برمجياً لضمان عملهم 100% بدون الحاجة لربطهم من واجهة الخصائص
            guna2TrackBarVideo.Scroll += guna2TrackBarVideo_Scroll;
            guna2TrackBarVolume.Scroll += guna2TrackBarVolume_Scroll;

            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView1.MediaPlayer = _mediaPlayer;
            _mediaPlayer.EndReached += MediaPlayer_EndReached;
        }

        // === كود اصطياد اختصارات الكيبورد الاحترافي ===
        // هذه الدالة أقوى من KeyDown وتضمن عمل الاختصارات حتى لو كان الفيديو شغال
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // السماح باختصار قائمة المساعدة حتى لو مفيش فيديو شغال
            if (keyData == (Keys.Shift | Keys.OemQuestion) || keyData == Keys.OemQuestion)
            {
                ShowShortcutsMenu();
                return true;
            }

            // لو مفيش فيديو شغال، متكملش باقي الاختصارات
            if (_mediaPlayer == null || playlist.Count == 0)
                return base.ProcessCmdKey(ref msg, keyData);

            switch (keyData)
            {
                case Keys.Space:
                    guna2Button2_Click(null, null);
                    return true; // يعني تم تنفيذ الأمر بنجاح

                case Keys.Right:
                    if (_mediaPlayer.IsPlaying)
                        _mediaPlayer.Time += 5000;
                    return true;

                case Keys.Left:
                    if (_mediaPlayer.IsPlaying && _mediaPlayer.Time > 5000)
                        _mediaPlayer.Time -= 5000;
                    else if (_mediaPlayer.IsPlaying)
                        _mediaPlayer.Time = 0;
                    return true;

                case Keys.Up:
                    if (guna2TrackBarVolume.Value <= 95)
                        guna2TrackBarVolume.Value += 5;
                    else
                        guna2TrackBarVolume.Value = 100;

                    // استدعاء دالة تغيير الصوت برمجياً لربط الكيبورد بالـ Slider
                    guna2TrackBarVolume_Scroll(null, null);
                    return true;

                case Keys.Down:
                    if (guna2TrackBarVolume.Value >= 5)
                        guna2TrackBarVolume.Value -= 5;
                    else
                        guna2TrackBarVolume.Value = 0;

                    guna2TrackBarVolume_Scroll(null, null);
                    return true;

                case Keys.M:
                    guna2Button6_Click(null, null);
                    return true;

                case Keys.F:
                    ToggleFullScreen();
                    return true;

                case Keys.Escape:
                    if (isFullScreen)
                        ToggleFullScreen();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // === دالة ملء الشاشة ===
        private void ToggleFullScreen()
        {
            if (!isFullScreen)
            {
                // حفظ أبعاد وشكل الفورم الطبيعي قبل التكبير
                normalWindowState = this.WindowState;
                normalBorderStyle = this.FormBorderStyle;
                normalBounds = this.Bounds;

                // تحويل الفورم لملء الشاشة
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                isFullScreen = true;
            }
            else
            {
                // إرجاع الفورم لشكله الطبيعي
                this.FormBorderStyle = normalBorderStyle;
                this.WindowState = normalWindowState;
                this.Bounds = normalBounds;
                isFullScreen = false;
            }
        }

        // === دالة عرض قائمة الاختصارات ===
        private void ShowShortcutsMenu()
        {
            string shortcuts = "قائمة الاختصارات (Shortcuts):\n\n" +
                               "⏯ مسطرة (Space): تشغيل / إيقاف مؤقت\n" +
                               "⏩ سهم يمين: تقديم الفيديو 5 ثواني\n" +
                               "⏪ سهم يسار: تأخير الفيديو 5 ثواني\n" +
                               "🔊 سهم فوق: رفع مستوى الصوت\n" +
                               "🔉 سهم تحت: خفض مستوى الصوت\n" +
                               "🔇 حرف (M): كتم / تشغيل الصوت\n" +
                               "🔲 حرف (F): تكبير لملء الشاشة\n" +
                               "❌ زر (Esc): الخروج من ملء الشاشة\n" +
                               "❓ زر (؟): عرض هذه القائمة";

            MessageBox.Show(shortcuts, "اختصارات لوحة المفاتيح", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MediaPlayer_EndReached(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                if (isRepeatOne)
                {
                    PlayMedia(currentIndex);
                }
                else
                {
                    guna2Button3_Click(null, null);
                }
            });
        }

        private void PlayMedia(int index)
        {
            if (index >= 0 && index < playlist.Count)
            {
                currentIndex = index;
                var media = new Media(_libVLC, playlist[currentIndex], FromType.FromPath);
                _mediaPlayer.Play(media);
                guna2Button2.Text = "⏸";

                // تحديث الـ Slider بتاع الصوت مع بداية كل فيديو لضمان التوافق
                _mediaPlayer.Volume = guna2TrackBarVolume.Value;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Mute = !_mediaPlayer.Mute;

                if (_mediaPlayer.Mute)
                    guna2Button6.Text = "Unmute 🔇";
                else
                    guna2Button6.Text = "Mute 🔊";
            }
        }

        private void videoView1_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    playlist.Clear();
                    playlist.Add(ofd.FileName);
                    PlayMedia(0);
                }
            }
        }

        private void openMultifilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    playlist.AddRange(ofd.FileNames);

                    if (currentIndex == -1 || !_mediaPlayer.IsPlaying)
                    {
                        PlayMedia(playlist.Count - ofd.FileNames.Length);
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.Pause();
                guna2Button2.Text = "▶";
            }
            else
            {
                _mediaPlayer.Play();
                guna2Button2.Text = "⏸";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            int nextIndex = currentIndex + 1;

            if (nextIndex >= playlist.Count)
            {
                if (isRepeatAll)
                    nextIndex = 0;
                else
                    return;
            }

            PlayMedia(nextIndex);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            int prevIndex = currentIndex - 1;

            if (prevIndex < 0)
            {
                if (isRepeatAll)
                    prevIndex = playlist.Count - 1;
                else
                    prevIndex = 0;
            }

            PlayMedia(prevIndex);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (!isRepeatAll && !isRepeatOne)
            {
                isRepeatAll = true;
                isRepeatOne = false;
                guna2Button5.Text = "🔁";
            }
            else if (isRepeatAll)
            {
                isRepeatAll = false;
                isRepeatOne = true;
                guna2Button5.Text = "🔂";
            }
            else
            {
                isRepeatAll = false;
                isRepeatOne = false;
                guna2Button5.Text = "➡";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_mediaPlayer != null && _mediaPlayer.IsPlaying)
            {
                int currentPos = (int)(_mediaPlayer.Position * 1000);
                // استخدام تحديث صامت لتجنب التداخل أثناء سحب المستخدم للشريط
                guna2TrackBarVideo.Value = currentPos;
            }
        }

        private void guna2TrackBarVideo_Scroll(object sender, ScrollEventArgs e)
        {
            if (_mediaPlayer != null && _mediaPlayer.Media != null)
            {
                _mediaPlayer.Position = (float)guna2TrackBarVideo.Value / 1000f;
            }
        }

        private void guna2TrackBarVolume_Scroll(object sender, ScrollEventArgs e)
        {
            if (_mediaPlayer != null)
            {
                _mediaPlayer.Volume = guna2TrackBarVolume.Value;

                if (_mediaPlayer.Mute && guna2TrackBarVolume.Value > 0)
                {
                    _mediaPlayer.Mute = false;
                    guna2Button6.Text = "Mute 🔊";
                }
            }
        }
    }
}