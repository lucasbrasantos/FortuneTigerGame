using FortuneTigerGame.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media;
using System.Windows.Threading;
//using System.Media;

namespace FortuneTigerGame.Services
{
    public class MusicPlayer
    {
        private Dictionary<string, MediaPlayer> _backgroundTracks;
        private Dictionary<string, MediaPlayer> _soundEffects;
        private MediaPlayer _currentBackgroundMusic;

        private static MusicPlayer _instance;

        public static MusicPlayer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MusicPlayer();
                }
                return _instance;
            }
        }

        // Constructor
        private MusicPlayer()
        {
            _backgroundTracks = new Dictionary<string, MediaPlayer>();
            _soundEffects = new Dictionary<string, MediaPlayer>();

            InitializeMusics();
        }

        private void InitializeMusics()
        {
            LoadBackgroundMusic("mainTheme", Properties.Resources.mainTheme);
            LoadBackgroundMusic("loginTheme", Properties.Resources.loginTheme);
            LoadBackgroundMusic("loreTheme", Properties.Resources.loreTrack);
            LoadBackgroundMusic("endMusic", Properties.Resources.endMusic);

            LoadSoundEffect("gongFX", Properties.Resources.gongFX);
        }


        // ------ //

        public void LoadBackgroundMusic(string name, UnmanagedMemoryStream resourceStream)
        {
            if (!_backgroundTracks.ContainsKey(name))
            {
                string tempFilePath = SaveResourceToTempFile(resourceStream, $"{name}.wav");
                MediaPlayer player = new MediaPlayer();                
                player.Open(new Uri(tempFilePath, UriKind.Absolute));
                _backgroundTracks[name] = player;
            }
        }

        public void PlayBackgroundMusic(string name)
        {
            if (_backgroundTracks.ContainsKey(name))
            {

                if (_currentBackgroundMusic != null && _currentBackgroundMusic == _backgroundTracks[name] && _currentBackgroundMusic.Position > TimeSpan.Zero)
                {
                     //If it's already playing, do nothing
                    return;
                }

                _currentBackgroundMusic?.Stop();
                _currentBackgroundMusic = _backgroundTracks[name];
                _currentBackgroundMusic.Volume = 1.0;

                _currentBackgroundMusic.MediaEnded += (s, e) =>
                {
                    _currentBackgroundMusic.Position = TimeSpan.Zero;
                    _currentBackgroundMusic.Play();
                };
                
                _currentBackgroundMusic.Play();
            }
        }

        public void StopBackgroundMusic()
        {
            _currentBackgroundMusic?.Stop();
        }

        // ------ //

        public void LoadSoundEffect(string name, UnmanagedMemoryStream resourceStream)
        {
            if (!_soundEffects.ContainsKey(name))
            {
                string tempFilePath = SaveResourceToTempFile(resourceStream, $"{name}.wav");
                MediaPlayer player = new MediaPlayer();
                player.Open(new Uri(tempFilePath, UriKind.Absolute));
                _soundEffects[name] = player;
            }
        }

        public void PlaySoundEffect(string name)
        {
            if (_soundEffects.ContainsKey(name))
            {
                _soundEffects[name]?.Stop();
                _soundEffects[name].Play();
            }
        }

        public void StopSoundEffect(string name)
        {
            if (_soundEffects.ContainsKey(name))
            {
                _soundEffects[name]?.Stop();
            }
        }

        // ------ //
        private string SaveResourceToTempFile(UnmanagedMemoryStream resourceStream, string fileName)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), fileName);
            using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
            {
                resourceStream.CopyTo(fileStream);
            }
            return tempFilePath;
        }

        public void SetVolume(float volume)
        {
            if (_currentBackgroundMusic != null)
            {
                _currentBackgroundMusic.Volume = volume;

            }
        }

        public void FadeOut(double durationInSeconds)
        {
            if (_currentBackgroundMusic == null || _currentBackgroundMusic.Volume <= 0)
            {
                return;
            }

            double initialVolume = _currentBackgroundMusic.Volume;
            int steps = 20;
            double interval = durationInSeconds / steps;
            double decrement = initialVolume / steps;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(interval);

            timer.Tick += (sender, args) =>
            {
                if (_currentBackgroundMusic.Volume > 0)
                {
                    _currentBackgroundMusic.Volume -= decrement;
                    if (_currentBackgroundMusic.Volume < 0)
                        _currentBackgroundMusic.Volume = 0;
                }
                else
                {
                    _currentBackgroundMusic.Stop();
                    timer.Stop();
                }
            };

            timer.Start();
        }
    }
}
