using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Vlc;
using Vlc.DotNet;
using Vlc.DotNet.Core;
using Vlc.DotNet.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using InvokersLib;

namespace ABMTcVLC
{
    public partial class FormAMBT_VLC : Form
    {
        public string szMedia;
        // Define a CancellationTokenSource at the class level
        public CancellationTokenSource cancellationTokenSource;
        public bool isLooping;
        public bool isRepeating;
        public bool isPlaying;

        // https://www.youtube.com/watch?v=iGowt4-nQEM

        public FormAMBT_VLC()
        {
            InitializeComponent();
            szMedia = "C:\\Data\\test-app\\Jhinjoti-vilambit-gat-learn.mp4";
            AxVLC.Show();
            Timer1.Interval = 10;
            // Subscribe to the media duration changed event
            AxVLC.VlcMediaPlayer.TimeChanged += VlcMediaPlayer_TimeChanged;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                szMedia = OpenFileDlg.FileName;
                AxVLC.SetMedia(new Uri(szMedia));

                //AxVLC.Play(new Uri(szMedia));
                if (File.Exists("G:\\FILE_LATER\\ABMusicTrainer\\" + Path.GetFileName(szMedia) + ".loop"))
                {
                    LblLoop.Text = "Loop file exists";
                }
                else
                {
                    LblLoop.Text = " **NO Loop file";
                }
            }
        }

        private void VlcMediaPlayer_TimeChanged(object sender, VlcMediaPlayerTimeChangedEventArgs e)
        {
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            AxVLC.Stop();
            isPlaying = false;
            Timer1.Stop();
        }

        private void BtnPlayPause_Click(object sender, EventArgs e)
        {
            if (BtnPlayPause.Text == "Pause")
            {
                AxVLC.Pause();
                isPlaying = true;
                Timer1.Start();
                BtnPlayPause.Text = "Play";
            }
            else
            {
                AxVLC.Play();
                isPlaying = false;
                Timer1.Stop();
                BtnPlayPause.Text = "Pause";
            }
        }

        private void BtnLoop1_Click(object sender, EventArgs e)
        {
            DoLoop(10 * 1000, 20 * 1000);
        }

        private void BtnLoop2_Click(object sender, EventArgs e)
        {
            DoLoop(50 * 1000, 80 * 1000);
        }

        private void ChkRepeat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void DoLoop(int tStart, int tEnd)
        {
            // Stop if playing or in a loop
            //doStop();
            
            AxVLC.Time = tStart;
            AxVLC.Play();
            isPlaying = true;

            // Create a new CancellationTokenSource
            cancellationTokenSource = new CancellationTokenSource();

            try
            {
                await Task.Delay((tEnd - tStart), cancellationTokenSource.Token);
                //if isRepeating then
                AxVLC.Stop();
            }
            catch (TaskCanceledException)
            {
                // This will be thrown if the CancellationToken is cancelled before the delay completes.
                // You can ignore this or handle it as needed.
            }
            isLooping = true;
        }

//        private void DoStop() // stops the player
//        {
//            try
//            {
//                cancellationTokenSource?.Cancel();
//            }
//            catch { }
//            AxVLC.Stop();
//            isLooping = false;
//            isRepeating = false;
//        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (AxVLC.State == Vlc.DotNet.Core.Interops.Signatures.MediaStates.Playing)
            {
                INVOKERS.InvokeTrackerValue(Trkbar, (int)AxVLC.Time / Timer1.Interval); // Convert milliseconds to seconds
            }
        }

        private void AxVLC_Playing(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
        }

        private void AxVLC_LengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            // Get the media duration in milliseconds
            long durationInMilliseconds = AxVLC.VlcMediaPlayer.Length;

            // Convert duration to seconds
            int durationInSeconds = (int)(durationInMilliseconds / Timer1.Interval);
            INVOKERS.InvokeTrackerMaximum(Trkbar, (int)durationInSeconds);
            //Trkbar.Maximum = durationInSeconds;
        }

        private void AxVLC_MediaChanged(object sender, VlcMediaPlayerMediaChangedEventArgs e)
        {
        }
    }
}
