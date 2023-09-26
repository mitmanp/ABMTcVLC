namespace ABMTcVLC
{
    partial class FormAMBT_VLC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAMBT_VLC));
            this.AxVLC = new Vlc.DotNet.Forms.VlcControl();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPlayPause = new System.Windows.Forms.Button();
            this.ChkRepeat = new System.Windows.Forms.CheckBox();
            this.BtnLoop1 = new System.Windows.Forms.Button();
            this.BtnLoop2 = new System.Windows.Forms.Button();
            this.LblLoop = new System.Windows.Forms.Label();
            this.OpenFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.Trkbar = new System.Windows.Forms.TrackBar();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AxVLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trkbar)).BeginInit();
            this.SuspendLayout();
            // 
            // AxVLC
            // 
            this.AxVLC.BackColor = System.Drawing.Color.Black;
            this.AxVLC.Location = new System.Drawing.Point(32, 61);
            this.AxVLC.Margin = new System.Windows.Forms.Padding(4);
            this.AxVLC.Name = "AxVLC";
            this.AxVLC.Size = new System.Drawing.Size(819, 404);
            this.AxVLC.Spu = -1;
            this.AxVLC.TabIndex = 0;
            this.AxVLC.Text = "VLCcontrol1";
            this.AxVLC.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("AxVLC.VlcLibDirectory")));
            this.AxVLC.VlcMediaplayerOptions = null;
            this.AxVLC.LengthChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerLengthChangedEventArgs>(this.AxVLC_LengthChanged);
            this.AxVLC.MediaChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerMediaChangedEventArgs>(this.AxVLC_MediaChanged);
            this.AxVLC.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.AxVLC_Playing);
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoad.Location = new System.Drawing.Point(27, 15);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(100, 40);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "LOAD";
            this.BtnLoad.UseVisualStyleBackColor = false;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnStop.Location = new System.Drawing.Point(239, 15);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(100, 40);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPlayPause
            // 
            this.BtnPlayPause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPlayPause.Location = new System.Drawing.Point(134, 15);
            this.BtnPlayPause.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlayPause.Name = "BtnPlayPause";
            this.BtnPlayPause.Size = new System.Drawing.Size(100, 40);
            this.BtnPlayPause.TabIndex = 4;
            this.BtnPlayPause.Text = "Play";
            this.BtnPlayPause.UseVisualStyleBackColor = false;
            this.BtnPlayPause.Click += new System.EventHandler(this.BtnPlayPause_Click);
            // 
            // ChkRepeat
            // 
            this.ChkRepeat.AutoSize = true;
            this.ChkRepeat.Location = new System.Drawing.Point(467, 15);
            this.ChkRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.ChkRepeat.Name = "ChkRepeat";
            this.ChkRepeat.Size = new System.Drawing.Size(167, 29);
            this.ChkRepeat.TabIndex = 5;
            this.ChkRepeat.Text = "Repeat Loop";
            this.ChkRepeat.UseVisualStyleBackColor = true;
            this.ChkRepeat.CheckedChanged += new System.EventHandler(this.ChkRepeat_CheckedChanged);
            // 
            // BtnLoop1
            // 
            this.BtnLoop1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoop1.Location = new System.Drawing.Point(633, 15);
            this.BtnLoop1.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoop1.Name = "BtnLoop1";
            this.BtnLoop1.Size = new System.Drawing.Size(100, 40);
            this.BtnLoop1.TabIndex = 6;
            this.BtnLoop1.Text = "10-20";
            this.BtnLoop1.UseVisualStyleBackColor = false;
            this.BtnLoop1.Click += new System.EventHandler(this.BtnLoop1_Click);
            // 
            // BtnLoop2
            // 
            this.BtnLoop2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnLoop2.Location = new System.Drawing.Point(751, 15);
            this.BtnLoop2.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLoop2.Name = "BtnLoop2";
            this.BtnLoop2.Size = new System.Drawing.Size(100, 40);
            this.BtnLoop2.TabIndex = 7;
            this.BtnLoop2.Text = "50-80";
            this.BtnLoop2.UseVisualStyleBackColor = false;
            this.BtnLoop2.Click += new System.EventHandler(this.BtnLoop2_Click);
            // 
            // LblLoop
            // 
            this.LblLoop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblLoop.Location = new System.Drawing.Point(17, 601);
            this.LblLoop.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblLoop.Name = "LblLoop";
            this.LblLoop.Size = new System.Drawing.Size(418, 44);
            this.LblLoop.TabIndex = 8;
            // 
            // Trkbar
            // 
            this.Trkbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Trkbar.Location = new System.Drawing.Point(27, 483);
            this.Trkbar.Name = "Trkbar";
            this.Trkbar.Size = new System.Drawing.Size(824, 90);
            this.Trkbar.TabIndex = 9;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormAMBT_VLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 672);
            this.Controls.Add(this.Trkbar);
            this.Controls.Add(this.LblLoop);
            this.Controls.Add(this.BtnLoop2);
            this.Controls.Add(this.BtnLoop1);
            this.Controls.Add(this.ChkRepeat);
            this.Controls.Add(this.BtnPlayPause);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.AxVLC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAMBT_VLC";
            this.Text = "ABMT VLC";
            ((System.ComponentModel.ISupportInitialize)(this.AxVLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trkbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Vlc.DotNet.Forms.VlcControl AxVLC;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPlayPause;
        private System.Windows.Forms.CheckBox ChkRepeat;
        private System.Windows.Forms.Button BtnLoop1;
        private System.Windows.Forms.Button BtnLoop2;
        private System.Windows.Forms.Label LblLoop;
        private System.Windows.Forms.OpenFileDialog OpenFileDlg;
        private System.Windows.Forms.TrackBar Trkbar;
        private System.Windows.Forms.Timer Timer1;
    }
}

