using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Music_Management.Models;
using NAudio.Wave;

namespace Music_Management.UI.Views
{
    public partial class MusicPlayer : Form
    {
        private List<Song> songs;
        private int index;

        private AudioFileReader reader;
        private WaveOutEvent output;

        private System.Windows.Forms.Timer timelineTimer;
        private System.Windows.Forms.Timer gifTimer;
        private bool isPaused = false;
        private bool isRepeat = false;
        private bool userDragging = false;

        private List<Image> gifFrames;
        private int gifIndex = 0;

        private Image playImg, pauseImg, repeatOnImg, repeatOffImg, nextImg, previousImg;

        public MusicPlayer(List<Song> songs, int startIndex = 0)
        {
            this.songs = songs;
            this.index = startIndex;

            InitializeComponent();
            LoadButtonImages();
            SetupGifAnimation();
            SetupTimers();
            HookEvents();
            PlaySong(index);
        }

        private void LoadButtonImages()
        {
            playImg = Image.FromFile("Assets/Icons/play.png");
            pauseImg = Image.FromFile("Assets/Icons/pause.png");
            repeatOnImg = Image.FromFile("Assets/Icons/repeat-on.png");
            repeatOffImg = Image.FromFile("Assets/Icons/repeat-off.png");
            nextImg = Image.FromFile("Assets/Icons/next.png");
            previousImg = Image.FromFile("Assets/Icons/previous.png");

            btnPlayPause.Image = pauseImg;
            btnRepeat.Image = repeatOffImg;
            btnNext.Image = nextImg;
            btnPrevious.Image = previousImg;
        }

        private void SetupGifAnimation()
        {
            gifFrames = new List<Image>();
            var gif = Image.FromFile("Assets/Icons/disc.gif");
            var dimension = new System.Drawing.Imaging.FrameDimension(gif.FrameDimensionsList[0]);
            int frameCount = gif.GetFrameCount(dimension);
            for (int i = 0; i < frameCount; i++)
            {
                gif.SelectActiveFrame(dimension, i);
                gifFrames.Add(new Bitmap(gif));
            }

            gifTimer = new System.Windows.Forms.Timer();
            gifTimer.Interval = 100;
            gifTimer.Tick += (s, e) =>
            {
                gifIndex = (gifIndex + 1) % gifFrames.Count;
                pbDisc.Image = gifFrames[gifIndex];
            };
            gifTimer.Start();
        }

        private void SetupTimers()
        {
            timelineTimer = new System.Windows.Forms.Timer();
            timelineTimer.Interval = 100;
            timelineTimer.Tick += (s, e) => UpdateTimeline();
            timelineTimer.Start();
        }

        private void HookEvents()
        {
            btnPlayPause.Click += (s, e) => PauseResume();
            btnNext.Click += (s, e) => PlayNext();
            btnPrevious.Click += (s, e) => PlayPrevious();
            btnRepeat.Click += (s, e) =>
            {
                isRepeat = !isRepeat;
                btnRepeat.Image = isRepeat ? repeatOnImg : repeatOffImg;
            };

            timeline.MouseDown += (s, e) => userDragging = true;
            timeline.MouseUp += (s, e) =>
            {
                userDragging = false;
                if (reader != null)
                    reader.CurrentTime = TimeSpan.FromSeconds((timeline.Value / 1000.0) * reader.TotalTime.TotalSeconds);
            };
        }

        private void PlaySong(int idx)
        {
            if (idx < 0 || idx >= songs.Count) return;

            index = idx;
            reader?.Dispose();
            output?.Dispose();

            var song = songs[index];
            lblTitle.Text = song.Title;
            lblCurrentTime.Text = "00:00";
            lblTotalTime.Text = song.Duration;

            reader = new AudioFileReader(song.FilePath);
            output = new WaveOutEvent();
            output.Init(reader);
            output.Play();

            btnPlayPause.Image = pauseImg;
        }

        private void PauseResume()
        {
            if (output == null) return;

            if (isPaused)
            {
                output.Play();
                isPaused = false;
                btnPlayPause.Image = pauseImg;
            }
            else
            {
                output.Pause();
                isPaused = true;
                btnPlayPause.Image = playImg;
            }
        }

        private void PlayNext()
        {
            if (index < songs.Count - 1)
                PlaySong(index + 1);
            else if (isRepeat)
                PlaySong(0);
        }

        private void PlayPrevious()
        {
            if (index > 0)
                PlaySong(index - 1);
            else if (isRepeat)
                PlaySong(songs.Count - 1);
        }

        private void UpdateTimeline()
        {
            if (reader == null) return;

            if (!userDragging && output.PlaybackState == PlaybackState.Playing)
            {
                double frac = reader.CurrentTime.TotalSeconds / reader.TotalTime.TotalSeconds;
                timeline.Value = Math.Min(timeline.Maximum, (int)(frac * 1000));
                lblCurrentTime.Text = reader.CurrentTime.ToString(@"mm\:ss");

                if (reader.CurrentTime >= reader.TotalTime)
                {
                    if (isRepeat)
                        PlaySong(index);
                    else
                        PlayNext();
                }
            }
        }
    }
}
