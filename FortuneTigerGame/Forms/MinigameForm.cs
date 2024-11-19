using FortuneTigerGame.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortuneTigerGame.Forms
{
    public partial class MinigameForm : Form
    {
        public MinigameForm()
        {
            MusicPlayer.Instance.PlayBackgroundMusic("endMusic");
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MusicPlayer.Instance.StopBackgroundMusic();
            MenuForm menuForm = new MenuForm();
            this.Hide();
            menuForm.ShowDialog();
            this.Close();
        }
    }
}
