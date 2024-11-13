using FortuneTigerGame.Components;
using FortuneTigerGame.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class LoreForm : Form
    {
        private Timer _bgTimer;

        public LoreForm()
        {
            InitializeComponent();
            PlayLoreVideo();
            SkipButton();

            skipBtn.BorderColor = Color.Gray;
            skipBtn.FontSize = 26;

            skipBtn.DefaultColor = Color.FromArgb(140, 50, 50, 50);
            skipBtn.HoverColor = Color.DarkGray;
            skipBtn.ClickColor = Color.Black;

            skipBtn.ButtonClicked += SkipBtn_ButtonClick;
        }

        private void PlayLoreVideo()
        {
            axWindowsMediaPlayer1.uiMode = "none";
            //axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.URL = @"C:\Users\Lucas Braga Santos\Videos\tigreDaFortuna.mp4";
            axWindowsMediaPlayer1.settings.setMode("loop", false);
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.SendToBack();
        }

        private async Task SkipButton()
        {
            skipBtn.Visible = false;
            await Task.Delay(5000); // 5 sec delay
            skipBtn.Visible = true;
            skipBtn.Enabled = true;
        }

        private void SkipBtn_ButtonClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
