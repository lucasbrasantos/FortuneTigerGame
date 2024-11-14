using FortuneTigerGame.Components;
using FortuneTigerGame.Services;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class WelcomeForm : Form
    {

        private Timer _timer;

        public WelcomeForm()
        {
            InitializeComponent();
            MusicPlayer.Instance.PlayBackgroundMusic("mainTheme");
            startButton.ButtonClicked += Button1_ButtonClicked;

            _timer = new Timer();
            _timer.Interval = 5000; // GONG FX Duration
            _timer.Tick += Timer_Tick;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MusicPlayer.Instance.StopBackgroundMusic();
            base.OnFormClosed(e);
        }

        private void Button1_ButtonClicked(object sender, EventArgs e)
        {
            MusicPlayer.Instance.FadeOut(0.5); // FadeOut BackgroundMusic
            MusicPlayer.Instance.PlaySoundEffect("gongFX");
            _timer.Start();
            startButton.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();

            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
