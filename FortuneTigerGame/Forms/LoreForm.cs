using FortuneTigerGame.Components;
using FortuneTigerGame.Properties;
using FortuneTigerGame.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.Versioning;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

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
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "FortuneTigerGame.Resources.loreVideo.mov";            

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null) {

                    string tempFilePath = Path.Combine(Path.GetTempPath(), "loreVideo.mov");
                
                    using(var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }

                    axWindowsMediaPlayer1.uiMode = "none";
                    //axWindowsMediaPlayer1.Dock = DockStyle.Fill;
                    axWindowsMediaPlayer1.URL = tempFilePath;
                    axWindowsMediaPlayer1.settings.setMode("loop", false);
                    axWindowsMediaPlayer1.settings.autoStart = true;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    axWindowsMediaPlayer1.SendToBack();

                    axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
                }
            }
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

        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) 
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                MenuForm menuForm = new MenuForm();
                this.Hide();
                menuForm.ShowDialog();
                this.Close();
            }
        }
    }
}
